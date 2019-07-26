using TL.Engine.SDK.Services;
using TL.Integrations.SDK.Telegram.Bots;

namespace TL.Integrations.SDK.Telegram.Handlers
{
    public abstract class Handler : HandlerBase
    {
        public Handler(IActivatorService activator) : base(activator)
        {
        }

        public virtual IHandlerBase Configure(IBaseBot bot)
        {
            Bot = bot;
            return this.Configure(bot.GetType());
        }
    }

    public abstract class Handler<TBot> : HandlerBase
        where TBot : BaseBot
    {
        public Handler(IActivatorService activator) : base(activator)
        {
        }

        public virtual IHandlerBase Configure(TBot bot)
        {
            Bot = bot;
            return this.Configure(bot.GetType());
        }

        public new TBot Bot { get => base.Bot as TBot; set => base.Bot = value; }
    }
}
