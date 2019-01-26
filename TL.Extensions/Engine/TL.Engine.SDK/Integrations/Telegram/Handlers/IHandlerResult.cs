using System.Collections.Generic;

namespace TL.Engine.SDK.Integrations.Telegram.Handlers
{
    public interface IHandlerResult
    {
        bool Ok { get; }

        IEnumerable<IHandlerMethodResult> Results { get; }
    }
}
