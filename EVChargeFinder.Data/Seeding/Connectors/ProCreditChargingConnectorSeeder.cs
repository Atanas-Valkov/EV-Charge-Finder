namespace EVChargeFinder.Data.Seeding.Connectors
{
    using DbModels;
    using DbModels.Enums;

    public static class ProCreditChargingConnectorSeeder
    {
 
        public static Connector[] GetConnectors(
            Dictionary<string, int> ChargingStationIds)
        {
            List<Connector> connectors = new List<Connector>();


            
            AddConnectors(
    connectors,
    ChargingStationIds["ProCredit Charging Poligrafia"],
    ConnectorType.Type2,
    3,
    22.00m,
    0.47m);

          
            AddConnectors(
    connectors,
    ChargingStationIds["ProCredit Charging Lev Tolstoy"],



    ConnectorType.Type2,
    3,
    22.00m,
    0.47m);

            AddConnectors(
                connectors,
                ChargingStationIds["ProCredit Charging UNWE"],
                ConnectorType.Type2,
                3,
                22.00m,
                0.47m);


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
