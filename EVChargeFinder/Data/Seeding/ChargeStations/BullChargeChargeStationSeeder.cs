using EVChargeFinder.DbModels;
using EVChargeFinder.DbModels.Enums;

namespace EVChargeFinder.Data.Seeding.ChargingStations
{
    public static class BullChargeChargingStationSeeder
    {
        public static ChargingStation[] GetChargingStations(int operatorId)
        {
            return
            [
                new ChargingStation
                {
                    Name = "BullCharge Headquarters",
                    Address = "ул. Магнаурска школа 11",
                    City = "София",
                    Latitude = 42.656190m,
                    Longitude = 23.389164m,
                    ChargingStationStatus = ChargingStationStatus.Active,
                    DataSource = "BullCharge",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargingStation
                {
                    Name = "BullCharge Bulgarian Industrial Association",
                    Address = "ул. Чаталджа 76",
                    City = "София",
                    Latitude = 42.700090m,
                    Longitude = 23.343010m,
                    ChargingStationStatus = ChargingStationStatus.Active,
                    DataSource = "BullCharge",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargingStation
                {
                    Name = "BullCharge Guesthouse Horizont",
                    Address = "ул. Девети Септември 3",
                    City = "Добринище",
                    Latitude = 41.819209m,
                    Longitude = 23.560427m,
                    ChargingStationStatus = ChargingStationStatus.Active,
                    DataSource = "BullCharge",
                    ExternalId = null,
                    OperatorId = operatorId
                }
            ];
        }
    }
}