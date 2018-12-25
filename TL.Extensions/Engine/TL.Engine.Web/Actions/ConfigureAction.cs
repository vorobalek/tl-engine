using ExtCore.Infrastructure.Actions;
using Microsoft.AspNetCore.Builder;
using System;
using TL.Engine.Web.Middleware;

namespace TL.Engine.Web.Actions
{
    public class ConfigureAction : IConfigureAction
    {
        public int Priority => int.MinValue;

        public void Execute(IApplicationBuilder applicationBuilder, IServiceProvider serviceProvider)
        {
            applicationBuilder.UseRequestTimestamp();
            applicationBuilder.UseStatusCodePagesWithReExecute("/StatusCode/{0}");
            applicationBuilder.UseExceptionHandler("/Error");
        }
    }
}
