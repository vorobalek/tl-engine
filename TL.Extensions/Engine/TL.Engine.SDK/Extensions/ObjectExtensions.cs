using System;
using System.Reflection;

namespace TL.Engine.SDK.Extensions
{
    public static class ObjectExtensions
    {
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

        public static void CopyFrom(this object destination, object source)
        {
            Copy(source, destination);
        }

        public static void CopyTo(this object source, object destination)
        {
            Copy(source, destination);
        }
    }
}
