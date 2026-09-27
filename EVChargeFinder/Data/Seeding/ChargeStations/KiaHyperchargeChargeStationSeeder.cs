namespace EVChargeFinder.Data.Seeding.ChargeStations
{
    using DbModels;
    using DbModels.Enums;
    public static class KiaHyperchargeChargeStationSeeder
    {
        public static ChargeStation[] GetChargeStations(int operatorId)
        {
            return
            [
                new ChargeStation
                {
                    Name = "Kia Hypercharge Tsarigradsko Shose 144",
                    Address = "бул. Цариградско шосе 144",
                    City = "София",
                    Latitude = 42.636709m,
                    Longitude = 23.415775m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Kia Hypercharge",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "Kia Hypercharge Pozitano 2",
                    Address = "ул. Позитано 2",
                    City = "София",
                    Latitude = 42.695595m,
                    Longitude = 23.317809m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Kia Hypercharge",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "Kia Hypercharge Yuzhen",
                    Address = "Южен, 1421 София",
                    City = "София",
                    Latitude = 42.679701m,
                    Longitude = 23.315047m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Kia Hypercharge",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "Kia Hypercharge Industrialna 12",
                    Address = "ул. Индустриална 12",
                    City = "Бургас",
                    Latitude = 42.473693m,
                    Longitude = 27.439807m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Kia Hypercharge",
                    ExternalId = null,
                    OperatorId = operatorId
                }

            ];
        }
    }
}