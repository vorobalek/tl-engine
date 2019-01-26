using Microsoft.Extensions.Logging;

namespace TL.TelegramBots.Web.Bots
{
    public class DefaultBot : BaseBot
    {
        public DefaultBot(ILoggerFactory loggerFactory, string token, string name = null) : base(loggerFactory, token, name)
        {
        }
    }
}
