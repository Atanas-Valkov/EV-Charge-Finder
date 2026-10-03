namespace EVChargeFinder.Data.Seeding.ChargingStations
{
    using DbModels;
    using DbModels.Enums;

    public class VarnaChargingChargingStationSeeder
    {
        public static ChargingStation[] GetChargingStations(int operatorId)
        {
            return
            [
                new ChargingStation
                {
                    Name = "Varna Charging №5 - Tsaribrod",
                    Address = "ул. Цариброд 31",
                    City = "Варна",
                    Latitude = 43.200066m,
                    Longitude = 27.912945m,
                    ChargingStationStatus = ChargingStationStatus.Active,
                    DataSource = "Varna Charging",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargingStation
                {
                    Name = "Varna Charging №16 - Marin Drinov",
                    Address = "ул. Професор Марин Дринов 1",
                    City = "Варна",
                    Latitude = 43.207682m,
                    Longitude = 27.916646m,
                    ChargingStationStatus = ChargingStationStatus.Active,
                    DataSource = "Varna Charging",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargingStation
                {
                    Name = "Varna Charging №17 - Chataldzha",
                    Address = "ул. Цар Асен I",
                    City = "Варна",
                    Latitude = 43.214613m,
                    Longitude = 27.923643m,
                    ChargingStationStatus = ChargingStationStatus.Active,
                    DataSource = "Varna Charging",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargingStation
                {
                    Name = "Varna Charging №18 - Lyuben Karavelov",
                    Address = "ул. Любен Каравелов",
                    City = "Варна",
                    Latitude = 43.209875m,
                    Longitude = 27.923913m,
                    ChargingStationStatus = ChargingStationStatus.Active,
                    DataSource = "Varna Charging",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargingStation
                {
                    Name = "Varna Charging №20 - Marin Drinov",
                    Address = "ул. Марин Дринов 56-58",
                    City = "Варна",
                    Latitude = 43.211763m,
                    Longitude = 27.921612m,
                    ChargingStationStatus = ChargingStationStatus.Active,
                    DataSource = "Varna Charging",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargingStation
                {
                    Name = "Varna Charging №21 - Drin",
                    Address = "ул. Дрин",
                    City = "Варна",
                    Latitude = 43.211327m,
                    Longitude = 27.910189m,
                    ChargingStationStatus = ChargingStationStatus.Active,
                    DataSource = "Varna Charging",
                    ExternalId = null,
                    OperatorId = operatorId
                }
            ];
        }
    }
}