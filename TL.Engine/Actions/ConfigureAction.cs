using ExtCore.Infrastructure.Actions;
using Microsoft.AspNetCore.Builder;
using System;
using TL.Engine.Middleware;

namespace TL.Engine.Actions
{
    public class ConfigureAction : IConfigureAction
    {
        public int Priority => int.MinValue;

        public void Execute(IApplicationBuilder applicationBuilder, IServiceProvider serviceProvider)
        {
            applicationBuilder.UseFailRedirection();
        }
    }
}
