using EVChargeFinder.DbModels;
using EVChargeFinder.DbModels.Enums;

namespace EVChargeFinder.Data.Seeding.ChargeStations
{
    public static class BullChargeChargeStationSeeder
    {
        public static ChargeStation[] GetChargeStations(int operatorId)
        {
            return
            [
                new ChargeStation
                {
                    Name = "BullCharge Headquarters",
                    Address = "ул. Магнаурска школа 11",
                    City = "София",
                    Latitude = 42.656190m,
                    Longitude = 23.389164m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "BullCharge",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "BullCharge Bulgarian Industrial Association",
                    Address = "ул. Чаталджа 76",
                    City = "София",
                    Latitude = 42.700090m,
                    Longitude = 23.343010m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "BullCharge",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "BullCharge Guesthouse Horizont",
                    Address = "ул. Девети Септември 3",
                    City = "Добринище",
                    Latitude = 41.819209m,
                    Longitude = 23.560427m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "BullCharge",
                    ExternalId = null,
                    OperatorId = operatorId
                }
            ];
        }
    }
}