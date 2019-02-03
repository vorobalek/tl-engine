using System;
using Telegram.Bot.Types;

namespace TL.Integrations.Telegram.Methods.Command.Callback.Base
{
    public abstract class BotCallbackHCommandMethod : CallbackHCommandMethod
    {
        public override Type BotType => typeof(Bots.BaseBot);

        protected override bool IsPolicyAcceptable(CallbackQuery callbackQuery, params object[] args)
        {
            return true;
        }
    }
}
