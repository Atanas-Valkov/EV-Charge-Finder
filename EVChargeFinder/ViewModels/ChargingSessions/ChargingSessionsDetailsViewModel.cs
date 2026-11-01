namespace EVChargeFinder.ViewModels.ChargingSessions
{
    public class ChargingSessionsDetailsViewModel : ChargingSessionIndexItemViewModel
    {
        public string? ChargingStationCity { get; set; }

        public string? ChargingStationAddress { get; set; }

        public string OperatorName { get; set; } = null!;

        public string ConnectorType { get; set; } = null!;

        public decimal ConnectorPowerKw { get; set; }
    }
}