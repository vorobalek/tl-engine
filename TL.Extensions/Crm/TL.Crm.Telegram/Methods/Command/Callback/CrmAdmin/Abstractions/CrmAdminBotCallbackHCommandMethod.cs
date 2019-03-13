using System;
using TL.Crm.Telegram.Bots;
using TL.Integrations.Telegram.Methods.Command.Callback;

namespace TL.Crm.Telegram.Methods.Command.Callback.CrmAdmin
{
    public abstract class CrmAdminBotCallbackHCommandMethod : CallbackHCommandMethod
    {
        public override Type BotType => typeof(CrmAdminBot);

        public new CrmAdminBot Bot => base.Bot as CrmAdminBot;
    }
}
