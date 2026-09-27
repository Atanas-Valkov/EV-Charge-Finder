using EVChargeFinder.DbModels;
using EVChargeFinder.DbModels.Enums;

namespace EVChargeFinder.Data.Seeding.ChargeStations
{
    public static class EldriveChargeStationSeeder
    {
        public static ChargeStation[] GetChargeStations(int operatorId)
        {
            return
            [
                new ChargeStation
                {
                    Name = "Eldrive Praktis MEGA Sofia",
                    Address = "бул. Ботевградско шосе 527",
                    City = "София",
                    Latitude = 42.708167m,
                    Longitude = 23.460000m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Eldrive",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "Eldrive Grand Mall Varna",
                    Address = "ул. Академик Андрей Сахаров 2",
                    City = "Варна",
                    Latitude = 43.217804m,
                    Longitude = 27.897807m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Eldrive",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "Eldrive Shell Lyubimets West",
                    Address = "АМ Марица, Любимец",
                    City = "Любимец",
                    Latitude = 41.843240m,
                    Longitude = 26.122269m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Eldrive",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "Eldrive Shell Lyubimets East",
                    Address = "АМ Марица, Любимец",
                    City = "Любимец",
                    Latitude = 41.844539m,
                    Longitude = 26.119940m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Eldrive",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "Eldrive Shell Montana",
                    Address = "Околовръстен път, ул. Диана",
                    City = "Монтана",
                    Latitude = 43.406887m,
                    Longitude = 23.238914m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Eldrive",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "Eldrive Technopolis Nadezhda",
                    Address = "бул. История славянобългарска 13",
                    City = "София",
                    Latitude = 42.717007m,
                    Longitude = 23.317606m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Eldrive",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "Eldrive Billa Razgrad",
                    Address = "ул. Дунав 40",
                    City = "Разград",
                    Latitude = 43.529781m,
                    Longitude = 26.521058m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Eldrive",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "Eldrive Billa Samokov",
                    Address = "ул. Искър 2",
                    City = "Самоков",
                    Latitude = 42.334645m,
                    Longitude = 23.554896m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Eldrive",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "Eldrive Billa Sevlievo",
                    Address = "ул. Стефан Пешев 90А",
                    City = "Севлиево",
                    Latitude = 43.029222m,
                    Longitude = 25.091889m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Eldrive",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "Eldrive Bulport Logistics",
                    Address = "Южна промишлена зона, Бизнес сграда Булпорт",
                    City = "Варна",
                    Latitude = 43.199141m,
                    Longitude = 27.897161m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Eldrive",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "Eldrive The Mall Sofia",
                    Address = "бул. Цариградско шосе 115З",
                    City = "София",
                    Latitude = 42.660472m,
                    Longitude = 23.382139m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Eldrive",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "Eldrive XO Park Sofia",
                    Address = "бул. Ботевградско шосе 515-525",
                    City = "София",
                    Latitude = 42.709500m,
                    Longitude = 23.451583m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Eldrive",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "Eldrive Billa Nadezhda",
                    Address = "бул. Ломско шосе 171",
                    City = "София",
                    Latitude = 42.735917m,
                    Longitude = 23.291333m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Eldrive",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "Eldrive Billa Lincoln",
                    Address = "бул. Президент Линкълн 72",
                    City = "София",
                    Latitude = 42.689861m,
                    Longitude = 23.248444m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Eldrive",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "Eldrive Billa Hladilnika",
                    Address = "бул. Черни връх 94",
                    City = "София",
                    Latitude = 42.655917m,
                    Longitude = 23.315472m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Eldrive",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "Eldrive Billa Buxton",
                    Address = "бул. Братя Бъкстон 96",
                    City = "София",
                    Latitude = 42.658487m,
                    Longitude = 23.271816m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Eldrive",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "Eldrive Shell Studena",
                    Address = "АМ Струма, км 294+500",
                    City = "Студена",
                    Latitude = 42.539216m,
                    Longitude = 23.129031m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Eldrive",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "Eldrive Damyanitsa Hub",
                    Address = "гара Дамяница",
                    City = "Дамяница",
                    Latitude = 41.503443m,
                    Longitude = 23.272214m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Eldrive",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "Eldrive Technopolis Sandanski",
                    Address = "Магистрален път Е-79, разклона за с. Дамяница",
                    City = "Сандански",
                    Latitude = 41.512806m,
                    Longitude = 23.281083m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Eldrive",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "Eldrive Shell Yambol",
                    Address = "АМ Тракия, км 276+150",
                    City = "Хаджидимитрово",
                    Latitude = 42.532199m,
                    Longitude = 26.400016m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Eldrive",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "Eldrive Retail Park Vidin",
                    Address = "бул. Панония 43",
                    City = "Видин",
                    Latitude = 44.000838m,
                    Longitude = 22.869030m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Eldrive",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "Eldrive Holiday Park Pazardzhik",
                    Address = "бул. Стефан Стамболов 13",
                    City = "Пазарджик",
                    Latitude = 42.183140m,
                    Longitude = 24.345640m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Eldrive",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "Eldrive Holiday Park Haskovo",
                    Address = "Димитровградско шосе, срещу Бирената фабрика",
                    City = "Хасково",
                    Latitude = 41.969860m,
                    Longitude = 25.560498m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Eldrive",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "Eldrive Retail Park Dupnitsa",
                    Address = "ул. Отовица 1",
                    City = "Дупница",
                    Latitude = 42.273329m,
                    Longitude = 23.130305m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Eldrive",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "Eldrive Technopolis Blagoevgrad",
                    Address = "ул. Св. Димитър Солунски 5",
                    City = "Благоевград",
                    Latitude = 42.009639m,
                    Longitude = 23.093444m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Eldrive",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "Eldrive Technopolis Burgas 2",
                    Address = "бул. Транспортна 53",
                    City = "Бургас",
                    Latitude = 42.528139m,
                    Longitude = 27.453639m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Eldrive",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "Eldrive Shell Trakia South",
                    Address = "АМ Тракия, км 118+035, дясно, посока Бургас",
                    City = "Пловдив",
                    Latitude = 42.197708m,
                    Longitude = 24.633407m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Eldrive",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "Eldrive Shell Trakia North",
                    Address = "АМ Тракия, км 118+414, ляво, посока София",
                    City = "Пловдив",
                    Latitude = 42.198798m,
                    Longitude = 24.638033m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Eldrive",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "Eldrive Sea Cars Sandanski",
                    Address = "Главен път I-1",
                    City = "Сандански",
                    Latitude = 41.525636m,
                    Longitude = 23.273715m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Eldrive",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "Eldrive Moto-Pfohe Pleven",
                    Address = "ул. Сторгозия 191",
                    City = "Плевен",
                    Latitude = 43.430749m,
                    Longitude = 24.584956m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Eldrive",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "Eldrive Metropolitan Hotel Sofia",
                    Address = "бул. Цариградско шосе 64",
                    City = "София",
                    Latitude = 42.657069m,
                    Longitude = 23.383067m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Eldrive",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "Eldrive Billa Lulin",
                    Address = "бул. Царица Йоана 72",
                    City = "София",
                    Latitude = 42.719562m,
                    Longitude = 23.256477m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Eldrive",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "Eldrive Via Park North",
                    Address = "ул. Васил Левски 105",
                    City = "Пловдив",
                    Latitude = 42.172443m,
                    Longitude = 24.741551m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Eldrive",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "Eldrive Toyota Blagoevgrad",
                    Address = "Главен път Е79, 5-ти км, посока Кулата",
                    City = "Благоевград",
                    Latitude = 41.948429m,
                    Longitude = 23.096374m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Eldrive",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "Eldrive Bulgaria Mall",
                    Address = "бул. България 69",
                    City = "София",
                    Latitude = 42.663851m,
                    Longitude = 23.289549m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Eldrive",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "Eldrive Metro Sofia",
                    Address = "бул. Цариградско шосе 115",
                    City = "София",
                    Latitude = 42.647434m,
                    Longitude = 23.393671m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Eldrive",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "Eldrive Vasilevi Plaza",
                    Address = "ул. Индустриална 11",
                    City = "София",
                    Latitude = 42.707270m,
                    Longitude = 23.335125m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Eldrive",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "Eldrive Sofia Park",
                    Address = "ул. Рачо Петков Казанджията 8",
                    City = "София",
                    Latitude = 42.621328m,
                    Longitude = 23.368754m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Eldrive",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "Eldrive Sofia Airport Center",
                    Address = "бул. Христофор Колумб 64",
                    City = "София",
                    Latitude = 42.682408m,
                    Longitude = 23.403369m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Eldrive",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "Eldrive Sofia Airport Terminal 2",
                    Address = "Терминал 2",
                    City = "София",
                    Latitude = 42.687798m,
                    Longitude = 23.412938m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Eldrive",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "Eldrive Moto-Pfohe Sofia",
                    Address = "Околовръстен път 483",
                    City = "София",
                    Latitude = 42.703218m,
                    Longitude = 23.450091m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Eldrive",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "Eldrive Shell Lulin",
                    Address = "бул. Панчо Владигеров",
                    City = "София",
                    Latitude = 42.719273m,
                    Longitude = 23.253652m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Eldrive",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "Eldrive Fantastico G.M. Dimitrov",
                    Address = "бул. Д-р Г. М. Димитров",
                    City = "София",
                    Latitude = 42.658963m,
                    Longitude = 23.346611m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Eldrive",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "Eldrive Gazprom Tsarigradsko",
                    Address = "бул. Цариградско шосе 355",
                    City = "София",
                    Latitude = 42.638650m,
                    Longitude = 23.413177m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Eldrive",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "Eldrive KFC Sofia",
                    Address = "бул. Владимир Вазов 81",
                    City = "София",
                    Latitude = 42.709703m,
                    Longitude = 23.394364m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Eldrive",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "Eldrive Sheynovo",
                    Address = "ул. Шейново 6",
                    City = "София",
                    Latitude = 42.692607m,
                    Longitude = 23.337461m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Eldrive",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "Eldrive Fantastico Dragalevtsi",
                    Address = "бул. Черни връх 204",
                    City = "София",
                    Latitude = 42.641026m,
                    Longitude = 23.311901m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Eldrive",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "Eldrive Fantastico Bankya",
                    Address = "ул. Иванянско шосе 2",
                    City = "Банкя",
                    Latitude = 42.716489m,
                    Longitude = 23.170671m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Eldrive",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "Eldrive Metro Sofia Voluyak",
                    Address = "ул. Сливница 182",
                    City = "Волуяк",
                    Latitude = 42.746227m,
                    Longitude = 23.231627m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Eldrive",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "Eldrive Mall Plovdiv",
                    Address = "ул. Перущица 8",
                    City = "Пловдив",
                    Latitude = 42.141806m,
                    Longitude = 24.718645m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Eldrive",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "Eldrive VIA Park Plovdiv",
                    Address = "бул. Александър Стамболийски 131",
                    City = "Пловдив",
                    Latitude = 42.125037m,
                    Longitude = 24.721544m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Eldrive",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "Eldrive Haas Plovdiv",
                    Address = "бул. България 121",
                    City = "Пловдив",
                    Latitude = 42.155111m,
                    Longitude = 24.711056m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Eldrive",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "Eldrive HomeMax Plovdiv",
                    Address = "бул. Менделеев 2",
                    City = "Пловдив",
                    Latitude = 42.128528m,
                    Longitude = 24.769609m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Eldrive",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "Eldrive Gazprom Plovdiv",
                    Address = "Карловско шосе 38",
                    City = "Пловдив",
                    Latitude = 42.206666m,
                    Longitude = 24.733343m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Eldrive",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "Eldrive Shell Maritsa",
                    Address = "бул. 6-ти септември 152",
                    City = "Пловдив",
                    Latitude = 42.153911m,
                    Longitude = 24.763585m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Eldrive",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "Eldrive DKS Varna",
                    Address = "ул. Васил Друмев 73",
                    City = "Варна",
                    Latitude = 43.211382m,
                    Longitude = 27.932152m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Eldrive",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "Eldrive Landmark Centre Varna",
                    Address = "бул. Сливница 24",
                    City = "Варна",
                    Latitude = 43.207213m,
                    Longitude = 27.917652m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Eldrive",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "Eldrive Metro Varna",
                    Address = "бул. Цар Освободител 230",
                    City = "Варна",
                    Latitude = 43.232471m,
                    Longitude = 27.861250m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Eldrive",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "Eldrive HomeMax Varna",
                    Address = "бул. Владислав Варненчик 271",
                    City = "Варна",
                    Latitude = 43.221024m,
                    Longitude = 27.875832m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Eldrive",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "Eldrive Moto-Pfohe Varna",
                    Address = "срещу Летище Варна",
                    City = "Варна",
                    Latitude = 43.242053m,
                    Longitude = 27.832893m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Eldrive",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "Eldrive Business Park Varna",
                    Address = "АМ Хемус",
                    City = "Варна",
                    Latitude = 43.229200m,
                    Longitude = 27.856680m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Eldrive",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "Eldrive Shell Ruse",
                    Address = "бул. България 9",
                    City = "Русе",
                    Latitude = 43.833412m,
                    Longitude = 25.958274m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Eldrive",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "Eldrive Metro Ruse",
                    Address = "E85 1317",
                    City = "Русе",
                    Latitude = 43.814575m,
                    Longitude = 25.926704m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Eldrive",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "Eldrive Metro Pleven",
                    Address = "ул. Метро 11",
                    City = "Плевен",
                    Latitude = 43.437794m,
                    Longitude = 24.593060m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Eldrive",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "Eldrive America for Bulgaria Student Center",
                    Address = "ул. Свобода Бъчварова 12",
                    City = "Благоевград",
                    Latitude = 42.011444m,
                    Longitude = 23.095194m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Eldrive",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "Eldrive Metro Blagoevgrad",
                    Address = "ул. Зеленодолско шосе 17",
                    City = "Благоевград",
                    Latitude = 42.012244m,
                    Longitude = 23.067679m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Eldrive",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "Eldrive Panairski Livadi",
                    Address = "ул. Панаирски ливади 21",
                    City = "Гоце Делчев",
                    Latitude = 41.580469m,
                    Longitude = 23.744148m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Eldrive",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "Eldrive Nayden Gerov Bansko",
                    Address = "ул. Найден Геров 1",
                    City = "Банско",
                    Latitude = 41.828768m,
                    Longitude = 23.476816m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Eldrive",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "Eldrive Gazprom Bansko",
                    Address = "ул. Патриарх Евтимий",
                    City = "Банско",
                    Latitude = 41.851079m,
                    Longitude = 23.480954m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Eldrive",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "Eldrive Slivnitsa Municipality",
                    Address = "пл. Съединение 1",
                    City = "Сливница",
                    Latitude = 42.852251m,
                    Longitude = 23.037817m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Eldrive",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "Eldrive Abritus Razgrad",
                    Address = "бул. Априлско въстание 70",
                    City = "Разград",
                    Latitude = 43.523914m,
                    Longitude = 26.551679m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Eldrive",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "Eldrive Razgrad Center",
                    Address = "ул. Варна",
                    City = "Разград",
                    Latitude = 43.523451m,
                    Longitude = 26.523697m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Eldrive",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "Eldrive Hotel Serdika Silistra",
                    Address = "ул. Тутракан 27",
                    City = "Силистра",
                    Latitude = 44.107222m,
                    Longitude = 27.239250m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Eldrive",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "Eldrive Cedar Lovech",
                    Address = "ул. Велико Търново 7",
                    City = "Ловеч",
                    Latitude = 43.148108m,
                    Longitude = 24.723326m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Eldrive",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "Eldrive Billa Troyan",
                    Address = "ул. Г. С. Раковски 2",
                    City = "Троян",
                    Latitude = 42.885528m,
                    Longitude = 24.713557m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Eldrive",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "Eldrive Retail Park Smolyan",
                    Address = "ул. Доктор Петър Берон",
                    City = "Смолян",
                    Latitude = 41.571835m,
                    Longitude = 24.715837m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Eldrive",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "Eldrive Shell Shumen",
                    Address = "път I-2, км 112",
                    City = "Шумен",
                    Latitude = 43.314664m,
                    Longitude = 26.923360m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Eldrive",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "Eldrive Shell Pravets",
                    Address = "АМ Хемус",
                    City = "Правец",
                    Latitude = 42.908341m,
                    Longitude = 23.879809m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Eldrive",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "Eldrive Shell Enevo North",
                    Address = "АМ Хемус, Енево",
                    City = "Енево",
                    Latitude = 43.300363m,
                    Longitude = 27.226093m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Eldrive",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "Eldrive Santa Marina Holiday Village",
                    Address = "в.с. Санта Марина",
                    City = "Созопол",
                    Latitude = 42.408067m,
                    Longitude = 27.677854m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Eldrive",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "Eldrive Swimming Complex Flora",
                    Address = "ул. Иван Богоров",
                    City = "Бургас",
                    Latitude = 42.503361m,
                    Longitude = 27.478917m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Eldrive",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "Eldrive Rodopi Burgas",
                    Address = "ул. Родопи",
                    City = "Бургас",
                    Latitude = 42.504722m,
                    Longitude = 27.467472m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Eldrive",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "Eldrive Borisova Gradina",
                    Address = "ул. Александър Стамболийски 38",
                    City = "Бургас",
                    Latitude = 42.496056m,
                    Longitude = 27.465722m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Eldrive",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "Eldrive Boycho Branzov",
                    Address = "ул. Свети Пантелеймон Лечител",
                    City = "Бургас",
                    Latitude = 42.515582m,
                    Longitude = 27.467085m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Eldrive",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "Eldrive Parking Gurko",
                    Address = "ул. Генерал Гурко",
                    City = "Бургас",
                    Latitude = 42.501057m,
                    Longitude = 27.475863m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Eldrive",
                    ExternalId = null,
                    OperatorId = operatorId
                }
            ];
        }
    }
}