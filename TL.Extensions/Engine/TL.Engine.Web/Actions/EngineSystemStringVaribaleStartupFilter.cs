using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using System;
using TL.Engine.Data.Entities.System;
using TL.Engine.Data.Managers;
using TL.Engine.Web.Middleware;

namespace TL.Engine.Web.Actions
{
    public class EngineSystemStringVaribaleStartupFilter : IStartupFilter
    {
        IStringVariableManager StringVariableManager { get; set; }

        public EngineSystemStringVaribaleStartupFilter(IStringVariableManager stringVariableManager)
        {
            StringVariableManager = stringVariableManager;
        }

        public Action<IApplicationBuilder> Configure(Action<IApplicationBuilder> next)
        {
            if (StringVariableManager.Get(CheckActivityMiddleware.CheckActivityEnableVariable) == null)
            {
                StringVariableManager.Create(new StringVariable(CheckActivityMiddleware.CheckActivityEnableVariable, true.ToString()));
            }
            if (StringVariableManager.Get(CheckActivityMiddleware.UpdateActivityEnableVariable) == null)
            {
                StringVariableManager.Create(new StringVariable(CheckActivityMiddleware.UpdateActivityEnableVariable, false.ToString()));
            }

            return next;
        }
    }
}
