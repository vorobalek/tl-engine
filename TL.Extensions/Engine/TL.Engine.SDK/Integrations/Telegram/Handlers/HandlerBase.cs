using ExtCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Telegram.Bot.Types;
using TL.Engine.SDK.Extensions;
using TL.Engine.SDK.Integrations.Telegram.Bots;

namespace TL.Engine.SDK.Integrations.Telegram.Handlers
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

        public async Task<IHandlerResult> ExecuteAsync(Update update)
        {
            var methods = Methods
                .Where(m => m.IsPolicyAcceptable(update) && m.IsRelevantMethod(update))
                .OrderBy(m => m.Priority);

            var results = await methods.ExecuteAsync(update);

            if (results.Count() == 0)
            {
                results = await Methods
                    .Where(m => m.Command == "notimplemented" && m.UpdateType == update.Type)
                    .OrderBy(m => m.Priority)
                    .ExecuteAsync(update);
            }

            return new HandlerResult(results);
        }
    }
}
