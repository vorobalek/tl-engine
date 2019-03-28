using System.Collections.Generic;

namespace TL.Integrations.SDK.Telegram.Handlers
{
    public interface IHandlerResult
    {
        bool IsOk { get; }

        bool IsFill { get; }

        IEnumerable<IHandlerMethodResult> Results { get; }
    }
}
