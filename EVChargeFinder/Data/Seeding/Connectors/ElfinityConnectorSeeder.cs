namespace EVChargeFinder.Data.Seeding.Connectors
{
    using DbModels;
    using DbModels.Enums;

    public static class ElfinityConnectorSeeder
    {
        private const decimal DefaultDcPricePerKWh = 0.45m;

        public static Connector[] GetConnectors(
            Dictionary<string, int> chargeStationIds)
        {
            List<Connector> connectors = new List<Connector>();


            // TODO: "Elfinity Graf Ignatievo"
            // Location is confirmed, but exact connector type/count/power
            // was not reliably verified from public sources.


            // TODO: "Elfinity Otets Paisiy 3"
            // Location is confirmed, but exact connector type/count/power
            // was not reliably verified from public sources.


            // TODO: "Elfinity Yane Sandanski 1"
            // Location is confirmed, but exact connector type/count/power
            // was not reliably verified from public sources.


            // TODO: "Elfinity Yanko Sakazov 25"
            // Location is confirmed, but exact connector type/count/power
            // was not reliably verified from public sources.


            AddConnectors(
                connectors,
                chargeStationIds["Elfinity Knyaz Aleksandar Batenberg 28"],
                ConnectorType.CCS2,
                1,
                180.00m,
                DefaultDcPricePerKWh);


            AddConnectors(
                connectors,
                chargeStationIds["Elfinity Oborishte 5"],
                ConnectorType.CCS2,
                1,
                50.00m,
                DefaultDcPricePerKWh);


            AddConnectors(
                connectors,
                chargeStationIds["Elfinity Port Varna"],
                ConnectorType.CCS2,
                1,
                150.00m,
                DefaultDcPricePerKWh);


            AddConnectors(
                connectors,
                chargeStationIds["Elfinity Knyaz Boris I"],
                ConnectorType.CCS2,
                1,
                60.00m,
                DefaultDcPricePerKWh);


            AddConnectors(
                connectors,
                chargeStationIds["Elfinity Burgas 906"],
                ConnectorType.CCS2,
                1,
                30.00m,
                DefaultDcPricePerKWh);


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
