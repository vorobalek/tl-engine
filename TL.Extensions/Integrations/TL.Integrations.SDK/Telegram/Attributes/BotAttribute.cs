using System;

namespace TL.Integrations.SDK.Telegram.Attributes
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
