using System.Collections.Generic;
using System.Linq;

namespace TL.Engine.SDK.Integrations.Telegram.Handlers
{
    public class HandlerResult : IHandlerResult
    {
        public bool IsOk => IsFill && Results.All(it => it.Ok);

        public bool IsFill => Results != null && Results.Count() > 0;

        public HandlerResult(IEnumerable<IHandlerMethodResult> results)
        {
            Results = results;
        }

        public IEnumerable<IHandlerMethodResult> Results { get; }
    }
}
