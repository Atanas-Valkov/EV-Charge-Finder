namespace EVChargeFinder.Data.Seeding.ChargeStations
{
    using DbModels;
    using DbModels.Enums;

    public static class eCarsChargeStationSeeder
    {
        public static ChargeStation[] GetChargeStations(int operatorId)
        {
            return
            [
                new ChargeStation
                {
                    Name = "eCars Casino Phoenix",
                    Address = "АМ Струма, Казино Финикс",
                    City = "Кулата",
                    Latitude = 41.381260m,
                    Longitude = 23.356120m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "eCars",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "eCars Park Hotel Pirin Sharlopov",
                    Address = "ул. Хидрострой 27",
                    City = "Сандански",
                    Latitude = 41.581939m,
                    Longitude = 23.289374m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "eCars",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {   
                    Name = "eCars Avtokompleks Kalivas",
                    Address = "Южна индустриална зона",
                    City = "Благоевград",
                    Latitude = 42.005922m,
                    Longitude = 23.079443m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "eCars",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "eCars Oasis Beach Club",
                    Address = "ул. Царевски път",
                    City = "Лозенец",
                    Latitude = 42.199637m,
                    Longitude = 27.816857m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "eCars",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "eCars Hotel Yanakiev",
                    Address = "Клуб Хотел Янакиев",
                    City = "Боровец",
                    Latitude = 42.263038m,
                    Longitude = 23.603970m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "eCars",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "eCars Hotel Morska Vila",
                    Address = "ул. Антеа 5, местност Буджака",
                    City = "Созопол",
                    Latitude = 42.406272m,
                    Longitude = 27.707337m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "eCars",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "eCars Atiya Resort",
                    Address = "ул. Свети Никола 1",
                    City = "Черноморец",
                    Latitude = 42.442780m,
                    Longitude = 27.645856m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "eCars",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "eCars Omnikar Auto",
                    Address = "Софийски околовръстен път 235",
                    City = "София",
                    Latitude = 42.625745m,
                    Longitude = 23.352503m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "eCars",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "eCars Inter Expo Center",
                    Address = "бул. Цариградско шосе 147",
                    City = "София",
                    Latitude = 42.649297m,
                    Longitude = 23.394632m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "eCars",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "eCars Hotel Balkantsi",
                    Address = "местност Узана",
                    City = "Габрово",
                    Latitude = 42.766612m,
                    Longitude = 25.252054m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "eCars",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "eCars Grand Hotel Yantra",
                    Address = "ул. Опълченска 2",
                    City = "Велико Търново",
                    Latitude = 43.083284m,
                    Longitude = 25.640883m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "eCars",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "eCars Sunny Garden SPA Hotel",
                    Address = "бул. България 6",
                    City = "Вършец",
                    Latitude = 43.192349m,
                    Longitude = 23.285689m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "eCars",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "eCars Novi Pazar",
                    Address = "ул. Цар Освободител 39А",
                    City = "Нови пазар",
                    Latitude = 43.339533m,
                    Longitude = 27.188287m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "eCars",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "eCars Shtipsko",
                    Address = "с. Щипско",
                    City = "Щипско",
                    Latitude = 43.372801m,
                    Longitude = 27.517010m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "eCars",
                    ExternalId = null,
                    OperatorId = operatorId
                }
            ];
        }
    }
}