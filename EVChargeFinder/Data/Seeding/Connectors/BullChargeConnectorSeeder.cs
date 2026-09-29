namespace EVChargeFinder.Data.Seeding.Connectors
{
    using DbModels;
    using DbModels.Enums;

    public static class BullChargeConnectorSeeder
    {
      private const decimal UnknownPricePerKWh = 0.00m;

        public static Connector[] GetConnectors(
            Dictionary<string, int> chargeStationIds)
        {
            List<Connector> connectors = new List<Connector>();

            AddConnectors(
                connectors,
                chargeStationIds["BullCharge Headquarters"],
                ConnectorType.Type2,
                5,
                22.00m,
                UnknownPricePerKWh);


            //TODO: "BullCharge Bulgarian Industrial Association"
          
            AddConnectors(
                connectors,
                chargeStationIds["BullCharge Guesthouse Horizont"],
                ConnectorType.Type2,
                1,
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
