using EVChargeFinder.InputModels;
using EVChargeFinder.Services.Core.Interfaces;

namespace EVChargeFinder.Controllers
{
    using Data;
    using Data.DbModels;
    using Data.DbModels.Enums;
    using EVChargeFinder.Services.Core;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;
    using ViewModels.ChargingStations;


    public class ChargingStationsController : Controller
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly IChargingStationService _chargingStationService;

        public ChargingStationsController(ApplicationDbContext dbContext,
            IChargingStationService chargingStationService)
        {
            _dbContext = dbContext;
            _chargingStationService = chargingStationService;
        }

        [HttpGet]
        public async Task<IActionResult> Index(int pageNumber = 1)
        {
            ChargingStationsIndexViewModel model = await _chargingStationService.GetIndexAsync(pageNumber);

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Details(int? id)
        {
            if (!id.HasValue || id <= 0)
            {
                return BadRequest();
            }

            ChargingStationDetailsViewModel? viewModel = await _chargingStationService.GetDetailsAsync(id.Value);

            if (viewModel == null)
            {
                return NotFound();
            }

            return View(viewModel);
        }


        [HttpGet]
        public async Task<IActionResult> Search([FromQuery] ChargingStationsSearchInputModel inputModel)
        {
            ChargingStationsSearchInputModel filters = ModelState.IsValid
                ? inputModel
                : new ChargingStationsSearchInputModel();

            ChargingStationsIndexViewModel viewModel = await _chargingStationService.SearchAsync(filters);

            if (ModelState.IsValid &&
                inputModel.OperatorId.HasValue && viewModel.Operators.All(o => o.Id != inputModel.OperatorId.Value))
            {
                ModelState.AddModelError(nameof(inputModel.OperatorId), "The selected operator does not exist.");
            }

            viewModel.SearchTerm = inputModel.SearchTerm?.Trim();
            viewModel.SelectedChargingType = inputModel.ChargingType;
            viewModel.SelectedStatus = inputModel.Status;
            viewModel.SelectedOperatorId = inputModel.OperatorId;
            viewModel.SelectedConnectorType = inputModel.ConnectorType;

            return View("Index", viewModel);
        }
    }
}