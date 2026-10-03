namespace EVChargeFinder.Data.Seeding.ChargingStations
{
    using DbModels;
    using DbModels.Enums;

    public static class WINKChargingChargingStationSeeder
    {
        public static ChargingStation[] GetChargingStations(int operatorId)
        {
            return
            [
                new ChargingStation
                {
                    Name = "WINK Fantastico Pernik",
                    Address = "2304 Перник",
                    City = "Перник",
                    Latitude = 42.604245m,
                    Longitude = 23.114118m,
                    ChargingStationStatus = ChargingStationStatus.Active,
                    DataSource = "WINK Charging",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargingStation
                {
                    Name = "WINK Zheleznicharska Vidin",
                    Address = "ул. Железничарска 16",
                    City = "Видин",
                    Latitude = 43.984832m,
                    Longitude = 22.874349m,
                    ChargingStationStatus = ChargingStationStatus.Active,
                    DataSource = "WINK Charging",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargingStation
                {
                    Name = "WINK Tsarevo",
                    Address = "ул. Крайбрежна 39",
                    City = "Царево",
                    Latitude = 42.161684m,
                    Longitude = 27.864452m,
                    ChargingStationStatus = ChargingStationStatus.Active,
                    DataSource = "WINK Charging",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargingStation
                {
                    Name = "WINK Yambol",
                    Address = "ул. Търговска 35",
                    City = "Ямбол",
                    Latitude = 42.482090m,
                    Longitude = 26.512969m,
                    ChargingStationStatus = ChargingStationStatus.Active,
                    DataSource = "WINK Charging",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargingStation
                {
                    Name = "WINK Krumovgrad",
                    Address = "ул. Ахрида 4",
                    City = "Крумовград",
                    Latitude = 41.471460m,
                    Longitude = 25.652042m,
                    ChargingStationStatus = ChargingStationStatus.Active,
                    DataSource = "WINK Charging",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargingStation
                {
                    Name = "WINK Fantastico Manastirski Livadi",
                    Address = "ул. Пирин 51А",
                    City = "София",
                    Latitude = 42.665583m,
                    Longitude = 23.280000m,
                    ChargingStationStatus = ChargingStationStatus.Active,
                    DataSource = "WINK Charging",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargingStation
                {
                    Name = "WINK Karlovo",
                    Address = "ул. Генерал Гурко Мархолев 3",
                    City = "Карлово",
                    Latitude = 42.645377m,
                    Longitude = 24.798496m,
                    ChargingStationStatus = ChargingStationStatus.Active,
                    DataSource = "WINK Charging",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargingStation
                {
                    Name = "WINK Karlovo 1",
                    Address = "Карлово",
                    City = "Карлово",
                    Latitude = 42.643513m,
                    Longitude = 24.805203m,
                    ChargingStationStatus = ChargingStationStatus.Active,
                    DataSource = "WINK Charging",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargingStation
                {
                    Name = "WINK Momchilgrad",
                    Address = "ул. Маказа 11А",
                    City = "Момчилград",
                    Latitude = 41.525056m,
                    Longitude = 25.411667m,
                    ChargingStationStatus = ChargingStationStatus.Active,
                    DataSource = "WINK Charging",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargingStation
                {
                    Name = "WINK Bansko 1",
                    Address = "Банско",
                    City = "Банско",
                    Latitude = 41.829938m,
                    Longitude = 23.480938m,
                    ChargingStationStatus = ChargingStationStatus.Active,
                    DataSource = "WINK Charging",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargingStation
                {
                    Name = "WINK Bansko 3",
                    Address = "Банско",
                    City = "Банско",
                    Latitude = 41.826142m,
                    Longitude = 23.478075m,
                    ChargingStationStatus = ChargingStationStatus.Active,
                    DataSource = "WINK Charging",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargingStation
                {
                    Name = "WINK Pomorie 1",
                    Address = "Поморие",
                    City = "Поморие",
                    Latitude = 42.554313m,
                    Longitude = 27.649313m,
                    ChargingStationStatus = ChargingStationStatus.Active,
                    DataSource = "WINK Charging",
                    ExternalId = null,
                    OperatorId = operatorId
                }
            ];
        }
    }
}