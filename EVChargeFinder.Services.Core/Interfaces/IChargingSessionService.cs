using System.ComponentModel.DataAnnotations;

namespace EVChargeFinder.Services.Core.Interfaces
{
    using InputModels;
    using Data.DbModels;
    using ViewModels.ChargingSessions;

    public interface IChargingSessionService
    {
        Task<ChargingSessionsIndexViewModel> GetIndexAsync(ChargingSessionsSearchInputModel inputModel);
        Task<ChargingSessionsDetailsViewModel?> GetDetailsAsync(int id);


        Task<ChargingSessionsCreateViewModel> GetCreateAsync();
        Task<IEnumerable<ValidationResult>> CreateAsync(ChargingSessionsCreateInputModel inputModel);


        Task<(ChargingSessionsEditViewModel? ViewModel, bool IsUnfinished)> GetEditAsync(int id);
        Task<(IEnumerable<ValidationResult>? ValidationErrors, bool IsUnfinished)> EditAsync(int id, ChargingSessionsCreateInputModel inputModel);


        Task<ChargingSessionsDeleteViewModel?> GetDeleteAsync(int id);
        Task<bool> DeleteAsync(int id);



        Task<ChargingStation[]> FetchChargingStationsAsync();

        Task<ConnectorSelectViewModel[]> GetConnectorsByStationAsync(int stationId);

    }
}