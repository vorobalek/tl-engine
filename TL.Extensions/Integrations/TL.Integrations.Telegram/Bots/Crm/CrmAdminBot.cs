using System;

namespace TL.Integrations.Telegram.Bots.Crm
{
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
