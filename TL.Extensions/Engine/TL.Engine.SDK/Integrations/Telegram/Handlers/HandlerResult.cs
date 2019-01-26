using System.Collections.Generic;
using System.Linq;

namespace TL.Engine.SDK.Integrations.Telegram.Handlers
{
    public class HandlerResult : IHandlerResult
    {
        public bool Ok => Results?.Any(it => it.Ok) ?? false;

        public HandlerResult(IEnumerable<IHandlerMethodResult> results)
        {
            Results = results;
        }

        public IEnumerable<IHandlerMethodResult> Results { get; }
    }
}
