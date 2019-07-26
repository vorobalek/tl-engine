using System;
using TL.Engine.SDK.Services;
using TL.Integrations.Telegram.Bots;

namespace TL.Integrations.Telegram.Methods.Command.Callback.Default
{
    public abstract class DefaultBotCallbackHCommandMethod : CallbackHCommandMethod
    {
        public DefaultBotCallbackHCommandMethod(IActivatorService activator) : base(activator)
        {
        }

        public override Type BotType => typeof(DefaultBot);

        public new DefaultBot Bot => base.Bot as DefaultBot;
    }
}
