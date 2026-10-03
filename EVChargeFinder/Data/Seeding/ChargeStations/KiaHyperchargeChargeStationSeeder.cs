namespace EVChargeFinder.Data.Seeding.ChargingStations
{
    using DbModels;
    using DbModels.Enums;
    public static class KiaHyperchargeChargingStationSeeder
    {
        public static ChargingStation[] GetChargingStations(int operatorId)
        {
            return
            [
                new ChargingStation
                {
                    Name = "Kia Hypercharge Tsarigradsko Shose 144",
                    Address = "бул. Цариградско шосе 144",
                    City = "София",
                    Latitude = 42.636709m,
                    Longitude = 23.415775m,
                    ChargingStationStatus = ChargingStationStatus.Active,
                    DataSource = "Kia Hypercharge",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargingStation
                {
                    Name = "Kia Hypercharge Pozitano 2",
                    Address = "ул. Позитано 2",
                    City = "София",
                    Latitude = 42.695595m,
                    Longitude = 23.317809m,
                    ChargingStationStatus = ChargingStationStatus.Active,
                    DataSource = "Kia Hypercharge",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargingStation
                {
                    Name = "Kia Hypercharge Yuzhen",
                    Address = "Южен, 1421 София",
                    City = "София",
                    Latitude = 42.679701m,
                    Longitude = 23.315047m,
                    ChargingStationStatus = ChargingStationStatus.Active,
                    DataSource = "Kia Hypercharge",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargingStation
                {
                    Name = "Kia Hypercharge Industrialna 12",
                    Address = "ул. Индустриална 12",
                    City = "Бургас",
                    Latitude = 42.473693m,
                    Longitude = 27.439807m,
                    ChargingStationStatus = ChargingStationStatus.Active,
                    DataSource = "Kia Hypercharge",
                    ExternalId = null,
                    OperatorId = operatorId
                }

            ];
        }
    }
}