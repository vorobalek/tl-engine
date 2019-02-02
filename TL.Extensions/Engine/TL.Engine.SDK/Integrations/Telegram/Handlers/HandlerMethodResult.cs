namespace TL.Engine.SDK.Integrations.Telegram.Handlers
{
    public class HandlerMethodResult : IHandlerMethodResult
    {
        public HandlerMethodResult(bool ok, string result = null, string exception = null)
        {
            Ok = ok;
            Result = result;
            Exception = exception;
        }

        public bool Ok { get; }

        public string Result { get; }

        public string Exception { get; }
    }
}
