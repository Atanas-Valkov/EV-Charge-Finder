namespace EVChargeFinder.Data.Seeding.ChargeStations
{

    using DbModels;
    using DbModels.Enums;

    public class EVN2GOChargeStationSeeder
    {
        public static ChargeStation[] GetChargeStations(int operatorId)
        {
            return
            [
                new ChargeStation
                {
                    Name = "EVN2GO Hristo G. Danov",
                    Address = "ул. Христо Г. Данов 37",
                    City = "Пловдив",
                    Latitude = 42.148536m,
                    Longitude = 24.743272m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "EVN2GO",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "EVN2GO Great Basilica Plovdiv",
                    Address = "бул. Княгиня Мария Луиза 3",
                    City = "Пловдив",
                    Latitude = 42.144571m,
                    Longitude = 24.752559m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "EVN2GO",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "EVN2GO TEC Sever Plovdiv",
                    Address = "ул. Васил Левски 236",
                    City = "Пловдив",
                    Latitude = 42.183030m,
                    Longitude = 24.741380m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "EVN2GO",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "EVN2GO Grand Mall Varna",
                    Address = "ул. Академик Андрей Сахаров 2",
                    City = "Варна",
                    Latitude = 43.217440m,
                    Longitude = 27.898520m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "EVN2GO",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "EVN2GO Pamporovo Studenets",
                    Address = "Паркинг под ски зона Студенец",
                    City = "Пампорово",
                    Latitude = 41.641772m,
                    Longitude = 24.691337m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "EVN2GO",
                    ExternalId = null,
                    OperatorId = operatorId
                }
            ];
        }
    }
}