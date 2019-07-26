using TL.Engine.SDK.Services;

namespace TL.Integrations.SDK.Telegram.Handlers
{
    public abstract class HandlerMethod<THandler> : HandlerMethodBase where THandler : IHandlerBase
    {
        public HandlerMethod(IActivatorService activator) : base(activator)
        {
            Configure(typeof(THandler));
        }
    }
}
