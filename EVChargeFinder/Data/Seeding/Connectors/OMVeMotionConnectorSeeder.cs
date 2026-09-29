namespace EVChargeFinder.Data.Seeding.Connectors
{
    using DbModels;
    using DbModels.Enums;

    public static class OMVeMotionConnectorSeeder
    {
        public static Connector[] GetConnectors(
            Dictionary<string, int> chargeStationIds)
        {
            List<Connector> connectors = new List<Connector>();

            AddConnectors(
                connectors,
                chargeStationIds["OMV Хемус"],
                ConnectorType.CCS2,
                4,
                300.00m,
                0.39m);

            AddConnectors(
                connectors,
                chargeStationIds["OMV Хемус Осиковица"],
                ConnectorType.CCS2,
                4,
                300.00m,
                0.39m);

            AddConnectors(
                connectors,
                chargeStationIds["OMV Хемус Шумен Юг"],
                ConnectorType.CCS2,
                4,
                300.00m,
                0.39m);

            AddConnectors(
                connectors,
                chargeStationIds["OMV София Бояна"],
                ConnectorType.CCS2,
                2,
                300.00m,
                0.39m);

            AddConnectors(
                connectors,
                chargeStationIds["OMV София бул. България"],
                ConnectorType.CCS2,
                2,
                300.00m,
                0.39m);

            AddConnectors(
                connectors,
                chargeStationIds["OMV Стара Загора Дезинтегратор"],
                ConnectorType.CCS2,
                2,
                180.00m,
                0.39m);

            AddConnectors(
                connectors,
                chargeStationIds["OMV Тракия Дражево"],
                ConnectorType.CCS2,
                2,
                180.00m,
                0.39m);

            AddConnectors(
                connectors,
                chargeStationIds["OMV Тракия Виноградец"],
                ConnectorType.CCS2,
                2,
                120.00m,
                0.39m);

            AddConnectors(
                connectors,
                chargeStationIds["OMV Тракия Хаджидимитрово"],
                ConnectorType.CCS2,
                2,
                120.00m,
                0.39m);

            AddConnectors(
                connectors,
                chargeStationIds["OMV Тракия Динката"],
                ConnectorType.CCS2,
                2,
                60.00m,
                0.35m);

            AddConnectors(
                connectors,
                chargeStationIds["OMV София Ботевградско"],
                ConnectorType.CCS2,
                2,
                120.00m,
                0.39m);

            AddConnectors(
                connectors,
                chargeStationIds["OMV Струма Чучулигово ляво"],
                ConnectorType.CCS2,
                1,
                50.00m,
                0.35m);

            AddConnectors(
                connectors,
                chargeStationIds["OMV София Корабче"],
                ConnectorType.CCS2,
                1,
                50.00m,
                0.35m);


            // TODO: "OMV Тракия Белозем"
            // OMV currently states that the charging station at this site is being upgraded.
            // Connector count, power and price are therefore intentionally not seeded yet.

            return connectors.ToArray();
        }


        private static void AddConnectors(
            List<Connector> connectors,
            int chargeStationId,
            ConnectorType connectorType,
            int count,
            decimal powerKw,
            decimal pricePerKWh)
        {
            for (int connectorNumber = 1; connectorNumber <= count; connectorNumber++)
            {
                Connector connector = new Connector
                {
                    ConnectorNumber = connectorNumber,
                    ConnectorType = connectorType,
                    PowerKw = powerKw,
                    PricePerKWh = pricePerKWh,
                    ConnectorStatus = ConnectorStatus.Unknown,
                    ExternalId = null,
                    ChargeStationId = chargeStationId
                };

                connectors.Add(connector);
            }
        }
    }
}
