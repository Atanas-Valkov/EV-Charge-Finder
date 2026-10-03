namespace EVChargeFinder.Data.Seeding.Connectors
{
    using DbModels;
    using DbModels.Enums;

    public static class VarnaChargingConnectorSeeder
    {
      private const decimal DefaultPricePerKWh = 0.36m;

        public static Connector[] GetConnectors(
            Dictionary<string, int> ChargingStationIds)
        {
            List<Connector> connectors = new List<Connector>();


            AddConnectors(
                connectors,
                ChargingStationIds["Varna Charging №5 - Tsaribrod"],
                ConnectorType.Type2,
                2,
                22.00m,
                DefaultPricePerKWh);

            AddConnectors(
                connectors,
                ChargingStationIds["Varna Charging №16 - Marin Drinov"],
                ConnectorType.Type2,
                2,
                22.00m,
                DefaultPricePerKWh);

            AddConnectors(
                connectors,
                ChargingStationIds["Varna Charging №17 - Chataldzha"],
                ConnectorType.Type2,
                2,
                22.00m,
                DefaultPricePerKWh);


            AddConnectors(
                connectors,
                ChargingStationIds["Varna Charging №18 - Lyuben Karavelov"],
                ConnectorType.Type2,
                2,
                22.00m,
                DefaultPricePerKWh);


            AddConnectors(
                connectors,
                ChargingStationIds["Varna Charging №20 - Marin Drinov"],
                ConnectorType.Type2,
                2,
                22.00m,
                DefaultPricePerKWh);


            AddConnectors(
                connectors,
                ChargingStationIds["Varna Charging №21 - Drin"],
                ConnectorType.Type2,
                2,
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
    }
}
