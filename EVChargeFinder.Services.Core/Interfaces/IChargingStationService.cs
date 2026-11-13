namespace EVChargeFinder.Services.Core.Interfaces
{
    using Data.DbModels;
    using EVChargeFinder.ViewModels.ChargingSessions;
    using InputModels;
    using ViewModels.ChargingStations;

    public interface IChargingStationService
    {
        Task<ChargingStationsIndexViewModel> GetIndexAsync(int pageNumber = 1);

        Task<ChargingStationDetailsViewModel?> GetDetailsAsync(int id);

        Task<ChargingStationsIndexViewModel> SearchAsync(ChargingStationsSearchInputModel inputModel);


    }
}