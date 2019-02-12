using System;
using Telegram.Bot.Types;
using TL.Integrations.Telegram.Bots;

namespace TL.Integrations.Telegram.Methods.Command.Callback.Base
{
    public abstract class BotCallbackHCommandMethod : CallbackHCommandMethod
    {
        public override Type BotType => typeof(BaseBot);

        public new BaseBot Bot => base.Bot as BaseBot;

        protected override bool IsPolicyAcceptable(CallbackQuery callbackQuery, params object[] args)
        {
            return true;
        }
    }
}
