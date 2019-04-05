using System;

namespace TL.Engine.SDK.Attributes.Api.Executable
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true, Inherited = true)]
    public class PrivateApiAttribute : Attribute
    {
        public string Description { get; set; }
    }
}
