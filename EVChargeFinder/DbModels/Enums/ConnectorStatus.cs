namespace EVChargeFinder.DbModels.Enums
{
    public enum ConnectorStatus
    {
       
        Available = 1,
        Preparing = 2,
        Charging = 3,
        SuspendedByEv = 4,
        SuspendedByEvSe = 5,
        Finishing = 6,
        Reserved = 7,
        Occupied = 8,
        Unavailable = 9,
        Faulted = 10,
        Offline = 11,
        Unknown = 0
    }
}