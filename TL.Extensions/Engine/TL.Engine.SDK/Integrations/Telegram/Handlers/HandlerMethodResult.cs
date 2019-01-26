namespace TL.Engine.SDK.Integrations.Telegram.Handlers
{
    public class HandlerMethodResult : IHandlerMethodResult
    {
        public HandlerMethodResult(bool ok, string result = null)
        {
            Ok = ok;
            Result = result;
        }

        public bool Ok { get; }

        public string Result { get; }
    }
}
