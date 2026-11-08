namespace EVChargeFinder.Controllers
{
    using Data;
    using Data.DbModels;
    using InputModels;
    using ViewModels.ChargingSessions;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;

    public class ChargingSessionsController : Controller
    {
        private readonly ApplicationDbContext _dbContext;

        public ChargingSessionsController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }


        [HttpGet]
        public async Task<IActionResult> Index([FromQuery] ChargingSessionsSearchInputModel inputModel)
        {
            const int pageSize = 10;

            ChargingSessionsSearchInputModel filters = ModelState.IsValid
                ? inputModel
                : new ChargingSessionsSearchInputModel();

            IQueryable<ChargingSession> query = _dbContext.ChargingSessions
                .AsNoTracking();

            if (!string.IsNullOrWhiteSpace(filters.SearchTerm))
            {
                string searchTerm = filters.SearchTerm.Trim();
                query = query.Where(s => s.Connector.ChargingStation.Name.Contains(searchTerm));
            }

            if (filters.From.HasValue)
            {
                DateTime startDate = filters.From.Value.Date;
                query = query.Where(s => s.StartedAt >= startDate);
            }

            if (filters.To.HasValue)
            {
                DateTime endDate = filters.To.Value.Date;
                query = query.Where(s => s.StartedAt.Date <= endDate);
            }

            int sessionsCount = await query.CountAsync();
            decimal totalEnergyKWh = await query.SumAsync(s => (decimal?)s.EnergyKWh) ?? 0m;
            decimal totalCost = await query.SumAsync(s => (decimal?)s.TotalCost) ?? 0m;

            var completedSessions = await query
                .Where(s => s.EndedAt.HasValue)
                .Select(s => new
                {
                    s.StartedAt,
                    EndedAt = s.EndedAt!.Value
                })
                .ToListAsync();

            TimeSpan? averageDuration = null;

            if (completedSessions.Count > 0)
            {
                double averageTicks = completedSessions
                    .Average(s => (double)(s.EndedAt - s.StartedAt).Ticks);

                averageDuration = TimeSpan.FromTicks((long)averageTicks);
            }

            List<ChargingSessionDailyEnergyViewModel> dailyEnergy = await query
                .GroupBy(s => s.StartedAt.Date)
                .Select(g => new ChargingSessionDailyEnergyViewModel
                {
                    Date = g.Key,
                    EnergyKWh = g.Sum(s => s.EnergyKWh)
                })
                .OrderBy(day => day.Date)
                .ToListAsync();

            List<MostUsedConnectorViewModel> mostUsedConnectors = await query
                .GroupBy(cs => new
                {
                    cs.ConnectorId,
                    cs.Connector.ConnectorNumber,
                    cs.Connector.ChargingStationId,
                    ChargingStationName = cs.Connector.ChargingStation.Name
                })
                .Select(g => new MostUsedConnectorViewModel
                {
                    ConnectorId = g.Key.ConnectorId,
                    ConnectorNumber = g.Key.ConnectorNumber,
                    ChargingStationId = g.Key.ChargingStationId,
                    ChargingStationName = g.Key.ChargingStationName,
                    SessionsCount = g.Count()
                })
                .OrderByDescending(c => c.SessionsCount)
                .ThenBy(c => c.ConnectorId)
                .Take(5)
                .ToListAsync();

            int totalPages = (int)Math.Ceiling((double)sessionsCount / pageSize);
            int pageNumber = Math.Clamp(filters.PageNumber, 1,Math.Max(1, totalPages));

            List<ChargingSessionIndexItemViewModel> sessions = await query
                .OrderByDescending(s => s.StartedAt)
                .ThenByDescending(s => s.Id)
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .Select(cs => new ChargingSessionIndexItemViewModel
                {
                    Id = cs.Id,
                    StartedAt = cs.StartedAt,
                    EndedAt = cs.EndedAt,
                    EnergyKWh = cs.EnergyKWh,
                    AppliedPricePerKWh = cs.AppliedPricePerKWh,
                    TotalCost = cs.TotalCost,
                    ConnectorId = cs.ConnectorId,
                    ConnectorNumber = cs.Connector.ConnectorNumber.ToString(),
                    ChargingStationId = cs.Connector.ChargingStationId,
                    ChargingStationName = cs.Connector.ChargingStation.Name
                })
                .ToListAsync();

            ChargingSessionsIndexViewModel viewModel = new ChargingSessionsIndexViewModel
            {
                Sessions = sessions,
                SessionsCount = sessionsCount,
                TotalEnergyKWh = totalEnergyKWh,
                TotalCost = totalCost,
                AverageDuration = averageDuration,
                DailyEnergy = dailyEnergy,
                MostUsedConnectors = mostUsedConnectors,
                SearchTerm = inputModel.SearchTerm?.Trim(),
                From = inputModel.From,
                To = inputModel.To,
                PageNumber = pageNumber,
                PageSize = pageSize
            };

            return View(viewModel);
        }


        [HttpGet]
        public async Task<IActionResult> Create()
        {
            IEnumerable<ChargingStation> allChargingStations = await _dbContext.ChargingStations
                .AsNoTracking()
                .OrderBy(s => s.Name)
                .ToArrayAsync();

            DateTime currentDateTime = DateTime.Now;

            currentDateTime = new DateTime
            (
                currentDateTime.Year,
                currentDateTime.Month,
                currentDateTime.Day,
                currentDateTime.Hour,
                currentDateTime.Minute,
                0
            );

            ChargingSessionsCreateViewModel viewModel = new ChargingSessionsCreateViewModel
            {
                ChargingStations = allChargingStations,

                InputModel = new ChargingSessionsCreateInputModel
                {
                    StartedAt = currentDateTime,
                    EndedAt = currentDateTime.AddMinutes(30)
                }
            };

            return View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Create(ChargingSessionsCreateViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                viewModel.ChargingStations = await FetchChargingStationsAsync();
                return View(viewModel);
            }

            ChargingSessionsCreateInputModel inputModel = viewModel.InputModel;

            if (!await ChargingStationExistsAsync(inputModel.ChargingStationId))
            {
                ModelState.AddModelError(
                    $"{nameof(ChargingSessionsCreateViewModel.InputModel)}.{nameof(inputModel.ChargingStationId)}",
                    "The selected charging station does not exist.");
            }
            else
            {
                Connector? connector =
                    await GetConnectorForStationAsync(inputModel.ConnectorId, inputModel.ChargingStationId);

                if (connector == null)
                {
                    ModelState.AddModelError(
                        $"{nameof(ChargingSessionsCreateViewModel.InputModel)}.{nameof(inputModel.ConnectorId)}",
                        "The selected connector does not exist or does not belong to the selected charging station.");
                }
                else
                {
                    ValidateChargingDuration(inputModel);
                    ValidateEnergy(inputModel, connector);
                    ValidateAppliedPrice(inputModel, connector);
                }
            }

            if (!ModelState.IsValid)
            {
                viewModel.ChargingStations = await FetchChargingStationsAsync();
                return View(viewModel);
            }


            try
            {
                ChargingSession newSession = new ChargingSession
                {
                    ConnectorId = inputModel.ConnectorId,
                    StartedAt = inputModel.StartedAt,
                    EndedAt = inputModel.EndedAt,
                    EnergyKWh = inputModel.EnergyKWh,
                    AppliedPricePerKWh = inputModel.AppliedPricePerKWh,
                    TotalCost = Math.Round(inputModel.EnergyKWh * inputModel.AppliedPricePerKWh,2,MidpointRounding.AwayFromZero)
                };

                _dbContext.ChargingSessions.Add(newSession);
                await _dbContext.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                ModelState.AddModelError
                (
                    string.Empty,
                    "An unexpected error occurred while saving the charging session. Please try again."
                );

                return View(viewModel);
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetConnectorsByStation(int stationId)
        {
            ConnectorSelectViewModel[] connectors = await _dbContext.Connectors
                .AsNoTracking()
                .Where(c => c.ChargingStationId == stationId)
                .OrderBy(c => c.ConnectorNumber)
                .Select(c => new ConnectorSelectViewModel
                {
                    Id = c.Id,
                    Text = $"Connector {c.ConnectorNumber} - {c.ConnectorType} - {c.PowerKw:F0} kW",
                    PowerKw = c.PowerKw,
                    PricePerKWh = c.PricePerKWh
                })
                .ToArrayAsync();

            return Json(connectors);
        }

        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            if (id <= 0)
            {
                return BadRequest();
            }

            ChargingSession? selectedChargingSession = await _dbContext.ChargingSessions
                .AsNoTracking()
                .Include(cs => cs.Connector)
                .ThenInclude(c => c.ChargingStation)
                .ThenInclude(c => c.Operator)
                .SingleOrDefaultAsync(cs => cs.Id == id);

            if (selectedChargingSession == null)
            {
                return BadRequest();
            }

            ChargingSessionsDetailsViewModel viewModel = new ChargingSessionsDetailsViewModel
            {
                Id = selectedChargingSession.Id,
                StartedAt = selectedChargingSession.StartedAt,
                EndedAt = selectedChargingSession.EndedAt,
                EnergyKWh = selectedChargingSession.EnergyKWh,
                AppliedPricePerKWh = selectedChargingSession.AppliedPricePerKWh,
                TotalCost = selectedChargingSession.TotalCost,

                
                ConnectorNumber = selectedChargingSession.ConnectorId.ToString(),
                ConnectorType = selectedChargingSession.Connector.ConnectorType.ToString(),
                ConnectorPowerKw = selectedChargingSession.Connector.PowerKw,

                ChargingStationId = selectedChargingSession.Connector.ChargingStationId,
                ChargingStationName = selectedChargingSession.Connector.ChargingStation.Name,
                ChargingStationCity = selectedChargingSession.Connector.ChargingStation.City,
                ChargingStationAddress = selectedChargingSession.Connector.ChargingStation.Address,
                OperatorName = selectedChargingSession.Connector.ChargingStation.Operator.Name
            };

            return View(viewModel);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            if (id <= 0)
            {
                return BadRequest();
            }

            ChargingSession? selectedChargingSession = await _dbContext.ChargingSessions
                .AsNoTracking()
                .Include(cs => cs.Connector)
                .SingleOrDefaultAsync(cs => cs.Id == id);

            if (selectedChargingSession == null)
            {
                return NotFound();
            }

            if (!selectedChargingSession.EndedAt.HasValue)
            {
                return BadRequest("Editing an unfinished charging session is not supported.");
            }

            ChargingSessionsEditViewModel viewModel = new ChargingSessionsEditViewModel
            {
                Id = selectedChargingSession.Id,
                ChargingStations = await FetchChargingStationsAsync(),

                InputModel = new ChargingSessionsCreateInputModel()
                {
                    ChargingStationId = selectedChargingSession.Connector.ChargingStationId,
                    ConnectorId = selectedChargingSession.ConnectorId,
                    StartedAt = selectedChargingSession.StartedAt,
                    EndedAt = selectedChargingSession.EndedAt.Value,
                    EnergyKWh = selectedChargingSession.EnergyKWh,
                    AppliedPricePerKWh = selectedChargingSession.AppliedPricePerKWh
                }
            };

            return View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Edit([FromRoute] int id, ChargingSessionsEditViewModel viewModel)
        {
            if (id <= 0)
            {
                return BadRequest();
            }

            ChargingSession? selectedChargingSession = await _dbContext.ChargingSessions
                .SingleOrDefaultAsync(cs => cs.Id == id);

            ChargingSessionsCreateInputModel inputModel = viewModel.InputModel;

            if (selectedChargingSession == null)
            {
                return NotFound();
            }

            if (!await ChargingStationExistsAsync(inputModel.ChargingStationId))
            {
                ModelState.AddModelError(
                    $"{nameof(ChargingSessionsCreateViewModel.InputModel)}.{nameof(inputModel.ChargingStationId)}",
                    "The selected charging station does not exist.");
            }
            else
            {
                Connector? connector =
                    await GetConnectorForStationAsync(inputModel.ConnectorId, inputModel.ChargingStationId);

                if (connector == null)
                {
                    ModelState.AddModelError(
                        $"{nameof(ChargingSessionsCreateViewModel.InputModel)}.{nameof(inputModel.ConnectorId)}",
                        "The selected connector does not exist or does not belong to the selected charging station.");
                }
                else
                {
                    ValidateChargingDuration(inputModel);
                    ValidateEnergy(inputModel, connector);
                    ValidateAppliedPrice(inputModel, connector);
                }
            }

            if (!ModelState.IsValid)
            {
                viewModel.ChargingStations = await FetchChargingStationsAsync();
                return View(viewModel);
            }

            try
            {
                selectedChargingSession.ConnectorId = inputModel.ConnectorId;
                selectedChargingSession.StartedAt = inputModel.StartedAt;
                selectedChargingSession.EndedAt = inputModel.EndedAt;
                selectedChargingSession.EnergyKWh = inputModel.EnergyKWh;
                selectedChargingSession.AppliedPricePerKWh = inputModel.AppliedPricePerKWh;

                await _dbContext.SaveChangesAsync();
                return RedirectToAction(nameof(Index), new { id });
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                ModelState.AddModelError
                (
                    string.Empty,
                    "An unexpected error occurred while saving the charging session. Please try again."
                );

                return View(viewModel);
            }
        }


        [HttpGet]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            if (id <= 0)
            {
                return BadRequest();
            }

            ChargingSessionsDeleteViewModel? viewModel = await _dbContext.ChargingSessions
                .AsNoTracking()
                .Where(cs => cs.Id == id)
                .Select(cs => new ChargingSessionsDeleteViewModel
                {
                    Id = cs.Id,
                    ChargingStationName = cs.Connector.ChargingStation.Name,
                    ChargingStationCity = cs.Connector.ChargingStation.City,
                    ConnectorNumber = cs.Connector.ConnectorNumber,
                    StartedAt = cs.StartedAt,
                    EndedAt = cs.EndedAt,
                    EnergyKWh = cs.EnergyKWh
                })
                .SingleOrDefaultAsync();

            if (viewModel == null)
            {
                return NotFound();
            }

            
            return View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Delete([FromRoute] int id, ChargingSessionsDeleteViewModel viewModel)
        {
            if (id <= 0)
            {
                return BadRequest();
            }

            ChargingSession? selectedChargingSession = await _dbContext.ChargingSessions
                .SingleOrDefaultAsync(cs => cs.Id == id);

            if (selectedChargingSession == null)
            {
                return NotFound();
            }

            try
            {
                _dbContext.ChargingSessions.Remove(selectedChargingSession);
                await _dbContext.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            catch (DbUpdateException e)
            {
                Console.Error.WriteLine(e);
                ModelState.AddModelError(string.Empty, "An error occurred while deleting the charging session. Please try again.\"");
                return RedirectToAction(nameof(Delete), new { id, saveChangesError = true });
            }
        }

        private async Task<ChargingStation[]> FetchChargingStationsAsync()
        {
            return await _dbContext.ChargingStations
                .AsNoTracking()
                .OrderBy(s => s.Name)
                .ToArrayAsync();
        }

        private async Task<bool> ChargingStationExistsAsync(int chargingStationId)
        {
            return await _dbContext.ChargingStations.AnyAsync(e => e.Id == chargingStationId);
        }

        private async Task<Connector?> GetConnectorForStationAsync(int connectorId, int stationId)
        {
            return await _dbContext.Connectors
                .AsNoTracking()
                .SingleOrDefaultAsync(c => c.Id == connectorId && c.ChargingStationId == stationId);
        }

        private void ValidateChargingDuration(ChargingSessionsCreateInputModel inputModel)
        {
            TimeSpan duration = inputModel.EndedAt - inputModel.StartedAt;

            if (duration > TimeSpan.FromHours(96))
            {
                ModelState.AddModelError(
                    $"{nameof(ChargingSessionsCreateViewModel.InputModel)}.{nameof(inputModel.EndedAt)}",
                    "Charging session cannot exceed 96 hours.");
            }
        }

        private void ValidateEnergy(ChargingSessionsCreateInputModel inputModel, Connector connector)
        {
            TimeSpan duration = inputModel.EndedAt - inputModel.StartedAt;

            if (duration <= TimeSpan.Zero)
            {
                return;
            }

            decimal maximumEnergyKWh = connector.PowerKw * (decimal)duration.TotalHours;

            if (inputModel.EnergyKWh > maximumEnergyKWh)
            {
                ModelState.AddModelError(
                    $"{nameof(ChargingSessionsCreateViewModel.InputModel)}.{nameof(inputModel.EnergyKWh)}",
                    $"Maximum energy for this charging period is {maximumEnergyKWh:F2} kWh.");
            }
        }

        private void ValidateAppliedPrice(ChargingSessionsCreateInputModel inputModel, Connector connector)
        {
            if (inputModel.AppliedPricePerKWh > connector.PricePerKWh)
            {
                ModelState.AddModelError(
                    $"{nameof(ChargingSessionsCreateViewModel.InputModel)}.{nameof(inputModel.AppliedPricePerKWh)}",
                    $"The applied price cannot exceed {connector.PricePerKWh:F2} €/kWh.");
            }
        }
    }
}