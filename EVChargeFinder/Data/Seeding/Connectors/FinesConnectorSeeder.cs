namespace EVChargeFinder.Data.Seeding.Connectors
{
    using DbModels;
    using DbModels.Enums;
    public static class FinesConnectorSeeder
    {
        public static Connector[] GetConnectors(
            Dictionary<string, int> chargeStationIds)
        {
            List<Connector> connectors = new List<Connector>();

            AddConnectors(
                connectors,
                chargeStationIds["FINES Trakia 122"],
                (ConnectorType.CCS2, 1, 600.00m, 0.33m),
                (ConnectorType.MCS, 1, 1000.00m, 0.33m),
                (ConnectorType.CCS2, 10, 480.00m, 0.33m));

            AddConnectors(
                connectors,
                chargeStationIds["FINES Elit Vidin"],
                (ConnectorType.CCS2, 2, 480.00m, 0.39m));

            AddConnectors(
                connectors,
                chargeStationIds["FINES Imperial Palace Svilengrad"],
                (ConnectorType.CCS2, 2, 480.00m, 0.39m),
                (ConnectorType.CCS2, 2, 150.00m, 0.39m));

            AddConnectors(
                connectors,
                chargeStationIds["FINES Varna Billa"],
                (ConnectorType.CCS2, 8, 480.00m, 0.39m));

            AddConnectors(
                connectors,
                chargeStationIds["FINES Chuchuligovo"],
                (ConnectorType.CCS2, 2, 400.00m, 0.39m),
                (ConnectorType.CCS2, 6, 300.00m, 0.39m));

            AddConnectors(
                connectors,
                chargeStationIds["FINES Petrol Orizovo"],
                (ConnectorType.CCS2, 2, 180.00m, 0.39m));

            AddConnectors(
                connectors,
                chargeStationIds["Balkan AD Lovech"],
                (ConnectorType.CCS2, 12, 480.00m, 0.39m));

            AddConnectors(
                connectors,
                chargeStationIds["FINES Intercom Group Varna"],
                (ConnectorType.CCS2, 2, 240.00m, 0.39m));

            AddConnectors(
                connectors,
                chargeStationIds["FINES Varna Star Power"],
                (ConnectorType.CCS2, 2, 150.00m, 0.39m));

            AddConnectors(
                connectors,
                chargeStationIds["FINES Hyundai Varna"],
                (ConnectorType.CCS2, 2, 150.00m, 0.39m));

            AddConnectors(
                connectors,
                chargeStationIds["FINES Bulavto Premium Varna"],
                (ConnectorType.CCS2, 2, 150.00m, 0.39m));

            AddConnectors(
                connectors,
                chargeStationIds["FINES Tomsy Burgas"],
                (ConnectorType.CCS2, 2, 180.00m, 0.39m));

            AddConnectors(
                connectors,
                chargeStationIds["FINES Tomov Plaza Plovdiv"],
                (ConnectorType.CCS2, 2, 180.00m, 0.39m));

            AddConnectors(
                connectors,
                chargeStationIds["FINES Hay Group Shumen"],
                (ConnectorType.CCS2, 2, 360.00m, 0.39m),
                (ConnectorType.CCS2, 2, 240.00m, 0.39m));

            AddConnectors(
                connectors,
                chargeStationIds["FiNES Omnicar Auto Plovdiv"],
                (ConnectorType.CCS2, 2, 360.00m, 0.39m));

            AddConnectors(
                connectors,
                chargeStationIds["FINES Harmanli"],
                (ConnectorType.CCS2, 2, 320.00m, 0.20m),
                (ConnectorType.CCS2, 2, 240.00m, 0.20m));

            AddConnectors(
                connectors,
                chargeStationIds["FINES Petrol Studena"],
                (ConnectorType.CCS2, 4, 300.00m, 0.39m));

            AddConnectors(
                connectors,
                chargeStationIds["FINES Plovdiv Tsarigradsko"],
                (ConnectorType.CCS2, 2, 300.00m, 0.39m));

            AddConnectors(
                connectors,
                chargeStationIds["FINES Porsche Center Sofia"],
                (ConnectorType.CCS2, 2, 150.00m, 0.39m),
                (ConnectorType.CCS2, 2, 300.00m, 0.39m));

            AddConnectors(
                connectors,
                chargeStationIds["FINES Trakia 243 Sofia"],
                (ConnectorType.CCS2, 4, 400.00m, 0.39m),
                (ConnectorType.CCS2, 6, 240.00m, 0.39m));

            AddConnectors(
                connectors,
                chargeStationIds["FINES Trakia 243 Burgas"],
                (ConnectorType.Type2, 1, 22.00m, 0.39m),
                (ConnectorType.CCS2, 3, 600.00m, 0.39m),
                (ConnectorType.MCS, 1, 1000.00m, 0.39m),
                (ConnectorType.CCS2, 8, 480.00m, 0.39m),
                (ConnectorType.CCS2, 1, 120.00m, 0.39m),
                (ConnectorType.CHAdeMO, 1, 120.00m, 0.39m));

            AddConnectors(
                connectors,
                chargeStationIds["FINES Central Park Burgas"],
                (ConnectorType.Type2, 19, 22.00m, 0.32m),
                (ConnectorType.CCS2, 6, 480.00m, 0.39m),
                (ConnectorType.CCS2, 2, 50.00m, 0.39m));

            AddConnectors(
                connectors,
                chargeStationIds["Hydro Power Plant Kadievo"],
                (ConnectorType.Type2, 1, 22.00m, 0.15m),
                (ConnectorType.CCS2, 2, 180.00m, 0.18m),
                (ConnectorType.CCS2, 4, 480.00m, 0.22m));

            AddConnectors(
                connectors,
                chargeStationIds["FINES Dimar Stroy"],
                (ConnectorType.CCS2, 2, 360.00m, 0.39m));

            AddConnectors(
                connectors,
                chargeStationIds["FINES Ihtiman Burgas"],
                (ConnectorType.CCS2, 2, 240.00m, 0.39m),
                (ConnectorType.CCS2, 6, 320.00m, 0.39m));

            AddConnectors(
                connectors,
                chargeStationIds["FINES Hotel City Sandanski"],
                (ConnectorType.CCS2, 4, 300.00m, 0.39m));

            AddConnectors(
                connectors,
                chargeStationIds["FINES Hyundai Sofia"],
                (ConnectorType.CCS2, 2, 120.00m, 0.39m),
                (ConnectorType.CCS2, 2, 300.00m, 0.39m));

            AddConnectors(
                connectors,
                chargeStationIds["FINES Lukoil Sofia Ring"],
                (ConnectorType.CCS2, 3, 300.00m, 0.39m));

            AddConnectors(
                connectors,
                chargeStationIds["FINES Mr. Bricolage Blagoevgrad"],
                (ConnectorType.CCS2, 2, 300.00m, 0.39m));

            AddConnectors(
                connectors,
                chargeStationIds["FINES Mr. Bricolage XOPark"],
                (ConnectorType.CCS2, 2, 300.00m, 0.39m),
                (ConnectorType.CCS2, 2, 240.00m, 0.39m));

            AddConnectors(
                connectors,
                chargeStationIds["FINES Retail Park Dobrich"],
                (ConnectorType.CCS2, 2, 300.00m, 0.39m),
                (ConnectorType.Type2, 6, 22.00m, 0.32m));

            AddConnectors(
                connectors,
                chargeStationIds["FINES Technomarket Haskovo"],
                (ConnectorType.CCS2, 1, 50.00m, 0.39m),
                (ConnectorType.CHAdeMO, 1, 50.00m, 0.39m),
                (ConnectorType.CCS2, 2, 300.00m, 0.39m));

            AddConnectors(
                connectors,
                chargeStationIds["FINES Gelemenovo"],
                (ConnectorType.CCS2, 2, 240.00m, 0.39m),
                (ConnectorType.Type2, 1, 22.00m, 0.32m));

            AddConnectors(
                connectors,
                chargeStationIds["FINES Hyundai Burgas"],
                (ConnectorType.CCS2, 2, 240.00m, 0.39m));

            AddConnectors(
                connectors,
                chargeStationIds["FINES Mall Yambol"],
                (ConnectorType.CCS2, 2, 240.00m, 0.39m));

            AddConnectors(
                connectors,
                chargeStationIds["FINES MASTERHAUS Kazanlak"],
                (ConnectorType.Type2, 1, 22.00m, 0.32m),
                (ConnectorType.CCS2, 2, 240.00m, 0.39m));

            AddConnectors(
                connectors,
                chargeStationIds["FINES Mr. Bricolage Burgas"],
                (ConnectorType.CCS2, 6, 240.00m, 0.39m));

            AddConnectors(
                connectors,
                chargeStationIds["FINES Mr. Bricolage Haskovo"],
                (ConnectorType.CCS2, 2, 240.00m, 0.39m));

            AddConnectors(
                connectors,
                chargeStationIds["FINES Mr. Bricolage Plovdiv"],
                (ConnectorType.CCS2, 4, 240.00m, 0.39m));

            AddConnectors(
                connectors,
                chargeStationIds["FINES Mr. Bricolage Ruse"],
                (ConnectorType.CCS2, 2, 240.00m, 0.39m));

            AddConnectors(
                connectors,
                chargeStationIds["FINES Omnicar Plovdiv Rodopi"],
                (ConnectorType.CCS2, 2, 240.00m, 0.39m));

            AddConnectors(
                connectors,
                chargeStationIds["FINES Porcelanosa"],
                (ConnectorType.CCS2, 2, 240.00m, 0.39m));

            return connectors.ToArray();
        }


        private static void AddConnectors(
            List<Connector> connectors,
            int chargeStationId,
            params (
                ConnectorType Type,
                int Count,
                decimal PowerKw,
                decimal PricePerKWh)[] connectorGroups)
        {
            int connectorNumber = 1;

            foreach ((
                ConnectorType Type,
                int Count,
                decimal PowerKw,
                decimal PricePerKWh) connectorGroup in connectorGroups)
            {
                for (int i = 0; i < connectorGroup.Count; i++)
                {
                    Connector connector = new Connector
                    {
                        ConnectorNumber = connectorNumber,
                        ConnectorType = connectorGroup.Type,
                        PowerKw = connectorGroup.PowerKw,
                        PricePerKWh = connectorGroup.PricePerKWh,
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