using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Telegram.Bot.Types;
using TL.Integrations.SDK.Telegram.Handlers;

namespace TL.Integrations.SDK.Telegram.Extensions
{
    public static class HandlerMethodExtensions
    {
        public static async Task<IEnumerable<IHandlerMethodResult>> ExecuteAsync(this IEnumerable<IHandlerMethodBase> methods, Update update, params object[] args)
        {
            var results = new List<IHandlerMethodResult>();
            if (methods.Count() > 0)
            {
                foreach (var method in methods)
                {
                    results.Add(await method.TryExecuteAsync(update, args));
                    if (method.IsBlocker) break;
                    if (!method.CanInvokeNext) break;
                }
            }
            return results;
        }
    }
}
