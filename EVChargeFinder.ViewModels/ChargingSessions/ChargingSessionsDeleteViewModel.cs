namespace EVChargeFinder.ViewModels.ChargingSessions
{
    public class ChargingSessionsDeleteViewModel
    {
        public int Id { get; set; }

        public string ChargingStationName { get; set; } = null!;

        public string ChargingStationCity { get; set; } = null!;

        public int ConnectorNumber { get; set; }
    
        public DateTime StartedAt { get; set; }

        public DateTime? EndedAt { get; set; }

        public decimal EnergyKWh { get; set; }
    }
}