
namespace EVChargeFinder.Services.Core
{

    using Data;
    using Data.DbModels;
    using InputModels;
    using Interfaces;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;
    using System.ComponentModel.DataAnnotations;
    using ViewModels.ChargingSessions;

    public class ChargingSessionService : IChargingSessionService

    {
        private readonly ApplicationDbContext _dbContext;

        public ChargingSessionService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<ChargingSessionsIndexViewModel> GetIndexAsync(ChargingSessionsSearchInputModel filters)
        {
            const int pageSize = 10;

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

                if (endDate < DateTime.MaxValue.Date)
                {
                    DateTime exclusiveEndDate = endDate.AddDays(1);
                    query = query.Where(s => s.StartedAt < exclusiveEndDate);
                }
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
            int pageNumber = Math.Clamp(filters.PageNumber, 1, Math.Max(1, totalPages));

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
                SearchTerm = filters.SearchTerm?.Trim(),
                From = filters.From,
                To = filters.To,
                PageNumber = pageNumber,
                PageSize = pageSize
            };

            return viewModel;
        }

        public async Task<ChargingSessionsDetailsViewModel?> GetDetailsAsync(int id)
        {
            ChargingSessionsDetailsViewModel? viewModel = await _dbContext.ChargingSessions
                .AsNoTracking()
                .Where(cs => cs.Id == id)
                .Select(cs => new ChargingSessionsDetailsViewModel
                {
                    Id = cs.Id,
                    StartedAt = cs.StartedAt,
                    EndedAt = cs.EndedAt,
                    EnergyKWh = cs.EnergyKWh,
                    AppliedPricePerKWh = cs.AppliedPricePerKWh,
                    TotalCost = cs.TotalCost,

                    ConnectorNumber = cs.Connector.ConnectorNumber.ToString(),
                    ConnectorType = cs.Connector.ConnectorType.ToString(),
                    ConnectorPowerKw = cs.Connector.PowerKw,

                    ChargingStationId = cs.Connector.ChargingStationId,
                    ChargingStationName = cs.Connector.ChargingStation.Name,
                    ChargingStationCity = cs.Connector.ChargingStation.City,
                    ChargingStationAddress = cs.Connector.ChargingStation.Address,
                    OperatorName = cs.Connector.ChargingStation.Operator.Name
                })
                .SingleOrDefaultAsync();

            return viewModel;
        }
       

        public async Task<ChargingSessionsCreateViewModel> GetCreateAsync()
        {
            ChargingStation[] allChargingStations = await FetchChargingStationsAsync();
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

            return viewModel;
        }

        public async Task<IEnumerable<ValidationResult>> CreateAsync(ChargingSessionsCreateInputModel inputModel)
        {
            List<ValidationResult> validationErrors = await ValidateChargingSessionAsync(inputModel);

            if (validationErrors.Count > 0)
            {
                return validationErrors;
            }

            ChargingSession newSession = new ChargingSession
            {
                ConnectorId = inputModel.ConnectorId,
                StartedAt = inputModel.StartedAt,
                EndedAt = inputModel.EndedAt,
                EnergyKWh = inputModel.EnergyKWh,
                AppliedPricePerKWh = inputModel.AppliedPricePerKWh,
                TotalCost = Math.Round(
                    inputModel.EnergyKWh * inputModel.AppliedPricePerKWh,
                    2,
                    MidpointRounding.AwayFromZero)
            };

            await _dbContext.ChargingSessions.AddAsync(newSession);
            await _dbContext.SaveChangesAsync();

            return validationErrors;
        }


