using System;
using Telegram.Bot.Types;

namespace TL.Integrations.Telegram.Methods.Command.Callback.Default
{
    public abstract class DefaultBotCallbackHCommandMethod : CallbackHCommandMethod
    {
        public override Type BotType => typeof(Bots.DefaultBot);

        protected override bool IsPolicyAcceptable(CallbackQuery callbackQuery)
        {
            return true;
        }
    }
}
