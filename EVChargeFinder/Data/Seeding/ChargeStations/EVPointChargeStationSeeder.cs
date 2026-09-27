namespace EVChargeFinder.Data.Seeding.ChargeStations
{
    using DbModels;
    using DbModels.Enums;


    public static class EVPointChargeStationSeeder
    {
        public static ChargeStation[] GetChargeStations(int operatorId)
        {
            return
            [
                new ChargeStation
                {
                    Name = "EVPoint Добрич Ангел Стоянов 4",
                    Address = "Ангел Стоянов 4",
                    City = "Добрич",
                    Latitude = 43.587288m,
                    Longitude = 27.827756m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "EVPoint",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "EVPoint Добрич 25-ти Септември 51",
                    Address = "бул. 25-ти Септември 51",
                    City = "Добрич",
                    Latitude = 43.583544m,
                    Longitude = 27.832175m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "EVPoint",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "EVPoint Добрич Калиакра 65",
                    Address = "Калиакра 65",
                    City = "Добрич",
                    Latitude = 43.582061m,
                    Longitude = 27.812667m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "EVPoint",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "EVPoint Добрич Околовръстен път",
                    Address = "Околовръстен път",
                    City = "Добрич",
                    Latitude = 43.545257m,
                    Longitude = 27.822430m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "EVPoint",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "EVPoint Добрич Ген. Колев 45",
                    Address = "Ген. Колев 45",
                    City = "Добрич",
                    Latitude = 43.561061m,
                    Longitude = 27.827872m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "EVPoint",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "EVPoint Добрич 25-ти Септември 4",
                    Address = "бул. 25-ти Септември 4",
                    City = "Добрич",
                    Latitude = 43.545282m,
                    Longitude = 27.822813m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "EVPoint",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "EVPoint Стара Загора Загорка 35А",
                    Address = "Загорка 35а",
                    City = "Стара Загора",
                    Latitude = 42.411346m,
                    Longitude = 25.593505m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "EVPoint",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "EVPoint Стара Загора Никола Петков",
                    Address = "бул. Никола Петков",
                    City = "Стара Загора",
                    Latitude = 42.429610m,
                    Longitude = 25.668264m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "EVPoint",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "EVPoint Стара Загора Цар Симеон Велики",
                    Address = "бул. Цар Симеон Велики",
                    City = "Стара Загора",
                    Latitude = 42.411977m,
                    Longitude = 25.594660m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "EVPoint",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "EVPoint Стара Загора Алеко Константинов 3",
                    Address = "Алеко Константинов 3",
                    City = "Стара Загора",
                    Latitude = 42.414654m,
                    Longitude = 25.592202m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "EVPoint",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "EVPoint Стара Загора Димитър Филов 1",
                    Address = "ул. Подп. Дим. Филов 1",
                    City = "Стара Загора",
                    Latitude = 42.437627m,
                    Longitude = 25.627608m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "EVPoint",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "EVPoint Стара Загора Цар Симеон Велики 65А",
                    Address = "бул. Цар Симеон Велики 65а",
                    City = "Стара Загора",
                    Latitude = 42.423620m,
                    Longitude = 25.617009m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "EVPoint",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "EVPoint Стара Загора Патриарх Евтимий 79",
                    Address = "бул. Свети Патриарх Евтимий 79",
                    City = "Стара Загора",
                    Latitude = 42.423991m,
                    Longitude = 25.634708m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "EVPoint",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "EVPoint Разлог Реденка 34",
                    Address = "м. Реденка 34",
                    City = "Разлог",
                    Latitude = 41.875169m,
                    Longitude = 23.423259m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "EVPoint",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "EVPoint Разлог Бетоловото 130",
                    Address = "ул. Бетоловото 130",
                    City = "Разлог",
                    Latitude = 41.854547m,
                    Longitude = 23.405204m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "EVPoint",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "EVPoint Разлог Байова Борика 1Л",
                    Address = "Байова Борика 1л",
                    City = "Разлог",
                    Latitude = 41.860711m,
                    Longitude = 23.415239m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "EVPoint",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "EVPoint Разлог Изворите 2",
                    Address = "Изворите 2",
                    City = "Разлог",
                    Latitude = 41.855869m,
                    Longitude = 23.417600m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "EVPoint",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "EVPoint Разлог Джинджерица 6",
                    Address = "ул. Джинджерица 6",
                    City = "Разлог",
                    Latitude = 41.887536m,
                    Longitude = 23.425749m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "EVPoint",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "EVPoint Разлог 19",
                    Address = "19",
                    City = "Разлог",
                    Latitude = 41.876752m,
                    Longitude = 23.440119m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "EVPoint",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "EVPoint Благоевград Свобода Бъчварова 12",
                    Address = "Свобода Бъчварова 12",
                    City = "Благоевград",
                    Latitude = 42.009698m,
                    Longitude = 23.093464m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "EVPoint",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "EVPoint Благоевград 1",
                    Address = "1",
                    City = "Благоевград",
                    Latitude = 42.009432m,
                    Longitude = 23.074956m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "EVPoint",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "EVPoint Пазарджик Стефан Стамболов 13",
                    Address = "бул. Стефан Стамболов 13",
                    City = "Пазарджик",
                    Latitude = 42.182317m,
                    Longitude = 24.346683m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "EVPoint",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "EVPoint Пазарджик Пловдивска 107",
                    Address = "Пловдивска 107",
                    City = "Пазарджик",
                    Latitude = 42.187865m,
                    Longitude = 24.356603m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "EVPoint",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "EVPoint Пазарджик Пловдивска 78",
                    Address = "Пловдивска 78",
                    City = "Пазарджик",
                    Latitude = 42.185034m,
                    Longitude = 24.350854m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "EVPoint",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "EVPoint Пазарджик Стефан Стамболов 18",
                    Address = "бул. Стефан Стамболов 18",
                    City = "Пазарджик",
                    Latitude = 42.180789m,
                    Longitude = 24.346075m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "EVPoint",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "EVPoint Пазарджик Пловдивска 8",
                    Address = "Пловдивска 8",
                    City = "Пазарджик",
                    Latitude = 42.187549m,
                    Longitude = 24.356420m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "EVPoint",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "EVPoint Чирпан Пейо Яворов 29",
                    Address = "Пейо Крачолов Яворов 29",
                    City = "Чирпан",
                    Latitude = 42.200314m,
                    Longitude = 25.330048m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "EVPoint",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "EVPoint Чирпан Георги Димитров 111",
                    Address = "бул. Георги Димитров 111",
                    City = "Чирпан",
                    Latitude = 42.202416m,
                    Longitude = 25.342781m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "EVPoint",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "EVPoint Провадия 208",
                    Address = "208",
                    City = "Провадия",
                    Latitude = 43.158079m,
                    Longitude = 27.444591m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "EVPoint",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "EVPoint Провадия Дунав",
                    Address = "Дунав",
                    City = "Провадия",
                    Latitude = 43.185729m,
                    Longitude = 27.443217m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "EVPoint",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "EVPoint Леденик 4",
                    Address = "4",
                    City = "Леденик",
                    Latitude = 43.083550m,
                    Longitude = 25.578930m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "EVPoint",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "EVPoint Лозен 4",
                    Address = "Лозен 4",
                    City = "Лозен",
                    Latitude = 42.625797m,
                    Longitude = 23.447627m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "EVPoint",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "EVPoint Лозен Цариградско шосе 387",
                    Address = "бул. Цариградско шосе 387",
                    City = "Лозен",
                    Latitude = 42.640102m,
                    Longitude = 23.439013m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "EVPoint",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "EVPoint Банско Явор 83",
                    Address = "Явор 83",
                    City = "Банско",
                    Latitude = 41.835336m,
                    Longitude = 23.476984m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "EVPoint",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "EVPoint Нова Загора Генерал Скобелев 29",
                    Address = "Генерал Скобелев 29",
                    City = "Нова Загора",
                    Latitude = 42.499760m,
                    Longitude = 26.013887m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "EVPoint",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "EVPoint Плевен Българска Авиация 20",
                    Address = "Българска Авиация 20",
                    City = "Плевен",
                    Latitude = 43.431322m,
                    Longitude = 24.602315m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "EVPoint",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "EVPoint Плевен Александър Малинов",
                    Address = "бул. Александър Малинов",
                    City = "Плевен",
                    Latitude = 43.400277m,
                    Longitude = 24.644480m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "EVPoint",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "EVPoint Враждебна Ботевградско шосе 455",
                    Address = "бул. Ботевградско шосе 455",
                    City = "Враждебна",
                    Latitude = 42.709042m,
                    Longitude = 23.433294m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "EVPoint",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "EVPoint Горна Оряховица Княз Борис I 88",
                    Address = "Св. Княз Борис I 88",
                    City = "Горна Оряховица",
                    Latitude = 43.139255m,
                    Longitude = 25.719464m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "EVPoint",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "EVPoint Lidl София Андрей Ляпчев 52",
                    Address = "бул. Андрей Ляпчев 52",
                    City = "София",
                    Latitude = 42.649450m,
                    Longitude = 23.368690m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "EVPoint",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "EVPoint Lidl София Васил Левски 152",
                    Address = "бул. Васил Левски 152",
                    City = "София",
                    Latitude = 42.704460m,
                    Longitude = 23.333650m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "EVPoint",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "EVPoint Lidl Благоевград",
                    Address = "бул. Св. Димитър Солунски 26",
                    City = "Благоевград",
                    Latitude = 42.014620m,
                    Longitude = 23.084040m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "EVPoint",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "EVPoint Lidl Каварна",
                    Address = "ул. Марица 1",
                    City = "Каварна",
                    Latitude = 43.435460m,
                    Longitude = 28.326920m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "EVPoint",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "EVPoint Lidl Карнобат",
                    Address = "бул. Москва 24А",
                    City = "Карнобат",
                    Latitude = 42.650860m,
                    Longitude = 26.976820m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "EVPoint",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "EVPoint Lidl Кюстендил",
                    Address = "ул. Петър Ников 9",
                    City = "Кюстендил",
                    Latitude = 42.279200m,
                    Longitude = 22.672100m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "EVPoint",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "EVPoint Lidl Луковит",
                    Address = "ул. Възраждане 128",
                    City = "Луковит",
                    Latitude = 43.214640m,
                    Longitude = 24.165120m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "EVPoint",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "EVPoint Lidl Несебър",
                    Address = "местност Чаирите 357",
                    City = "Несебър",
                    Latitude = 42.710990m,
                    Longitude = 27.721620m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "EVPoint",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "EVPoint Lidl Пловдив",
                    Address = "ул. Недялка Шилева 8",
                    City = "Пловдив",
                    Latitude = 42.125970m,
                    Longitude = 24.785690m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "EVPoint",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "EVPoint Lidl Русе",
                    Address = "ул. Никола Петков 13",
                    City = "Русе",
                    Latitude = 43.853180m,
                    Longitude = 25.978290m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "EVPoint",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "EVPoint Lidl Самоков",
                    Address = "бул. Искър 2Б",
                    City = "Самоков",
                    Latitude = 42.334280m,
                    Longitude = 23.555370m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "EVPoint",
                    ExternalId = null,
                    OperatorId = operatorId
                }
            ];
        }
    }
}