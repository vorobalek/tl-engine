using System;
using Telegram.Bot.Types;
using TL.Integrations.Telegram.Bots;

namespace TL.Integrations.Telegram.Methods.Command.Message.Base
{
    public abstract class BotMessageHCommandMethod : MessageHCommandMethod
    {
        public override Type BotType => typeof(BaseBot);

        public override bool IsPolicyAcceptable(Update update, params object[] args)
        {
            return true;
        }
    }
}
