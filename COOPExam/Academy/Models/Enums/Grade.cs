namespace Academy.Models.Enums
{
    public enum Grade
    {
        Failed = 0,
        Passed = 1,
        Excellent = 2
    }
    public static class TrackPrint
    {
        public static string ToFriendlyString(this Grade me)
        {
            switch (me)
            {
                case Grade.Failed:
                    return "Failed";
                case Grade.Passed:
                    return "Passed";
                case Grade.Excellent:
                    return "Excellent";
                default:
                    return "You should not look here!";
            }
        }
    }
}
