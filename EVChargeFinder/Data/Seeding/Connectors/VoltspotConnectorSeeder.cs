namespace EVChargeFinder.Data.Seeding.Connectors
{
    using DbModels;
    using DbModels.Enums;

    public static class VoltspotConnectorSeeder
    {
 
        private const decimal DefaultPricePerKWh = 0.35m;

        public static Connector[] GetConnectors(
            Dictionary<string, int> chargeStationIds)
        {
            List<Connector> connectors = new List<Connector>();


            AddConnectors(
                connectors,
                chargeStationIds["Voltspot Kome CBA Kostinbrod"],
                (ConnectorType.CCS2, 1, 60.00m),
                (ConnectorType.CHAdeMO, 1, 60.00m),
                (ConnectorType.Type2, 1, 43.00m));


            AddConnectors(
                connectors,
                chargeStationIds["Voltspot Bora Bora"],
                (ConnectorType.CCS2, 4, 180.00m),
                (ConnectorType.CHAdeMO, 2, 60.00m));


            AddConnectors(
                connectors,
                chargeStationIds["Voltspot AutoBOX Ray"],
                (ConnectorType.CCS2, 1, 80.00m),
                (ConnectorType.CHAdeMO, 1, 60.00m),
                (ConnectorType.Type2, 1, 22.00m));


            AddConnectors(
                connectors,
                chargeStationIds["Voltspot AutoBOX Elmira"],
                (ConnectorType.Type2, 1, 22.00m));


            AddConnectors(
                connectors,
                chargeStationIds["Voltspot AutoBOX Popovo"],
                (ConnectorType.Type2, 1, 22.00m));


            AddConnectors(
                connectors,
                chargeStationIds["Voltspot Autocenter Vikar"],
                (ConnectorType.Type2, 1, 22.00m));


            AddConnectors(
                connectors,
                chargeStationIds["Voltspot Delta Planet Mall"],
                (ConnectorType.CCS2, 1, 60.00m),
                (ConnectorType.CHAdeMO, 1, 60.00m),
                (ConnectorType.Type2, 1, 43.00m));


            AddConnectors(
                connectors,
                chargeStationIds["Voltspot Furnata"],
                (ConnectorType.CCS2, 1, 90.00m),
                (ConnectorType.CHAdeMO, 1, 60.00m),
                (ConnectorType.Type2, 1, 43.00m));


            AddConnectors(
                connectors,
                chargeStationIds["Voltspot Sokol Gas Station"],
                (ConnectorType.Type2, 1, 22.00m));


            AddConnectors(
                connectors,
                chargeStationIds["Voltspot Kome CBA Sveta Troitsa"],
                (ConnectorType.Type2, 1, 22.00m));


            AddConnectors(
                connectors,
                chargeStationIds["Voltspot Kome CBA Bankya"],
                (ConnectorType.Type2, 2, 22.00m));


            AddConnectors(
                connectors,
                chargeStationIds["Voltspot Kome CBA Slatina"],
                (ConnectorType.Type2, 2, 22.00m));


            AddConnectors(
                connectors,
                chargeStationIds["Voltspot Kome CBA Ovcha Kupel"],
                (ConnectorType.Type2, 2, 22.00m));


            AddConnectors(
                connectors,
                chargeStationIds["Voltspot Hotel Park Center"],
                (ConnectorType.CCS2, 1, 30.00m),
                (ConnectorType.Type2, 1, 22.00m));


            AddConnectors(
                connectors,
                chargeStationIds["Voltspot Kome CBA Motopista"],
                (ConnectorType.Type2, 2, 22.00m));


            AddConnectors(
                connectors,
                chargeStationIds["Voltspot Kome CBA Druzhba"],
                (ConnectorType.Type2, 2, 22.00m));


            AddConnectors(
                connectors,
                chargeStationIds["Voltspot Kome CBA Pernik"],
                (ConnectorType.Type2, 1, 22.00m));


            AddConnectors(
                connectors,
                chargeStationIds["Voltspot Bolero CBA Pomorie"],
                (ConnectorType.Type2, 2, 22.00m));


            AddConnectors(
                connectors,
                chargeStationIds["Voltspot Bolero CBA Iztok"],
                (ConnectorType.Type2, 1, 7.00m));


            AddConnectors(
                connectors,
                chargeStationIds["Voltspot AutoBOX Strelcha"],
                (ConnectorType.Type2, 1, 22.00m));


            AddConnectors(
                connectors,
                chargeStationIds["Voltspot Horse Base & Hotel Max"],
                (ConnectorType.Type2, 1, 22.00m));


            AddConnectors(
                connectors,
                chargeStationIds["Voltspot Yambol Park"],
                (ConnectorType.CCS2, 1, 100.00m),
                (ConnectorType.CHAdeMO, 1, 60.00m),
                (ConnectorType.Type2, 1, 22.00m));


            AddConnectors(
                connectors,
                chargeStationIds["Voltspot Autoengineering"],
                (ConnectorType.Type2, 1, 22.00m));


            AddConnectors(
                connectors,
                chargeStationIds["Voltspot Struma Petrol"],
                (ConnectorType.CCS2, 1, 100.00m),
                (ConnectorType.CHAdeMO, 1, 60.00m),
                (ConnectorType.Type2, 1, 43.00m));


            AddConnectors(
                connectors,
                chargeStationIds["Voltspot Kome CBA Dupnitsa"],
                (ConnectorType.Type2, 2, 22.00m));


            AddConnectors(
                connectors,
                chargeStationIds["Voltspot Restaurant Tikhiyat Kat"],
                (ConnectorType.Type2, 2, 22.00m));


            AddConnectors(
                connectors,
                chargeStationIds["Voltspot Bolero CBA Tsarevo"],
                (ConnectorType.Type2, 1, 22.00m));


            AddConnectors(
                connectors,
                chargeStationIds["Voltspot AutoBOX Elhovo"],
                (ConnectorType.Type2, 1, 22.00m));


            AddConnectors(
                connectors,
                chargeStationIds["Voltspot Mall Plovdiv"],
                (ConnectorType.CCS2, 1, 140.00m),
                (ConnectorType.CHAdeMO, 1, 60.00m),
                (ConnectorType.Type2, 1, 43.00m));


            AddConnectors(
                connectors,
                chargeStationIds["Voltspot Parvomay Park"],
                (ConnectorType.Type2, 2, 7.00m));


            AddConnectors(
                connectors,
                chargeStationIds["Voltspot BGMARKET CBA Zapad"],
                (ConnectorType.Type2, 1, 22.00m));


            AddConnectors(
                connectors,
                chargeStationIds["Voltspot Hippoland Blagoevgrad"],
                (ConnectorType.Type2, 1, 22.00m));


            AddConnectors(
                connectors,
                chargeStationIds["Voltspot Kashmir Hotel & SPA"],
                (ConnectorType.Type2, 2, 22.00m));


            AddConnectors(
                connectors,
                chargeStationIds["Voltspot Motel Kozyat Rog"],
                (ConnectorType.Type2, 1, 22.00m));


            AddConnectors(
                connectors,
                chargeStationIds["Voltspot AutoBOX Haskovo"],
                (ConnectorType.Type2, 1, 22.00m));


            AddConnectors(
                connectors,
                chargeStationIds["Voltspot St. Ivan Rilski SPA Resort"],
                (ConnectorType.Type2, 4, 22.00m));


            AddConnectors(
                connectors,
                chargeStationIds["Voltspot Premier Resort"],
                (ConnectorType.Type2, 2, 22.00m));


            AddConnectors(
                connectors,
                chargeStationIds["Voltspot Shell Kardzhali"],
                (ConnectorType.CCS2, 2, 240.00m),
                (ConnectorType.CHAdeMO, 1, 60.00m),
                (ConnectorType.Type2, 2, 22.00m));


            return connectors.ToArray();
        }


        private static void AddConnectors(
            List<Connector> connectors,
            int chargeStationId,
            params (
                ConnectorType Type,
                int Count,
                decimal PowerKw)[] connectorGroups)
        {
            int connectorNumber = 1;

            foreach ((
                ConnectorType Type,
                int Count,
                decimal PowerKw) connectorGroup in connectorGroups)
            {
                for (int i = 0; i < connectorGroup.Count; i++)
                {
                    Connector connector = new Connector
                    {
                        ConnectorNumber = connectorNumber,
                        ConnectorType = connectorGroup.Type,
                        PowerKw = connectorGroup.PowerKw,
                        PricePerKWh = DefaultPricePerKWh,
                        ConnectorStatus = ConnectorStatus.Unknown,
                        ExternalId = null,
                        ChargeStationId = chargeStationId
                    };

                    connectors.Add(connector);
                    connectorNumber++;
                }
            }
        }
    }
}
