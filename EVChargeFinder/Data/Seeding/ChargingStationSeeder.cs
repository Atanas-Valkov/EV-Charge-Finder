using EVChargeFinder.Data.Seeding.ChargingStations;
using EVChargeFinder.DbModels;
using Microsoft.EntityFrameworkCore;

namespace EVChargeFinder.Data.Seeding
{
    public static class ChargingStationSeeder
    {
        public static void Seed(ApplicationDbContext context)
        {
            Dictionary<string, int> operatorIds = context.Operators
                .AsNoTracking()
                .ToDictionary(
                    o => o.Name,
                    o => o.Id);


            List<ChargingStation> ChargingStations = new List<ChargingStation>();

            ChargingStations.AddRange(EldriveChargingStationSeeder.GetChargingStations(operatorIds["Eldrive"]));

            ChargingStations.AddRange(FinesChargingStationSeeder.GetChargingStations(operatorIds["Fines Charging"]));

            ChargingStations.AddRange(ElectripChargingStationSeeder.GetChargingStations(operatorIds["Electrip"]));

            ChargingStations.AddRange(EVPointChargingStationSeeder.GetChargingStations(operatorIds["EVPoint"]));

            ChargingStations.AddRange(GigaChargerChargingStationSeeder.GetChargingStations(operatorIds["GigaCharger"]));

            ChargingStations.AddRange(ElectrochargeChargingStationSeeder.GetChargingStations(operatorIds["Electrocharge"]));

            ChargingStations.AddRange(OmvChargingStationSeeder.GetChargingStations(operatorIds["OMV eMotion"]));

            ChargingStations.AddRange(ElfinityChargingStationSeeder.GetChargingStations(operatorIds["Elfinity"]));

            ChargingStations.AddRange(KiaHyperchargeChargingStationSeeder.GetChargingStations(operatorIds["Kia Hypercharge"]));

            ChargingStations.AddRange(GPStationChargingStationSeeder.GetChargingStations(operatorIds["GPStation"]));

            ChargingStations.AddRange(WINKChargingChargingStationSeeder.GetChargingStations(operatorIds["WINK Charging"]));

            ChargingStations.AddRange(VoltspotChargingStationSeeder.GetChargingStations(operatorIds["Voltspot"]));

            ChargingStations.AddRange(EVN2GOChargingStationSeeder.GetChargingStations(operatorIds["EVN2GO"]));

            ChargingStations.AddRange(TeslaSuperchargerChargingStationSeeder.GetChargingStations(operatorIds["Tesla Supercharger"]));

            ChargingStations.AddRange(VarnaChargingChargingStationSeeder.GetChargingStations(operatorIds["Varna Charging"]));

            ChargingStations.AddRange(BullChargeChargingStationSeeder.GetChargingStations(operatorIds["BullCharge"]));

            ChargingStations.AddRange(eCarsChargingStationSeeder.GetChargingStations(operatorIds["eCars"]));

            ChargingStations.AddRange(ProCreditChargingChargingStationSeeder.GetChargingStations(operatorIds["ProCredit Charging"]));


            List<ChargingStation> existingChargingStations = context
                    .ChargingStations
                    .AsNoTracking()
                    .ToList();


            var existingStations = existingChargingStations
                    .Select(cs => 
                    (
                        cs.OperatorId,
                        cs.Name,
                        cs.Latitude,
                        cs.Longitude)
                    )
                    .ToHashSet();


            List<ChargingStation> ChargingStationsToAdd = new List<ChargingStation>();


            foreach (ChargingStation ChargingStation in ChargingStations)
            {
                (
                    int OperatorId,
                    string Name,
                    decimal Latitude,
                    decimal Longitude
                ) stationKey =
                (
                    ChargingStation.OperatorId,
                    ChargingStation.Name,
                    ChargingStation.Latitude,
                    ChargingStation.Longitude
                );

                if (!existingStations.Add(stationKey))
                {
                    continue;
                }

                ChargingStationsToAdd.Add(ChargingStation);
            }

            if (ChargingStationsToAdd.Count > 0)
            {
                context.ChargingStations.AddRange(ChargingStationsToAdd);

                context.SaveChanges();
            }
        }
    }
}