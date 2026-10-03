namespace EVChargeFinder.Data.Seeding.Connectors
{
    using DbModels;
    using DbModels.Enums;

    public static class KiaHyperchargeConnectorSeeder
    {
      private const decimal DefaultPricePerKWh = 0.39m;

        public static Connector[] GetConnectors(
            Dictionary<string, int> ChargingStationIds)
        {
            List<Connector> connectors = new List<Connector>();


            AddConnectorsWithExternalIds(
                connectors,
                ChargingStationIds["Kia Hypercharge Tsarigradsko Shose 144"],
                (ConnectorType.CCS2, 150.00m, DefaultPricePerKWh, "BG*KIA*EE4812E66*1"),
                (ConnectorType.CCS2, 150.00m, DefaultPricePerKWh, "BG*KIA*EE4812E66*2"));


            // Kia's own 2025 brochure shows three 150 kW charging points at this
            // address, while current public roaming data exposes two CCS points
            // with the verified IDs above. A possible third 150 kW point is not
            // seeded until it can be verified in the live Kia Hypercharge app.


            AddConnectors(
                connectors,
                ChargingStationIds["Kia Hypercharge Pozitano 2"],
                ConnectorType.CCS2,
                1,
                150.00m,
                DefaultPricePerKWh);


            AddConnectors(
                connectors,
                ChargingStationIds["Kia Hypercharge Yuzhen"],
                ConnectorType.CCS2,
                1,
                150.00m,
                DefaultPricePerKWh);


            AddConnectors(
                connectors,
                ChargingStationIds["Kia Hypercharge Industrialna 12"],
                ConnectorType.Type2,
                1,
                22.00m,
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


        private static void AddConnectorsWithExternalIds(
            List<Connector> connectors,
            int ChargingStationId,
            params (
                ConnectorType Type,
                decimal PowerKw,
                decimal PricePerKWh,
                string ExternalId)[] connectorGroups)
        {
            int connectorNumber = 1;

            foreach ((
                ConnectorType Type,
                decimal PowerKw,
                decimal PricePerKWh,
                string ExternalId) connectorGroup in connectorGroups)
            {
                Connector connector = new Connector
                {
                    ConnectorNumber = connectorNumber,
                    ConnectorType = connectorGroup.Type,
                    PowerKw = connectorGroup.PowerKw,
                    PricePerKWh = connectorGroup.PricePerKWh,
                    ConnectorStatus = ConnectorStatus.Unknown,
                    ExternalId = connectorGroup.ExternalId,
                    ChargingStationId = ChargingStationId
                };

                connectors.Add(connector);
                connectorNumber++;
            }
        }
    }
}
