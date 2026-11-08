namespace EVChargeFinder.ViewModels.ChargingSessions
{
    public class ChargingSessionIndexItemViewModel
    {
        public int Id { get; set; }

        public DateTime StartedAt { get; set; } = DateTime.UtcNow;

        public DateTime? EndedAt { get; set; } = DateTime.UtcNow;

        public decimal EnergyKWh { get; set; }

        public decimal AppliedPricePerKWh { get; set; }

        public decimal TotalCost { get; set; }

        public int ConnectorId { get; set; }

        public string ConnectorNumber { get; set; } = null!;

        public int ChargingStationId { get; set; }

        public string ChargingStationName { get; set; } = null!;

        public TimeSpan? Duration
        {
            get
            {
                if (EndedAt.HasValue)
                {
                    return EndedAt.Value - StartedAt;
                }

                return null;
            }
        }
    }
}