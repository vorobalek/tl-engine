using System;
using TL.Integrations.Telegram.Bots;

namespace TL.Integrations.Telegram.Methods.Command.Callback.Default
{
    public abstract class DefaultBotCallbackHCommandMethod : CallbackHCommandMethod
    {
        public override Type BotType => typeof(DefaultBot);

        public new DefaultBot Bot => base.Bot as DefaultBot;
    }
}
