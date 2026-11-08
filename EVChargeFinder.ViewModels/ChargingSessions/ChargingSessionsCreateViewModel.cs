namespace EVChargeFinder.ViewModels.ChargingSessions
{
    using EVChargeFinder.Data.DbModels;
    using EVChargeFinder.InputModels;

    public class ChargingSessionsCreateViewModel
    {
        public ChargingSessionsCreateInputModel InputModel { get; set; }
            = new();

        public IEnumerable<ChargingStation> ChargingStations { get; set; } = new List<ChargingStation>();
    }
}