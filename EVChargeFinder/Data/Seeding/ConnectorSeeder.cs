using EVChargeFinder.Data.Seeding.ChargingStations;

namespace EVChargeFinder.Data.Seeding
{
    using EVChargeFinder.Data.Seeding.Connectors;
    using EVChargeFinder.DbModels;
    using Microsoft.EntityFrameworkCore;

    public static class ConnectorSeeder
    {
        public static void Seed(ApplicationDbContext context)
        {
            Dictionary<string, int> ChargingStationIds = context.ChargingStations
                .AsNoTracking()
                .ToDictionary(
                    cs => cs.Name,
                    cs => cs.Id);


            List<Connector> connectors = new List<Connector>();


            connectors.AddRange(FinesConnectorSeeder.GetConnectors(ChargingStationIds));

            connectors.AddRange(EldriveConnectorSeeder.GetConnectors(ChargingStationIds));

            connectors.AddRange(ElectripConnectorSeeder.GetConnectors(ChargingStationIds));

            connectors.AddRange(EVPointConnectorSeeder.GetConnectors(ChargingStationIds));

            connectors.AddRange(GigaChargerConnectorSeeder.GetConnectors(ChargingStationIds));

            connectors.AddRange(ElectrochargeConnectorSeeder.GetConnectors(ChargingStationIds));

            connectors.AddRange(OMVeMotionConnectorSeeder.GetConnectors(ChargingStationIds));
          
            connectors.AddRange(ElfinityConnectorSeeder.GetConnectors(ChargingStationIds));

            connectors.AddRange(KiaHyperchargeConnectorSeeder.GetConnectors(ChargingStationIds));

            connectors.AddRange(GPStationConnectorSeeder.GetConnectors(ChargingStationIds));
           
            connectors.AddRange(WINKChargingConnectorSeeder.GetConnectors(ChargingStationIds));
           
            connectors.AddRange(VoltspotConnectorSeeder.GetConnectors(ChargingStationIds));
            
            connectors.AddRange(EVN2GOConnectorSeeder.GetConnectors(ChargingStationIds));
            
            connectors.AddRange(TeslaSuperchargerConnectorSeeder.GetConnectors(ChargingStationIds));
            
            connectors.AddRange(VarnaChargingConnectorSeeder.GetConnectors(ChargingStationIds));
            
            connectors.AddRange(BullChargeConnectorSeeder.GetConnectors(ChargingStationIds));
            
            connectors.AddRange(eCarsConnectorSeeder.GetConnectors(ChargingStationIds));
           
            connectors.AddRange(ProCreditChargingConnectorSeeder.GetConnectors(ChargingStationIds));

            List<Connector> existingConnectors = context.Connectors
                .ToList();


            Dictionary<
                (int ChargingStationId, int ConnectorNumber),
                Connector> existingConnectorsByKey =
                    existingConnectors.ToDictionary(
                        c => (
                            c.ChargingStationId,
                            c.ConnectorNumber),
                        c => c);


            List<Connector> connectorsToAdd =
                new List<Connector>();


            foreach (Connector connector in connectors)
            {
                (
                    int ChargingStationId,
                    int ConnectorNumber
                ) connectorKey =
                (
                    connector.ChargingStationId,
                    connector.ConnectorNumber
                );


                if (existingConnectorsByKey.TryGetValue(
                    connectorKey,
                    out Connector? existingConnector))
                {
                    existingConnector.ConnectorType =
                        connector.ConnectorType;

                    existingConnector.PowerKw =
                        connector.PowerKw;

                    existingConnector.PricePerKWh =
                        connector.PricePerKWh;


                    if (connector.ExternalId != null)
                    {
                        existingConnector.ExternalId =
                            connector.ExternalId;
                    }


                    continue;
                }


                connectorsToAdd.Add(connector);

                existingConnectorsByKey.Add(
                    connectorKey,
                    connector);
            }


            if (connectorsToAdd.Count > 0)
            {
                context.Connectors.AddRange(
                    connectorsToAdd);
            }


            context.SaveChanges();
        }
    }
}