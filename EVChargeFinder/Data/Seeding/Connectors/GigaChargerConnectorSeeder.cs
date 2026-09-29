namespace EVChargeFinder.Data.Seeding.Connectors
{
    using DbModels;
    using DbModels.Enums;

    public static class GigaChargerConnectorSeeder
    {
      private const decimal DefaultPricePerKWh = 0.25m;

        public static Connector[] GetConnectors(
            Dictionary<string, int> chargeStationIds)
        {
            List<Connector> connectors = new List<Connector>();

            // TODO: "GigaCharger Vrabnitsa 1, bl. 525"
            // Exact connector count/type/power is intentionally not seeded until it is verified.

            // TODO: "GigaCharger Serdika, bl. 15"
            // GigaCharger AC location is confirmed, but exact connector count/power is not verified.

            AddConnectors(
                connectors,
                chargeStationIds["GigaCharger Mladost 4"],
                (ConnectorType.Type2, 1, 7.20m, DefaultPricePerKWh));

            // TODO: "GigaCharger Trudolyubie 7"
            // Exact connector count/type/power is intentionally not seeded until it is verified.

            // TODO: "GigaCharger Geo Milev, bl. 245"
            // GigaCharger AC location is confirmed, but exact connector count/power is not verified.

            // TODO: "GigaCharger Druzhba 1, bl. 137"
            // GigaCharger AC location is confirmed, but exact connector count/power is not verified.

            // TODO: "GigaCharger Mladost 1, bl. 94"
            // GigaCharger AC location is confirmed, but exact connector count/power is not verified.

            // TODO: "GigaCharger Ilientsi 2"
            // GigaCharger AC location is confirmed, but exact connector count/power is not verified.

            // TODO: "GigaCharger Ivats 12"
            // GigaCharger AC location is confirmed, but exact connector count/power is not verified.

            // TODO: "GigaCharger Restaurant Bulgarche"
            // GigaCharger AC location is confirmed, but exact connector count/power is not verified.

            // TODO: "GigaCharger Mutkurova 119"
            // GigaCharger AC location is confirmed, but exact connector count/power is not verified.

            // TODO: "GigaCharger Proektantska"
            // GigaCharger AC location is confirmed, but exact connector count/power is not verified.

            // TODO: "GigaCharger Borisova - Rila"
            // GigaCharger AC location is confirmed, but exact connector count/power is not verified.

            AddConnectors(
                connectors,
                chargeStationIds["GigaCharger Hotel Riga"],
                (ConnectorType.Type2, 1, 22.00m, DefaultPricePerKWh));

            // TODO: "GigaCharger Bl. Madara"
            // GigaCharger AC location is confirmed, but exact connector count/power is not verified.

            // TODO: "GigaCharger Complex Dunav"
            // GigaCharger AC location is confirmed, but exact connector count/power is not verified.

            // TODO: "GigaCharger Hotel Crystal"
            // GigaCharger AC location is confirmed, but exact connector count/power is not verified.

            // TODO: "GigaCharger Gergana bl."
            // GigaCharger AC location is confirmed, but exact connector count/power is not verified.

            // TODO: "GigaCharger Petrohan bl."
            // Exact connector count/type/power is intentionally not seeded until it is verified.

            // TODO: "GigaCharger Basein Dunav"
            // GigaCharger AC location is confirmed, but exact connector count/power is not verified.

            // TODO: "GigaCharger Dragoman 6"
            // GigaCharger AC location is confirmed, but exact connector count/power is not verified.

            // TODO: "GigaCharger Restaurant Terasa"
            // GigaCharger AC location is confirmed, but exact connector count/power is not verified.

            // TODO: "GigaCharger Alei Vazrazhdane 32"
            // GigaCharger AC location is confirmed, but exact connector count/power is not verified.

            // TODO: "GigaCharger Graf Ignatiev 8"
            // GigaCharger AC location is confirmed, but exact connector count/power is not verified.

            AddConnectors(
                connectors,
                chargeStationIds["GigaCharger Vazrazhdane 27"],
                (ConnectorType.Type2, 1, 7.00m, DefaultPricePerKWh));

            // TODO: "GigaCharger Chaika, bl. 68"
            // GigaCharger AC location is confirmed, but exact connector count/power is not verified.

            // TODO: "GigaCharger Carwash Rikar"
            // GigaCharger AC location is confirmed, but exact connector count/power is not verified.

            AddConnectors(
                connectors,
                chargeStationIds["GigaCharger Vazrazhdane 4"],
                (ConnectorType.Type2, 1, 7.00m, DefaultPricePerKWh));

            // TODO: "GigaCharger Simfoniya"
            // GigaCharger AC location is confirmed, but exact connector count/power is not verified.

            // TODO: "GigaCharger Eskana"
            // GigaCharger AC location is confirmed, but exact connector count/power is not verified.

            // TODO: "GigaCharger Graf Ignatiev 17"
            // Exact connector count/type/power is intentionally not seeded until it is verified.

            // TODO: "GigaCharger Bumer-85"
            // GigaCharger AC location is confirmed, but exact connector count/power is not verified.

            // TODO: "GigaCharger Obzor 4"
            // GigaCharger AC location is confirmed, but exact connector count/power is not verified.

            // TODO: "GigaCharger FKC"
            // GigaCharger AC location is confirmed, but exact connector count/power is not verified.

            AddConnectors(
                connectors,
                chargeStationIds["GigaCharger Graf Ignatiev 33"],
                (ConnectorType.Type2, 1, 22.00m, DefaultPricePerKWh));

            // TODO: "GigaCharger Baruten Pogreb"
            // GigaCharger AC location is confirmed, but exact connector count/power is not verified.

            // TODO: "GigaCharger Doyran 2 Garage"
            // GigaCharger AC location is confirmed, but exact connector count/power is not verified.

            // TODO: "GigaCharger Mladost, bl. 121"
            // GigaCharger AC location is confirmed, but exact connector count/power is not verified.

            // TODO: "GigaCharger Troshevo, bl. 18"
            // GigaCharger AC location is confirmed, but exact connector count/power is not verified.

            AddConnectors(
                connectors,
                chargeStationIds["GigaCharger Perperikon 4"],
                (ConnectorType.Type2, 1, 22.00m, DefaultPricePerKWh));

            AddConnectors(
                connectors,
                chargeStationIds["GigaCharger Pchelina"],
                (ConnectorType.Type2, 1, 7.00m, DefaultPricePerKWh));

            // TODO: "GigaCharger Shagy Carpets"
            // GigaCharger AC location is confirmed, but exact connector count/power is not verified.

            AddConnectors(
                connectors,
                chargeStationIds["GigaCharger Naiden Gerov 10"],
                (ConnectorType.Type2, 1, 7.00m, DefaultPricePerKWh));

            // TODO: "GigaCharger Velikova"
            // Exact connector count/type/power is intentionally not seeded until it is verified.

            AddConnectors(
                connectors,
                chargeStationIds["GigaCharger Kaylaka Park Hotel"],
                (ConnectorType.Type2, 1, 22.00m, DefaultPricePerKWh));

            // TODO: "GigaCharger Bratya Miladinovi, bl. 18"
            // GigaCharger AC location is confirmed, but exact connector count/power is not verified.

            // TODO: "GigaCharger Office Networx"
            // GigaCharger AC location is confirmed, but exact connector count/power is not verified.

            // TODO: "GigaCharger Drastar Oil"
            // GigaCharger AC location is confirmed, but exact connector count/power is not verified.

            // TODO: "GigaCharger Lex 351"
            // GigaCharger AC location is confirmed, but exact connector count/power is not verified.

            // TODO: "GigaCharger Troyan Plaza Hotel"
            // GigaCharger AC location is confirmed, but exact connector count/power is not verified.

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
