using TL.Engine.Data.Entities.System;
using TL.Engine.Data.Managers;
using TL.Engine.SDK.Actions;
using TL.Engine.Web.Middleware;

namespace TL.Engine.Web.Actions
{
    public class CheckEngineSystemStringVaribaleStartupAction : IStartupAction
    {
        IStringVariableManager StringVariableManager { get; set; }

        public bool IsBlocker => true;

        public int Priority => 1000;

        public string Description => "Проверка системных переменных ядра";

        public CheckEngineSystemStringVaribaleStartupAction(IStringVariableManager stringVariableManager)
        {
            StringVariableManager = stringVariableManager;
        }

        public IStartupActionResult Invoke()
        {
            if (StringVariableManager.Get(CheckActivityMiddleware.CheckActivityEnableVariable) == null)
            {
                StringVariableManager.Create(new StringVariable(CheckActivityMiddleware.CheckActivityEnableVariable, true.ToString()));
            }
            if (StringVariableManager.Get(CheckActivityMiddleware.UpdateActivityEnableVariable) == null)
            {
                StringVariableManager.Create(new StringVariable(CheckActivityMiddleware.UpdateActivityEnableVariable, false.ToString()));
            }
            return StartupActionResult.Good(description: Description);
        }
    }
}
