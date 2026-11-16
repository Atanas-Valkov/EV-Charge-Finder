namespace EVChargeFinder.Controllers
{
    using Data;
    using InputModels;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;
    using Services.Core.Interfaces;
    using System.ComponentModel.DataAnnotations;
    using ViewModels.ChargingSessions;

    public class ChargingSessionsController : ControllerBase
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly IChargingSessionService _chargingSessionService;
        private readonly ILogger<ChargingSessionsController> _logger;


        public ChargingSessionsController(ApplicationDbContext dbContext,
            IChargingSessionService chargingSessionService, ILogger<ChargingSessionsController> logger)
        {
            _dbContext = dbContext;
            _chargingSessionService = chargingSessionService;
            _logger = logger;
        }


        [HttpGet]
        public async Task<IActionResult> Index([FromQuery] ChargingSessionsSearchInputModel inputModel)
        {
            string currentUserId = GetUserId();

            if (string.IsNullOrEmpty(currentUserId))
            {
                return Challenge();
            }

            bool isAdmin = User.IsInRole("Admin");

            ChargingSessionsSearchInputModel filters = ModelState.IsValid
                ? inputModel
                : new ChargingSessionsSearchInputModel();

            ChargingSessionsIndexViewModel viewModel =
                await _chargingSessionService.GetIndexAsync(filters, currentUserId, isAdmin);

            viewModel.SearchTerm = inputModel.SearchTerm?.Trim();
            viewModel.From = inputModel.From;
            viewModel.To = inputModel.To;

            return View(viewModel);
        }


        [HttpGet]
        public async Task<IActionResult> Create()
        {
            ChargingSessionsCreateViewModel viewModel = await _chargingSessionService.GetCreateAsync();

            return View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Create(ChargingSessionsCreateViewModel viewModel)
        {
            string currentUserId = GetUserId();

            if (!ModelState.IsValid)
            {
                viewModel.ChargingStations = await _chargingSessionService.FetchChargingStationsAsync();
                return View(viewModel);
            }

            try
            {
                IEnumerable<ValidationResult> validationErrors =
                    await _chargingSessionService.CreateAsync(viewModel.InputModel, currentUserId);

                foreach (ValidationResult error in validationErrors)
                {
                    foreach (string memberName in error.MemberNames)
                    {
                        ModelState.AddModelError(
                            $"{nameof(ChargingSessionsCreateViewModel.InputModel)}.{memberName}",
                            error.ErrorMessage ?? "Invalid value.");
                    }
                }

                if (!ModelState.IsValid)
                {
                    viewModel.ChargingStations = await _chargingSessionService.FetchChargingStationsAsync();
                    return View(viewModel);
                }

                return RedirectToAction(nameof(Index));
            }
            catch (Exception e)
            {
                _logger.LogError(e, "An error occurred while creating a charging session.");

                ModelState.AddModelError(
                    string.Empty,
                    "An unexpected error occurred while saving the charging session. Please try again.");

                viewModel.ChargingStations = await _chargingSessionService.FetchChargingStationsAsync();

                return View(viewModel);
            }
        }


        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            if (id <= 0)
            {
                return BadRequest();
            }

            string currentUserId = GetUserId();

            if (string.IsNullOrWhiteSpace(currentUserId))
            {
                return Challenge();
            }

            bool isAdmin = User.IsInRole("Admin");
            ;

            ChargingSessionsDetailsViewModel? selectedChargingSession =
                await _chargingSessionService.GetDetailsAsync(id, currentUserId, isAdmin);

            if (selectedChargingSession == null)
            {
                return NotFound();
            }

            return View(selectedChargingSession);
        }


        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            if (id <= 0)
            {
                return BadRequest();
            }

            string currentUserId = GetUserId();
            bool isAdmin = User.IsInRole("Admin");

            (ChargingSessionsEditViewModel? viewModel, bool isUnfinishedGet) =
                await _chargingSessionService.GetEditAsync(id, currentUserId, isAdmin);

            if (isUnfinishedGet)
            {
                return BadRequest("Editing an unfinished charging session is not supported.");
            }

            if (viewModel == null)
            {
                return NotFound();
            }

            return View(viewModel);
        }


        [HttpPost]
        public async Task<IActionResult> Edit([FromRoute] int id, ChargingSessionsEditViewModel viewModel)
        {
            if (id <= 0)
            {
                return BadRequest();
            }

            string currentUserId = GetUserId();

            if (string.IsNullOrWhiteSpace(currentUserId))
            {
                return Challenge();
            }

            bool isAdmin = User.IsInRole("Admin");

            try
            {
                if (!ModelState.IsValid)
                {
                    (ChargingSessionsEditViewModel? currentViewModel, bool isUnfinishedGet) =
                        await _chargingSessionService.GetEditAsync(id, currentUserId, isAdmin);

                    if (isUnfinishedGet)
                    {
                        return BadRequest("Editing an unfinished charging session is not supported.");
                    }

                    if (currentViewModel == null)
                    {
                        return NotFound();
                    }

                    viewModel.ChargingStations = currentViewModel.ChargingStations;

                    return View(viewModel);
                }

                (IEnumerable<ValidationResult>? validationErrors, bool isUnfinishedEdit) =
                    await _chargingSessionService.EditAsync(id, viewModel.InputModel, currentUserId, isAdmin);

                if (isUnfinishedEdit)
                {
                    return BadRequest("Editing an unfinished charging session is not supported.");
                }

                if (validationErrors == null)
                {
                    return NotFound();
                }

                foreach (ValidationResult error in validationErrors)
                {
                    foreach (string memberName in error.MemberNames)
                    {
                        ModelState.AddModelError($"{nameof(ChargingSessionsEditViewModel.InputModel)}.{memberName}",
                            error.ErrorMessage ?? "Invalid value.");
                    }
                }

                if (!ModelState.IsValid)
                {
                    viewModel.ChargingStations = await _chargingSessionService.FetchChargingStationsAsync();
                    return View(viewModel);
                }

                return RedirectToAction(nameof(Index));
            }
            catch (Exception e)
            {
                _logger.LogError(e, "An error occurred while editing charging session with ID {SessionId}.", id);

                ModelState.AddModelError(
                    string.Empty,
                    "An unexpected error occurred while saving the charging session. Please try again.");

                viewModel.ChargingStations = await _chargingSessionService.FetchChargingStationsAsync();

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

            string currentUserId = GetUserId();
            bool isAdmin = User.IsInRole("Admin");

            ChargingSessionsDeleteViewModel? viewModel =
                await _chargingSessionService.GetDeleteAsync(id, currentUserId, isAdmin);

            if (viewModel == null)
            {
                return NotFound();
            }

            return View(viewModel);
        }

        [HttpPost]
        [ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed([FromRoute] int id)
        {
            if (id <= 0)
            {
                return BadRequest();
            }

            string currentUserId = GetUserId();
            bool isAdmin = User.IsInRole("Admin");

            try
            {
                bool isDeleted = await _chargingSessionService.DeleteAsync(id, currentUserId, isAdmin);

                if (!isDeleted)
                {
                    return NotFound();
                }

                return RedirectToAction(nameof(Index));
            }
            catch (DbUpdateException e)
            {
                _logger.LogError(e, "An error occurred while deleting charging session with ID {SessionId}.", id);

                ModelState.AddModelError(
                    string.Empty,
                    "An error occurred while deleting the charging session. Please try again.");

                ChargingSessionsDeleteViewModel? viewModel =
                    await _chargingSessionService.GetDeleteAsync(id, currentUserId, isAdmin);

                if (viewModel == null)
                {
                    return NotFound();
                }

                return View("Delete", viewModel);
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetConnectorsByStation(int stationId)
        {
            ConnectorSelectViewModel[] connectors =
                await _chargingSessionService.GetConnectorsByStationAsync(stationId);

            return Json(connectors);
        }
    }
}