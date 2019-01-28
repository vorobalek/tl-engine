using TL.Engine.SDK.Integrations.Telegram.Bots;
using TL.Engine.SDK.Integrations.Telegram.Handlers;

namespace TL.Integrations.Telegram.Handlers
{
    public class HMessage : HandlerBase
    {
        public HMessage(IBaseBot bot) : base(bot.GetType())
        {
            Bot = bot;
        }
    }
}
