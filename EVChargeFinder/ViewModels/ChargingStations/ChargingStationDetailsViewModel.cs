namespace EVChargeFinder.ViewModels.ChargingStations
{
    using DbModels.Enums;

    public class ChargingStationDetailsViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public string Address { get; set; } = null!;

        public string? City { get; set; }

        public string OperatorName { get; set; } = null!;

        public ChargingStationStatus Status { get; set; }

        public string DataSource { get; set; } = null!;

        public DateTime LastUpdatedAt { get; set; }

        public decimal Latitude { get; set; }

        public decimal Longitude { get; set; }

        public int ConnectorsCount { get; set; }

        public decimal MaxPowerKw { get; set; }

        public ICollection<ConnectorDetailsViewModel> Connectors { get; set; }
            = new HashSet<ConnectorDetailsViewModel>();
    }
}