using System;

namespace TL.Integrations.Telegram.Bots.Crm
{
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
