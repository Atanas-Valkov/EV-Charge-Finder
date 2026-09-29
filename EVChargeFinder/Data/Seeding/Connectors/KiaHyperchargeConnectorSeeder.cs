namespace EVChargeFinder.Data.Seeding.Connectors
{
    using DbModels;
    using DbModels.Enums;

    public static class KiaHyperchargeConnectorSeeder
    {
      private const decimal DefaultPricePerKWh = 0.39m;

        public static Connector[] GetConnectors(
            Dictionary<string, int> chargeStationIds)
        {
            List<Connector> connectors = new List<Connector>();


            AddConnectorsWithExternalIds(
                connectors,
                chargeStationIds["Kia Hypercharge Tsarigradsko Shose 144"],
                (ConnectorType.CCS2, 150.00m, DefaultPricePerKWh, "BG*KIA*EE4812E66*1"),
                (ConnectorType.CCS2, 150.00m, DefaultPricePerKWh, "BG*KIA*EE4812E66*2"));


            // Kia's own 2025 brochure shows three 150 kW charging points at this
            // address, while current public roaming data exposes two CCS points
            // with the verified IDs above. A possible third 150 kW point is not
            // seeded until it can be verified in the live Kia Hypercharge app.


            AddConnectors(
                connectors,
                chargeStationIds["Kia Hypercharge Pozitano 2"],
                ConnectorType.CCS2,
                1,
                150.00m,
                DefaultPricePerKWh);


            AddConnectors(
                connectors,
                chargeStationIds["Kia Hypercharge Yuzhen"],
                ConnectorType.CCS2,
                1,
                150.00m,
                DefaultPricePerKWh);


            AddConnectors(
                connectors,
                chargeStationIds["Kia Hypercharge Industrialna 12"],
                ConnectorType.Type2,
                1,
                22.00m,
                DefaultPricePerKWh);


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
                    ChargeStationId = chargeStationId
                };

                connectors.Add(connector);
            }
        }


        private static void AddConnectorsWithExternalIds(
            List<Connector> connectors,
            int chargeStationId,
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
                    ChargeStationId = chargeStationId
                };

                connectors.Add(connector);
                connectorNumber++;
            }
        }
    }
}
