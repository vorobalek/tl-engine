using TL.Integrations.SDK.Telegram.Bots;

namespace TL.Integrations.SDK.Telegram.Handlers
{
    public abstract class Handler : HandlerBase
    {
        public Handler(IBaseBot bot) : base(bot.GetType())
        {
            Bot = bot;
        }
    }

    public abstract class Handler<TBot> : HandlerBase where TBot : BaseBot
    {
        public Handler() : base(typeof(TBot))
        {
        }

        public Handler(TBot bot) : this()
        {
            Bot = bot;
        }

        public new TBot Bot { get => base.Bot as TBot; set => base.Bot = value; }
    }
}
