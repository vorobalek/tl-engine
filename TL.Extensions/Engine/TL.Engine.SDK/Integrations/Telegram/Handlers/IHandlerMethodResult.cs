namespace TL.Engine.SDK.Integrations.Telegram.Handlers
{
    public interface IHandlerMethodResult
    {
        bool Ok { get; }

        string Result { get; }
    }
}