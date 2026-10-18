namespace EVChargeFinder.ViewModels.ChargingSessions
{
    public class ChargingSessionsIndexViewModel
    {
        public int SessionsCount { get; set; }

        public decimal TotalEnergyKWh { get; set; }

        public decimal TotalCost { get; set; }

        public TimeSpan? AverageDuration { get; set; }

        public string? SearchTerm { get; set; }

        public int? SelectedChargingStationId { get; set; }

        public int? SelectedConnectorId { get; set; }

        public DateTime? From { get; set; }

        public DateTime? To { get; set; }

        public int PageNumber { get; set; } = 1;

        public int PageSize { get; set; } = 10;

        public int TotalPages => (int)Math.Ceiling((double)SessionsCount / PageSize);

        public ICollection<ChargingSessionIndexItemViewModel> Sessions { get; set; }
            = new List<ChargingSessionIndexItemViewModel>();

        public ICollection<ChargingSessionDailyEnergyViewModel> DailyEnergy { get; set; }
            = new List<ChargingSessionDailyEnergyViewModel>();

        public ICollection<MostUsedConnectorViewModel> MostUsedConnectors { get; set; }
            = new List<MostUsedConnectorViewModel>();

        public ICollection<ChargingStationFilterViewModel> ChargingStations { get; set; }
            = new List<ChargingStationFilterViewModel>();

        public ICollection<ConnectorFilterViewModel> Connectors { get; set; }
            = new List<ConnectorFilterViewModel>();
    }
}