namespace EVChargeFinder.Common
{
    public class EntityValidation
    {
        public static class ChargingStation
        {
            public const int NameMinLength = 2;
            public const int NameMaxLength = 150;

            public const int AddressMinLength = 1;
            public const int AddressMaxLength = 150;

            public const int CityMinLength = 2;
            public const int CityMaxLength = 200;

            public const string LatitudeMinValue = "-90";
            public const string LatitudeMaxValue = "90";

            public const string LongitudeMinValue = "-180";
            public const string LongitudeMaxValue = "180";

            public const int DataSourceMinLength = 2;
            public const int DataSourceMaxLength = 200;

            public const int ExternalIdMinLength = 1;
            public const int ExternalIdMaxLength = 100;

            public const int ChargingStationIdMinValue = 1;
            public const int ChargingStationIdMaxValue = int.MaxValue;  

        }

        public static class Operator
        {
            public const int NameMinLength = 2; 
            public const int NameMaxLength = 150;

            public const int WebsiteMinLength = 2;
            public const int WebsiteMaxLength = 100;
        }

        public static class Connector
        {
            public const int ExternalIdMaxLength = 100;
        }

        public static class ChargingSessions
        {
            public const int ConnectorIdMinValue = 1;
            public const int ConnectorIdMaxValue = int.MaxValue;

            public const double EnergyKWhMinValue = 0.01;
            public const double EnergyKWhMaxValue = 9999.99;

            public const double AppliedPricePerKWhMinValue = 0.01;
            public const double AppliedPricePerKWhMaxValue = 9999.99;
        }
    }
}