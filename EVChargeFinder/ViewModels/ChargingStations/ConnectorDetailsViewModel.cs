namespace EVChargeFinder.ViewModels.ChargingStations
{
    using DbModels.Enums;

    public class ConnectorDetailsViewModel
    {
        public int Id { get; set; }

        public int ConnectorNumber { get; set; }

        public ConnectorType ConnectorType { get; set; }

        public decimal PowerKw { get; set; }

        public decimal PricePerKWh { get; set; }

        public ConnectorStatus Status { get; set; }
    }
}