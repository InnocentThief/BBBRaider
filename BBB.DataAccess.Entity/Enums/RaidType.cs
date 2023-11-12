namespace BBB.DataAccess.Entity.Enums
{
    internal enum RaidType : byte
    {
        DH = 1,
        IH = 2,
    }

    internal static class RaidTypeConverter
    {
        internal static string ToText(this RaidType type)
        {
            return type switch
            {
                RaidType.DH => "Dunkle Stunden (Dark Hours)",
                RaidType.IH => "Stahlross (Iron Horse)",
                _ => "Unknown raid type",
            };
        }
    }
}
