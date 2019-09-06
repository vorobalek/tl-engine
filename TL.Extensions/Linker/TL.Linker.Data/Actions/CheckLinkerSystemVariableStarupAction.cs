using Microsoft.Extensions.Logging;
using TL.Engine.Data.Entities.System;
using TL.Engine.Data.Managers;
using TL.Engine.SDK.Actions;
using TL.Engine.SDK.Services;
using TL.Linker.Data.Managers;

namespace TL.Linker.Data.Actions
{
    public class CheckLinkerSystemVariableStarupAction : IStartupAction
    {
        IStringVariableManager StringVariableManager { get; }

        IStartupService Service { get; }

        public int Priority => 10000;

        public string Description => "Проверка системных переменных модуля Linker.";

        public CheckLinkerSystemVariableStarupAction(IStringVariableManager stringVariableManager, IStartupService service)
        {
            StringVariableManager = stringVariableManager;
            Service = service;
        }

        public IStartupActionResult Invoke()
        {
            if (StringVariableManager.Get(LinkManager.NameOfMaskVariable) == null)
            {
                Service.InvokeCallback($"Восстановление {LinkManager.NameOfMaskVariable}", 50);
                StringVariableManager.Create(new StringVariable(LinkManager.NameOfMaskVariable, "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz"));
            }

            if (StringVariableManager.Get(LinkManager.NameOfMaxLengthVariable) == null)
            {
                Service.InvokeCallback($"Восстановление {LinkManager.NameOfMaxLengthVariable}", 100);
                StringVariableManager.Create(new StringVariable(LinkManager.NameOfMaxLengthVariable, 6.ToString()));
            }

            return StartupActionResult.Good(description: Description);
        }
    }
}
