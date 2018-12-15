using ExtCore.Infrastructure.Actions;
using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Text;

namespace TL.Engine.Web.Actions
{
    public class ConfigureAction : IConfigureAction
    {
        public int Priority => 1000;

        public void Execute(IApplicationBuilder applicationBuilder, IServiceProvider serviceProvider)
        {
            applicationBuilder.UseStatusCodePagesWithReExecute("/Error/{0}");
        }
    }
}
