using System;

namespace TL.Engine.SDK.Attributes.Bots
{
    [AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = true)]
    public class BotAttribute : Attribute
    {
        public string Name { get; }

        public BotAttribute(string name)
        {
            Name = name;
        }
    }
}
