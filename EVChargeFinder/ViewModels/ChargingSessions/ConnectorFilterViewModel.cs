namespace EVChargeFinder.ViewModels.ChargingSessions
{
    public class ConnectorFilterViewModel
    {
        public int Id { get; set; }

        public int ConnectorNumber { get; set; }

        public int ChargingStationId { get; set; }

        public string ChargingStationName { get; set; } = null!;
    }
}