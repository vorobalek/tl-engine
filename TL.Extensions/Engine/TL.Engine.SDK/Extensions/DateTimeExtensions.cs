using System;

namespace TL.Engine.SDK.Extensions
{
    /// <summary>
    /// Расширения типа <see cref="DateTime"/>.
    /// </summary>
    public static class DateTimeExtensions
    {
        /// <summary>
        /// Преобразовать в подробный строковый формат.
        /// </summary>
        /// <param name="dateTime">Отметка времени.</param>
        /// <returns>Преобразованная в подробный текстовы формат отметка времени.</returns>
        public static string ToDetailedString(this DateTime dateTime)
        {
            return $"{dateTime}.{dateTime.Millisecond.ToString("000")}";
        }
    }
}
