using EVChargeFinder.Data.Seeding.ChargeStations;
using EVChargeFinder.DbModels;
using Microsoft.EntityFrameworkCore;

namespace EVChargeFinder.Data.Seeding
{
    public static class ChargeStationSeeder
    {
        public static void Seed(ApplicationDbContext context)
        {
            Dictionary<string, int> operatorIds = context.Operators
                .AsNoTracking()
                .ToDictionary(
                    o => o.Name,
                    o => o.Id);


            List<ChargeStation> chargeStations = new List<ChargeStation>();

            chargeStations.AddRange(EldriveChargeStationSeeder.GetChargeStations(operatorIds["Eldrive"]));

            chargeStations.AddRange(FinesChargeStationSeeder.GetChargeStations(operatorIds["Fines Charging"]));

            chargeStations.AddRange(ElectripChargeStationSeeder.GetChargeStations(operatorIds["Electrip"]));

            chargeStations.AddRange(EVPointChargeStationSeeder.GetChargeStations(operatorIds["EVPoint"]));

            chargeStations.AddRange(GigaChargerChargeStationSeeder.GetChargeStations(operatorIds["GigaCharger"]));

            chargeStations.AddRange(ElectrochargeChargeStationSeeder.GetChargeStations(operatorIds["Electrocharge"]));

            chargeStations.AddRange(OmvChargeStationSeeder.GetChargeStations(operatorIds["OMV eMotion"]));

            chargeStations.AddRange(ElfinityChargeStationSeeder.GetChargeStations(operatorIds["Elfinity"]));

            chargeStations.AddRange(KiaHyperchargeChargeStationSeeder.GetChargeStations(operatorIds["Kia Hypercharge"]));

            chargeStations.AddRange(GPStationChargeStationSeeder.GetChargeStations(operatorIds["GPStation"]));

            chargeStations.AddRange(WINKChargingChargeStationSeeder.GetChargeStations(operatorIds["WINK Charging"]));

            chargeStations.AddRange(VoltspotChargeStationSeeder.GetChargeStations(operatorIds["Voltspot"]));

            chargeStations.AddRange(EVN2GOChargeStationSeeder.GetChargeStations(operatorIds["EVN2GO"]));

            chargeStations.AddRange(TeslaSuperchargerChargeStationSeeder.GetChargeStations(operatorIds["Tesla Supercharger"]));

            chargeStations.AddRange(VarnaChargingChargeStationSeeder.GetChargeStations(operatorIds["Varna Charging"]));

            chargeStations.AddRange(BullChargeChargeStationSeeder.GetChargeStations(operatorIds["BullCharge"]));

            chargeStations.AddRange(eCarsChargeStationSeeder.GetChargeStations(operatorIds["eCars"]));

            chargeStations.AddRange(ProCreditChargingChargeStationSeeder.GetChargeStations(operatorIds["ProCredit Charging"]));


            List<ChargeStation> existingChargeStations = context
                    .ChargeStations
                    .AsNoTracking()
                    .ToList();


            var existingStations = existingChargeStations
                    .Select(cs => 
                    (
                        cs.OperatorId,
                        cs.Name,
                        cs.Latitude,
                        cs.Longitude)
                    )
                    .ToHashSet();


            List<ChargeStation> chargeStationsToAdd = new List<ChargeStation>();


            foreach (ChargeStation chargeStation in chargeStations)
            {
                (
                    int OperatorId,
                    string Name,
                    decimal Latitude,
                    decimal Longitude
                ) stationKey =
                (
                    chargeStation.OperatorId,
                    chargeStation.Name,
                    chargeStation.Latitude,
                    chargeStation.Longitude
                );

                if (!existingStations.Add(stationKey))
                {
                    continue;
                }

                chargeStationsToAdd.Add(chargeStation);
            }

            if (chargeStationsToAdd.Count > 0)
            {
                context.ChargeStations.AddRange(chargeStationsToAdd);

                context.SaveChanges();
            }
        }
    }
}