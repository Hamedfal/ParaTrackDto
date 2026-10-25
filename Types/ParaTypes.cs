namespace ParaTrackDto.Types
{
    /// <summary>
    /// 64 bits access permissions
    /// </summary>
    [Flags]
    public enum ParaPermissions : ulong
    {
        NONE = 0x0000000000000000,

        /// <summary>
        /// 0x8000, 0000, 0000, 0000
        /// </summary>
        SUPERUSER = 0x8000000000000000
    }

    [Flags]
    public enum ParaRole : uint
    {
        NONE = 0x00000000,

        /// <summary>
        /// 0x8000, 0000
        /// </summary>
        SUPERUSER = 0x80000000
    }

    public enum FrequencyType
    {
        Hourly = 0,
        Daily = 1,
        Weekly = 2
    }

    public enum PatrolStatus
    {
        NONE = 0,

        AWAITING,

        INPROGRESS,

        COMPLETED,

        MISSED
    }

    public enum IncidentPriority
    {
        LOW = 0,

        REGULAR,

        HIGH
    }

    public enum IncidentStatus
    {
        OPEN = 0,
        INPROGRESS,
        ONHOLD,
        CLOSED
    }

    public enum KeyType
    {
        KEY = 0,
        FOB = 1
    }
}
