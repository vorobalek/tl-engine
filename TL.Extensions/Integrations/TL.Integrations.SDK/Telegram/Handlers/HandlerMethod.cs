namespace TL.Integrations.SDK.Telegram.Handlers
{
    public abstract class HandlerMethod<THandler> : HandlerMethodBase where THandler : IHandlerBase
    {
        public HandlerMethod() : base(typeof(THandler))
        {
        }
    }
}
