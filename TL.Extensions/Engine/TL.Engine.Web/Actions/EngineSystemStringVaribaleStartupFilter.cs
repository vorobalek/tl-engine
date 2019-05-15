using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Logging;
using System;
using TL.Engine.Data.Entities.System;
using TL.Engine.Data.Managers;
using TL.Engine.SDK.Extensions;
using TL.Engine.SDK.Services;
using TL.Engine.SDK.StartupFilers;
using TL.Engine.Web.Middleware;

namespace TL.Engine.Web.Actions
{
    public class EngineSystemStringVaribaleStartupFilter : BaseStartupFiler
    {
        IStringVariableManager StringVariableManager { get; set; }

        ILogger<EngineSystemStringVaribaleStartupFilter> Logger { get; set; }

        public EngineSystemStringVaribaleStartupFilter(IStringVariableManager stringVariableManager, ILogger<EngineSystemStringVaribaleStartupFilter> logger, IStartupService startupService) : base(startupService)
        {
            StringVariableManager = stringVariableManager;
            Logger = logger;
        }

        protected override Action<IApplicationBuilder> Continue(Action<IApplicationBuilder> next)
        {
            try
            {
                if (StringVariableManager.Get(CheckActivityMiddleware.CheckActivityEnableVariable) == null)
                {
                    StringVariableManager.Create(new StringVariable(CheckActivityMiddleware.CheckActivityEnableVariable, true.ToString()));
                }
                if (StringVariableManager.Get(CheckActivityMiddleware.UpdateActivityEnableVariable) == null)
                {
                    StringVariableManager.Create(new StringVariable(CheckActivityMiddleware.UpdateActivityEnableVariable, false.ToString()));
                }
            }
            catch (Exception ex)
            {
                Logger.TLogCritical($"Не удалось выполнить {GetType().GetFullName()}\r\n{ex}");
            }

            return next;
        }
    }
}
