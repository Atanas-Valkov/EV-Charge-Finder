namespace EVChargeFinder.Common
{
    public class EntityValidation
    {
        public static class ChargeStation
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
    }
}