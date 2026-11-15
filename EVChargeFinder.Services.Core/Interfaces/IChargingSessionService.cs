using System.ComponentModel.DataAnnotations;

namespace EVChargeFinder.Services.Core.Interfaces
{
    using InputModels;
    using Data.DbModels;
    using ViewModels.ChargingSessions;

    public interface IChargingSessionService
    {
        Task<ChargingSessionsIndexViewModel> GetIndexAsync(ChargingSessionsSearchInputModel inputModel,string currentUserId, bool isAdmin);
        Task<ChargingSessionsDetailsViewModel?> GetDetailsAsync(int id, string currentUserId, bool isAdmin);


        Task<ChargingSessionsCreateViewModel> GetCreateAsync();
        Task<IEnumerable<ValidationResult>> CreateAsync(ChargingSessionsCreateInputModel inputModel , string currentUserId);


        Task<(ChargingSessionsEditViewModel? ViewModel, bool IsUnfinished)> GetEditAsync(int id, string currentUserId, bool isAdmin);
        Task<(IEnumerable<ValidationResult>? ValidationErrors, bool IsUnfinished)> EditAsync(int id, ChargingSessionsCreateInputModel inputModel, string currentUserId, bool isAdmin);


        Task<ChargingSessionsDeleteViewModel?> GetDeleteAsync(int id, string currentUserId, bool isAdmin);
        Task<bool> DeleteAsync(int id, string currentUserId, bool isAdmin);



        Task<ChargingStation[]> FetchChargingStationsAsync();

        Task<ConnectorSelectViewModel[]> GetConnectorsByStationAsync(int stationId);

    }
}