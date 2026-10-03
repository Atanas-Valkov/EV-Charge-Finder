namespace EVChargeFinder.Data.Seeding.ChargingStations
{
    using DbModels;
    using DbModels.Enums;


    public static class GigaChargerChargingStationSeeder
    {
        public static ChargingStation[] GetChargingStations(int operatorId)
        {
            return
            [
                new ChargingStation
                {
                    Name = "GigaCharger Vrabnitsa 1, bl. 525",
                    Address = "Vrabnitsa 1, bl. 525",
                    City = "София",
                    Latitude = 42.733941m,
                    Longitude = 23.288174m,
                    ChargingStationStatus = ChargingStationStatus.Active,
                    DataSource = "GigaCharger",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargingStation
                {
                    Name = "GigaCharger Serdika, bl. 15",
                    Address = "Serdika, bl. 15",
                    City = "София",
                    Latitude = 42.694677m,
                    Longitude = 23.297526m,
                    ChargingStationStatus = ChargingStationStatus.Active,
                    DataSource = "GigaCharger",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargingStation
                {
                    Name = "GigaCharger Mladost 4",
                    Address = "Mladost 4",
                    City = "София",
                    Latitude = 42.632959m,
                    Longitude = 23.379802m,
                    ChargingStationStatus = ChargingStationStatus.Active,
                    DataSource = "GigaCharger",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargingStation
                {
                    Name = "GigaCharger Trudolyubie 7",
                    Address = "ул. Трудолюбие 7",
                    City = "София",
                    Latitude = 42.685473m,
                    Longitude = 23.359146m,
                    ChargingStationStatus = ChargingStationStatus.Active,
                    DataSource = "GigaCharger",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargingStation
                {
                    Name = "GigaCharger Geo Milev, bl. 245",
                    Address = "Geo Milev, bl. 245",
                    City = "София",
                    Latitude = 42.677522m,
                    Longitude = 23.364142m,
                    ChargingStationStatus = ChargingStationStatus.Active,
                    DataSource = "GigaCharger",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargingStation
                {
                    Name = "GigaCharger Druzhba 1, bl. 137",
                    Address = "Druzhba 1, bl. 137",
                    City = "София",
                    Latitude = 42.664166m,
                    Longitude = 23.397824m,
                    ChargingStationStatus = ChargingStationStatus.Active,
                    DataSource = "GigaCharger",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargingStation
                {
                    Name = "GigaCharger Mladost 1, bl. 94",
                    Address = "Mladost 1, bl. 94",
                    City = "София",
                    Latitude = 42.660503m,
                    Longitude = 23.364973m,
                    ChargingStationStatus = ChargingStationStatus.Active,
                    DataSource = "GigaCharger",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargingStation
                {
                    Name = "GigaCharger Ilientsi 2",
                    Address = "Илиенци 2",
                    City = "София",
                    Latitude = 42.741568m,
                    Longitude = 23.309972m,
                    ChargingStationStatus = ChargingStationStatus.Active,
                    DataSource = "GigaCharger",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargingStation
                {
                    Name = "GigaCharger Ivats 12",
                    Address = "Ivats 12",
                    City = "Русе",
                    Latitude = 43.856221m,
                    Longitude = 25.958001m,
                    ChargingStationStatus = ChargingStationStatus.Active,
                    DataSource = "GigaCharger",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargingStation
                {
                    Name = "GigaCharger Restaurant Bulgarche",
                    Address = "Ресторант Българче",
                    City = "Русе",
                    Latitude = 43.849948m,
                    Longitude = 25.959865m,
                    ChargingStationStatus = ChargingStationStatus.Active,
                    DataSource = "GigaCharger",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargingStation
                {
                    Name = "GigaCharger Mutkurova 119",
                    Address = "Mutkurova 119",
                    City = "Русе",
                    Latitude = 43.837698m,
                    Longitude = 25.957706m,
                    ChargingStationStatus = ChargingStationStatus.Active,
                    DataSource = "GigaCharger",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargingStation
                {
                    Name = "GigaCharger Proektantska",
                    Address = "Проектантска",
                    City = "Русе",
                    Latitude = 43.852144m,
                    Longitude = 25.951093m,
                    ChargingStationStatus = ChargingStationStatus.Active,
                    DataSource = "GigaCharger",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargingStation
                {
                    Name = "GigaCharger Borisova - Rila",
                    Address = "Borisova str - Rila",
                    City = "Русе",
                    Latitude = 43.842143m,
                    Longitude = 25.955041m,
                    ChargingStationStatus = ChargingStationStatus.Active,
                    DataSource = "GigaCharger",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargingStation
                {
                    Name = "GigaCharger Hotel Riga",
                    Address = "Хотел Рига",
                    City = "Русе",
                    Latitude = 43.852776m,
                    Longitude = 25.951378m,
                    ChargingStationStatus = ChargingStationStatus.Active,
                    DataSource = "GigaCharger",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargingStation
                {
                    Name = "GigaCharger Bl. Madara",
                    Address = "Бл. Мадара",
                    City = "Русе",
                    Latitude = 43.857489m,
                    Longitude = 25.972698m,
                    ChargingStationStatus = ChargingStationStatus.Active,
                    DataSource = "GigaCharger",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargingStation
                {
                    Name = "GigaCharger Complex Dunav",
                    Address = "Complex Dunav",
                    City = "Русе",
                    Latitude = 43.845091m,
                    Longitude = 25.977645m,
                    ChargingStationStatus = ChargingStationStatus.Active,
                    DataSource = "GigaCharger",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargingStation
                {
                    Name = "GigaCharger Hotel Crystal",
                    Address = "Hotel Crystal",
                    City = "Русе",
                    Latitude = 43.842947m,
                    Longitude = 25.948549m,
                    ChargingStationStatus = ChargingStationStatus.Active,
                    DataSource = "GigaCharger",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargingStation
                {
                    Name = "GigaCharger Gergana bl.",
                    Address = "Gergana bl.",
                    City = "Русе",
                    Latitude = 43.847663m,
                    Longitude = 25.989400m,
                    ChargingStationStatus = ChargingStationStatus.Active,
                    DataSource = "GigaCharger",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargingStation
                {
                    Name = "GigaCharger Petrohan bl.",
                    Address = "Petrohan bl.",
                    City = "Русе",
                    Latitude = 43.840821m,
                    Longitude = 25.970403m,
                    ChargingStationStatus = ChargingStationStatus.Active,
                    DataSource = "GigaCharger",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargingStation
                {
                    Name = "GigaCharger Basein Dunav",
                    Address = "Басейн Дунав",
                    City = "Русе",
                    Latitude = 43.844690m,
                    Longitude = 25.978472m,
                    ChargingStationStatus = ChargingStationStatus.Active,
                    DataSource = "GigaCharger",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargingStation
                {
                    Name = "GigaCharger Dragoman 6",
                    Address = "6 Dragoman str",
                    City = "Русе",
                    Latitude = 43.842330m,
                    Longitude = 25.945683m,
                    ChargingStationStatus = ChargingStationStatus.Active,
                    DataSource = "GigaCharger",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargingStation
                {
                    Name = "GigaCharger Restaurant Terasa",
                    Address = "Ресторант Тераса",
                    City = "Русе",
                    Latitude = 43.850582m,
                    Longitude = 25.949029m,
                    ChargingStationStatus = ChargingStationStatus.Active,
                    DataSource = "GigaCharger",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargingStation
                {
                    Name = "GigaCharger Alei Vazrazhdane 32",
                    Address = "Alei Vazrazhdane, 32",
                    City = "Русе",
                    Latitude = 43.857929m,
                    Longitude = 25.968008m,
                    ChargingStationStatus = ChargingStationStatus.Active,
                    DataSource = "GigaCharger",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargingStation
                {
                    Name = "GigaCharger Graf Ignatiev 8",
                    Address = "Graf Ignatiev 8",
                    City = "Варна",
                    Latitude = 43.199019m,
                    Longitude = 27.917684m,
                    ChargingStationStatus = ChargingStationStatus.Active,
                    DataSource = "GigaCharger",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargingStation
                {
                    Name = "GigaCharger Vazrazhdane 27",
                    Address = "Vazrazhdane 27",
                    City = "Варна",
                    Latitude = 43.234935m,
                    Longitude = 27.884438m,
                    ChargingStationStatus = ChargingStationStatus.Active,
                    DataSource = "GigaCharger",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargingStation
                {
                    Name = "GigaCharger Chaika, bl. 68",
                    Address = "Chaika, bl. 68",
                    City = "Варна",
                    Latitude = 43.215582m,
                    Longitude = 27.944891m,
                    ChargingStationStatus = ChargingStationStatus.Active,
                    DataSource = "GigaCharger",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargingStation
                {
                    Name = "GigaCharger Carwash Rikar",
                    Address = "Автомивка Рикар",
                    City = "Варна",
                    Latitude = 43.226629m,
                    Longitude = 27.926326m,
                    ChargingStationStatus = ChargingStationStatus.Active,
                    DataSource = "GigaCharger",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargingStation
                {
                    Name = "GigaCharger Vazrazhdane 4",
                    Address = "Vazrazhdane 4",
                    City = "Варна",
                    Latitude = 43.240258m,
                    Longitude = 27.878733m,
                    ChargingStationStatus = ChargingStationStatus.Active,
                    DataSource = "GigaCharger",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargingStation
                {
                    Name = "GigaCharger Simfoniya",
                    Address = "Simfoniya",
                    City = "Варна",
                    Latitude = 43.216570m,
                    Longitude = 27.951833m,
                    ChargingStationStatus = ChargingStationStatus.Active,
                    DataSource = "GigaCharger",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargingStation
                {
                    Name = "GigaCharger Eskana",
                    Address = "Еskana",
                    City = "Варна",
                    Latitude = 43.220963m,
                    Longitude = 27.923540m,
                    ChargingStationStatus = ChargingStationStatus.Active,
                    DataSource = "GigaCharger",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargingStation
                {
                    Name = "GigaCharger Graf Ignatiev 17",
                    Address = "ул. Граф Игнатиев 17",
                    City = "Варна",
                    Latitude = 43.199490m,
                    Longitude = 27.918214m,
                    ChargingStationStatus = ChargingStationStatus.Active,
                    DataSource = "GigaCharger",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargingStation
                {
                    Name = "GigaCharger Bumer-85",
                    Address = "Bumer-85",
                    City = "Варна",
                    Latitude = 43.229711m,
                    Longitude = 27.888128m,
                    ChargingStationStatus = ChargingStationStatus.Active,
                    DataSource = "GigaCharger",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargingStation
                {
                    Name = "GigaCharger Obzor 4",
                    Address = "Obzor 4 str",
                    City = "Варна",
                    Latitude = 43.251130m,
                    Longitude = 27.981567m,
                    ChargingStationStatus = ChargingStationStatus.Active,
                    DataSource = "GigaCharger",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargingStation
                {
                    Name = "GigaCharger FKC",
                    Address = "FKC",
                    City = "Варна",
                    Latitude = 43.204522m,
                    Longitude = 27.922647m,
                    ChargingStationStatus = ChargingStationStatus.Active,
                    DataSource = "GigaCharger",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargingStation
                {
                    Name = "GigaCharger Graf Ignatiev 33",
                    Address = "Graf Ignatiev 33",
                    City = "Варна",
                    Latitude = 43.200528m,
                    Longitude = 27.920667m,
                    ChargingStationStatus = ChargingStationStatus.Active,
                    DataSource = "GigaCharger",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargingStation
                {
                    Name = "GigaCharger Baruten Pogreb",
                    Address = "Baruten pogreb str",
                    City = "Варна",
                    Latitude = 43.204028m,
                    Longitude = 27.899278m,
                    ChargingStationStatus = ChargingStationStatus.Active,
                    DataSource = "GigaCharger",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargingStation
                {
                    Name = "GigaCharger Doyran 2 Garage",
                    Address = "Doyran 2 Garage",
                    City = "Варна",
                    Latitude = 43.216000m,
                    Longitude = 27.916083m,
                    ChargingStationStatus = ChargingStationStatus.Active,
                    DataSource = "GigaCharger",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargingStation
                {
                    Name = "GigaCharger Mladost, bl. 121",
                    Address = "121 blok, Mladost",
                    City = "Варна",
                    Latitude = 43.233556m,
                    Longitude = 27.882139m,
                    ChargingStationStatus = ChargingStationStatus.Active,
                    DataSource = "GigaCharger",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargingStation
                {
                    Name = "GigaCharger Troshevo, bl. 18",
                    Address = "Troshevo, bl. 18",
                    City = "Варна",
                    Latitude = 43.226944m,
                    Longitude = 27.883361m,
                    ChargingStationStatus = ChargingStationStatus.Active,
                    DataSource = "GigaCharger",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargingStation
                {
                    Name = "GigaCharger Perperikon 4",
                    Address = "Perperikon 4",
                    City = "Варна",
                    Latitude = 43.238556m,
                    Longitude = 27.870556m,
                    ChargingStationStatus = ChargingStationStatus.Active,
                    DataSource = "GigaCharger",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargingStation
                {
                    Name = "GigaCharger Pchelina",
                    Address = "Pchelina",
                    City = "Варна",
                    Latitude = 43.235778m,
                    Longitude = 27.899639m,
                    ChargingStationStatus = ChargingStationStatus.Active,
                    DataSource = "GigaCharger",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargingStation
                {
                    Name = "GigaCharger Shagy Carpets",
                    Address = "Shagy Carpets",
                    City = "Враца",
                    Latitude = 43.225909m,
                    Longitude = 23.548892m,
                    ChargingStationStatus = ChargingStationStatus.Active,
                    DataSource = "GigaCharger",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargingStation
                {
                    Name = "GigaCharger Naiden Gerov 10",
                    Address = "10 Naiden Gerov str",
                    City = "Враца",
                    Latitude = 43.205742m,
                    Longitude = 23.557270m,
                    ChargingStationStatus = ChargingStationStatus.Active,
                    DataSource = "GigaCharger",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargingStation
                {
                    Name = "GigaCharger Velikova",
                    Address = "Velikova",
                    City = "Плевен",
                    Latitude = 43.402584m,
                    Longitude = 24.607609m,
                    ChargingStationStatus = ChargingStationStatus.Active,
                    DataSource = "GigaCharger",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargingStation
                {
                    Name = "GigaCharger Kaylaka Park Hotel",
                    Address = "Kaylaka Park Hotel",
                    City = "Плевен",
                    Latitude = 43.376549m,
                    Longitude = 24.620762m,
                    ChargingStationStatus = ChargingStationStatus.Active,
                    DataSource = "GigaCharger",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargingStation
                {
                    Name = "GigaCharger Bratya Miladinovi, bl. 18",
                    Address = "Bratya Miladinovi, bl. 18",
                    City = "Бургас",
                    Latitude = 42.502949m,
                    Longitude = 27.465524m,
                    ChargingStationStatus = ChargingStationStatus.Active,
                    DataSource = "GigaCharger",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargingStation
                {
                    Name = "GigaCharger Office Networx",
                    Address = "Офис Networx",
                    City = "Ловеч",
                    Latitude = 43.144618m,
                    Longitude = 24.717116m,
                    ChargingStationStatus = ChargingStationStatus.Active,
                    DataSource = "GigaCharger",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargingStation
                {
                    Name = "GigaCharger Drastar Oil",
                    Address = "Drastar Oil",
                    City = "Силистра",
                    Latitude = 44.121909m,
                    Longitude = 27.274141m,
                    ChargingStationStatus = ChargingStationStatus.Active,
                    DataSource = "GigaCharger",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargingStation
                {
                    Name = "GigaCharger Lex 351",
                    Address = "Лекс 351",
                    City = "Пловдив",
                    Latitude = 42.154862m,
                    Longitude = 24.735920m,
                    ChargingStationStatus = ChargingStationStatus.Active,
                    DataSource = "GigaCharger",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargingStation
                {
                    Name = "GigaCharger Troyan Plaza Hotel",
                    Address = "Troyan Plaza Hotel",
                    City = "Троян",
                    Latitude = 42.886127m,
                    Longitude = 24.713301m,
                    ChargingStationStatus = ChargingStationStatus.Active,
                    DataSource = "GigaCharger",
                    ExternalId = null,
                    OperatorId = operatorId
                }
            ];
        }
    }
}