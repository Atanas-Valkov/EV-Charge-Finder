namespace EVChargeFinder.Data.Seeding.Connectors
{
    using DbModels;
    using DbModels.Enums;

    public static class ElfinityConnectorSeeder
    {
        private const decimal rDefaultDcPricePerKWh = 0.45m;

        public static Connector[] GetConnectors(
            Dictionary<string, int> ChargingStationIds)
        {
            List<Connector> connectors = new List<Connector>();


   
            AddConnectors(
                connectors,
                ChargingStationIds["Elfinity Graf Ignatievo"],
                ConnectorType.CCS2,
                1,
                180.00m,
                0.50m
               
               );

            AddConnectors(
                connectors,
                ChargingStationIds["Elfinity Otets Paisiy 3"],
                ConnectorType.CCS2,
                1,
                180.00m,
                0.50m);

            AddConnectors(
                connectors,
                ChargingStationIds["Elfinity Yane Sandanski 1"],
                ConnectorType.CCS2,
                1,
                180.00m,
                0.50m);


            AddConnectors(
                connectors,
                ChargingStationIds["Elfinity Yanko Sakazov 25"],
                ConnectorType.CCS2,
                1,
                180.00m,
                0.50m);


            AddConnectors(
                connectors,
                ChargingStationIds["Elfinity Knyaz Aleksandar Batenberg 28"],
                ConnectorType.CCS2,
                1,
                180.00m,
                0.50m);


            AddConnectors(
                connectors,
                ChargingStationIds["Elfinity Oborishte 5"],
                ConnectorType.CCS2,
                1,
                50.00m,
                0.50m);


            AddConnectors(
                connectors,
                ChargingStationIds["Elfinity Port Varna"],
                ConnectorType.CCS2,
                1,
                150.00m,
                0.50m);


            AddConnectors(
                connectors,
                ChargingStationIds["Elfinity Knyaz Boris I"],
                ConnectorType.CCS2,
                1,
                60.00m,
                0.50m);


            AddConnectors(
                connectors,
                ChargingStationIds["Elfinity Burgas 906"],
                ConnectorType.CCS2,
                1,
                30.00m,
                0.50m);


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
