using System;
using TL.Integrations.Telegram.Bots;

namespace TL.Integrations.Telegram.Methods.Command.Message.Base
{
    public abstract class BaseBotMessageHCommandMethod : MessageHCommandMethod
    {
        public override Type BotType => typeof(BaseBot);

        public new BaseBot Bot => base.Bot as BaseBot;
    }
}
