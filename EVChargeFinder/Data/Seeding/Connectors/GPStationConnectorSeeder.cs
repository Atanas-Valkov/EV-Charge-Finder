namespace EVChargeFinder.Data.Seeding.Connectors
{
    using DbModels;
    using DbModels.Enums;

    public static class GPStationConnectorSeeder
    {
        private const decimal HistoricalStandardPricePerKWh = 0.25m;
        private const decimal HistoricalNiagaraPricePerKWh = 0.36m;

        public static Connector[] GetConnectors(
            Dictionary<string, int> ChargingStationIds)
        {
            List<Connector> connectors = new List<Connector>();


            AddConnectors(
                connectors,
                ChargingStationIds["GPStation Central Station"],
                ConnectorType.Type2,
                1,
                22.00m,
                HistoricalStandardPricePerKWh);


            AddConnectors(
                connectors,
                ChargingStationIds["GPStation Niagara Druzhba 2"],
                ConnectorType.Type2,
                2,
                22.00m,
                HistoricalNiagaraPricePerKWh);


            AddConnectors(
                connectors,
                ChargingStationIds["GPStation St. Sofia Golf Club"],
                ConnectorType.Type2,
                1,
                7.50m,
                HistoricalStandardPricePerKWh);


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
