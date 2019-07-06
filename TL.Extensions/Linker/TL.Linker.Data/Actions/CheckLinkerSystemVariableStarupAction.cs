using Microsoft.Extensions.Logging;
using TL.Engine.Data.Entities.System;
using TL.Engine.Data.Managers;
using TL.Engine.SDK.Actions;
using TL.Linker.Data.Managers;

namespace TL.Linker.Data.Actions
{
    public class CheckLinkerSystemVariableStarupAction : IStartupAction
    {
        IStringVariableManager StringVariableManager { get; set; }

        ILogger<CheckLinkerSystemVariableStarupAction> Logger { get; set; }

        public int Priority => 10000;

        public string Description => "Проверка системных переменных модуля Linker";

        public CheckLinkerSystemVariableStarupAction(IStringVariableManager stringVariableManager, ILogger<CheckLinkerSystemVariableStarupAction> logger)
        {
            StringVariableManager = stringVariableManager;
            Logger = logger;
        }

        public IStartupActionResult Invoke()
        {
            if (StringVariableManager.Get(LinkManager.NameOfMaskVariable) == null)
            {
                StringVariableManager.Create(new StringVariable(LinkManager.NameOfMaskVariable, "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz"));
            }

            if (StringVariableManager.Get(LinkManager.NameOfMaxLengthVariable) == null)
            {
                StringVariableManager.Create(new StringVariable(LinkManager.NameOfMaxLengthVariable, 6.ToString()));
            }

            return StartupActionResult.Good(description: Description);
        }
    }
}
