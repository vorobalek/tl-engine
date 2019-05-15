using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Logging;
using System;
using TL.Engine.Data.Entities.System;
using TL.Engine.Data.Managers;
using TL.Engine.SDK.Extensions;
using TL.Engine.SDK.Services;
using TL.Engine.SDK.StartupFilers;
using TL.Linker.Data.Managers;

namespace TL.Linker.Data.Actions
{
    public class LinkerSystemVariableStarupFilter : BaseStartupFiler
    {
        IStringVariableManager StringVariableManager { get; set; }

        ILogger<LinkerSystemVariableStarupFilter> Logger { get; set; }

        public LinkerSystemVariableStarupFilter(IStringVariableManager stringVariableManager, ILogger<LinkerSystemVariableStarupFilter> logger, IStartupService startupService) : base(startupService)
        {
            StringVariableManager = stringVariableManager;
            Logger = logger;
        }

        protected override Action<IApplicationBuilder> Continue(Action<IApplicationBuilder> next)
        {
            try
            {
                if (StringVariableManager.Get(LinkManager.NameOfMaskVariable) == null)
                {
                    StringVariableManager.Create(new StringVariable(LinkManager.NameOfMaskVariable, "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz"));
                }

                if (StringVariableManager.Get(LinkManager.NameOfMaxLengthVariable) == null)
                {
                    StringVariableManager.Create(new StringVariable(LinkManager.NameOfMaxLengthVariable, 6.ToString()));
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
