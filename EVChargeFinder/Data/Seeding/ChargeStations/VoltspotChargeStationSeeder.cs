namespace EVChargeFinder.Data.Seeding.ChargingStations
{
    using DbModels;
    using DbModels.Enums;
    public static class VoltspotChargingStationSeeder
    {
        public static ChargingStation[] GetChargingStations(int operatorId)
        {
            return
            [
                new ChargingStation
                {
                    Name = "Voltspot Kome CBA Kostinbrod",
                    Address = "ул. Славянска",
                    City = "Костинброд",
                    Latitude = 42.810159m,
                    Longitude = 23.216921m,
                    ChargingStationStatus = ChargingStationStatus.Active,
                    DataSource = "Voltspot",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargingStation
                {
                    Name = "Voltspot Bora Bora",
                    Address = "9",
                    City = "Несебър",
                    Latitude = 42.659401m,
                    Longitude = 27.688487m,
                    ChargingStationStatus = ChargingStationStatus.Active,
                    DataSource = "Voltspot",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargingStation
                {
                    Name = "Voltspot AutoBOX Ray",
                    Address = "ул. Плевен",
                    City = "Плевен",
                    Latitude = 43.440261m,
                    Longitude = 24.598770m,
                    ChargingStationStatus = ChargingStationStatus.Active,
                    DataSource = "Voltspot",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargingStation
                {
                    Name = "Voltspot AutoBOX Elmira",
                    Address = "ул. Св. Климент Охридски",
                    City = "Плевен",
                    Latitude = 43.406660m,
                    Longitude = 24.635729m,
                    ChargingStationStatus = ChargingStationStatus.Active,
                    DataSource = "Voltspot",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargingStation
                {
                    Name = "Voltspot AutoBOX Popovo",
                    Address = "бул. България",
                    City = "Попово",
                    Latitude = 43.348066m,
                    Longitude = 26.215450m,
                    ChargingStationStatus = ChargingStationStatus.Active,
                    DataSource = "Voltspot",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargingStation
                {
                    Name = "Voltspot Autocenter Vikar",
                    Address = "ул. Морски звуци 9",
                    City = "Варна",
                    Latitude = 43.247165m,
                    Longitude = 27.983999m,
                    ChargingStationStatus = ChargingStationStatus.Active,
                    DataSource = "Voltspot",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargingStation
                {
                    Name = "Voltspot Delta Planet Mall",
                    Address = "бул. Сливница 185",
                    City = "Варна",
                    Latitude = 43.228003m,
                    Longitude = 27.874078m,
                    ChargingStationStatus = ChargingStationStatus.Active,
                    DataSource = "Voltspot",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargingStation
                {
                    Name = "Voltspot Furnata",
                    Address = "ул. Георги Сава Раковски 1",
                    City = "Петревене",
                    Latitude = 43.158608m,
                    Longitude = 24.147967m,
                    ChargingStationStatus = ChargingStationStatus.Active,
                    DataSource = "Voltspot",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargingStation
                {
                    Name = "Voltspot Sokol Gas Station",
                    Address = "главен път за Айтос",
                    City = "Ябълчево",
                    Latitude = 42.789184m,
                    Longitude = 27.250873m,
                    ChargingStationStatus = ChargingStationStatus.Active,
                    DataSource = "Voltspot",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargingStation
                {
                    Name = "Voltspot Kome CBA Sveta Troitsa",
                    Address = "ул. Бургас",
                    City = "София",
                    Latitude = 42.711724m,
                    Longitude = 23.297497m,
                    ChargingStationStatus = ChargingStationStatus.Active,
                    DataSource = "Voltspot",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargingStation
                {
                    Name = "Voltspot Kome CBA Bankya",
                    Address = "ул. Стефан Стамболов",
                    City = "Банкя",
                    Latitude = 42.708069m,
                    Longitude = 23.151350m,
                    ChargingStationStatus = ChargingStationStatus.Active,
                    DataSource = "Voltspot",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargingStation
                {
                    Name = "Voltspot Kome CBA Slatina",
                    Address = "ул. Борис Новоселски",
                    City = "София",
                    Latitude = 42.687631m,
                    Longitude = 23.372169m,
                    ChargingStationStatus = ChargingStationStatus.Active,
                    DataSource = "Voltspot",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargingStation
                {
                    Name = "Voltspot Kome CBA Ovcha Kupel",
                    Address = "ул. Феникс",
                    City = "София",
                    Latitude = 42.687094m,
                    Longitude = 23.246571m,
                    ChargingStationStatus = ChargingStationStatus.Active,
                    DataSource = "Voltspot",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargingStation
                {
                    Name = "Voltspot Hotel Park Center",
                    Address = "бул. Цар Освободител",
                    City = "Сливен",
                    Latitude = 42.680138m,
                    Longitude = 26.315904m,
                    ChargingStationStatus = ChargingStationStatus.Active,
                    DataSource = "Voltspot",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargingStation
                {
                    Name = "Voltspot Kome CBA Motopista",
                    Address = "ж.к. Гоце Делчев",
                    City = "София",
                    Latitude = 42.664625m,
                    Longitude = 23.293236m,
                    ChargingStationStatus = ChargingStationStatus.Active,
                    DataSource = "Voltspot",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargingStation
                {
                    Name = "Voltspot Kome CBA Druzhba",
                    Address = "ж.к. Дружба, бл. 202",
                    City = "София",
                    Latitude = 42.654480m,
                    Longitude = 23.396365m,
                    ChargingStationStatus = ChargingStationStatus.Active,
                    DataSource = "Voltspot",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargingStation
                {
                    Name = "Voltspot Kome CBA Pernik",
                    Address = "ул. Рашо Димитров, бл. 64",
                    City = "Перник",
                    Latitude = 42.613392m,
                    Longitude = 23.092585m,
                    ChargingStationStatus = ChargingStationStatus.Active,
                    DataSource = "Voltspot",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargingStation
                {
                    Name = "Voltspot Bolero CBA Pomorie",
                    Address = "ул. Добри Чинтулов",
                    City = "Поморие",
                    Latitude = 42.570432m,
                    Longitude = 27.612718m,
                    ChargingStationStatus = ChargingStationStatus.Active,
                    DataSource = "Voltspot",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargingStation
                {
                    Name = "Voltspot Bolero CBA Iztok",
                    Address = "ул. Димитър Аврамов",
                    City = "Бургас",
                    Latitude = 42.524660m,
                    Longitude = 27.464754m,
                    ChargingStationStatus = ChargingStationStatus.Active,
                    DataSource = "Voltspot",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargingStation
                {
                    Name = "Voltspot AutoBOX Strelcha",
                    Address = "бул. Руски",
                    City = "Стрелча",
                    Latitude = 42.503960m,
                    Longitude = 24.322438m,
                    ChargingStationStatus = ChargingStationStatus.Active,
                    DataSource = "Voltspot",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargingStation
                {
                    Name = "Voltspot Horse Base & Hotel Max",
                    Address = "ул. Патриарх Евтимий",
                    City = "Нова Загора",
                    Latitude = 42.503249m,
                    Longitude = 26.019340m,
                    ChargingStationStatus = ChargingStationStatus.Active,
                    DataSource = "Voltspot",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargingStation
                {
                    Name = "Voltspot Yambol Park",
                    Address = "бул. Граф Игнатиев",
                    City = "Ямбол",
                    Latitude = 42.477910m,
                    Longitude = 26.518496m,
                    ChargingStationStatus = ChargingStationStatus.Active,
                    DataSource = "Voltspot",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargingStation
                {
                    Name = "Voltspot Autoengineering",
                    Address = "ул. Ген. Владимир Вазов 11",
                    City = "Бургас",
                    Latitude = 42.470933m,
                    Longitude = 27.439970m,
                    ChargingStationStatus = ChargingStationStatus.Active,
                    DataSource = "Voltspot",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargingStation
                {
                    Name = "Voltspot Struma Petrol",
                    Address = "път 6202",
                    City = "Кюстендил",
                    Latitude = 42.280960m,
                    Longitude = 22.722657m,
                    ChargingStationStatus = ChargingStationStatus.Active,
                    DataSource = "Voltspot",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargingStation
                {
                    Name = "Voltspot Kome CBA Dupnitsa",
                    Address = "път 6204",
                    City = "Дупница",
                    Latitude = 42.274465m,
                    Longitude = 23.132328m,
                    ChargingStationStatus = ChargingStationStatus.Active,
                    DataSource = "Voltspot",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargingStation
                {
                    Name = "Voltspot Restaurant Tikhiyat Kat",
                    Address = "ул. Слокощица",
                    City = "Кюстендил",
                    Latitude = 42.265893m,
                    Longitude = 22.704761m,
                    ChargingStationStatus = ChargingStationStatus.Active,
                    DataSource = "Voltspot",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargingStation
                {
                    Name = "Voltspot Bolero CBA Tsarevo",
                    Address = "ул. Милин камък",
                    City = "Царево",
                    Latitude = 42.170007m,
                    Longitude = 27.842938m,
                    ChargingStationStatus = ChargingStationStatus.Active,
                    DataSource = "Voltspot",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargingStation
                {
                    Name = "Voltspot AutoBOX Elhovo",
                    Address = "път 7008",
                    City = "Елхово",
                    Latitude = 42.157890m,
                    Longitude = 26.563135m,
                    ChargingStationStatus = ChargingStationStatus.Active,
                    DataSource = "Voltspot",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargingStation
                {
                    Name = "Voltspot Mall Plovdiv",
                    Address = "ул. Перущица",
                    City = "Пловдив",
                    Latitude = 42.141177m,
                    Longitude = 24.719023m,
                    ChargingStationStatus = ChargingStationStatus.Active,
                    DataSource = "Voltspot",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargingStation
                {
                    Name = "Voltspot Parvomay Park",
                    Address = "667",
                    City = "Първомай",
                    Latitude = 42.090600m,
                    Longitude = 25.211655m,
                    ChargingStationStatus = ChargingStationStatus.Active,
                    DataSource = "Voltspot",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargingStation
                {
                    Name = "Voltspot BGMARKET CBA Zapad",
                    Address = "ул. Марица",
                    City = "Благоевград",
                    Latitude = 42.016490m,
                    Longitude = 23.085157m,
                    ChargingStationStatus = ChargingStationStatus.Active,
                    DataSource = "Voltspot",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargingStation
                {
                    Name = "Voltspot Hippoland Blagoevgrad",
                    Address = "бул. Александър Стамболийски",
                    City = "Благоевград",
                    Latitude = 42.007871m,
                    Longitude = 23.096234m,
                    ChargingStationStatus = ChargingStationStatus.Active,
                    DataSource = "Voltspot",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargingStation
                {
                    Name = "Voltspot Kashmir Hotel & SPA",
                    Address = "кв. Чепино",
                    City = "Велинград",
                    Latitude = 42.002059m,
                    Longitude = 23.985391m,
                    ChargingStationStatus = ChargingStationStatus.Active,
                    DataSource = "Voltspot",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargingStation
                {
                    Name = "Voltspot Motel Kozyat Rog",
                    Address = "99",
                    City = "Малко Търново",
                    Latitude = 41.978079m,
                    Longitude = 27.517229m,
                    ChargingStationStatus = ChargingStationStatus.Active,
                    DataSource = "Voltspot",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargingStation
                {
                    Name = "Voltspot AutoBOX Haskovo",
                    Address = "бул. Съединение 96",
                    City = "Хасково",
                    Latitude = 41.931060m,
                    Longitude = 25.599413m,
                    ChargingStationStatus = ChargingStationStatus.Active,
                    DataSource = "Voltspot",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargingStation
                {
                    Name = "Voltspot St. Ivan Rilski SPA Resort",
                    Address = "ул. Шинова ела 18",
                    City = "Банско",
                    Latitude = 41.823220m,
                    Longitude = 23.488230m,
                    ChargingStationStatus = ChargingStationStatus.Active,
                    DataSource = "Voltspot",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargingStation
                {
                    Name = "Voltspot Premier Resort",
                    Address = "ул. Караманица",
                    City = "Банско",
                    Latitude = 41.822222m,
                    Longitude = 23.481472m,
                    ChargingStationStatus = ChargingStationStatus.Active,
                    DataSource = "Voltspot",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargingStation
                {
                    Name = "Voltspot Shell Kardzhali",
                    Address = "ул. Първи май",
                    City = "Кърджали",
                    Latitude = 41.615612m,
                    Longitude = 25.375619m,
                    ChargingStationStatus = ChargingStationStatus.Active,
                    DataSource = "Voltspot",
                    ExternalId = null,
                    OperatorId = operatorId
                }
            ];
        }
    }
}