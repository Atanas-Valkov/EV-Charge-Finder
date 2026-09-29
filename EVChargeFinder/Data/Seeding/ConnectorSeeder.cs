using EVChargeFinder.Data.Seeding.ChargeStations;

namespace EVChargeFinder.Data.Seeding
{
    using EVChargeFinder.Data.Seeding.Connectors;
    using EVChargeFinder.DbModels;
    using Microsoft.EntityFrameworkCore;

    public static class ConnectorSeeder
    {
        public static void Seed(ApplicationDbContext context)
        {
            Dictionary<string, int> chargeStationIds = context.ChargeStations
                .AsNoTracking()
                .ToDictionary(
                    cs => cs.Name,
                    cs => cs.Id);


            List<Connector> connectors = new List<Connector>();


            connectors.AddRange(FinesConnectorSeeder.GetConnectors(chargeStationIds));

            connectors.AddRange(EldriveConnectorSeeder.GetConnectors(chargeStationIds));

            connectors.AddRange(ElectripConnectorSeeder.GetConnectors(chargeStationIds));

            connectors.AddRange(EVPointConnectorSeeder.GetConnectors(chargeStationIds));

            connectors.AddRange(GigaChargerConnectorSeeder.GetConnectors(chargeStationIds));

            connectors.AddRange(ElectrochargeConnectorSeeder.GetConnectors(chargeStationIds));

            connectors.AddRange(OMVeMotionConnectorSeeder.GetConnectors(chargeStationIds));
          
            connectors.AddRange(ElfinityConnectorSeeder.GetConnectors(chargeStationIds));

            connectors.AddRange(KiaHyperchargeConnectorSeeder.GetConnectors(chargeStationIds));

            connectors.AddRange(GPStationConnectorSeeder.GetConnectors(chargeStationIds));
           
            connectors.AddRange(WINKChargingConnectorSeeder.GetConnectors(chargeStationIds));
           
            connectors.AddRange(VoltspotConnectorSeeder.GetConnectors(chargeStationIds));
            
            connectors.AddRange(EVN2GOConnectorSeeder.GetConnectors(chargeStationIds));
            
            connectors.AddRange(TeslaSuperchargerConnectorSeeder.GetConnectors(chargeStationIds));
            
            connectors.AddRange(VarnaChargingConnectorSeeder.GetConnectors(chargeStationIds));
            
            connectors.AddRange(BullChargeConnectorSeeder.GetConnectors(chargeStationIds));
            
            connectors.AddRange(eCarsConnectorSeeder.GetConnectors(chargeStationIds));
           
            connectors.AddRange(ProCreditChargingConnectorSeeder.GetConnectors(chargeStationIds));

            List<Connector> existingConnectors = context.Connectors
                .ToList();


            Dictionary<
                (int ChargeStationId, int ConnectorNumber),
                Connector> existingConnectorsByKey =
                    existingConnectors.ToDictionary(
                        c => (
                            c.ChargeStationId,
                            c.ConnectorNumber),
                        c => c);


            List<Connector> connectorsToAdd =
                new List<Connector>();


            foreach (Connector connector in connectors)
            {
                (
                    int ChargeStationId,
                    int ConnectorNumber
                ) connectorKey =
                (
                    connector.ChargeStationId,
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