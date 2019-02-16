using System;
using TL.Engine.SDK.Attributes.Bots;
using TL.Integrations.Telegram.Bots;

namespace TL.Crm.Telegram.Bots
{
    [Bot("CRM.Администрирование")]
    public class CrmAdminBot : BaseBot
    {
        public CrmAdminBot(IServiceProvider serviceProvider, string token, bool skipUpdates) : base(serviceProvider, token, skipUpdates)
        {
        }

        public CrmAdminBot(IServiceProvider serviceProvider, string token, string name = null, bool skipUpdates = false) : base(serviceProvider, token, name, skipUpdates)
        {
        }
    }
}
