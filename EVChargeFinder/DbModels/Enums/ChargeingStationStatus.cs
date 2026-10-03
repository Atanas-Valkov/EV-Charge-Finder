namespace EVChargeFinder.DbModels.Enums
{
    public enum ChargingStationStatus
    {
        
        Active = 1,
        Inactive = 2,
        PartiallyAvailable = 3,
        Unavailable = 4,
        Maintenance = 5,
        Faulted = 6,
        Offline = 7,
        Unknown = 8
    }
}