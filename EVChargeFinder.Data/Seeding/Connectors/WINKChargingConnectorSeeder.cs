namespace EVChargeFinder.Data.Seeding.Connectors
{
    using DbModels;
    using DbModels.Enums;

    public static class WINKChargingConnectorSeeder
    {
       

        public static Connector[] GetConnectors(
            Dictionary<string, int> ChargingStationIds)
        {
            List<Connector> connectors = new List<Connector>();


            AddConnectors(
           connectors,
           ChargingStationIds["WINK Fantastico Pernik"],
           ConnectorType.Type2,
           1,
           22.00m,
           0.41m);


            AddConnectors(
      connectors,
      ChargingStationIds["WINK Zheleznicharska Vidin"],
      ConnectorType.Type2,
      1,
      22.00m,
      0.41m);


            AddConnectors(
      connectors,
      ChargingStationIds["WINK Tsarevo"],
      ConnectorType.Type2,
      1,
      22.00m,
      0.41m);


            AddConnectors(
      connectors,
      ChargingStationIds["WINK Yambol"],
      ConnectorType.Type2,
      1,
      22.00m,
      0.41m);


            AddConnectors(
      connectors,
      ChargingStationIds["WINK Krumovgrad"],
      ConnectorType.Type2,
      1,
      22.00m,
      0.41m);


            AddConnectors(
                connectors,
                ChargingStationIds["WINK Fantastico Manastirski Livadi"],
                ConnectorType.Type2,
                1,
                22.00m,
                0.41m);


            AddConnectors(
      connectors,
      ChargingStationIds["WINK Karlovo"],
      ConnectorType.Type2,
      1,
      22.00m,
      0.41m);


            AddConnectors(
      connectors,
      ChargingStationIds["WINK Karlovo 1"],
      ConnectorType.Type2,
      1,
      22.00m,
      0.41m);


            AddConnectors(
                connectors,
                ChargingStationIds["WINK Momchilgrad"],
                ConnectorType.Type2,
                2,
                22.00m,
                0.41m);


            AddConnectors(
                connectors,
                ChargingStationIds["WINK Bansko 1"],
                ConnectorType.Type2,
                1,
                22.00m,
                0.41m);

            AddConnectors(
         connectors,
         ChargingStationIds["WINK Bansko 3"],
         ConnectorType.Type2,
         1,
         22.00m,
         0.41m);



            AddConnectors(
         connectors,
         ChargingStationIds["WINK Pomorie 1"],
         ConnectorType.Type2,
         1,
         22.00m,
         0.41m);


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
