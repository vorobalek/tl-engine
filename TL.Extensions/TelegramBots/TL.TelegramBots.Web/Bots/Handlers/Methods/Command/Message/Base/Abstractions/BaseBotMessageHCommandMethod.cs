using System;
using Telegram.Bot.Types;

namespace TL.TelegramBots.Web.Bots.Handlers.Methods.Command.Message.Base
{
    public abstract class BaseBotMessageHCommandMethod : MessageHCommandMethod
    {
        public override Type BotType => typeof(BaseBot);

        public override bool IsPolicyAcceptable(Update update)
        {
            return true;
        }
    }
}
