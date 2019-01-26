using TL.Engine.SDK.Integrations.Telegram.Bots;
using TL.Engine.SDK.Integrations.Telegram.Handlers;

namespace TL.TelegramBots.Web.Bots.Handlers
{
    public class HCommand : HandlerBase
    {
        public HCommand(IBaseBot bot) : base(bot.GetType())
        {
            Bot = bot;
        }
    }
}
