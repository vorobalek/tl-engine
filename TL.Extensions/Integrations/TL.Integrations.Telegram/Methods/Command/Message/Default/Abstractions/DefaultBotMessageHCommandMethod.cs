using System;
using TL.Integrations.Telegram.Bots;

namespace TL.Integrations.Telegram.Methods.Command.Message.Default
{
    public abstract class DefaultBotMessageHCommandMethod : MessageHCommandMethod
    {
        public override Type BotType => typeof(DefaultBot);
    }
}
