namespace EVChargeFinder.Data.Seeding.ChargeStations
{
    using DbModels;
    using DbModels.Enums;
    public static class FinesChargeStationSeeder
    {
        public static ChargeStation[] GetChargeStations(int operatorId)
        {
            return
            [
                new ChargeStation
                {
                    Name = "FINES Trakia 122",
                    Address = "805, Бенковски 4201, България",
                    City = "Бенковски",
                    Latitude = 42.204255m,
                    Longitude = 24.674509m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Fines Charging",
                    ExternalId = "LV-PLOVDIV-1",
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "FINES Elit Vidin",
                    Address = "14, Новоселци 3725, България",
                    City = "Новоселци",
                    Latitude = 43.985786m,
                    Longitude = 22.829289m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Fines Charging",
                    ExternalId = "LV-VIDIN-ELITPARKING",
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "FINES Imperial Palace Svilengrad",
                    Address = "Сан Стефано 9, Свиленград 6500, България",
                    City = "Свиленград",
                    Latitude = 41.777718m,
                    Longitude = 26.205310m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Fines Charging",
                    ExternalId = "LV-SVILENGRAD-IMPERIALPALACE",
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "FINES Varna Billa",
                    Address = "Акад. Андрей Сахаров 1, Варна 9009, България",
                    City = "Варна",
                    Latitude = 43.220944m,
                    Longitude = 27.898206m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Fines Charging",
                    ExternalId = "LV-VARNA-IVA2003",
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "FINES Chuchuligovo",
                    Address = "Автомагистрала Струма, Чучулигово 2865, България",
                    City = "Чучулигово",
                    Latitude = 41.397157m,
                    Longitude = 23.354445m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Fines Charging",
                    ExternalId = "LV-CHUCHULIGOVO-DC1",
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "FINES Petrol Orizovo",
                    Address = "Автомагистрала Тракия, Оризово 6253, България",
                    City = "Оризово",
                    Latitude = 42.193636m,
                    Longitude = 25.156967m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Fines Charging",
                    ExternalId = "LV-ORIZOVO-0001",
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "Balkan AD Lovech",
                    Address = "Мизия 1, Ловеч 5502, България",
                    City = "Ловеч",
                    Latitude = 43.160554m,
                    Longitude = 24.716112m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Fines Charging",
                    ExternalId = "LV-LOVECH-BALKANAD",
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "FINES Intercom Group Varna",
                    Address = "Уста Кольо Фичето 23, Варна 9009, България",
                    City = "Варна",
                    Latitude = 43.215720m,
                    Longitude = 27.873765m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Fines Charging",
                    ExternalId = "LV-VARNA-INTRCMGRP",
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "FINES Varna Star Power",
                    Address = "Булевард Цар Освободител 122, Варна 9025, България",
                    City = "Варна",
                    Latitude = 43.231959m,
                    Longitude = 27.895045m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Fines Charging",
                    ExternalId = "LV-VARNA-1",
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "FINES Hyundai Varna",
                    Address = "Автомагистрала Хемус, Варна 9009, България",
                    City = "Варна",
                    Latitude = 43.224955m,
                    Longitude = 27.866258m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Fines Charging",
                    ExternalId = "LV-VARNA-HYUNDAI1",
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "FINES Bulavto Premium Varna",
                    Address = "Бул. Владислав Варненчик 262, Варна 9009, България",
                    City = "Варна",
                    Latitude = 43.222962m,
                    Longitude = 27.870444m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Fines Charging",
                    ExternalId = "LV-VARNA-3",
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "FINES Tomsy Burgas",
                    Address = "Одрин 116, Бургас 8001, България",
                    City = "Бургас",
                    Latitude = 42.518033m,
                    Longitude = 27.423737m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Fines Charging",
                    ExternalId = "LV-BURGAS-TOMSY",
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "FINES Tomov Plaza Plovdiv",
                    Address = "Бул. Асеновградско Шосе 9, Пловдив 4008, България",
                    City = "Пловдив",
                    Latitude = 42.126954m,
                    Longitude = 24.770653m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Fines Charging",
                    ExternalId = "CB-PLOVDIV-TOMOVPLAZA",
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "FINES Hay Group Shumen",
                    Address = "Бул. Мадара 6, Шумен 9701, България",
                    City = "Шумен",
                    Latitude = 43.252001m,
                    Longitude = 26.962426m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Fines Charging",
                    ExternalId = "LV-SHUMEN-HAYGROUP",
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "FiNES Omnicar Auto Plovdiv",
                    Address = "Бул. Васил Левски, Труд 4199, България",
                    City = "Труд",
                    Latitude = 42.196464m,
                    Longitude = 24.736275m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Fines Charging",
                    ExternalId = "LV-PLOVDIV-OMNIC",
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "FINES Harmanli",
                    Address = "76, Харманли 6450, България",
                    City = "Харманли",
                    Latitude = 41.925453m,
                    Longitude = 25.920911m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Fines Charging",
                    ExternalId = "LV-HARMNALI-DC1",
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "FINES Petrol Studena",
                    Address = "Автомагистрала Струма, Перник 2308, България",
                    City = "Перник",
                    Latitude = 42.584382m,
                    Longitude = 23.120602m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Fines Charging",
                    ExternalId = "LV-STRUMA-PETROLSTUDENA",
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "FINES Plovdiv Tsarigradsko",
                    Address = "Бул. Цариградско Шосе 71, Пловдив 4006, България",
                    City = "Пловдив",
                    Latitude = 42.149488m,
                    Longitude = 24.797417m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Fines Charging",
                    ExternalId = "CB-PLOVDIV-TSARIGRADSKO",
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "FINES Porsche Center Sofia",
                    Address = "Бул. Цариградско Шосе, Горубляне 1138, България",
                    City = "София",
                    Latitude = 42.636368m,
                    Longitude = 23.421074m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Fines Charging",
                    ExternalId = "LV-SOFIA-PORSCHECENTER",
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "FINES Trakia 243 Sofia",
                    Address = "Автомагистрала Тракия, Езеро 8919, България",
                    City = "Езеро",
                    Latitude = 42.453887m,
                    Longitude = 26.051071m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Fines Charging",
                    ExternalId = "LV-TRAKIA243-N",
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "FINES Trakia 243 Burgas",
                    Address = "Автомагистрала Тракия, Езеро 8919, България",
                    City = "Езеро",
                    Latitude = 42.453208m,
                    Longitude = 26.052089m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Fines Charging",
                    ExternalId = "LV-TRAKIA243-S",
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "FINES Central Park Burgas",
                    Address = "Бул. Даме Груев 6б, Бургас 8005, България",
                    City = "Бургас",
                    Latitude = 42.510709m,
                    Longitude = 27.458609m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Fines Charging",
                    ExternalId = "LV-BURGAS-CENTRALPARK",
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "Hydro Power Plant Kadievo",
                    Address = "Ул. 4-Та 56, Кадиево 4213, България",
                    City = "Кадиево",
                    Latitude = 42.134592m,
                    Longitude = 24.597142m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Fines Charging",
                    ExternalId = "LV-KADIEVO-0001",
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "FINES Dimar Stroy",
                    Address = "Бул. Бургаско Шосе, Сливен 8806, България",
                    City = "Сливен",
                    Latitude = 42.674277m,
                    Longitude = 26.369030m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Fines Charging",
                    ExternalId = "LV-SLIVEN-DMRSTROY",
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "FINES Ihtiman Burgas",
                    Address = "Автомагистрала Тракия, Ихтиман 2050, България",
                    City = "Ихтиман",
                    Latitude = 42.431943m,
                    Longitude = 23.850982m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Fines Charging",
                    ExternalId = "LV-IHTIMAN-TRAKIA1",
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "FINES Hotel City Sandanski",
                    Address = "Бул. Европа, Сандански 2800, България",
                    City = "Сандански",
                    Latitude = 41.540545m,
                    Longitude = 23.254595m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Fines Charging",
                    ExternalId = "LV-SANDANSKI-HOTELCITY",
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "FINES Hyundai Sofia",
                    Address = "Околовръстен Път 258, София 1766, България",
                    City = "София",
                    Latitude = 42.622979m,
                    Longitude = 23.379430m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Fines Charging",
                    ExternalId = "LV-SOFIA-HYUNDAI",
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "FINES Lukoil Sofia Ring",
                    Address = "Околовръстен Път 481, Враждебна 1839, България",
                    City = "София",
                    Latitude = 42.701606m,
                    Longitude = 23.449767m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Fines Charging",
                    ExternalId = "LV-SOFIA-LUKOILSOFIARINGEAST",
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "FINES Mr. Bricolage Blagoevgrad",
                    Address = "Яне Сандански 1, Благоевград 2703, България",
                    City = "Благоевград",
                    Latitude = 41.996591m,
                    Longitude = 23.087598m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Fines Charging",
                    ExternalId = "LV-BLAGOEVGRAD-BRICOLAGE",
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "FINES Mr. Bricolage XOPark",
                    Address = "Околовръстен Път, Челопечене 1853, България",
                    City = "София",
                    Latitude = 42.711416m,
                    Longitude = 23.451325m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Fines Charging",
                    ExternalId = "LV-SOFIA-BRCXOP",
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "FINES Retail Park Dobrich",
                    Address = "Бул. 25-Ти Септември 70, Добрич 9301, България",
                    City = "Добрич",
                    Latitude = 43.579055m,
                    Longitude = 27.830266m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Fines Charging",
                    ExternalId = "LV-DOBRICH-RTPARK1",
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "FINES Technomarket Haskovo",
                    Address = "5, Хасково 6304, България",
                    City = "Хасково",
                    Latitude = 41.931162m,
                    Longitude = 25.603756m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Fines Charging",
                    ExternalId = "LV-HASKOVO-FINES",
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "FINES Gelemenovo",
                    Address = "Ул. Шестнадесета 9, Гелеменово 4444, България",
                    City = "Гелеменово",
                    Latitude = 42.268348m,
                    Longitude = 24.314088m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Fines Charging",
                    ExternalId = "LV-GELEMENOVO-1",
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "FINES Hyundai Burgas",
                    Address = "Стефан Стамболов, Бургас 8008, България",
                    City = "Бургас",
                    Latitude = 42.540767m,
                    Longitude = 27.440882m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Fines Charging",
                    ExternalId = "LV-BURGAS-HYUNDAI1",
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "FINES Mall Yambol",
                    Address = "Кабиле 36а, Ямбол 8600, България",
                    City = "Ямбол",
                    Latitude = 42.485068m,
                    Longitude = 26.509479m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Fines Charging",
                    ExternalId = "LV-YAMBOL-MALL",
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "FINES MASTERHAUS Kazanlak",
                    Address = "Банянска, Казанлък 6102, България",
                    City = "Казанлък",
                    Latitude = 42.615117m,
                    Longitude = 25.406800m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Fines Charging",
                    ExternalId = "LV-KAZANLAK-0001",
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "FINES Mr. Bricolage Burgas",
                    Address = "Бул. Захари Стоянов, Бургас 8002, България",
                    City = "Бургас",
                    Latitude = 42.472232m,
                    Longitude = 27.432899m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Fines Charging",
                    ExternalId = "LV-BURGAS-MRBRICOLAGE",
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "FINES Mr. Bricolage Haskovo",
                    Address = "Дунав 17в, Хасково 6303, България",
                    City = "Хасково",
                    Latitude = 41.940045m,
                    Longitude = 25.557803m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Fines Charging",
                    ExternalId = "LV-HASKOVO-RPARKHSKOVO",
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "FINES Mr. Bricolage Plovdiv",
                    Address = "6-Ти Септември 242, Пловдив 4006, България",
                    City = "Пловдив",
                    Latitude = 42.153242m,
                    Longitude = 24.769216m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Fines Charging",
                    ExternalId = "LV-PLOVDIV-MRBRICOLAGE",
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "FINES Mr. Bricolage Ruse",
                    Address = "Розова Долина 4-6, Русе 7000, България",
                    City = "Русе",
                    Latitude = 43.845879m,
                    Longitude = 25.962189m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Fines Charging",
                    ExternalId = "LV-RUSE-MRBRICOLAGE",
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "FINES Omnicar Plovdiv Rodopi",
                    Address = "Бул. Константин Величков 49, Пловдив 4000, България",
                    City = "Пловдив",
                    Latitude = 42.133022m,
                    Longitude = 24.758334m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Fines Charging",
                    ExternalId = "LV-FINESOMNICARRODOP-0001",
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "FINES Porcelanosa",
                    Address = "Бул. Симеоновско Шосе 120, София 1700, България",
                    City = "София",
                    Latitude = 42.637257m,
                    Longitude = 23.333785m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Fines Charging",
                    ExternalId = "LV-PORCELANOSA-0001",
                    OperatorId = operatorId
                }
            ];
        }
    }
}