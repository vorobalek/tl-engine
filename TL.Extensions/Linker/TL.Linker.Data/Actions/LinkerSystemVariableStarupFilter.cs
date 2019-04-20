using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using System;
using TL.Engine.Data.Entities.System;
using TL.Engine.Data.Managers;
using TL.Linker.Data.Managers;

namespace TL.Linker.Data.Actions
{
    public class LinkerSystemVariableStarupFilter : IStartupFilter
    {
        IStringVariableManager StringVariableManager { get; set; }

        public LinkerSystemVariableStarupFilter(IStringVariableManager stringVariableManager)
        {
            StringVariableManager = stringVariableManager;
        }

        public Action<IApplicationBuilder> Configure(Action<IApplicationBuilder> next)
        {
            if (StringVariableManager.Get(LinkManager.NameOfMaskVariable) == null)
            {
                StringVariableManager.Create(new StringVariable(LinkManager.NameOfMaskVariable, "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz"));
            }

            if (StringVariableManager.Get(LinkManager.NameOfMaxLengthVariable) == null)
            {
                StringVariableManager.Create(new StringVariable(LinkManager.NameOfMaxLengthVariable, 6.ToString()));
            }

            return next;
        }
    }
}
