using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Telegram.Bot.Types;
using TL.Engine.SDK.Integrations.Telegram.Handlers;

namespace TL.Engine.SDK.Extensions
{
    public static class HandlerMethodExtensions
    {
        public static async Task<IEnumerable<IHandlerMethodResult>> ExecuteAsync(this IEnumerable<IHandlerMethodBase> methods, Update update)
        {
            var results = new List<IHandlerMethodResult>();
            if (methods.Count() > 0)
            {
                foreach (var method in methods)
                {
                    results.Add(await method.TryExecuteAsync(update));
                    if (method.IsBlocker) break;
                }
            }
            return results;
        }
    }
}
