using System;

namespace TL.Engine.SDK.Extensions
{
    public static class DateTimeExtensions
    {
        public static string ToDetailedString(this DateTime dateTime)
        {
            return $"{dateTime}.{dateTime.Millisecond.ToString("000")}";
        }
    }
}
