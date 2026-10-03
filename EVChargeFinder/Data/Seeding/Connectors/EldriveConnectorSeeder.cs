namespace EVChargeFinder.Data.Seeding.Connectors
{
    using DbModels;
    using DbModels.Enums;

    public static class EldriveConnectorSeeder
    {
        public static Connector[] GetConnectors(
            Dictionary<string, int> ChargingStationIds)
        {
            List<Connector> connectors = new List<Connector>();

            AddConnectorsWithExternalIds(
                connectors,
                ChargingStationIds["Eldrive Praktis MEGA Sofia"],
                (ConnectorType.CCS2, 200.00m, 0.46m, "BG642*1"),
                (ConnectorType.CCS2, 200.00m, 0.46m, "BG642*2"));

            AddConnectorsWithExternalIds(
                connectors,
                ChargingStationIds["Eldrive Grand Mall Varna"],
                (ConnectorType.CCS2, 200.00m, 0.46m, "BG692*1"),
                (ConnectorType.CCS2, 200.00m, 0.46m, "BG692*2"));

            // TODO: "Eldrive Shell Lyubimets West"
            // Connector count/type/power is intentionally not seeded until it is verified.

            AddConnectorsWithExternalIds(
                connectors,
                ChargingStationIds["Eldrive Shell Lyubimets East"],
                (ConnectorType.CCS2, 300.00m, 0.46m, "BG729*1"),
                (ConnectorType.CCS2, 300.00m, 0.46m, "BG729*2"),
                (ConnectorType.CCS2, 300.00m, 0.46m, null),
                (ConnectorType.CCS2, 300.00m, 0.46m, null));

            AddConnectors(
                connectors,
                ChargingStationIds["Eldrive Shell Montana"],
                (ConnectorType.CCS2, 1, 50.00m, 0.46m),
                (ConnectorType.CHAdeMO, 1, 50.00m, 0.46m));

            // TODO: "Eldrive Technopolis Nadezhda"
            // Connector count/type/power is intentionally not seeded until it is verified.

            // TODO: "Eldrive Billa Razgrad"
            // Connector count/type/power is intentionally not seeded until it is verified.

            // TODO: "Eldrive Billa Samokov"
            // Connector count/type/power is intentionally not seeded until it is verified.

            // TODO: "Eldrive Billa Sevlievo"
            // Connector count/type/power is intentionally not seeded until it is verified.

            AddConnectors(
                connectors,
                ChargingStationIds["Eldrive Bulport Logistics"],
                (ConnectorType.CCS2, 2, 150.00m, 0.46m));

            // TODO: "Eldrive The Mall Sofia"
            // Connector count/type/power is intentionally not seeded until it is verified.

            // TODO: "Eldrive XO Park Sofia"
            // Connector count/type/power is intentionally not seeded until it is verified.

            // TODO: "Eldrive Billa Nadezhda"
            // Connector count/type/power is intentionally not seeded until it is verified.

            // TODO: "Eldrive Billa Lincoln"
            // Connector count/type/power is intentionally not seeded until it is verified.

            // TODO: "Eldrive Billa Hladilnika"
            // Connector count/type/power is intentionally not seeded until it is verified.

            // TODO: "Eldrive Billa Buxton"
            // Connector count/type/power is intentionally not seeded until it is verified.

            AddConnectors(
                connectors,
                ChargingStationIds["Eldrive Shell Studena"],
                (ConnectorType.CCS2, 2, 120.00m, 0.46m));

            AddConnectors(
                connectors,
                ChargingStationIds["Eldrive Damyanitsa Hub"],
                (ConnectorType.CCS2, 8, 120.00m, 0.46m),
                (ConnectorType.Type2, 1, 22.00m, 0.41m));

            AddConnectors(
                connectors,
                ChargingStationIds["Eldrive Technopolis Sandanski"],
                (ConnectorType.CCS2, 6, 150.00m, 0.46m));

            AddConnectors(
                connectors,
                ChargingStationIds["Eldrive Shell Yambol"],
                (ConnectorType.CCS2, 1, 50.00m, 0.46m),
                (ConnectorType.CHAdeMO, 1, 50.00m, 0.46m));

            AddConnectors(
                connectors,
                ChargingStationIds["Eldrive Retail Park Vidin"],
                (ConnectorType.CCS2, 2, 120.00m, 0.46m));

            // TODO: "Eldrive Holiday Park Pazardzhik"
            // Connector count/type/power is intentionally not seeded until it is verified.

            AddConnectors(
                connectors,
                ChargingStationIds["Eldrive Holiday Park Haskovo"],
                (ConnectorType.CCS2, 2, 120.00m, 0.46m),
                (ConnectorType.CCS2, 2, 50.00m, 0.46m));

            AddConnectors(
                connectors,
                ChargingStationIds["Eldrive Retail Park Dupnitsa"],
                (ConnectorType.CCS2, 1, 50.00m, 0.46m));

            AddConnectors(
                connectors,
                ChargingStationIds["Eldrive Technopolis Blagoevgrad"],
                (ConnectorType.CCS2, 2, 150.00m, 0.46m));

            // TODO: "Eldrive Technopolis Burgas 2"
            // Connector count/type/power is intentionally not seeded until it is verified.

            AddConnectors(
                connectors,
                ChargingStationIds["Eldrive Shell Trakia South"],
                (ConnectorType.CCS2, 1, 50.00m, 0.46m),
                (ConnectorType.CHAdeMO, 1, 50.00m, 0.46m));

            AddConnectors(
                connectors,
                ChargingStationIds["Eldrive Shell Trakia North"],
                (ConnectorType.CCS2, 1, 50.00m, 0.46m),
                (ConnectorType.CHAdeMO, 1, 50.00m, 0.46m));

            AddConnectors(
                connectors,
                ChargingStationIds["Eldrive Sea Cars Sandanski"],
                (ConnectorType.CCS2, 1, 50.00m, 0.46m));

            AddConnectors(
                connectors,
                ChargingStationIds["Eldrive Moto-Pfohe Pleven"],
                (ConnectorType.CCS2, 2, 150.00m, 0.46m));

            AddConnectors(
                connectors,
                ChargingStationIds["Eldrive Metropolitan Hotel Sofia"],
                (ConnectorType.CCS2, 4, 120.00m, 0.46m));

            // TODO: "Eldrive Billa Lulin"
            // Connector count/type/power is intentionally not seeded until it is verified.

            // TODO: "Eldrive Via Park North"
            // Connector count/type/power is intentionally not seeded until it is verified.

            // TODO: "Eldrive Toyota Blagoevgrad"
            // Connector count/type/power is intentionally not seeded until it is verified.

            AddConnectors(
                connectors,
                ChargingStationIds["Eldrive Bulgaria Mall"],
                (ConnectorType.CCS2, 4, 120.00m, 0.46m));

            AddConnectors(
                connectors,
                ChargingStationIds["Eldrive Metro Sofia"],
                (ConnectorType.CCS2, 1, 25.00m, 0.46m),
                (ConnectorType.CHAdeMO, 1, 25.00m, 0.46m),
                (ConnectorType.Type2, 1, 22.00m, 0.41m));

            AddConnectors(
                connectors,
                ChargingStationIds["Eldrive Vasilevi Plaza"],
                (ConnectorType.CCS2, 5, 50.00m, 0.46m),
                (ConnectorType.CHAdeMO, 5, 50.00m, 0.46m),
                (ConnectorType.CCS2, 1, 20.00m, 0.46m),
                (ConnectorType.Type2, 1, 22.00m, 0.41m));

            AddConnectors(
                connectors,
                ChargingStationIds["Eldrive Sofia Park"],
                (ConnectorType.CCS2, 1, 22.00m, 0.46m),
                (ConnectorType.CHAdeMO, 1, 22.00m, 0.46m));

            AddConnectors(
                connectors,
                ChargingStationIds["Eldrive Sofia Airport Center"],
                (ConnectorType.Type2, 2, 22.00m, 0.41m));

            AddConnectors(
                connectors,
                ChargingStationIds["Eldrive Sofia Airport Terminal 2"],
                (ConnectorType.Type2, 6, 22.00m, 0.41m));

            AddConnectors(
                connectors,
                ChargingStationIds["Eldrive Moto-Pfohe Sofia"],
                (ConnectorType.CCS2, 1, 50.00m, 0.46m),
                (ConnectorType.CHAdeMO, 1, 50.00m, 0.46m));

            AddConnectors(
                connectors,
                ChargingStationIds["Eldrive Shell Lulin"],
                (ConnectorType.CCS2, 1, 24.00m, 0.46m),
                (ConnectorType.CHAdeMO, 1, 24.00m, 0.46m));

            AddConnectors(
                connectors,
                ChargingStationIds["Eldrive Fantastico G.M. Dimitrov"],
                (ConnectorType.CCS2, 1, 25.00m, 0.46m),
                (ConnectorType.CHAdeMO, 1, 25.00m, 0.46m),
                (ConnectorType.Type2, 3, 22.00m, 0.41m));

            AddConnectors(
                connectors,
                ChargingStationIds["Eldrive Gazprom Tsarigradsko"],
                (ConnectorType.CCS2, 1, 50.00m, 0.46m),
                (ConnectorType.CHAdeMO, 1, 50.00m, 0.46m));

            AddConnectors(
                connectors,
                ChargingStationIds["Eldrive KFC Sofia"],
                (ConnectorType.CCS2, 1, 50.00m, 0.46m),
                (ConnectorType.CHAdeMO, 1, 50.00m, 0.46m));

            AddConnectors(
                connectors,
                ChargingStationIds["Eldrive Sheynovo"],
                (ConnectorType.CCS2, 2, 25.00m, 0.46m),
                (ConnectorType.CHAdeMO, 2, 25.00m, 0.46m));

            AddConnectors(
                connectors,
                ChargingStationIds["Eldrive Fantastico Dragalevtsi"],
                (ConnectorType.CCS2, 1, 25.00m, 0.46m),
                (ConnectorType.CHAdeMO, 1, 25.00m, 0.46m),
                (ConnectorType.Type2, 1, 22.00m, 0.41m));

            AddConnectors(
                connectors,
                ChargingStationIds["Eldrive Fantastico Bankya"],
                (ConnectorType.CCS2, 1, 50.00m, 0.46m),
                (ConnectorType.CHAdeMO, 1, 50.00m, 0.46m));

            AddConnectors(
                connectors,
                ChargingStationIds["Eldrive Metro Sofia Voluyak"],
                (ConnectorType.Type2, 2, 22.00m, 0.41m));

            AddConnectors(
                connectors,
                ChargingStationIds["Eldrive Mall Plovdiv"],
                (ConnectorType.CCS2, 1, 50.00m, 0.46m),
                (ConnectorType.CHAdeMO, 1, 50.00m, 0.46m));

            AddConnectors(
                connectors,
                ChargingStationIds["Eldrive VIA Park Plovdiv"],
                (ConnectorType.CCS2, 2, 50.00m, 0.46m),
                (ConnectorType.CHAdeMO, 2, 50.00m, 0.46m),
                (ConnectorType.CCS2, 1, 22.00m, 0.46m),
                (ConnectorType.Type2, 1, 22.00m, 0.41m));

            AddConnectors(
                connectors,
                ChargingStationIds["Eldrive Haas Plovdiv"],
                (ConnectorType.CCS2, 1, 24.00m, 0.46m));

            AddConnectors(
                connectors,
                ChargingStationIds["Eldrive HomeMax Plovdiv"],
                (ConnectorType.Type2, 2, 22.00m, 0.41m));

            AddConnectors(
                connectors,
                ChargingStationIds["Eldrive Gazprom Plovdiv"],
                (ConnectorType.CCS2, 1, 50.00m, 0.46m),
                (ConnectorType.CHAdeMO, 1, 50.00m, 0.46m));

            AddConnectors(
                connectors,
                ChargingStationIds["Eldrive Shell Maritsa"],
                (ConnectorType.CCS2, 1, 50.00m, 0.46m),
                (ConnectorType.CHAdeMO, 1, 50.00m, 0.46m));

            AddConnectors(
                connectors,
                ChargingStationIds["Eldrive DKS Varna"],
                (ConnectorType.CCS2, 1, 50.00m, 0.46m),
                (ConnectorType.CHAdeMO, 1, 50.00m, 0.46m));

            AddConnectors(
                connectors,
                ChargingStationIds["Eldrive Landmark Centre Varna"],
                (ConnectorType.Type2, 1, 22.00m, 0.41m));

            AddConnectors(
                connectors,
                ChargingStationIds["Eldrive Metro Varna"],
                (ConnectorType.Type2, 2, 22.00m, 0.41m));

            AddConnectors(
                connectors,
                ChargingStationIds["Eldrive HomeMax Varna"],
                (ConnectorType.Type2, 1, 22.00m, 0.41m));

            AddConnectors(
                connectors,
                ChargingStationIds["Eldrive Moto-Pfohe Varna"],
                (ConnectorType.CCS2, 1, 20.00m, 0.46m),
                (ConnectorType.CHAdeMO, 1, 20.00m, 0.46m),
                (ConnectorType.Type2, 1, 22.00m, 0.41m));

            AddConnectors(
                connectors,
                ChargingStationIds["Eldrive Business Park Varna"],
                (ConnectorType.Type2, 2, 22.00m, 0.41m));

            AddConnectors(
                connectors,
                ChargingStationIds["Eldrive Shell Ruse"],
                (ConnectorType.CCS2, 1, 50.00m, 0.46m),
                (ConnectorType.CHAdeMO, 1, 50.00m, 0.46m));

            AddConnectors(
                connectors,
                ChargingStationIds["Eldrive Metro Ruse"],
                (ConnectorType.Type2, 2, 22.00m, 0.41m));

            AddConnectors(
                connectors,
                ChargingStationIds["Eldrive Metro Pleven"],
                (ConnectorType.Type2, 2, 22.00m, 0.41m));

            AddConnectors(
                connectors,
                ChargingStationIds["Eldrive America for Bulgaria Student Center"],
                (ConnectorType.Type2, 2, 22.00m, 0.41m));

            AddConnectors(
                connectors,
                ChargingStationIds["Eldrive Metro Blagoevgrad"],
                (ConnectorType.Type2, 2, 22.00m, 0.41m));

            AddConnectors(
                connectors,
                ChargingStationIds["Eldrive Panairski Livadi"],
                (ConnectorType.CCS2, 2, 180.00m, 0.46m));

            AddConnectors(
                connectors,
                ChargingStationIds["Eldrive Nayden Gerov Bansko"],
                (ConnectorType.Type2, 4, 22.00m, 0.41m));

            AddConnectors(
                connectors,
                ChargingStationIds["Eldrive Gazprom Bansko"],
                (ConnectorType.CCS2, 1, 50.00m, 0.46m),
                (ConnectorType.CHAdeMO, 1, 50.00m, 0.46m));

            AddConnectors(
                connectors,
                ChargingStationIds["Eldrive Slivnitsa Municipality"],
                (ConnectorType.Type2, 1, 22.00m, 0.41m));

            AddConnectors(
                connectors,
                ChargingStationIds["Eldrive Abritus Razgrad"],
                (ConnectorType.Type2, 1, 22.00m, 0.41m));

            AddConnectors(
                connectors,
                ChargingStationIds["Eldrive Razgrad Center"],
                (ConnectorType.Type2, 1, 22.00m, 0.41m));

            AddConnectors(
                connectors,
                ChargingStationIds["Eldrive Hotel Serdika Silistra"],
                (ConnectorType.CCS2, 1, 50.00m, 0.46m));

            AddConnectors(
                connectors,
                ChargingStationIds["Eldrive Cedar Lovech"],
                (ConnectorType.CCS2, 2, 120.00m, 0.46m));

            AddConnectors(
                connectors,
                ChargingStationIds["Eldrive Billa Troyan"],
                (ConnectorType.CCS2, 2, 50.00m, 0.46m));

            AddConnectors(
                connectors,
                ChargingStationIds["Eldrive Retail Park Smolyan"],
                (ConnectorType.CCS2, 2, 120.00m, 0.46m));

            AddConnectors(
                connectors,
                ChargingStationIds["Eldrive Shell Shumen"],
                (ConnectorType.CCS2, 1, 50.00m, 0.46m),
                (ConnectorType.CHAdeMO, 1, 50.00m, 0.46m));

            AddConnectors(
                connectors,
                ChargingStationIds["Eldrive Shell Pravets"],
                (ConnectorType.CCS2, 1, 50.00m, 0.46m),
                (ConnectorType.CHAdeMO, 1, 50.00m, 0.46m));

            AddConnectors(
                connectors,
                ChargingStationIds["Eldrive Shell Enevo North"],
                (ConnectorType.CCS2, 1, 50.00m, 0.46m),
                (ConnectorType.CHAdeMO, 1, 50.00m, 0.46m));

            AddConnectors(
                connectors,
                ChargingStationIds["Eldrive Santa Marina Holiday Village"],
                (ConnectorType.CCS2, 1, 24.00m, 0.46m));

            AddConnectors(
                connectors,
                ChargingStationIds["Eldrive Swimming Complex Flora"],
                (ConnectorType.CCS2, 1, 24.00m, 0.46m));

            AddConnectors(
                connectors,
                ChargingStationIds["Eldrive Rodopi Burgas"],
                (ConnectorType.CCS2, 1, 24.00m, 0.46m));

            AddConnectors(
                connectors,
                ChargingStationIds["Eldrive Borisova Gradina"],
                (ConnectorType.CCS2, 3, 24.00m, 0.46m));

            AddConnectors(
                connectors,
                ChargingStationIds["Eldrive Boycho Branzov"],
                (ConnectorType.CCS2, 1, 50.00m, 0.46m));

            AddConnectors(
                connectors,
                ChargingStationIds["Eldrive Parking Gurko"],
                (ConnectorType.CCS2, 1, 25.00m, 0.46m),
                (ConnectorType.CHAdeMO, 1, 25.00m, 0.46m),
                (ConnectorType.Type2, 1, 22.00m, 0.41m));

            return connectors.ToArray();
        }


        private static void AddConnectorsWithExternalIds(
            List<Connector> connectors,
            int ChargingStationId,
            params (
                ConnectorType Type,
                decimal PowerKw,
                decimal PricePerKWh,
                string? ExternalId)[] connectorData)
        {
            int connectorNumber = 1;

            foreach ((
                ConnectorType Type,
                decimal PowerKw,
                decimal PricePerKWh,
                string? ExternalId) connectorInfo in connectorData)
            {
                Connector connector = new Connector
                {
                    ConnectorNumber = connectorNumber,
                    ConnectorType = connectorInfo.Type,
                    PowerKw = connectorInfo.PowerKw,
                    PricePerKWh = connectorInfo.PricePerKWh,
                    ConnectorStatus = ConnectorStatus.Unknown,
                    ExternalId = connectorInfo.ExternalId,
                    ChargingStationId = ChargingStationId
                };

                connectors.Add(connector);
                connectorNumber++;
            }
        }


        private static void AddConnectors(
            List<Connector> connectors,
            int ChargingStationId,
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
                        ChargingStationId = ChargingStationId
                    };

                    connectors.Add(connector);
                    connectorNumber++;
                }
            }
        }
    }
}
