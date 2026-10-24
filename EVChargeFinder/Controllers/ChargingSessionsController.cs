namespace EVChargeFinder.Controllers
{
    using Data;
    using DbModels;
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
        public async Task<IActionResult> Index(string? searchTerm, int? chargingStationId, int? connectorId,
            DateTime? from, DateTime? to, int pageNumber = 1)
        {
            const int pageSize = 10;

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (from.HasValue && to.HasValue && from.Value.Date > to.Value.Date)
            {
                return BadRequest("The start date must not be after the end date.");
            }

            IQueryable<ChargingSession> query = _dbContext.ChargingSessions
                .AsNoTracking()
                .AsQueryable();

            searchTerm = searchTerm?.Trim();

            if (!string.IsNullOrWhiteSpace(searchTerm))
            {
                query = query.Where(s => s.Connector.ChargingStation.Name.Contains(searchTerm));
            }

            if (chargingStationId.HasValue)
            {
                query = query.Where(s => s.Connector.ChargingStationId == chargingStationId.Value);
            }

            if (connectorId.HasValue)
            {
                query = query.Where(s => s.ConnectorId == connectorId.Value);
            }

            if (from.HasValue)
            {
                DateTime startDate = from.Value.Date;
                query = query.Where(s => s.StartedAt >= startDate);
            }

            if (to.HasValue)
            {
                DateTime endDate = to.Value.Date;
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
                double averageTicks = completedSessions.Average(s => (double)(s.EndedAt - s.StartedAt).Ticks);
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

            pageNumber = Math.Clamp(pageNumber, 1, Math.Max(1, totalPages));

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

            List<ChargingStationFilterViewModel> chargingStations = await _dbContext.ChargingStations
                .AsNoTracking()
                .OrderBy(s => s.Name)
                .Select(s => new ChargingStationFilterViewModel
                {
                    Id = s.Id,
                    Name = s.Name
                })
                .ToListAsync();

            IQueryable<Connector> connectorsQuery = _dbContext.Connectors
                .AsNoTracking()
                .AsQueryable();

            if (chargingStationId.HasValue)
            {
                connectorsQuery = connectorsQuery.Where(c => c.ChargingStationId == chargingStationId.Value);
            }

            List<ConnectorFilterViewModel> connectors = await connectorsQuery
                .OrderBy(c => c.ChargingStation.Name)
                .ThenBy(c => c.ConnectorNumber)
                .Select(c => new ConnectorFilterViewModel
                {
                    Id = c.Id,
                    ConnectorNumber = c.ConnectorNumber,
                    ChargingStationId = c.ChargingStationId,
                    ChargingStationName = c.ChargingStation.Name
                })
                .ToListAsync();

            ChargingSessionsIndexViewModel model = new ChargingSessionsIndexViewModel
            {
                Sessions = sessions,
                SessionsCount = sessionsCount,
                TotalEnergyKWh = totalEnergyKWh,
                TotalCost = totalCost,
                AverageDuration = averageDuration,
                DailyEnergy = dailyEnergy,
                MostUsedConnectors = mostUsedConnectors,
                ChargingStations = chargingStations,
                Connectors = connectors,
                SearchTerm = searchTerm,
                SelectedChargingStationId = chargingStationId,
                SelectedConnectorId = connectorId,
                From = from,
                To = to,
                PageNumber = pageNumber,
                PageSize = pageSize
            };

            return View(model);
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

        [HttpPost]
        public async Task<IActionResult> Create(ChargingSessionsCreateViewModel viewModel)
        {
            IEnumerable<ChargingStation> allChargingStations = FetchChargingStations();
            viewModel.ChargingStations = allChargingStations;

            if (!ModelState.IsValid)
            {
                return View(viewModel);
            }

            ChargingSessionsCreateInputModel inputModel = viewModel.InputModel;

            Connector connector = await _dbContext.Connectors
                .AsNoTracking()
                .Where(c => c.Id == inputModel.ConnectorId)
                .FirstAsync(c => c.Id == inputModel.ConnectorId);

            TimeSpan chargingDuration = inputModel.EndedAt - inputModel.StartedAt;
            decimal durationHours = (decimal)chargingDuration.TotalHours;
            decimal maximumEnergyKWh = connector.PowerKw * durationHours;

            if (durationHours > 96)
            {
                ModelState.AddModelError(nameof(inputModel.EndedAt),
                    "Charging session cannot exceed 96 hours.");

                return View(viewModel);
            }

            if (inputModel.EnergyKWh > maximumEnergyKWh )
            {
                ModelState.AddModelError(nameof(inputModel.EnergyKWh),
                    $"Maximum energy for this charging period is {maximumEnergyKWh:F0} kWh.");

                return View(viewModel);
            }

            if (inputModel.AppliedPricePerKWh > connector.PricePerKWh)
            {
                ModelState.AddModelError(nameof(inputModel.AppliedPricePerKWh),
                    $"The applied price cannot exceed {connector.PricePerKWh:F2} €/kWh.");

                return View(viewModel);
            }


            ChargingSession newSession = new ChargingSession()
            {
                StartedAt = inputModel.StartedAt,
                EndedAt = inputModel.EndedAt,
                EnergyKWh = inputModel.EnergyKWh,
                AppliedPricePerKWh = inputModel.AppliedPricePerKWh,
                TotalCost = inputModel.EnergyKWh * inputModel.AppliedPricePerKWh,
                ConnectorId = inputModel.ConnectorId
            };

            _dbContext.ChargingSessions.Add(newSession);
            await _dbContext.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private IEnumerable<ChargingStation> FetchChargingStations()
        {
            return _dbContext.ChargingStations
                .AsNoTracking()
                .OrderBy(s => s.Name)
                .ToArray();
        }
    }
}