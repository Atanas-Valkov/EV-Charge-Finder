namespace EVChargeFinder.Data.Seeding.ChargeStations
{
    using DbModels;
    using DbModels.Enums;


    public static class GPStationChargeStationSeeder
    {
        public static ChargeStation[] GetChargeStations(int operatorId)
        {
            return
            [
                new ChargeStation
                {
                    Name = "GPStation Central Station",
                    Address = "бул. Княгиня Мария Луиза 102",
                    City = "София",
                    Latitude = 42.712115m,
                    Longitude = 23.321046m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "GPStation",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "GPStation Niagara Druzhba 2",
                    Address = "ул. Обиколна 32",
                    City = "София",
                    Latitude = 42.641959m,
                    Longitude = 23.408612m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "GPStation",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "GPStation St. Sofia Golf Club",
                    Address = "St. Sofia Golf Club & SPA",
                    City = "Равно поле",
                    Latitude = 42.671130m,
                    Longitude = 23.537610m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "GPStation",
                    ExternalId = null,
                    OperatorId = operatorId
                }
            ];
        }
    }
}