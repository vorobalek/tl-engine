namespace TL.Engine.SDK.Integrations.Telegram.Handlers
{
    public abstract class HandlerMethod<THandler> : HandlerMethodBase where THandler : IHandlerBase
    {
        public HandlerMethod() : base(typeof(THandler))
        {
        }
    }
}
