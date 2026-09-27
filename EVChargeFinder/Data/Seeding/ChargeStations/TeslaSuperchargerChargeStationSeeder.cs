namespace EVChargeFinder.Data.Seeding.ChargeStations
{
    using DbModels;
    using DbModels.Enums;

    public class TeslaSuperchargerChargeStationSeeder
    {
        public static ChargeStation[] GetChargeStations(int operatorId)
        {
            return
            [
                new ChargeStation
                {
                    Name = "Tesla Supercharger Bulgaria Mall",
                    Address = "бул. България 69",
                    City = "София",
                    Latitude = 42.663811m,
                    Longitude = 23.289310m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Tesla Supercharger",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "Tesla Supercharger Paradise Center",
                    Address = "бул. Черни връх 100",
                    City = "София",
                    Latitude = 42.657734m,
                    Longitude = 23.313515m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Tesla Supercharger",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "Tesla Supercharger Plovdiv",
                    Address = "ул. Лев Толстой 6",
                    City = "Пловдив",
                    Latitude = 42.144727m,
                    Longitude = 24.768828m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Tesla Supercharger",
                    ExternalId = null,
                    OperatorId = operatorId
                }
            ];
        }
    }
}