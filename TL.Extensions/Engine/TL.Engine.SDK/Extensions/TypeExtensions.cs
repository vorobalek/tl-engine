using System;
using System.Collections.Generic;

namespace TL.Engine.SDK.Extensions
{
    public static class TypeExtensions
    {
        public static string GetName(this Type type)
        {
            if (type?.IsGenericType ?? false)
            {
                var genericTypesNames = new List<string>();
                foreach (var item in type.GenericTypeArguments)
                {
                    genericTypesNames.Add(item.GetName());
                }

                return $"{type.Name.Split('`')[0]}<{string.Join(", ", genericTypesNames)}>";
            }

            return type?.Name;
        }

        public static string GetFullName(this Type type)
        {
            if (type?.IsGenericType ?? false)
            {
                var genericTypesNames = new List<string>();
                foreach (var item in type.GenericTypeArguments)
                {
                    genericTypesNames.Add(item.GetFullName());
                }

                return $"{type.Name.Split('`')[0]}<{string.Join(", ", genericTypesNames)}>";
            }

            return type?.FullName;
        }
    }
}
