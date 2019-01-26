using System;
using System.Threading.Tasks;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using TL.Engine.SDK.Integrations.Telegram.Bots;

namespace TL.Engine.SDK.Integrations.Telegram.Handlers
{
    public abstract class HandlerMethodBase : IHandlerMethodBase
    {
        public virtual IBaseBot Bot => Handler?.Bot;
        public virtual IHandlerBase Handler { get; set; }

        public HandlerMethodBase(Type handlerType)
        {
            HandlerType = handlerType;
        }

        public abstract string Command { get; }
        public abstract string Description { get; }

        public virtual bool IsPrivate => false;
        public virtual bool IsTerminated => false;

        public abstract bool IsRelevantMethod(Update update);
        public abstract bool IsPolicyAcceptable(Update update);

        public abstract Type BotType { get; }
        public Type HandlerType { get; }

        public abstract UpdateType UpdateType { get; }

        public abstract Task<IHandlerMethodResult> ExecuteAsync(Update update);
    }
}
