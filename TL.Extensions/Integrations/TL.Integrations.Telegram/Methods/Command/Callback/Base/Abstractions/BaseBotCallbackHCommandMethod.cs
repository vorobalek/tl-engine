using System;
using TL.Integrations.Telegram.Bots;

namespace TL.Integrations.Telegram.Methods.Command.Callback.Base
{
    public abstract class BaseBotCallbackHCommandMethod : CallbackHCommandMethod
    {
        public override Type BotType => typeof(BaseBot);

        public new BaseBot Bot => base.Bot as BaseBot;
    }
}
