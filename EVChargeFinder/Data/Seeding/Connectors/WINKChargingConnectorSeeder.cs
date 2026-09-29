namespace EVChargeFinder.Data.Seeding.Connectors
{
    using DbModels;
    using DbModels.Enums;

    public static class WINKChargingConnectorSeeder
    {
        private const decimal DefaultPricePerKWh = 0.41m;

        public static Connector[] GetConnectors(
            Dictionary<string, int> chargeStationIds)
        {
            List<Connector> connectors = new List<Connector>();


            // TODO: "WINK Fantastico Pernik"
            // Public sources confirm this WINK location as AC,
            // but exact connector count and power were not reliably verified.


            // TODO: "WINK Zheleznicharska Vidin"
            // Public sources confirm 22 kW and AC operation,
            // but exact connector count was not reliably verified.


            // TODO: "WINK Tsarevo"
            // Location at ul. Krajbrezhna 39 is confirmed,
            // but exact connector type/count/power was not reliably verified.


            // TODO: "WINK Yambol"
            // Public sources confirm this location is AC only,
            // but exact connector count and power were not reliably verified.


            // TODO: "WINK Krumovgrad"
            // Location is confirmed, but exact connector type/count/power
            // was not reliably verified.


            AddConnectors(
                connectors,
                chargeStationIds["WINK Fantastico Manastirski Livadi"],
                ConnectorType.Type2,
                1,
                22.00m,
                DefaultPricePerKWh);


            // TODO: "WINK Karlovo"
            // Public sources confirm this is an AC WINK location,
            // but exact connector count and power were not reliably verified.


            // TODO: "WINK Karlovo 1"
            // Public sources confirm this is an AC WINK location,
            // but exact connector count and power were not reliably verified.


            AddConnectors(
                connectors,
                chargeStationIds["WINK Momchilgrad"],
                ConnectorType.Type2,
                2,
                22.00m,
                DefaultPricePerKWh);


            AddConnectors(
                connectors,
                chargeStationIds["WINK Bansko 1"],
                ConnectorType.Type2,
                1,
                22.00m,
                DefaultPricePerKWh);


            // TODO: "WINK Bansko 3"
            // Public sources confirm this is an AC WINK location,
            // but exact connector count and power were not reliably verified.


            // TODO: "WINK Pomorie 1"
            // Public sources confirm this is an AC WINK location,
            // but exact connector count and power were not reliably verified.


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
    }
}
