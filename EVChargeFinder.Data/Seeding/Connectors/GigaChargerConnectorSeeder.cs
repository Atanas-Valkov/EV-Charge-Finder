namespace EVChargeFinder.Data.Seeding.Connectors
{
    using DbModels;
    using DbModels.Enums;

    public static class GigaChargerConnectorSeeder
    {
 
        public static Connector[] GetConnectors(
            Dictionary<string, int> ChargingStationIds)
        {
            List<Connector> connectors = new List<Connector>();

           
            AddConnectors(
              connectors,
              ChargingStationIds["GigaCharger Vrabnitsa 1, bl. 525"],
              (ConnectorType.Type2, 1, 22.00m, 0.25m));

         
            AddConnectors(
            connectors,
            ChargingStationIds["GigaCharger Serdika, bl. 15"],
            (ConnectorType.Type2, 1, 22.00m, 0.25m));

            AddConnectors(
                connectors,
                ChargingStationIds["GigaCharger Mladost 4"],
                (ConnectorType.Type2, 1, 7.20m, 0.25m));

            AddConnectors(
              connectors,
              ChargingStationIds["GigaCharger Trudolyubie 7"],
              (ConnectorType.Type2, 1, 7.20m, 0.25m));

            AddConnectors(
              connectors,
              ChargingStationIds["GigaCharger Geo Milev, bl. 245"],
              (ConnectorType.Type2, 1, 7.20m, 0.25m));


            AddConnectors(
              connectors,
              ChargingStationIds["GigaCharger Druzhba 1, bl. 137"],
              (ConnectorType.Type2, 1, 7.20m, 0.25m));

           
            AddConnectors(
              connectors,
              ChargingStationIds["GigaCharger Mladost 1, bl. 94"],
              (ConnectorType.Type2, 1, 7.20m, 0.25m));


            AddConnectors(
              connectors,
              ChargingStationIds["GigaCharger Ilientsi 2"],
              (ConnectorType.Type2, 1, 7.20m, 0.25m));

        
            AddConnectors(
              connectors,
              ChargingStationIds["GigaCharger Ivats 12"],
              (ConnectorType.Type2, 1, 7.20m, 0.25m));

       
            AddConnectors(
              connectors,
              ChargingStationIds["GigaCharger Restaurant Bulgarche"],
              (ConnectorType.Type2, 1, 7.20m, 0.25m));

       
            AddConnectors(
              connectors,
              ChargingStationIds["GigaCharger Mutkurova 119"],
              (ConnectorType.Type2, 1, 7.20m, 0.25m));

            AddConnectors(
              connectors,
              ChargingStationIds["GigaCharger Proektantska"],
              (ConnectorType.Type2, 1, 7.20m, 0.25m));

            AddConnectors(
              connectors,
              ChargingStationIds["GigaCharger Borisova - Rila"],
              (ConnectorType.Type2, 1, 7.20m, 0.25m));

            AddConnectors(
                connectors,
                ChargingStationIds["GigaCharger Hotel Riga"],
                (ConnectorType.Type2, 1, 22.00m, 0.25m));

         
            AddConnectors(
              connectors,
              ChargingStationIds["GigaCharger Bl. Madara"],
              (ConnectorType.Type2, 1, 7.20m, 0.25m));

        
            AddConnectors(
              connectors,
              ChargingStationIds["GigaCharger Complex Dunav"],
              (ConnectorType.Type2, 1, 7.20m, 0.25m));


            AddConnectors(
              connectors,
              ChargingStationIds["GigaCharger Hotel Crystal"],
              (ConnectorType.Type2, 1, 7.20m, 0.25m));

            AddConnectors(
              connectors,
              ChargingStationIds["GigaCharger Gergana bl."],
              (ConnectorType.Type2, 1, 7.20m, 0.25m));

            AddConnectors(
              connectors,
              ChargingStationIds["GigaCharger Petrohan bl."],
              (ConnectorType.Type2, 1, 7.20m, 0.25m));

 
            AddConnectors(
              connectors,
              ChargingStationIds["GigaCharger Basein Dunav"],
              (ConnectorType.Type2, 1, 7.20m, 0.25m));


            AddConnectors(
              connectors,
              ChargingStationIds["GigaCharger Dragoman 6"],
              (ConnectorType.Type2, 1, 7.20m, 0.25m));


            AddConnectors(
              connectors,
              ChargingStationIds["GigaCharger Restaurant Terasa"],
              (ConnectorType.Type2, 1, 7.20m, 0.25m));

            AddConnectors(
              connectors,
              ChargingStationIds["GigaCharger Alei Vazrazhdane 32"],
              (ConnectorType.Type2, 1, 7.20m, 0.25m));

          
            AddConnectors(
              connectors,
              ChargingStationIds["GigaCharger Graf Ignatiev 8"],
              (ConnectorType.Type2, 1, 7.20m, 0.25m));

            AddConnectors(
                connectors,
                ChargingStationIds["GigaCharger Vazrazhdane 27"],
                (ConnectorType.Type2, 1, 7.00m, 0.25m));


            AddConnectors(
              connectors,
              ChargingStationIds["GigaCharger Chaika, bl. 68"],
              (ConnectorType.Type2, 1, 7.20m, 0.25m));


            AddConnectors(
              connectors,
              ChargingStationIds["GigaCharger Carwash Rikar"],
              (ConnectorType.Type2, 1, 7.20m, 0.25m));

            AddConnectors(
                connectors,
                ChargingStationIds["GigaCharger Vazrazhdane 4"],
                (ConnectorType.Type2, 1, 7.00m, 0.25m));


            AddConnectors(
              connectors,
              ChargingStationIds["GigaCharger Simfoniya"],
              (ConnectorType.Type2, 1, 7.20m, 0.25m));

            AddConnectors(
              connectors,
              ChargingStationIds["GigaCharger Eskana"],
              (ConnectorType.Type2, 1, 7.20m, 0.25m));


            AddConnectors(
              connectors,
              ChargingStationIds["GigaCharger Graf Ignatiev 17"],
              (ConnectorType.Type2, 1, 7.20m, 0.25m));

            AddConnectors(
              connectors,
              ChargingStationIds["GigaCharger Bumer-85"],
              (ConnectorType.Type2, 1, 7.20m, 0.25m));

            AddConnectors(
              connectors,
              ChargingStationIds["GigaCharger Obzor 4"],
              (ConnectorType.Type2, 1, 7.20m, 0.25m));


            AddConnectors(
              connectors,
              ChargingStationIds["GigaCharger FKC"],
              (ConnectorType.Type2, 1, 7.20m, 0.25m));

            AddConnectors(
                connectors,
                ChargingStationIds["GigaCharger Graf Ignatiev 33"],
                (ConnectorType.Type2, 1, 22.00m, 0.25m));


            AddConnectors(
              connectors,
              ChargingStationIds["GigaCharger Baruten Pogreb"],
              (ConnectorType.Type2, 1, 7.20m, 0.25m));


            AddConnectors(
              connectors,
              ChargingStationIds["GigaCharger Doyran 2 Garage"],
              (ConnectorType.Type2, 1, 7.20m, 0.25m));

            AddConnectors(
              connectors,
              ChargingStationIds["GigaCharger Mladost, bl. 121"],
              (ConnectorType.Type2, 1, 7.20m, 0.25m));


            AddConnectors(
              connectors,
              ChargingStationIds["GigaCharger Troshevo, bl. 18"],
              (ConnectorType.Type2, 1, 7.20m, 0.25m));

            AddConnectors(
                connectors,
                ChargingStationIds["GigaCharger Perperikon 4"],
                (ConnectorType.Type2, 1, 22.00m, 0.25m));

            AddConnectors(
                connectors,
                ChargingStationIds["GigaCharger Pchelina"],
                (ConnectorType.Type2, 1, 7.00m, 0.25m));


            AddConnectors(
              connectors,
              ChargingStationIds["GigaCharger Shagy Carpets"],
              (ConnectorType.Type2, 1, 7.20m, 0.25m));

            AddConnectors(
                connectors,
                ChargingStationIds["GigaCharger Naiden Gerov 10"],
                (ConnectorType.Type2, 1, 7.00m, 0.25m));

            AddConnectors(
              connectors,
              ChargingStationIds["GigaCharger Velikova"],
              (ConnectorType.Type2, 1, 7.20m, 0.25m));

            AddConnectors(
                connectors,
                ChargingStationIds["GigaCharger Kaylaka Park Hotel"],
                (ConnectorType.Type2, 1, 22.00m, 0.25m));

            AddConnectors(
              connectors,
              ChargingStationIds["GigaCharger Bratya Miladinovi, bl. 18"],
              (ConnectorType.Type2, 1, 7.20m, 0.25m));


            AddConnectors(
              connectors,
              ChargingStationIds["GigaCharger Office Networx"],
              (ConnectorType.Type2, 1, 7.20m, 0.25m));


            AddConnectors(
              connectors,
              ChargingStationIds["GigaCharger Drastar Oil"],
              (ConnectorType.Type2, 1, 7.20m, 0.25m));


            AddConnectors(
              connectors,
              ChargingStationIds["GigaCharger Lex 351"],
              (ConnectorType.Type2, 1, 7.20m, 0.25m));

            AddConnectors(
              connectors,
              ChargingStationIds["GigaCharger Troyan Plaza Hotel"],
              (ConnectorType.Type2, 1, 7.20m, 0.25m));

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
