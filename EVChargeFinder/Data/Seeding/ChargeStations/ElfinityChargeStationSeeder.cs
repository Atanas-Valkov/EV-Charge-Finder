namespace EVChargeFinder.Data.Seeding.ChargeStations
{

    using DbModels;
    using DbModels.Enums;
    public static class ElfinityChargeStationSeeder
    {
        public static ChargeStation[] GetChargeStations(int operatorId)
        {
            return
            [
                new ChargeStation
                {
                    Name = "Elfinity Graf Ignatievo",
                    Address = "Граф Игнатиево, 4198",
                    City = "Граф Игнатиево",
                    Latitude = 42.269478m,
                    Longitude = 24.729359m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Elfinity",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "Elfinity Otets Paisiy 3",
                    Address = "ул. Отец Паисий 3",
                    City = "Банско",
                    Latitude = 41.833442m,
                    Longitude = 23.488243m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Elfinity",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "Elfinity Yane Sandanski 1",
                    Address = "ул. Яне Сандански 1",
                    City = "Благоевград",
                    Latitude = 41.996745m,
                    Longitude = 23.088079m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Elfinity",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "Elfinity Yanko Sakazov 25",
                    Address = "ул. Янко Сакъзов 25",
                    City = "Козлодуй",
                    Latitude = 43.767615m,
                    Longitude = 23.722671m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Elfinity",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "Elfinity Knyaz Aleksandar Batenberg 28",
                    Address = "бул. Княз Александър Батенберг 28",
                    City = "Стара Загора",
                    Latitude = 42.424789m,
                    Longitude = 25.616268m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Elfinity",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "Elfinity Oborishte 5",
                    Address = "ул. Оборище 5",
                    City = "София",
                    Latitude = 42.695506m,
                    Longitude = 23.336359m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Elfinity",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "Elfinity Port Varna",
                    Address = "Пристанищен комплекс Одесос",
                    City = "Варна",
                    Latitude = 43.192427m,
                    Longitude = 27.921349m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Elfinity",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "Elfinity Knyaz Boris I",
                    Address = "бул. Княз Борис I",
                    City = "Варна",
                    Latitude = 43.215110m,
                    Longitude = 27.955109m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Elfinity",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "Elfinity Burgas 906",
                    Address = "906, 8016 Бургас",
                    City = "Бургас",
                    Latitude = 42.565103m,
                    Longitude = 27.496095m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Elfinity",
                    ExternalId = null,
                    OperatorId = operatorId
                }
            ];
        }
    }
}