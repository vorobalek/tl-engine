namespace TL.Integrations.SDK.Telegram.Handlers
{
    public interface IHandlerMethodResult
    {
        bool Ok { get; }

        string Result { get; }

        string Exception { get; }
    }
}