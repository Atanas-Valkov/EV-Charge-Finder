namespace EVChargeFinder.ViewModels.ChargingStations
{
    using DbModels.Enums;

    public class ChargingStationIndexItemViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public string Address { get; set; } = null!;

        public string? City { get; set; }

        public string OperatorName { get; set; } = null!;

        public ChargingStationStatus Status { get; set; }

        public decimal Latitude { get; set; }

        public decimal Longitude { get; set; }

        public string ChargingType { get; set; } = null!;

        public decimal MaxPowerKw { get; set; }
    }
}