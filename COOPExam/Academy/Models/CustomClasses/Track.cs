using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Models.CustomClasses
{
    public enum Track
    {
        Frontend = 0,
        Dev = 1,
        None = 2
    }
    public static class TrackPrint
    {
        public static string ToFriendlyString(this Track me)
        {
            switch (me)
            {
                case Track.None:
                    return "None";
                case Track.Frontend:
                    return "Frontend";
                case Track.Dev:
                    return "Dev";
                default:
                    return "You should not look here!";
            }
        }
    }
}
