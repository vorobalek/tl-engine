using System;
using TL.Crm.Telegram.Bots;
using TL.Integrations.Telegram.Methods.Command.Callback;

namespace TL.Crm.Telegram.Methods.Command.Callback.CrmClient
{
    public abstract class CrmClientBotCallbackHCommandMethod : CallbackHCommandMethod
    {
        public override Type BotType => typeof(CrmClientBot);

        public new CrmClientBot Bot => base.Bot as CrmClientBot;
    }
}
