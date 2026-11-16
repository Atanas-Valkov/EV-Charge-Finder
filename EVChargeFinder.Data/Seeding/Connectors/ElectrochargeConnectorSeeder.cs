namespace EVChargeFinder.Data.Seeding.Connectors
{
    using DbModels;
    using DbModels.Enums;

    public static class ElectrochargeConnectorSeeder
    {
        public static Connector[] GetConnectors(Dictionary<string, int> ChargingStationIds)
        {
            List<Connector> connectors = new List<Connector>();

            AddConnectors(
                connectors,
                ChargingStationIds["Electrocharge Plovdiv 320B"],
                (ConnectorType.CCS2, 2, 120.00m, 0.39m),
                (ConnectorType.Type2, 1, 22.00m, 0.35m));


            AddConnectors(
                connectors,
                ChargingStationIds["Electrocharge Lozen Saedinenie 127"],
                (ConnectorType.Type2, 1, 22.00m, 0.35m));

            AddConnectors(
                connectors,
                ChargingStationIds["Electrocharge 109th Street 266"],
                (ConnectorType.Type2, 1, 22.00m, 0.35m));

            AddConnectors(
                connectors,
                ChargingStationIds["Electrocharge Mladost 526"],
                (ConnectorType.Type2, 1, 22.00m, 0.35m));

            AddConnectors(
                connectors,
                ChargingStationIds["Electrocharge Pchela 212"],
                (ConnectorType.Type2, 1, 22.00m, 0.35m));

            AddConnectors(
                connectors,
                ChargingStationIds["Electrocharge Braila 11"],
                (ConnectorType.Type2, 1, 22.00m, 0.35m));

            AddConnectors(
                connectors,
                ChargingStationIds["Electrocharge Orion 84"],
                (ConnectorType.Type2, 1, 22.00m, 0.35m));

            AddConnectors(
                connectors,
                ChargingStationIds["Electrocharge Simitli"],
                (ConnectorType.CCS2, 2, 120.00m, 0.39m),
                (ConnectorType.Type2, 1, 22.00m, 0.35m));

          
            AddConnectors(
                connectors,
                ChargingStationIds["Electrocharge Petrol Kulata"],
                (ConnectorType.CCS2, 2, 120.00m, 0.39m),
                (ConnectorType.Type2, 1, 22.00m, 0.35m));

            AddConnectors(
                connectors,
                ChargingStationIds["Electrocharge Lukovit"],
                (ConnectorType.CCS2, 2, 120.00m, 0.39m),
                (ConnectorType.Type2, 1, 22.00m, 0.35m));

            AddConnectors(
                connectors,
                ChargingStationIds["Electrocharge Lom"],
                (ConnectorType.CCS2, 2, 120.00m, 0.39m),
                (ConnectorType.Type2, 1, 22.00m, 0.35m));

            return connectors.ToArray();
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
