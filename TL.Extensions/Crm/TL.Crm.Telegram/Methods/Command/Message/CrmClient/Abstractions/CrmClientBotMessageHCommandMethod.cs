using System;
using TL.Crm.Telegram.Bots;
using TL.Integrations.Telegram.Methods.Command.Message;

namespace TL.Crm.Telegram.Methods.Command.Message.CrmClient
{
    public abstract class CrmClientBotMessageHCommandMethod : MessageHCommandMethod
    {
        public override Type BotType => typeof(CrmClientBot);

        public new CrmClientBot Bot => base.Bot as CrmClientBot;
    }
}
