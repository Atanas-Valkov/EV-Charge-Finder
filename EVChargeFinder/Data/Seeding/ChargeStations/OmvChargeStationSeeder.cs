namespace EVChargeFinder.Data.Seeding.ChargeStations
{
    using DbModels;
    using DbModels.Enums;
    public static class OmvChargeStationSeeder
    {
        public static ChargeStation[] GetChargeStations(int operatorId)
        {
            return
            [
                new ChargeStation
                {
                    Name = "OMV Хемус",
                    Address = "АМ Хемус, 57 км, посока Варна",
                    City = null,
                    Latitude = 42.956847m,
                    Longitude = 24.024391m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "OMV eMotion",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "OMV Хемус Осиковица",
                    Address = "АМ Хемус, 57 км, посока София",
                    City = null,
                    Latitude = 42.954281m,
                    Longitude = 24.021232m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "OMV eMotion",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "OMV Хемус Шумен Юг",
                    Address = "АМ Хемус, км. 356+831, дясно, район Каспичан",
                    City = "Каспичан",
                    Latitude = 43.319629m,
                    Longitude = 27.116144m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "OMV eMotion",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "OMV София Бояна",
                    Address = "ул. Околовръстен път №6",
                    City = "София",
                    Latitude = 42.651344m,
                    Longitude = 23.287498m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "OMV eMotion",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "OMV София бул. България",
                    Address = "бул. България №49В",
                    City = "София",
                    Latitude = 42.667510m,
                    Longitude = 23.290962m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "OMV eMotion",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "OMV Стара Загора Дезинтегратор",
                    Address = "бул. Славянски №60",
                    City = "Стара Загора",
                    Latitude = 42.419448m,
                    Longitude = 25.630056m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "OMV eMotion",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "OMV Тракия Дражево",
                    Address = "АМ Тракия, 279 км, ляво, посока София",
                    City = "Дражево",
                    Latitude = 42.545300m,
                    Longitude = 26.446230m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "OMV eMotion",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "OMV Тракия Виноградец",
                    Address = "АМ Тракия, 73 км, дясно, местност Сухата чешма №120",
                    City = "Виноградец",
                    Latitude = 42.319619m,
                    Longitude = 24.130599m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "OMV eMotion",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "OMV Тракия Хаджидимитрово",
                    Address = "АМ Тракия, 273 км, дясно, посока Бургас",
                    City = "Хаджидимитрово",
                    Latitude = 42.530583m,
                    Longitude = 26.398222m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "OMV eMotion",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "OMV Тракия Динката",
                    Address = "АМ Тракия, 86 км, ляво, местност Гара Кория",
                    City = "Динката",
                    Latitude = 42.278672m,
                    Longitude = 24.277295m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "OMV eMotion",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "OMV Тракия Белозем",
                    Address = "АМ Тракия, 152 км, ляво, посока София",
                    City = "Белозем",
                    Latitude = 42.219123m,
                    Longitude = 25.041880m,
                    ChargeStationStatus = ChargeStationStatus.Maintenance,
                    DataSource = "OMV eMotion",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "OMV София Ботевградско",
                    Address = "Ботевградско шосе №439",
                    City = "София",
                    Latitude = 42.709500m,
                    Longitude = 23.427765m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "OMV eMotion",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "OMV Струма Чучулигово ляво",
                    Address = "АМ Струма, 166.5 км, ляво, посока София",
                    City = "Чучулигово",
                    Latitude = 41.397260m,
                    Longitude = 23.355160m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "OMV eMotion",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "OMV София Корабче",
                    Address = "бул. Цариградско шосе №116",
                    City = "София",
                    Latitude = 42.641479m,
                    Longitude = 23.404499m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "OMV eMotion",
                    ExternalId = null,
                    OperatorId = operatorId
                }
            ];
        }
    }
}