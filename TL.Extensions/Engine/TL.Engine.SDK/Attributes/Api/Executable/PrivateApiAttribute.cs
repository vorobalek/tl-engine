using System;

namespace TL.Engine.SDK.Attributes.Api.Executable
{
    /// <summary>
    /// Атрибут приватного API-метода.
    /// </summary>
    /// <seealso cref="Attribute" />
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true, Inherited = true)]
    public class PrivateApiAttribute : Attribute
    {
        /// <summary>
        /// Описание.
        /// </summary>
        public string Description { get; set; }
    }
}
