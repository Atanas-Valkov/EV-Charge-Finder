namespace EVChargeFinder.Controllers
{
    using Data;
    using DbModels;
    using DbModels.Enums;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;
    using static Microsoft.CodeAnalysis.CSharp.SyntaxTokenParser;


    public class ChargingStationsController : Controller
    {
        private readonly ApplicationDbContext _dbContext;

        public ChargingStationsController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        // GET
        public IActionResult Index()
        {
            ChargingStation[] allChargingStations = _dbContext
                .ChargingStations
                .AsNoTracking()
                .Include(cs => cs.Operator)
                .Include(cs => cs.Connectors)
                .ToArray();

            ViewBag.Cities = _dbContext
                .ChargingStations
                .AsNoTracking()
                .Where(cs => cs.City != null)
                .Select(cs => cs.City!)
                .Distinct()
                .OrderBy(c => c)
                .ToArray();

            ViewBag.Operators = _dbContext
                .Operators
                .AsNoTracking()
                .OrderBy(o => o.Name)
                .ToArray();


            return View(allChargingStations);
        }

        public IActionResult Details(int? id)
        {
            if (!id.HasValue || id < 0)
            {
                return BadRequest();
            }

            ChargingStation? chargingStationDetails = _dbContext
                .ChargingStations
                .AsNoTracking()
                .Include(cs => cs.Operator)
                .Include(cs => cs.Connectors)
                .SingleOrDefault(cs => cs.Id == id);

            if (chargingStationDetails is null)
            {
                return NotFound();
            }

            return View(chargingStationDetails);
        }

        public IActionResult Search(string? searchTerm, string? city, ChargingStationStatus? status, int? operatorId, ConnectorType? connectorType)
        {
            IQueryable<ChargingStation> chargingStations = _dbContext
                .ChargingStations
                .AsNoTracking()
                .Include(cs => cs.Operator)
                .Include(cs => cs.Connectors);

            ViewBag.Cities = _dbContext
                .ChargingStations
                .AsNoTracking()
                .Where(cs => cs.City != null)
                .Select(cs => cs.City!)
                .Distinct()
                .OrderBy(c => c)
                .ToArray();

            ViewBag.Operators = _dbContext
                .Operators
                .AsNoTracking()
                .OrderBy(o => o.Name)
                .ToArray();

            if (!string.IsNullOrWhiteSpace(searchTerm))
            {
                chargingStations = chargingStations.Where(cs => cs.Name.Contains(searchTerm) || 
                                                                cs.Address.Contains(searchTerm) ||
                                                                cs.City !=null && cs.City.Contains(searchTerm) ||
                                                                cs.Operator.Name.Contains(searchTerm));
            }

            if (!string.IsNullOrWhiteSpace(city))
            {
                chargingStations = chargingStations.Where(cs => cs.City != null && cs.City == city);
            }

            if (status.HasValue)
            {
                chargingStations = chargingStations.Where(cs => cs.ChargingStationStatus == status.Value);
            }

            if (operatorId.HasValue)
            {
                chargingStations = chargingStations.Where(cs => cs.OperatorId == operatorId.Value);
            }

            if (connectorType.HasValue)
            {
                chargingStations = chargingStations.Where(cs => cs.Connectors.Any(c => c.ConnectorType == connectorType));
            }

            ChargingStation[] result = chargingStations.ToArray();


            return View("Index", result);
        }
    }
}