using ExtCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Telegram.Bot.Types;
using TL.Integrations.SDK.Telegram.Bots;
using TL.Integrations.SDK.Telegram.Extensions;

namespace TL.Integrations.SDK.Telegram.Handlers
{
    public abstract class HandlerBase : IHandlerBase
    {
        public virtual IBaseBot Bot { get; protected set; }

        public HandlerBase(Type botType)
        {
            Methods = new List<IHandlerMethodBase>();
            ExtensionManager
                .GetInstances<IHandlerMethodBase>()
                .Where(m => !m.IsTerminated && m.HandlerType == GetType() && m.BotType == botType)
                .ToList()
                .ForEach(m =>
                {
                    m.Handler = this;
                    Methods.Add(m);
                });
        }

        public List<IHandlerMethodBase> Methods { get; private set; }

        public async Task<IHandlerResult> ExecuteAsync(Update update, params object[] args)
        {
            var methods = Methods
                .Where(m => m.IsPolicyAcceptable(update, args) && m.IsRelevantMethod(update, args))
                .OrderBy(m => m.Priority);

            var results = await methods.ExecuteAsync(update, args);

            return new HandlerResult(results);
        }
    }
}
