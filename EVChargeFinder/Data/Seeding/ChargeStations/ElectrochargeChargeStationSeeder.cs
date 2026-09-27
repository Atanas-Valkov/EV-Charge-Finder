namespace EVChargeFinder.Data.Seeding.ChargeStations
{
    using DbModels;
    using DbModels.Enums;
    public class ElectrochargeChargeStationSeeder
    {
        public static ChargeStation[] GetChargeStations(int operatorId)
        {
            return
            [
                new ChargeStation
                {
                    Name = "Electrocharge Plovdiv 320B",
                    Address = "ул. Пловдив 320Б",
                    City = "София",
                    Latitude = 42.706761m,
                    Longitude = 23.294733m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Electrocharge",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "Electrocharge Lozen Saedinenie 127",
                    Address = "ул. Съединение 127",
                    City = "Лозен",
                    Latitude = 42.601720m,
                    Longitude = 23.486959m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Electrocharge",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "Electrocharge 109th Street 266",
                    Address = "ул. 109-та 266",
                    City = "София",
                    Latitude = 42.743734m,
                    Longitude = 23.280023m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Electrocharge",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "Electrocharge Mladost 526",
                    Address = "ж.к. Младост, бл. 526",
                    City = "София",
                    Latitude = 42.648281m,
                    Longitude = 23.384616m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Electrocharge",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "Electrocharge Pchela 212",
                    Address = "ул. Пчела 212",
                    City = "София",
                    Latitude = 42.671694m,
                    Longitude = 23.278306m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Electrocharge",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "Electrocharge Braila 11",
                    Address = "ул. Браила 11",
                    City = "София",
                    Latitude = 42.674067m,
                    Longitude = 23.287621m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Electrocharge",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "Electrocharge Orion 84",
                    Address = "ул. Орион 84",
                    City = "София",
                    Latitude = 42.709306m,
                    Longitude = 23.266111m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Electrocharge",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "Electrocharge Simitli",
                    Address = "Симитли",
                    City = "Симитли",
                    Latitude = 41.888926m,
                    Longitude = 23.117849m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Electrocharge",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "Electrocharge Petrol Kulata",
                    Address = "бензиностанция Petrol, АМ Струма",
                    City = "Кулата",
                    Latitude = 41.384119m,
                    Longitude = 23.361654m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Electrocharge",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "Electrocharge Lukovit",
                    Address = "Луковит",
                    City = "Луковит",
                    Latitude = 43.205833m,
                    Longitude = 24.161667m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Electrocharge",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "Electrocharge Lom",
                    Address = "Лом",
                    City = "Лом",
                    Latitude = 43.830500m,
                    Longitude = 23.237222m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Electrocharge",
                    ExternalId = null,
                    OperatorId = operatorId
                }
            ];
        }
    }
}