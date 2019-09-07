using System;
using System.IO;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;

namespace TL.Engine.SDK.Extensions
{
    /// <summary>
    /// Расширения типа <see cref="object"/>.
    /// </summary>
    public static class ObjectExtensions
    {
        /// <summary>
        /// Копировать объект 
        /// </summary>
        /// <param name="source">Исходный объект.</param>
        /// <param name="destination">Назначение.</param>
        /// <exception cref="ArgumentNullException">
        /// source
        /// or
        /// destination
        /// </exception>
        /// <exception cref="ArgumentException"></exception>
        public static void Copy(object source, object destination)
        {
            if (source == null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            if (destination == null)
            {
                throw new ArgumentNullException(nameof(destination));
            }

            if (source.GetType() != destination.GetType())
            {
                throw new ArgumentException($"{nameof(source)} имеет тип, отличный от {nameof(destination)}");
            }

            foreach (var prop in source.GetType().GetProperties())
            {
                if (!prop.CanRead)
                {
                    continue;
                }
                var targetProp = destination.GetType().GetProperty(prop.Name);
                if (!targetProp.CanWrite)
                {
                    continue;
                }
                if (targetProp.GetSetMethod(true) != null && targetProp.GetSetMethod(true).IsPrivate)
                {
                    continue;
                }
                if ((targetProp.GetSetMethod().Attributes & MethodAttributes.Static) != 0)
                {
                    continue;
                }
                if (!targetProp.PropertyType.IsAssignableFrom(prop.PropertyType))
                {
                    continue;
                }
                targetProp.SetValue(destination, prop.GetValue(source));
            }
        }

        /// <summary>
        /// Копировать объект из источника.
        /// </summary>
        /// <param name="destination">Назначение.</param>
        /// <param name="source">Источник.</param>
        public static void CopyFrom(this object destination, object source)
        {
            Copy(source, destination);
        }

        /// <summary>
        /// Копировать источник в объект.
        /// </summary>
        /// <param name="source">Источник.</param>
        /// <param name="destination">Назначение.</param>
        public static void CopyTo(this object source, object destination)
        {
            Copy(source, destination);
        }

        public static byte[] ToByteArray(this object obj)
        {
            if (obj == null) return null;
            BinaryFormatter bf = new BinaryFormatter();
            using (MemoryStream ms = new MemoryStream())
            {
                bf.Serialize(ms, obj);
                return ms.ToArray();
            }
        }

        public static T FromByteArray<T>(this byte[] data)
        {
            if (data == null) return default;
            BinaryFormatter bf = new BinaryFormatter();
            using (MemoryStream ms = new MemoryStream(data))
            {
                object obj = bf.Deserialize(ms);
                return (T)obj;
            }
        }
    }
}
