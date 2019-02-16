using System;
using TL.Crm.Telegram.Bots;
using TL.Integrations.Telegram.Methods.Command.Message;

namespace TL.Crm.Telegram.Methods.Command.Message.CrmAdmin
{
    public abstract class CrmAdminBotMessageHCommandMethod : MessageHCommandMethod
    {
        public override Type BotType => typeof(CrmAdminBot);

        public new CrmAdminBot Bot => base.Bot as CrmAdminBot;
    }
}
