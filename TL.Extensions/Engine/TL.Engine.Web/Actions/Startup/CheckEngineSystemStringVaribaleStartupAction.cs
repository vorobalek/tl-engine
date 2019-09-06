using TL.Engine.Data.Entities.System;
using TL.Engine.Data.Managers;
using TL.Engine.SDK.Actions;
using TL.Engine.SDK.Services;
using TL.Engine.Web.Middleware;

namespace TL.Engine.Web.Actions
{
    public class CheckEngineSystemStringVaribaleStartupAction : IStartupAction
    {
        IStringVariableManager StringVariableManager { get; }

        IStartupService Service { get; }

        public int Priority => 1000;

        public string Description => "Проверка системных переменных ядра.";

        public CheckEngineSystemStringVaribaleStartupAction(IStringVariableManager stringVariableManager, IStartupService service)
        {
            StringVariableManager = stringVariableManager;
            Service = service;
        }

        public IStartupActionResult Invoke()
        {
            if (StringVariableManager.Get(CheckActivityMiddleware.CheckActivityEnableVariable) == null)
            {
                Service.InvokeCallback($"Восстановление {CheckActivityMiddleware.CheckActivityEnableVariable}", 50);
                StringVariableManager.Create(new StringVariable(CheckActivityMiddleware.CheckActivityEnableVariable, true.ToString()));
            }

            if (StringVariableManager.Get(CheckActivityMiddleware.UpdateActivityEnableVariable) == null)
            {
                Service.InvokeCallback($"Восстановление {CheckActivityMiddleware.UpdateActivityEnableVariable}", 100);
                StringVariableManager.Create(new StringVariable(CheckActivityMiddleware.UpdateActivityEnableVariable, false.ToString()));
            }

            return StartupActionResult.Good(description: Description);
        }
    }
}
