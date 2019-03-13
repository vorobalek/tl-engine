using System;
using TL.Engine.SDK.Attributes.Bots;
using TL.Integrations.Telegram.Bots;

namespace TL.Crm.Telegram.Bots
{
    [Bot("CRM.Клиенты")]
    public class CrmClientBot : BaseBot
    {
        public CrmClientBot(IServiceProvider serviceProvider, string token, bool skipUpdates) : base(serviceProvider, token, skipUpdates)
        {
        }

        public CrmClientBot(IServiceProvider serviceProvider, string token, string name = null, bool skipUpdates = false) : base(serviceProvider, token, name, skipUpdates)
        {
        }
    }
}
