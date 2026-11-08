namespace EVChargeFinder.Data.Seeding.Connectors
{
    using DbModels;
    using DbModels.Enums;

    public static class ElectripConnectorSeeder
    {
        public static Connector[] GetConnectors(
            Dictionary<string, int> ChargingStationIds)
        {
            List<Connector> connectors = new List<Connector>();

            AddConnectors(
                connectors,
                ChargingStationIds["Electrip Plovdiv Plaza Mall"],
                (ConnectorType.CCS2, 4, 60.00m, 0.38m),
                (ConnectorType.Type2, 2, 22.00m, 0.33m));

            AddConnectors(
                connectors,
                ChargingStationIds["Electrip Hotel Ostrova Plovdiv"],
                (ConnectorType.Type2, 2, 22.00m, 0.33m));

            AddConnectors(
                connectors,
                ChargingStationIds["Electrip Grand Hotel Plovdiv"],
                (ConnectorType.CCS2, 3, 60.00m, 0.38m),
                (ConnectorType.Type2, 3, 22.00m, 0.33m));

            AddConnectors(
                connectors,
                ChargingStationIds["Electrip Flavia Business Park"],
                (ConnectorType.CCS2, 2, 60.00m, 0.38m));

            AddConnectors(
                connectors,
                ChargingStationIds["Electrip MegaLux Plovdiv"],
                (ConnectorType.CCS2, 2, 60.00m, 0.38m));

            AddConnectors(
                connectors,
                ChargingStationIds["Electrip Hotel Antique Plovdiv"],
                (ConnectorType.Type2, 2, 11.00m, 0.33m));

            AddConnectors(
                connectors,
                ChargingStationIds["Electrip Royal City Plovdiv"],
                (ConnectorType.CCS2, 4, 60.00m, 0.38m));

            AddConnectors(
                connectors,
                ChargingStationIds["Electrip Retail Park Karlovo"],
                (ConnectorType.CCS2, 4, 180.00m, 0.40m),
                (ConnectorType.Type2, 2, 22.00m, 0.33m));

            AddConnectors(
                connectors,
                ChargingStationIds["Electrip Yantra Grand Hotel"],
                (ConnectorType.Type2, 2, 22.00m, 0.33m));

            AddConnectors(
                connectors,
                ChargingStationIds["Electrip Hotel Kalina Palace"],
                (ConnectorType.Type2, 2, 22.00m, 0.33m));

            AddConnectors(
                connectors,
                ChargingStationIds["Electrip Midalidare Hotel & SPA"],
                (ConnectorType.Type2, 2, 22.00m, 0.33m));

            AddConnectors(
                connectors,
                ChargingStationIds["Electrip Rompetrol Nova Zagora"],
                (ConnectorType.CCS2, 4, 400.00m, 0.40m));

            AddConnectors(
                connectors,
                ChargingStationIds["Electrip Prohoda Gurkovo Complex"],
                (ConnectorType.CCS2, 2, 60.00m, 0.38m));

            AddConnectors(
                connectors,
                ChargingStationIds["Electrip Shell Pirdop"],
                (ConnectorType.CCS2, 2, 60.00m, 0.38m));

            AddConnectors(
                connectors,
                ChargingStationIds["Electrip Retail Park Targovishte"],
                (ConnectorType.CCS2, 1, 60.00m, 0.38m));

            AddConnectors(
                connectors,
                ChargingStationIds["Electrip Retail Park Troyan"],
                (ConnectorType.CCS2, 2, 60.00m, 0.38m),
                (ConnectorType.Type2, 3, 22.00m, 0.33m));

            AddConnectors(
                connectors,
                ChargingStationIds["Electrip Hotel Ostrova Troyan"],
                (ConnectorType.Type2, 1, 22.00m, 0.33m));

            AddConnectors(
                connectors,
                ChargingStationIds["Electrip Hotel Valor Montana"],
                (ConnectorType.Type2, 2, 11.00m, 0.33m));

            AddConnectors(
                connectors,
                ChargingStationIds["Electrip Stil Lux Yambol"],
                (ConnectorType.CCS2, 2, 60.00m, 0.38m));

            AddConnectors(
                connectors,
                ChargingStationIds["Electrip Mall Pernik"],
                (ConnectorType.CCS2, 1, 60.00m, 0.38m),
                (ConnectorType.Type2, 2, 22.00m, 0.33m));

            AddConnectors(
                connectors,
                ChargingStationIds["Electrip Technomarket Varna"],
                (ConnectorType.CCS2, 2, 60.00m, 0.38m));

            AddConnectors(
                connectors,
                ChargingStationIds["Electrip Varna Towers"],
                (ConnectorType.Type2, 2, 22.00m, 0.33m));

            AddConnectors(
                connectors,
                ChargingStationIds["Electrip Melia Grand Hermitage"],
                (ConnectorType.CCS2, 1, 60.00m, 0.38m),
                (ConnectorType.Type2, 1, 22.00m, 0.33m));

            AddConnectors(
                connectors,
                ChargingStationIds["Electrip Hotel Fantasia Haskovo"],
                (ConnectorType.Type2, 2, 22.00m, 0.33m));


            AddConnectors(
                connectors,
                ChargingStationIds["Electrip Katarzyna Estate"],
                (ConnectorType.CCS2, 1, 60.00m, 0.38m),
                (ConnectorType.Type2, 3, 22.00m, 0.33m));

            AddConnectors(
                connectors,
                ChargingStationIds["Electrip Merit Grand Mosta Hotel Casino & Spa"],
                (ConnectorType.CCS2, 1, 60.00m, 0.38m),
                (ConnectorType.Type2, 2, 22.00m, 0.33m));

            AddConnectors(
                connectors,
                ChargingStationIds["Electrip Pirin Park Hotel"],
                (ConnectorType.Type2, 2, 22.00m, 0.33m));

            AddConnectors(
                connectors,
                ChargingStationIds["Electrip Hotel Cornelia Deluxe"],
                (ConnectorType.Type2, 2, 22.00m, 0.33m));

            AddConnectors(
                connectors,
                ChargingStationIds["Electrip Ruskovets Thermal SPA & Ski Resort"],
                (ConnectorType.CCS2, 2, 60.00m, 0.38m),
                (ConnectorType.Type2, 2, 22.00m, 0.33m));

            AddConnectors(
                connectors,
                ChargingStationIds["Electrip SPA Resort St. Ivan Rilski"],
                (ConnectorType.Type2, 1, 22.00m, 0.33m));

            AddConnectors(
                connectors,
                ChargingStationIds["Electrip Hotel Yastrebets Wellness & Spa"],
                (ConnectorType.Type2, 2, 22.00m, 0.33m));

            AddConnectors(
                connectors,
                ChargingStationIds["Electrip Retail Park Razlog"],
                (ConnectorType.CCS2, 2, 60.00m, 0.38m),
                (ConnectorType.Type2, 2, 22.00m, 0.33m));

            AddConnectors(
                connectors,
                ChargingStationIds["Electrip Petrol 7315 Struma Highway"],
                (ConnectorType.CCS2, 2, 180.00m, 0.40m));

            AddConnectors(
                connectors,
                ChargingStationIds["Electrip Kruiz Blagoevgrad"],
                (ConnectorType.CCS2, 1, 60.00m, 0.38m));

            AddConnectors(
                connectors,
                ChargingStationIds["Electrip Gotse Delchev Petrol Station"],
                (ConnectorType.CCS2, 1, 180.00m, 0.40m));

            AddConnectors(
                connectors,
                ChargingStationIds["Electrip Complex Komitite"],
                (ConnectorType.CCS2, 2, 240.00m, 0.40m));

            AddConnectors(
                connectors,
                ChargingStationIds["Electrip Petrol Kulata"],
                (ConnectorType.CCS2, 2, 240.00m, 0.40m));

            AddConnectors(
                connectors,
                ChargingStationIds["Electrip Kruiz Petrich"],
                (ConnectorType.CCS2, 1, 60.00m, 0.38m));

            AddConnectors(
                connectors,
                ChargingStationIds["Electrip Kruiz Chepelare"],
                (ConnectorType.CCS2, 2, 180.00m, 0.40m));

            AddConnectors(
                connectors,
                ChargingStationIds["Electrip Grand Hotel Murgavets"],
                (ConnectorType.CCS2, 1, 60.00m, 0.38m),
                (ConnectorType.Type2, 2, 22.00m, 0.33m));

            AddConnectors(
                connectors,
                ChargingStationIds["Electrip Hotel Nero"],
                (ConnectorType.CCS2, 1, 60.00m, 0.38m),
                (ConnectorType.Type2, 2, 22.00m, 0.33m));

            AddConnectors(
                connectors,
                ChargingStationIds["Electrip Spa Hotel Devin"],
                (ConnectorType.Type2, 2, 22.00m, 0.33m));

            AddConnectors(
                connectors,
                ChargingStationIds["Electrip Sol Luna Bay Resort"],
                (ConnectorType.Type2, 4, 11.00m, 0.33m));

            AddConnectors(
                connectors,
                ChargingStationIds["Electrip Sol Nessebar Bay"],
                (ConnectorType.Type2, 2, 22.00m, 0.33m));

            AddConnectors(
                connectors,
                ChargingStationIds["Electrip Cacao Beach"],
                (ConnectorType.Type2, 3, 22.00m, 0.33m));

            AddConnectors(
                connectors,
                ChargingStationIds["Electrip Hotel Dune"],
                (ConnectorType.Type2, 2, 22.00m, 0.33m));

            AddConnectors(
                connectors,
                ChargingStationIds["Electrip Hotel Orlova Skala"],
                (ConnectorType.Type2, 1, 22.00m, 0.33m));

            AddConnectors(
                connectors,
                ChargingStationIds["Electrip Hotel Tsarska Banya"],
                (ConnectorType.Type2, 2, 22.00m, 0.33m));

            AddConnectors(
                connectors,
                ChargingStationIds["Electrip Hotel EMAR"],
                (ConnectorType.Type2, 1, 11.00m, 0.33m));

            AddConnectors(
                connectors,
                ChargingStationIds["Electrip Retail Park Silistra"],
                (ConnectorType.CCS2, 2, 60.00m, 0.38m));

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