        public async Task<(ChargingSessionsEditViewModel? ViewModel, bool IsUnfinished)> GetEditAsync(int id)
        {
            ChargingSession? selectedChargingSession = await _dbContext.ChargingSessions
                .AsNoTracking()
                .Include(cs => cs.Connector)
                .SingleOrDefaultAsync(cs => cs.Id == id);

            if (selectedChargingSession == null)
            {
                return (null, false);
            }

            if (!selectedChargingSession.EndedAt.HasValue)
            {
                return (null, true);
            }

            ChargingSessionsEditViewModel viewModel = new ChargingSessionsEditViewModel
            {
                Id = selectedChargingSession.Id,
                ChargingStations = await FetchChargingStationsAsync(),

                InputModel = new ChargingSessionsCreateInputModel
                {
                    ChargingStationId = selectedChargingSession.Connector.ChargingStationId,
                    ConnectorId = selectedChargingSession.ConnectorId,
                    StartedAt = selectedChargingSession.StartedAt,
                    EndedAt = selectedChargingSession.EndedAt.Value,
                    EnergyKWh = selectedChargingSession.EnergyKWh,
                    AppliedPricePerKWh = selectedChargingSession.AppliedPricePerKWh
                }
            };

            return (viewModel, false);
        }
        public async Task<(IEnumerable<ValidationResult>? ValidationErrors, bool IsUnfinished)> EditAsync(int id, ChargingSessionsCreateInputModel inputModel)
        {
            ChargingSession? selectedChargingSession = await _dbContext.ChargingSessions
                .SingleOrDefaultAsync(cs => cs.Id == id);

            if (selectedChargingSession == null)
            {
                return (null, false);
            }

            if (!selectedChargingSession.EndedAt.HasValue)
            {
                return (new List<ValidationResult>(), true);
            }

            List<ValidationResult> validationErrors = await ValidateChargingSessionAsync(inputModel);

            if (validationErrors.Count > 0)
            {
                return (validationErrors, false);
            }

            selectedChargingSession.ConnectorId = inputModel.ConnectorId;
            selectedChargingSession.StartedAt = inputModel.StartedAt;
            selectedChargingSession.EndedAt = inputModel.EndedAt;
            selectedChargingSession.EnergyKWh = inputModel.EnergyKWh;
            selectedChargingSession.AppliedPricePerKWh = inputModel.AppliedPricePerKWh;

            selectedChargingSession.TotalCost = Math.Round(
                inputModel.EnergyKWh * inputModel.AppliedPricePerKWh,
                2,
                MidpointRounding.AwayFromZero);

            await _dbContext.SaveChangesAsync();

            return (validationErrors, false);
        }


        public async Task<ChargingSessionsDeleteViewModel?> GetDeleteAsync(int id)
        {
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

            return viewModel;
        }
        public async Task<bool> DeleteAsync(int id)
        {
            ChargingSession? selectedChargingSession = await _dbContext.ChargingSessions
                .SingleOrDefaultAsync(cs => cs.Id == id);

            if (selectedChargingSession == null)
            {
                return false;
            }

            _dbContext.ChargingSessions.Remove(selectedChargingSession);
            await _dbContext.SaveChangesAsync();

            return true;
        }



        public async Task<ConnectorSelectViewModel[]> GetConnectorsByStationAsync(int stationId)
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

            return connectors;
        }

        public async Task<ChargingStation[]> FetchChargingStationsAsync()
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

        private void ValidateChargingDuration(ChargingSessionsCreateInputModel inputModel, List<ValidationResult> validationErrors)
        {
            TimeSpan duration = inputModel.EndedAt - inputModel.StartedAt;

            if (duration > TimeSpan.FromHours(96))
            {
                validationErrors.Add(new ValidationResult(
                    "Charging session cannot exceed 96 hours.",
                    new[] { nameof(inputModel.EndedAt) }));
            }
        }


        private void ValidateEnergy(ChargingSessionsCreateInputModel inputModel, Connector connector, List<ValidationResult> validationErrors)
        {
            TimeSpan duration = inputModel.EndedAt - inputModel.StartedAt;

            if (duration <= TimeSpan.Zero)
            {
                return;
            }

            decimal maximumEnergyKWh = connector.PowerKw * (decimal)duration.TotalHours;

            if (inputModel.EnergyKWh > maximumEnergyKWh)
            {
                validationErrors.Add(new ValidationResult(
                    $"Maximum energy for this charging period is {maximumEnergyKWh:F2} kWh.",
                    new[] { nameof(inputModel.EnergyKWh) }));
            }
        }

        private void ValidateAppliedPrice(ChargingSessionsCreateInputModel inputModel, Connector connector, List<ValidationResult> validationErrors)
        {
            if (inputModel.AppliedPricePerKWh > connector.PricePerKWh)
            {
                validationErrors.Add(new ValidationResult(
                    $"The applied price cannot exceed {connector.PricePerKWh:F2} €/kWh.",
                    new[] { nameof(inputModel.AppliedPricePerKWh) }));
            }
        }


        private async Task<List<ValidationResult>> ValidateChargingSessionAsync(ChargingSessionsCreateInputModel inputModel)
        {
            List<ValidationResult> validationErrors = new List<ValidationResult>();

            if (!await ChargingStationExistsAsync(inputModel.ChargingStationId))
            {
                validationErrors.Add(new ValidationResult(
                    "The selected charging station does not exist.",
                    new[] { nameof(inputModel.ChargingStationId) }));
            }
            else
            {
                Connector? connector = await GetConnectorForStationAsync(inputModel.ConnectorId, inputModel.ChargingStationId);

                if (connector == null)
                {
                    validationErrors.Add(new ValidationResult(
                        "The selected connector does not exist or does not belong to the selected charging station.",
                        new[] { nameof(inputModel.ConnectorId) }));
                }
                else
                {
                    ValidateChargingDuration(inputModel, validationErrors);
                    ValidateEnergy(inputModel, connector, validationErrors);
                    ValidateAppliedPrice(inputModel, connector, validationErrors);
                }
            }

            return validationErrors;
        }
    }
}