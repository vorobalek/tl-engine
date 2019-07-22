using ExtCore.Infrastructure;
using System.Linq;
using TL.Integrations.SDK.Telegram.Bots;
using TL.Integrations.SDK.Telegram.Handlers;

namespace TL.Integrations.SDK.Telegram.Extensions
{
    public static class HandlerExtensions
    {
        public static IHandlerBase ImportBaseMethods<T>(this IHandlerBase handler) where T : IBaseBot
        {
            ExtensionManager
                 .GetInstances<IHandlerMethodBase>(useCaching: true)
                 .Where(m => !m.IsTerminated && m.HandlerType == handler.GetType() && m.BotType == typeof(T))
                 .ToList()
                 .ForEach(m =>
                 {
                     if (!handler.Methods.Select(it => it.GetType()).Contains(m.GetType()))
                     {
                         m.Handler = handler;
                         handler.Methods.Add(m);
                     }
                 });
            return handler;
        }
    }
}
