using EVChargeFinder.DbModels;
using EVChargeFinder.InputModels;

namespace EVChargeFinder.ViewModels.ChargingSessions
{
    public class ChargingSessionsCreateViewModel
    {
        public ChargingSessionsCreateInputModel InputModel { get; set; }
            = new();

        public IEnumerable<ChargingStation> ChargingStations { get; set; } = new List<ChargingStation>();
    }
}