namespace EVChargeFinder.ViewModels.ChargingSessions
{
    public class MostUsedConnectorViewModel
    {
        public int ConnectorId { get; set; }

        public int ConnectorNumber { get; set; }

        public int ChargingStationId { get; set; }

        public string ChargingStationName { get; set; } = null!;

        public int SessionsCount { get; set; }
    }
}