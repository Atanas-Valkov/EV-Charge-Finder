namespace EVChargeFinder.Services.Core.Interfaces
{
    using EVChargeFinder.InputModels;
    using EVChargeFinder.ViewModels.ChargingStations;

    public interface IChargingStationService
    {
        Task<ChargingStationsIndexViewModel> GetIndexAsync(int pageNumber = 1);

        Task<ChargingStationDetailsViewModel?> GetDetailsAsync(int id);

        Task<ChargingStationsIndexViewModel> SearchAsync(ChargingStationsSearchInputModel inputModel);
    }
}