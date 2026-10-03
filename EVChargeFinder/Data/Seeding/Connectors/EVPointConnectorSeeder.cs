namespace EVChargeFinder.Data.Seeding.Connectors
{
    using DbModels;
    using DbModels.Enums;

    public static class EVPointConnectorSeeder
    {
        public static Connector[] GetConnectors(
            Dictionary<string, int> ChargingStationIds)
        {
            List<Connector> connectors = new List<Connector>();

            AddConnectors(
                connectors,
                ChargingStationIds["EVPoint Добрич Ангел Стоянов 4"],
                (ConnectorType.Type2, 1, 22.00m, 0.40m));

            AddConnectors(
                connectors,
                ChargingStationIds["EVPoint Добрич 25-ти Септември 51"],
                (ConnectorType.Type2, 1, 12.00m, 0.40m));

            AddConnectors(
                connectors,
                ChargingStationIds["EVPoint Добрич Калиакра 65"],
                (ConnectorType.Type2, 1, 12.00m, 0.40m));

            AddConnectors(
                connectors,
                ChargingStationIds["EVPoint Добрич Околовръстен път"],
                (ConnectorType.Type2, 1, 22.00m, 0.40m));

            AddConnectors(
                connectors,
                ChargingStationIds["EVPoint Добрич Ген. Колев 45"],
                (ConnectorType.Type2, 1, 40.00m, 0.40m));

            AddConnectors(
                connectors,
                ChargingStationIds["EVPoint Добрич 25-ти Септември 4"],
                (ConnectorType.Type2, 1, 22.00m, 0.40m));

            AddConnectors(
                connectors,
                ChargingStationIds["EVPoint Стара Загора Загорка 35А"],
                (ConnectorType.Type2, 1, 22.00m, 0.40m));

            AddConnectors(
                connectors,
                ChargingStationIds["EVPoint Стара Загора Никола Петков"],
                (ConnectorType.Type2, 1, 7.00m, 0.40m));

            AddConnectors(
                connectors,
                ChargingStationIds["EVPoint Стара Загора Цар Симеон Велики"],
                (ConnectorType.Type2, 1, 22.00m, 0.40m));

            AddConnectors(
                connectors,
                ChargingStationIds["EVPoint Стара Загора Алеко Константинов 3"],
                (ConnectorType.Type2, 1, 22.00m, 0.40m));

            AddConnectors(
                connectors,
                ChargingStationIds["EVPoint Стара Загора Димитър Филов 1"],
                (ConnectorType.Type2, 1, 22.00m, 0.40m));

            AddConnectors(
                connectors,
                ChargingStationIds["EVPoint Стара Загора Цар Симеон Велики 65А"],
                (ConnectorType.Type2, 1, 12.00m, 0.40m));

            AddConnectors(
                connectors,
                ChargingStationIds["EVPoint Стара Загора Патриарх Евтимий 79"],
                (ConnectorType.Type2, 1, 22.00m, 0.40m));

            AddConnectors(
                connectors,
                ChargingStationIds["EVPoint Разлог Реденка 34"],
                (ConnectorType.Type2, 1, 7.00m, 0.40m));

            AddConnectors(
                connectors,
                ChargingStationIds["EVPoint Разлог Бетоловото 130"],
                (ConnectorType.Type2, 1, 22.00m, 0.40m));

            AddConnectors(
                connectors,
                ChargingStationIds["EVPoint Разлог Байова Борика 1Л"],
                (ConnectorType.Type2, 1, 22.00m, 0.40m));

            AddConnectors(
                connectors,
                ChargingStationIds["EVPoint Разлог Изворите 2"],
                (ConnectorType.Type2, 1, 22.00m, 0.40m));

            AddConnectors(
                connectors,
                ChargingStationIds["EVPoint Разлог Джинджерица 6"],
                (ConnectorType.Type2, 1, 22.00m, 0.40m));

            AddConnectors(
                connectors,
                ChargingStationIds["EVPoint Разлог 19"],
                (ConnectorType.Type2, 1, 22.00m, 0.40m));

            AddConnectors(
                connectors,
                ChargingStationIds["EVPoint Благоевград Свобода Бъчварова 12"],
                (ConnectorType.Type2, 1, 12.00m, 0.40m));

            AddConnectors(
                connectors,
                ChargingStationIds["EVPoint Благоевград 1"],
                (ConnectorType.Type2, 1, 22.00m, 0.40m));

            AddConnectors(
                connectors,
                ChargingStationIds["EVPoint Пазарджик Стефан Стамболов 13"],
                (ConnectorType.Type2, 1, 12.00m, 0.40m));

            AddConnectors(
                connectors,
                ChargingStationIds["EVPoint Пазарджик Пловдивска 107"],
                (ConnectorType.Type2, 1, 22.00m, 0.40m));

            // TODO: "EVPoint Пазарджик Пловдивска 78"
            // Public listings identify an EVPoint DC point here, but connector type/power was not verified.

            AddConnectors(
                connectors,
                ChargingStationIds["EVPoint Пазарджик Стефан Стамболов 18"],
                (ConnectorType.Type2, 1, 22.00m, 0.40m));

            // TODO: "EVPoint Пазарджик Пловдивска 8"
            // Public listings identify an EVPoint DC point here, but connector type/power was not verified.

            // An additional EVPoint DC point is listed at the same address; type/power not seeded until verified.
            AddConnectors(
                connectors,
                ChargingStationIds["EVPoint Чирпан Пейо Яворов 29"],
                (ConnectorType.Type2, 1, 22.00m, 0.40m));

            AddConnectors(
                connectors,
                ChargingStationIds["EVPoint Чирпан Георги Димитров 111"],
                (ConnectorType.Type2, 1, 12.00m, 0.40m));

            AddConnectors(
                connectors,
                ChargingStationIds["EVPoint Провадия 208"],
                (ConnectorType.Type2, 1, 40.00m, 0.40m));

            AddConnectors(
                connectors,
                ChargingStationIds["EVPoint Провадия Дунав"],
                (ConnectorType.Type2, 1, 22.00m, 0.40m));

            // An additional EVPoint DC point is listed at the same address; type/power not seeded until verified.
            AddConnectors(
                connectors,
                ChargingStationIds["EVPoint Леденик 4"],
                (ConnectorType.Type2, 2, 22.00m, 0.40m));

            // TODO: "EVPoint Лозен 4"
            // Public listings report EVPoint DC up to 50 kW here, but connector type/count was not verified.

            AddConnectors(
                connectors,
                ChargingStationIds["EVPoint Лозен Цариградско шосе 387"],
                (ConnectorType.Type2, 1, 7.00m, 0.40m));

            AddConnectors(
                connectors,
                ChargingStationIds["EVPoint Банско Явор 83"],
                (ConnectorType.Type2, 1, 22.00m, 0.40m));

            AddConnectors(
                connectors,
                ChargingStationIds["EVPoint Нова Загора Генерал Скобелев 29"],
                (ConnectorType.Type2, 1, 22.00m, 0.40m));

            AddConnectors(
                connectors,
                ChargingStationIds["EVPoint Плевен Българска Авиация 20"],
                (ConnectorType.Type2, 1, 22.00m, 0.40m));

            // An additional EVPoint DC point is listed at the same address; type/power not seeded until verified.
            AddConnectors(
                connectors,
                ChargingStationIds["EVPoint Плевен Александър Малинов"],
                (ConnectorType.Type2, 1, 22.00m, 0.40m));

            // An additional EVPoint DC point is listed at the same address; type/power not seeded until verified.
            AddConnectors(
                connectors,
                ChargingStationIds["EVPoint Враждебна Ботевградско шосе 455"],
                (ConnectorType.Type2, 1, 22.00m, 0.40m));

            AddConnectors(
                connectors,
                ChargingStationIds["EVPoint Горна Оряховица Княз Борис I 88"],
                (ConnectorType.Type2, 1, 22.00m, 0.40m));

            AddConnectors(
                connectors,
                ChargingStationIds["EVPoint Lidl София Андрей Ляпчев 52"],
                (ConnectorType.CHAdeMO, 1, 50.00m, 0.40m),
                (ConnectorType.CCS2, 1, 50.00m, 0.40m),
                (ConnectorType.Type2, 1, 43.00m, 0.40m));

            AddConnectors(
                connectors,
                ChargingStationIds["EVPoint Lidl София Васил Левски 152"],
                (ConnectorType.CHAdeMO, 1, 50.00m, 0.40m),
                (ConnectorType.CCS2, 1, 50.00m, 0.40m),
                (ConnectorType.Type2, 1, 43.00m, 0.40m));

            AddConnectors(
                connectors,
                ChargingStationIds["EVPoint Lidl Благоевград"],
                (ConnectorType.CHAdeMO, 1, 50.00m, 0.40m),
                (ConnectorType.CCS2, 1, 50.00m, 0.40m),
                (ConnectorType.Type2, 1, 43.00m, 0.40m));

            AddConnectors(
                connectors,
                ChargingStationIds["EVPoint Lidl Каварна"],
                (ConnectorType.CHAdeMO, 1, 50.00m, 0.40m),
                (ConnectorType.CCS2, 1, 50.00m, 0.40m),
                (ConnectorType.Type2, 1, 43.00m, 0.40m));

            AddConnectors(
                connectors,
                ChargingStationIds["EVPoint Lidl Карнобат"],
                (ConnectorType.CHAdeMO, 1, 50.00m, 0.40m),
                (ConnectorType.CCS2, 1, 50.00m, 0.40m),
                (ConnectorType.Type2, 1, 43.00m, 0.40m));

            AddConnectors(
                connectors,
                ChargingStationIds["EVPoint Lidl Кюстендил"],
                (ConnectorType.CHAdeMO, 1, 50.00m, 0.40m),
                (ConnectorType.CCS2, 1, 50.00m, 0.40m),
                (ConnectorType.Type2, 1, 43.00m, 0.40m));

            AddConnectors(
                connectors,
                ChargingStationIds["EVPoint Lidl Луковит"],
                (ConnectorType.CHAdeMO, 1, 50.00m, 0.40m),
                (ConnectorType.CCS2, 1, 50.00m, 0.40m),
                (ConnectorType.Type2, 1, 43.00m, 0.40m));

            AddConnectors(
                connectors,
                ChargingStationIds["EVPoint Lidl Несебър"],
                (ConnectorType.CCS2, 2, 60.00m, 0.40m),
                (ConnectorType.Type2, 1, 22.00m, 0.40m));

            // TODO: "EVPoint Lidl Пловдив"
            // Lidl confirms a charging station at this address, but its current hardware model is not published.

            AddConnectors(
                connectors,
                ChargingStationIds["EVPoint Lidl Русе"],
                (ConnectorType.CHAdeMO, 1, 50.00m, 0.40m),
                (ConnectorType.CCS2, 1, 50.00m, 0.40m),
                (ConnectorType.Type2, 1, 43.00m, 0.40m));

            AddConnectors(
                connectors,
                ChargingStationIds["EVPoint Lidl Самоков"],
                (ConnectorType.CHAdeMO, 1, 50.00m, 0.40m),
                (ConnectorType.CCS2, 1, 50.00m, 0.40m),
                (ConnectorType.Type2, 1, 43.00m, 0.40m));

            return connectors.ToArray();
        }


        private static void AddConnectors(
            List<Connector> connectors,
            int ChargingStationId,
            params (
                ConnectorType Type,
                int Count,
                decimal PowerKw,
                decimal PricePerKWh)[] connectorGroups)
        {
            int connectorNumber = 1;

            foreach ((
                ConnectorType Type,
                int Count,
                decimal PowerKw,
                decimal PricePerKWh) connectorGroup in connectorGroups)
            {
                for (int i = 0; i < connectorGroup.Count; i++)
                {
                    Connector connector = new Connector
                    {
                        ConnectorNumber = connectorNumber,
                        ConnectorType = connectorGroup.Type,
                        PowerKw = connectorGroup.PowerKw,
                        PricePerKWh = connectorGroup.PricePerKWh,
                        ConnectorStatus = ConnectorStatus.Unknown,
                        ExternalId = null,
                        ChargingStationId = ChargingStationId
                    };

                    connectors.Add(connector);
                    connectorNumber++;
                }
            }
        }
    }
}
