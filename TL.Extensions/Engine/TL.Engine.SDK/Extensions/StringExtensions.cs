using System;

namespace TL.Engine.SDK.Extensions
{
    /// <summary>
    /// Расширения типа <see cref="string"/>.
    /// </summary>
    public static class StringExtensions
    {
        /// <summary>
        /// Добавить к строке дату и время.
        /// </summary>
        /// <param name="str">Исходная строка.</param>
        /// <returns></returns>
        public static string AddDateTime(this string str)
        {
            var dt = DateTime.Now;
            return $"{dt} {str}";
        }

        /// <summary>
        /// Добавить к строке дату и время с милисекундами.
        /// </summary>
        /// <param name="str">Исходная строка.</param>
        /// <returns></returns>
        public static string AddDateTimeMs(this string str)
        {
            var dt = DateTime.Now;
            return $"{dt}.{dt.Millisecond} {str}";
        }

        /// <summary>
        /// Добавить к строке дату и время с милисекундами и тиками процессора.
        /// </summary>
        /// <param name="str">Исходная строка.</param>
        /// <returns></returns>
        public static string AddDateTimeMsTicks(this string str)
        {
            var dt = DateTime.Now;
            return $"{dt}.{dt.Millisecond} ({dt.Ticks}) {str}";
        }
    }
}
