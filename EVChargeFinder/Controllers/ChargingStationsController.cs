namespace EVChargeFinder.Controllers
{
    using Data;
    using DbModels;
    using DbModels.Enums;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;
    using ViewModels.ChargingStations;


    public class ChargingStationsController : Controller
    {
        private readonly ApplicationDbContext _dbContext;

        public ChargingStationsController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public async Task<IActionResult> Index(int pageNumber = 1)
        {
            const int pageSize = 10;

            ChargingStation[] chargingStations = await _dbContext
                .ChargingStations
                .AsNoTracking()
                .Include(cs => cs.Operator)
                .Include(cs => cs.Connectors)
                .ToArrayAsync();


            int totalStations = chargingStations.Length;

            int totalPages = (int)Math.Ceiling(
                totalStations / (double)pageSize
            );


            pageNumber = Math.Max(1, pageNumber);

            if (totalPages > 0)
            {
                pageNumber = Math.Min(
                    pageNumber,
                    totalPages
                );
            }


            ChargingStationIndexItemViewModel[] mapStationViewModels =
                chargingStations
                    .Select(cs => new ChargingStationIndexItemViewModel
                    {
                        Id = cs.Id,
                        Name = cs.Name,
                        Address = cs.Address,
                        City = cs.City,
                        OperatorName = cs.Operator.Name,
                        Status = cs.ChargingStationStatus,
                        Latitude = cs.Latitude,
                        Longitude = cs.Longitude,

                        MaxPowerKw = cs.Connectors.Any()
                            ? cs.Connectors.Max(c => c.PowerKw)
                            : 0,

                        ChargingType = GetChargingType(cs)
                    })
                    .ToArray();


            ChargingStationIndexItemViewModel[] chargingStationViewModels =
                mapStationViewModels
                    .OrderBy(cs => cs.Id)
                    .Skip((pageNumber - 1) * pageSize)
                    .Take(pageSize)
                    .ToArray();


            string[] cities = await _dbContext
                .ChargingStations
                .AsNoTracking()
                .Where(cs => cs.City != null)
                .Select(cs => cs.City!)
                .Distinct()
                .OrderBy(c => c)
                .ToArrayAsync();


            OperatorFilterViewModel[] operators = await _dbContext
                .Operators
                .AsNoTracking()
                .OrderBy(o => o.Name)
                .Select(o => new OperatorFilterViewModel
                {
                    Id = o.Id,
                    Name = o.Name
                })
                .ToArrayAsync();


            ChargingStationsIndexViewModel model = new ChargingStationsIndexViewModel
                {
                    Stations = chargingStationViewModels,
                    MapStations = mapStationViewModels,
                    Cities = cities,
                    Operators = operators,
                    StationsCount = chargingStations.Length,
                    ActiveStationsCount = chargingStations
                        .Count(cs =>
                            cs.ChargingStationStatus ==
                            ChargingStationStatus.Active),

                    OperatorsCount = operators.Length,
                    ConnectorsCount = chargingStations
                        .Sum(cs => cs.Connectors.Count),
                    PageNumber = pageNumber,
                    TotalPages = totalPages
                };

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Details(int? id)
        {
            if (!id.HasValue || id <= 0)
            {
                return BadRequest();
            }

            var chargingStationDetailsQuery = await _dbContext.ChargingStations
                .AsNoTracking()
                .Include(cs => cs.Operator)
                .Include(cs => cs.Connectors)
                .SingleOrDefaultAsync(cs => cs.Id == id);

            if (chargingStationDetailsQuery == null)
            {
                return NotFound();
            }

            ChargingStationDetailsViewModel detailsViewModel =
                new ChargingStationDetailsViewModel
                {
                    Id = chargingStationDetailsQuery.Id,
                    Name = chargingStationDetailsQuery.Name,
                    Address = chargingStationDetailsQuery.Address,
                    City = chargingStationDetailsQuery.City,
                    OperatorName = chargingStationDetailsQuery.Operator.Name,
                    Status = chargingStationDetailsQuery.ChargingStationStatus,
                    DataSource = chargingStationDetailsQuery.DataSource,
                    LastUpdatedAt = chargingStationDetailsQuery.LastUpdatedAt,
                    Latitude = chargingStationDetailsQuery.Latitude,
                    Longitude = chargingStationDetailsQuery.Longitude,

                    ConnectorsCount = chargingStationDetailsQuery.Connectors.Count,

                    MaxPowerKw = chargingStationDetailsQuery.Connectors.Any()
                        ? chargingStationDetailsQuery.Connectors.Max(c => c.PowerKw)
                        : 0,
                    Connectors = chargingStationDetailsQuery.Connectors
                        .OrderBy(c => c.ConnectorNumber)
                        .Select(c => new ConnectorDetailsViewModel
                        {
                            Id = c.Id,
                            ConnectorNumber = c.ConnectorNumber,
                            ConnectorType = c.ConnectorType,
                            PowerKw = c.PowerKw,
                            PricePerKWh = c.PricePerKWh,
                            Status = c.ConnectorStatus
                        })
                        .ToList()
                };

            return View(detailsViewModel);
        }


        [HttpGet]
        public async Task<IActionResult> Search(string? searchTerm, string? city, ChargingStationStatus? status, int? operatorId, ConnectorType? connectorType, int pageNumber = 1)
        {
            IQueryable<ChargingStation> chargingStationsQuery = _dbContext.ChargingStations
                .AsNoTracking()
                .Include(cs => cs.Operator)
                .Include(cs => cs.Connectors);


            if (!string.IsNullOrWhiteSpace(searchTerm))
            {
                chargingStationsQuery = chargingStationsQuery.Where(cs =>
                    cs.Name.Contains(searchTerm) ||
                    cs.Address.Contains(searchTerm) ||
                    (cs.City != null && cs.City.Contains(searchTerm)) ||
                    cs.Operator.Name.Contains(searchTerm));
            }

            if (!string.IsNullOrWhiteSpace(city))
            {
                chargingStationsQuery = chargingStationsQuery
                    .Where(cs =>
                        cs.City != null &&
                        cs.City == city);
            }


            if (status.HasValue)
            {
                chargingStationsQuery = chargingStationsQuery
                    .Where(cs =>
                        cs.ChargingStationStatus == status.Value);
            }


            if (operatorId.HasValue)
            {
                chargingStationsQuery = chargingStationsQuery
                    .Where(cs =>
                        cs.OperatorId == operatorId.Value);
            }


            if (connectorType.HasValue)
            {
                chargingStationsQuery = chargingStationsQuery
                    .Where(cs =>
                        cs.Connectors.Any(c =>
                            c.ConnectorType == connectorType.Value));
            }


            const int pageSize = 10;

            int totalStations = await chargingStationsQuery.CountAsync();

            int activeStationsCount = await chargingStationsQuery
                .CountAsync(cs =>
                    cs.ChargingStationStatus == ChargingStationStatus.Active);

            int operatorsCount = await chargingStationsQuery
                .Select(cs => cs.OperatorId)
                .Distinct()
                .CountAsync();

            int connectorsCount = await chargingStationsQuery
                .SelectMany(cs => cs.Connectors)
                .CountAsync();


            int totalPages = (int)Math.Ceiling(
                totalStations / (double)pageSize);


            pageNumber = Math.Max(1, pageNumber);

            if (totalPages > 0)
            {
                pageNumber = Math.Min(
                    pageNumber,
                    totalPages);
            }


            ChargingStation[] chargingStationsDbModels =
                await chargingStationsQuery
                    .OrderBy(cs => cs.Id)
                    .Skip((pageNumber - 1) * pageSize)
                    .Take(pageSize)
                    .ToArrayAsync();


            ChargingStationIndexItemViewModel[] chargingStationViewModels =
                chargingStationsDbModels
                    .Select(cs => new ChargingStationIndexItemViewModel
                    {
                        Id = cs.Id,
                        Name = cs.Name,
                        Address = cs.Address,
                        City = cs.City,
                        OperatorName = cs.Operator.Name,
                        Status = cs.ChargingStationStatus,
                        Latitude = cs.Latitude,
                        Longitude = cs.Longitude,

                        MaxPowerKw = cs.Connectors.Any()
                            ? cs.Connectors.Max(c => c.PowerKw)
                            : 0,

                        ChargingType = GetChargingType(cs)
                    })
                    .ToArray();


            string[] cities = await _dbContext
                .ChargingStations
                .AsNoTracking()
                .Where(cs => cs.City != null)
                .Select(cs => cs.City!)
                .Distinct()
                .OrderBy(c => c)
                .ToArrayAsync();


            OperatorFilterViewModel[] operators = await _dbContext
                .Operators
                .AsNoTracking()
                .OrderBy(o => o.Name)
                .Select(o => new OperatorFilterViewModel
                {
                    Id = o.Id,
                    Name = o.Name
                })
                .ToArrayAsync();


            ChargingStationsIndexViewModel chargingStationsViewModel =
                new ChargingStationsIndexViewModel
                {
                    Stations = chargingStationViewModels,

                    Cities = cities,
                    Operators = operators,
                    StationsCount = totalStations,
                    ActiveStationsCount = activeStationsCount,
                    OperatorsCount = operatorsCount,
                    ConnectorsCount = connectorsCount,
                    SearchTerm = searchTerm,
                    SelectedCity = city,
                    SelectedStatus = status,
                    SelectedOperatorId = operatorId,
                    SelectedConnectorType = connectorType,
                    PageNumber = pageNumber,
                    TotalPages = totalPages
                };


            return View("Index", chargingStationsViewModel);
        }

        private static string GetChargingType(ChargingStation chargingStation)
        {
            bool hasAc = chargingStation.Connectors.Any(c =>
                c.ConnectorType == ConnectorType.Type1 ||
                c.ConnectorType == ConnectorType.Type2 ||
                c.ConnectorType == ConnectorType.Schuko ||
                c.ConnectorType == ConnectorType.GB_T_AC);

            bool hasDc = chargingStation.Connectors.Any(c =>
                c.ConnectorType == ConnectorType.CCS1 ||
                c.ConnectorType == ConnectorType.CCS2 ||
                c.ConnectorType == ConnectorType.CHAdeMO ||
                c.ConnectorType == ConnectorType.NACS ||
                c.ConnectorType == ConnectorType.GB_T_DC ||
                c.ConnectorType == ConnectorType.MCS);

            if (hasAc && hasDc)
            {
                return "AC/DC";
            }

            if (hasDc)
            {
                return "DC";
            }

            if (hasAc)
            {
                return "AC";
            }

            return "N/A";
        }
    }
}