namespace EVChargeFinder.Data.Seeding.ChargeStations
{
    using DbModels;
    using DbModels.Enums;
    public class ProCreditChargingChargeStationSeeder
    {
        public static ChargeStation[] GetChargeStations(int operatorId)
        {
            return
            [
                new ChargeStation
                {
                    Name = "ProCredit Charging Poligrafia",
                    Address = "бул. Княгиня Мария Луиза 72",
                    City = "Пловдив",
                    Latitude = 42.145570m,
                    Longitude = 24.765240m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "ProCredit Charging",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "ProCredit Charging Lev Tolstoy",
                    Address = "ул. Лев Толстой",
                    City = "Пловдив",
                    Latitude = 42.145750m,
                    Longitude = 24.766930m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "ProCredit Charging",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "ProCredit Charging UNWE",
                    Address = "ул. 8-ми декември 19",
                    City = "София",
                    Latitude = 42.650973m,
                    Longitude = 23.348442m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "ProCredit Charging",
                    ExternalId = null,
                    OperatorId = operatorId
                }
            ];
        }
    }
}