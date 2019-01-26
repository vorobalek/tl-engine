using TL.Engine.SDK.Integrations.Telegram.Bots;

namespace TL.Engine.SDK.Integrations.Telegram.Handlers
{
    public class Handler<TBot> : HandlerBase where TBot : IBaseBot
    {
        public Handler() : base(typeof(TBot))
        {
        }
    }
}
