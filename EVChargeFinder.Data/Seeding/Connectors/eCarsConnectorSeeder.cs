namespace EVChargeFinder.Data.Seeding.Connectors
{
    using DbModels;
    using DbModels.Enums;

    public static class eCarsConnectorSeeder
    {
        private const decimal UnknownPricePerKWh = 0.00m;

        public static Connector[] GetConnectors(
            Dictionary<string, int> ChargingStationIds)
        {
            List<Connector> connectors = new List<Connector>();


            AddConnectors(
                connectors,
                ChargingStationIds["eCars Casino Phoenix"],
                ConnectorType.Type2,
                2,
                22.00m,
                UnknownPricePerKWh);


            AddConnectors(
                connectors,
                ChargingStationIds["eCars Park Hotel Pirin Sharlopov"],
                ConnectorType.Type2,
                2,
                22.00m,
                UnknownPricePerKWh);


            AddConnectors(
                connectors,
                ChargingStationIds["eCars Avtokompleks Kalivas"],
                ConnectorType.Type2,
                1,
                22.00m,
                UnknownPricePerKWh);


            AddConnectors(
                connectors,
                ChargingStationIds["eCars Oasis Beach Club"],
                ConnectorType.Type2,
                1,
                22.00m,
                UnknownPricePerKWh);


            AddConnectors(
                connectors,
                ChargingStationIds["eCars Hotel Yanakiev"],
                ConnectorType.Type2,
                1,
                22.00m,
                UnknownPricePerKWh);

            AddConnectors(
                connectors,
                ChargingStationIds["eCars Hotel Morska Vila"],
                ConnectorType.Type2,
                1,
                22.00m,
                UnknownPricePerKWh);


            AddConnectors(
                connectors,
                ChargingStationIds["eCars Atiya Resort"],
                ConnectorType.Type2,
                1,
                22.00m,
                UnknownPricePerKWh);


            AddConnectors(
                connectors,
                ChargingStationIds["eCars Omnikar Auto"],
                ConnectorType.Type2,
                2,
                7.00m,
                UnknownPricePerKWh);


            AddConnectors(
                connectors,
                ChargingStationIds["eCars Inter Expo Center"],
                ConnectorType.Type2,
                1,
                3.00m,
                UnknownPricePerKWh);


            AddConnectors(
                connectors,
                ChargingStationIds["eCars Hotel Balkantsi"],
                ConnectorType.Type2,
                1,
                22.00m,
                UnknownPricePerKWh);


            AddConnectors(
                connectors,
                ChargingStationIds["eCars Grand Hotel Yantra"],
                ConnectorType.Type2,
                1,
                22.00m,
                UnknownPricePerKWh);


            AddConnectors(
                connectors,
                ChargingStationIds["eCars Sunny Garden SPA Hotel"],
                ConnectorType.Type2,
                1,
                22.00m,
                UnknownPricePerKWh);


            AddConnectors(
                connectors,
                ChargingStationIds["eCars Novi Pazar"],
                ConnectorType.Type2,
                1,
                7.40m,
                UnknownPricePerKWh);


            AddConnectors(
                connectors,
                ChargingStationIds["eCars Shtipsko"],
                ConnectorType.Type2,
                1,
                7.40m,
                UnknownPricePerKWh);


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