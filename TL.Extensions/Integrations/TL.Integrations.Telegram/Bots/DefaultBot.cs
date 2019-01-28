using Microsoft.Extensions.Logging;

namespace TL.Integrations.Telegram.Bots
{
    public class DefaultBot : BaseBot
    {
        public DefaultBot(ILoggerFactory loggerFactory, string token, string name = null) : base(loggerFactory, token, name)
        {
        }
    }
}
