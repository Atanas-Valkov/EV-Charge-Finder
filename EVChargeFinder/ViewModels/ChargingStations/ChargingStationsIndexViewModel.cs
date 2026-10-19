namespace EVChargeFinder.ViewModels.ChargingStations
{
    using DbModels.Enums;

    public class ChargingStationsIndexViewModel
    {
        public int StationsCount { get; set; }

        public int ActiveStationsCount { get; set; }

        public int OperatorsCount { get; set; }

        public int ConnectorsCount { get; set; }

        public string? SearchTerm { get; set; }

        public string? SelectedCity { get; set; }

        public int PageNumber { get; set; }

        public int TotalPages { get; set; }

        public ChargingStationStatus? SelectedStatus { get; set; }

        public int? SelectedOperatorId { get; set; }

        public ConnectorType? SelectedConnectorType { get; set; }


        public ICollection<string> Cities { get; set; } = new List<string>();

        public ICollection<OperatorFilterViewModel> Operators { get; set; }
            = new HashSet<OperatorFilterViewModel>();

        public ICollection<ChargingStationIndexItemViewModel> Stations { get; set; }
            = new HashSet<ChargingStationIndexItemViewModel>();

        public ChargingStationIndexItemViewModel[] MapStations { get; set; }
            = Array.Empty<ChargingStationIndexItemViewModel>();
    }
}