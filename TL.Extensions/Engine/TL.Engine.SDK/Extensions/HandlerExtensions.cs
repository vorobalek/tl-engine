using ExtCore.Infrastructure;
using System.Linq;
using TL.Engine.SDK.Integrations.Telegram.Bots;
using TL.Engine.SDK.Integrations.Telegram.Handlers;

namespace TL.Engine.SDK.Extensions
{
    public static class HandlerExtensions
    {
        public static IHandlerBase ImportBaseMethods<T>(this IHandlerBase handler) where T : IBaseBot
        {
            ExtensionManager
                 .GetInstances<IHandlerMethodBase>()
                 .Where(m => !m.IsTerminated && m.HandlerType == handler.GetType() && m.BotType == typeof(T))
                 .ToList()
                 .ForEach(m =>
                 {
                     if (handler.Methods.FirstOrDefault(it => it.GetType() == m.GetType()) == null)
                     {
                         m.Handler = handler;
                         handler.Methods.Add(m);
                     }
                 });
            return handler;
        }
    }
}
