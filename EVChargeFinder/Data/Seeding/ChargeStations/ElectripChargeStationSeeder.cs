namespace EVChargeFinder.Data.Seeding.ChargeStations
{
    using DbModels;
    using DbModels.Enums;

    public static class ElectripChargeStationSeeder
    {
        public static ChargeStation[] GetChargeStations(int operatorId)
        {
            return 
            [
                new ChargeStation
                {
                    Name = "Electrip Plovdiv Plaza Mall",
                    Address = "ул. Д-р Георги Странски 3",
                    City = "Пловдив",
                    Latitude = 42.144827m,
                    Longitude = 24.781437m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Electrip",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "Electrip Hotel Ostrova Plovdiv",
                    Address = "ул. Парк Отдих и Култура 40",
                    City = "Пловдив",
                    Latitude = 42.140863m,
                    Longitude = 24.699449m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Electrip",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "Electrip Grand Hotel Plovdiv",
                    Address = "ул. Златю Бояджиев 2",
                    City = "Пловдив",
                    Latitude = 42.155934m,
                    Longitude = 24.745543m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Electrip",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "Electrip Flavia Business Park",
                    Address = "ул. Индустриална",
                    City = "Пловдив",
                    Latitude = 42.120312m,
                    Longitude = 24.756208m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Electrip",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "Electrip MegaLux Plovdiv",
                    Address = "бул. Асеновградско шосе 9",
                    City = "Пловдив",
                    Latitude = 42.124084m,
                    Longitude = 24.772849m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Electrip",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "Electrip Hotel Antique Plovdiv",
                    Address = "бул. Васил Априлов 1А",
                    City = "Пловдив",
                    Latitude = 42.136335m,
                    Longitude = 24.741370m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Electrip",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "Electrip Royal City Plovdiv",
                    Address = "бул. Дунав 5",
                    City = "Пловдив",
                    Latitude = 42.162306m,
                    Longitude = 24.735444m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Electrip",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "Electrip Retail Park Karlovo",
                    Address = "ул. Ген. Владимир Заимов 32",
                    City = "Карлово",
                    Latitude = 42.633833m,
                    Longitude = 24.800667m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Electrip",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "Electrip Yantra Grand Hotel",
                    Address = "ул. Опълченска 2",
                    City = "Велико Търново",
                    Latitude = 43.083259m,
                    Longitude = 25.640885m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Electrip",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "Electrip Hotel Kalina Palace",
                    Address = "ул. Панорама 15",
                    City = "Трявна",
                    Latitude = 42.870053m,
                    Longitude = 25.487290m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Electrip",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "Electrip Midalidare Hotel & SPA",
                    Address = "с. Могилово",
                    City = "Могилово",
                    Latitude = 42.341139m,
                    Longitude = 25.399028m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Electrip",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "Electrip Rompetrol Nova Zagora",
                    Address = "АМ Тракия, км 244",
                    City = "Нова Загора",
                    Latitude = 42.453900m,
                    Longitude = 26.051460m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Electrip",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "Electrip Prohoda Gurkovo Complex",
                    Address = "ул. Прохода 39",
                    City = "Гурково",
                    Latitude = 42.653500m,
                    Longitude = 25.800472m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Electrip",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "Electrip Shell Pirdop",
                    Address = "ул. Цар Освободител 2",
                    City = "Пирдоп",
                    Latitude = 42.701958m,
                    Longitude = 24.185972m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Electrip",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "Electrip Retail Park Targovishte",
                    Address = "бул. Сюрен 29",
                    City = "Търговище",
                    Latitude = 43.241778m,
                    Longitude = 26.558000m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Electrip",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "Electrip Retail Park Troyan",
                    Address = "ул. Акад. Ангел Балевски 1",
                    City = "Троян",
                    Latitude = 42.892750m,
                    Longitude = 24.716694m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Electrip",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "Electrip Hotel Ostrova Troyan",
                    Address = "ул. Балкан 8",
                    City = "Бели Осъм",
                    Latitude = 42.863028m,
                    Longitude = 24.659944m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Electrip",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "Electrip Hotel Valor Montana",
                    Address = "бул. Генерал Арнолди 5",
                    City = "Монтана",
                    Latitude = 43.418333m,
                    Longitude = 23.222278m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Electrip",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "Electrip Stil Lux Yambol",
                    Address = "бул. Граф Игнатиев 185",
                    City = "Ямбол",
                    Latitude = 42.465361m,
                    Longitude = 26.526083m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Electrip",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "Electrip Mall Pernik",
                    Address = "ул. Св. Св. Кирил и Методий 23",
                    City = "Перник",
                    Latitude = 42.611028m,
                    Longitude = 23.040667m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Electrip",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "Electrip Technomarket Varna",
                    Address = "ул. Коево 2",
                    City = "Варна",
                    Latitude = 43.232694m,
                    Longitude = 27.866333m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Electrip",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "Electrip Varna Towers",
                    Address = "бул. Владислав Варненчик 260",
                    City = "Варна",
                    Latitude = 43.222190m,
                    Longitude = 27.876606m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Electrip",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "Electrip Melia Grand Hermitage",
                    Address = "к.к. Златни пясъци",
                    City = "Варна",
                    Latitude = 43.290444m,
                    Longitude = 28.043639m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Electrip",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "Electrip Hotel Fantasia Haskovo",
                    Address = "парк Кенана",
                    City = "Хасково",
                    Latitude = 41.943460m,
                    Longitude = 25.543490m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Electrip",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "Electrip Katarzyna Estate",
                    Address = "Katarzyna Estate, с. Мезек",
                    City = "Мезек",
                    Latitude = 41.747040m,
                    Longitude = 26.139140m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Electrip",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "Electrip Merit Grand Mosta Hotel Casino & Spa",
                    Address = "ул. Суворов",
                    City = "Свиленград",
                    Latitude = 41.770361m,
                    Longitude = 26.190889m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Electrip",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "Electrip Pirin Park Hotel",
                    Address = "ул. Хидрострой 27",
                    City = "Сандански",
                    Latitude = 41.581974m,
                    Longitude = 23.289111m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Electrip",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "Electrip Hotel Cornelia Deluxe",
                    Address = "местност Бетоловото",
                    City = "Разлог",
                    Latitude = 41.856792m,
                    Longitude = 23.415848m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Electrip",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "Electrip Ruskovets Thermal SPA & Ski Resort",
                    Address = "ул. Незнаен войн 1",
                    City = "Добринище",
                    Latitude = 41.824904m,
                    Longitude = 23.565390m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Electrip",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "Electrip SPA Resort St. Ivan Rilski",
                    Address = "ул. Свети Иван 4",
                    City = "Банско",
                    Latitude = 41.822726m,
                    Longitude = 23.488544m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Electrip",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "Electrip Hotel Yastrebets Wellness & Spa",
                    Address = "к.к. Боровец",
                    City = "Боровец",
                    Latitude = 42.258472m,
                    Longitude = 23.582889m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Electrip",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "Electrip Retail Park Razlog",
                    Address = "ул. Мехомия 20",
                    City = "Разлог",
                    Latitude = 41.879322m,
                    Longitude = 23.472326m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Electrip",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "Electrip Petrol 7315 Struma Highway",
                    Address = "АМ Струма, Студена",
                    City = "Студена",
                    Latitude = 42.583750m,
                    Longitude = 23.120194m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Electrip",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "Electrip Kruiz Blagoevgrad",
                    Address = "Южна промишлена зона",
                    City = "Благоевград",
                    Latitude = 42.008600m,
                    Longitude = 23.086140m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Electrip",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "Electrip Gotse Delchev Petrol Station",
                    Address = "Републикански път II-19",
                    City = "Хаджидимово",
                    Latitude = 41.539963m,
                    Longitude = 23.777992m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Electrip",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "Electrip Complex Komitite",
                    Address = "Комплекс Комитите, с. Чучулигово",
                    City = "Чучулигово",
                    Latitude = 41.405727m,
                    Longitude = 23.360201m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Electrip",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "Electrip Petrol Kulata",
                    Address = "E79, Кулата",
                    City = "Кулата",
                    Latitude = 41.384119m,
                    Longitude = 23.361654m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Electrip",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "Electrip Kruiz Petrich",
                    Address = "бензиностанция Круиз",
                    City = "Петрич",
                    Latitude = 41.405208m,
                    Longitude = 23.204165m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Electrip",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "Electrip Kruiz Chepelare",
                    Address = "път Пловдив - Чепеларе",
                    City = "Чепеларе",
                    Latitude = 41.694579m,
                    Longitude = 24.692938m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Electrip",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "Electrip Grand Hotel Murgavets",
                    Address = "център Пампорово",
                    City = "Пампорово",
                    Latitude = 41.657428m,
                    Longitude = 24.695471m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Electrip",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "Electrip Hotel Nero",
                    Address = "к.к. Пампорово",
                    City = "Пампорово",
                    Latitude = 41.646611m,
                    Longitude = 24.698000m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Electrip",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "Electrip Spa Hotel Devin",
                    Address = "ул. Дружба 2А",
                    City = "Девин",
                    Latitude = 41.742982m,
                    Longitude = 24.400920m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Electrip",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "Electrip Sol Luna Bay Resort",
                    Address = "Obzor Beach",
                    City = "Обзор",
                    Latitude = 42.840472m,
                    Longitude = 27.881417m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Electrip",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "Electrip Sol Nessebar Bay",
                    Address = "ул. Аурелия 7",
                    City = "Несебър",
                    Latitude = 42.653177m,
                    Longitude = 27.700711m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Electrip",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "Electrip Cacao Beach",
                    Address = "Cacao Beach, Слънчев бряг",
                    City = "Слънчев бряг",
                    Latitude = 42.673500m,
                    Longitude = 27.711528m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Electrip",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "Electrip Hotel Dune",
                    Address = "Хотел Дюн, Слънчев бряг",
                    City = "Слънчев бряг",
                    Latitude = 42.697028m,
                    Longitude = 27.716472m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Electrip",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "Electrip Hotel Orlova Skala",
                    Address = "Хотел Орлова Скала",
                    City = "Лопян",
                    Latitude = 42.859569m,
                    Longitude = 24.088039m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Electrip",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "Electrip Hotel Tsarska Banya",
                    Address = "ул. Липите 26",
                    City = "Баня",
                    Latitude = 42.590100m,
                    Longitude = 24.782400m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Electrip",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "Electrip Hotel EMAR",
                    Address = "ул. Йордан Попмихайлов 3",
                    City = "Сапарева баня",
                    Latitude = 42.288335m,
                    Longitude = 23.251400m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Electrip",
                    ExternalId = null,
                    OperatorId = operatorId
                },

                new ChargeStation
                {
                    Name = "Electrip Retail Park Silistra",
                    Address = "Retail Park Silistra",
                    City = "Силистра",
                    Latitude = 44.113861m,
                    Longitude = 27.273056m,
                    ChargeStationStatus = ChargeStationStatus.Active,
                    DataSource = "Electrip",
                    ExternalId = null,
                    OperatorId = operatorId
                }
            ];
        }
    }
}