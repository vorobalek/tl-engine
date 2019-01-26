using System;

namespace TL.TelegramBots.Web.Bots.Handlers.Methods.Command.Message.Default
{
    public abstract class DefaultBotMessageHCommandMethod : MessageHCommandMethod
    {
        public override Type BotType => typeof(DefaultBot);
    }
}
