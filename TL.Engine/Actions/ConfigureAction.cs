using ExtCore.Infrastructure.Actions;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using TL.Engine.Middleware;
using TL.Engine.SDK.Services;

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
