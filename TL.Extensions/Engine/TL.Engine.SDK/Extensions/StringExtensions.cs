using System;

namespace TL.Engine.SDK.Extensions
{
    public static class StringExtensions
    {
        public static string AddDateTime(this string str)
        {
            var dt = DateTime.Now;
            return $"{dt} {str}";
        }

        public static string AddDateTimeMs(this string str)
        {
            var dt = DateTime.Now;
            return $"{dt}.{dt.Millisecond} {str}";
        }

        public static string AddDateTimeMsTicks(this string str)
        {
            var dt = DateTime.Now;
            return $"{dt}.{dt.Millisecond} ({dt.Ticks}) {str}";
        }
    }
}
