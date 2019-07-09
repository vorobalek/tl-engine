using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace TL.Engine.SDK.Extensions
{
    /// <summary>
    /// Расширения типа <see cref="Enum"/>.
    /// </summary>
    public static class EnumExtensions
    {
        /// <summary>
        /// Получить имя, объявленное в <see cref="DisplayAttribute.Name"/>
        /// </summary>
        /// <param name="item">Элемент <see cref="Enum"/></param>
        /// <returns></returns>
        public static string DisplayName(this Enum item)
        {
            var type = item.GetType();
            var member = type.GetMember(item.ToString());
            DisplayAttribute displayName = (DisplayAttribute)member[0].GetCustomAttributes(typeof(DisplayAttribute), false).FirstOrDefault();

            if (displayName != null)
            {
                return displayName.Name;
            }

            return item.ToString();
        }
    }
}
