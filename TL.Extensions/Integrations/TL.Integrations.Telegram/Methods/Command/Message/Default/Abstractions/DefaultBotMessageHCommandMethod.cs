using System;
using TL.Engine.SDK.Services;
using TL.Integrations.Telegram.Bots;

namespace TL.Integrations.Telegram.Methods.Command.Message.Default
{
    public abstract class DefaultBotMessageHCommandMethod : MessageHCommandMethod
    {
        public DefaultBotMessageHCommandMethod(IActivatorService activator) : base(activator)
        {
        }

        public override Type BotType => typeof(DefaultBot);

        public new DefaultBot Bot => base.Bot as DefaultBot;
    }
}
