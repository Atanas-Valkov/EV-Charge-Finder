namespace EVChargeFinder.Data.Seeding.Connectors
{
    using DbModels;
    using DbModels.Enums;

    public static class TeslaSuperchargerConnectorSeeder
    {
       private const decimal DefaultPricePerKWh = 0.38m;

        public static Connector[] GetConnectors(
            Dictionary<string, int> ChargingStationIds)
        {
            List<Connector> connectors = new List<Connector>();

            AddConnectors(
                connectors,
                ChargingStationIds["Tesla Supercharger Bulgaria Mall"],
                ConnectorType.CCS2,
                8,
                250.00m,
                DefaultPricePerKWh);

            AddConnectors(
                connectors,
                ChargingStationIds["Tesla Supercharger Paradise Center"],
                ConnectorType.CCS2,
                6,
                250.00m,
                DefaultPricePerKWh);

            AddConnectors(
                connectors,
                ChargingStationIds["Tesla Supercharger Plovdiv"],
                ConnectorType.CCS2,
                4,
                125.00m,
                DefaultPricePerKWh);


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
