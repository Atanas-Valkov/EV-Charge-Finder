namespace EVChargeFinder.Data.Seeding.Connectors
{
    using DbModels;
    using DbModels.Enums;

    public static class ProCreditChargingConnectorSeeder
    {
 
        private const decimal UnknownPricePerKWh = 0.00m;

        public static Connector[] GetConnectors(
            Dictionary<string, int> chargeStationIds)
        {
            List<Connector> connectors = new List<Connector>();


            // TODO: "ProCredit Charging Poligrafia"
            
            // TODO: "ProCredit Charging Lev Tolstoy"
            
            AddConnectors(
                connectors,
                chargeStationIds["ProCredit Charging UNWE"],
                ConnectorType.Type2,
                3,
                22.00m,
                UnknownPricePerKWh);


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
