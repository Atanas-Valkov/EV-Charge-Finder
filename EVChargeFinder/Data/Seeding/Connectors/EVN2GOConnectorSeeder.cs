namespace EVChargeFinder.Data.Seeding.Connectors
{
    using DbModels;
    using DbModels.Enums;

    public static class EVN2GOConnectorSeeder
    {
        private const decimal HistoricalPricePerKWh = 0.51m;

        public static Connector[] GetConnectors(
            Dictionary<string, int> ChargingStationIds)
        {
            List<Connector> connectors = new List<Connector>();

            AddConnectors(
                connectors,
                ChargingStationIds["EVN2GO Hristo G. Danov"],
                ConnectorType.Type2,
                1,
                22.00m,
                HistoricalPricePerKWh);


            AddConnectors(
                connectors,
                ChargingStationIds["EVN2GO Great Basilica Plovdiv"],
                ConnectorType.Type2,
                1,
                22.00m,
                HistoricalPricePerKWh);


            AddConnectors(
                connectors,
                ChargingStationIds["EVN2GO TEC Sever Plovdiv"],
                ConnectorType.Type2,
                1,
                22.00m,
                HistoricalPricePerKWh);


            AddConnectors(
                connectors,
                ChargingStationIds["EVN2GO Grand Mall Varna"],
                ConnectorType.Type2,
                2,
                22.00m,
                HistoricalPricePerKWh);

            AddConnectors(
                connectors,
                ChargingStationIds["EVN2GO Pamporovo Studenets"],
                ConnectorType.CCS2,
                2,
                60.00m,
                HistoricalPricePerKWh);


            return connectors.ToArray();
        }


        private static void AddConnectors(
            List<Connector> connectors,
            int ChargingStationId,
            ConnectorType connectorType,
            int count,
            decimal powerKw,
            decimal pricePerKWh)
        {
            for (int connectorNumber = 1;
                 connectorNumber <= count;
                 connectorNumber++)
            {
                Connector connector = new Connector
                {
                    ConnectorNumber = connectorNumber,
                    ConnectorType = connectorType,
                    PowerKw = powerKw,
                    PricePerKWh = pricePerKWh,
                    ConnectorStatus = ConnectorStatus.Unknown,
                    ExternalId = null,
                    ChargingStationId = ChargingStationId
                };

                connectors.Add(connector);
            }
        }
    }
}