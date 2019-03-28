using System;
using System.Threading.Tasks;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using TL.Integrations.SDK.Telegram.Bots;

namespace TL.Integrations.SDK.Telegram.Handlers
{
    public abstract class HandlerMethodBase : IHandlerMethodBase
    {
        public virtual IBaseBot Bot => Handler?.Bot;
        public virtual IHandlerBase Handler { get; set; }

        public HandlerMethodBase(Type handlerType)
        {
            HandlerType = handlerType;
        }

        public virtual int Priority => 1000;
        public abstract string Command { get; }
        public abstract string Description { get; }

        public virtual bool IsBlocker => true;
        public virtual bool IsPrivate => false;
        public virtual bool IsTerminated => false;

        public abstract bool IsRelevantMethod(Update update, params object[] args);
        public abstract bool IsPolicyAcceptable(Update update, params object[] args);

        public virtual bool CanInvokeNext { get; private set; } = false;

        protected void AbortExecute()
        {
            CanInvokeNext = false;
        }

        protected void ContinueExecute()
        {
            CanInvokeNext = true;
        }

        public abstract Type BotType { get; }
        public Type HandlerType { get; }

        public abstract UpdateType UpdateType { get; }

        protected abstract Task<IHandlerMethodResult> ExecuteAsync(Update update, params object[] args);
        public virtual async Task<IHandlerMethodResult> TryExecuteAsync(Update update, params object[] args)
        {
            try
            {
                CanInvokeNext = false;
                return await ExecuteAsync(update, args);
            }
            catch (Exception ex)
            {
                return new HandlerMethodResult(false, "", $"{Command}: {ex}");
            }
        }
    }
}
