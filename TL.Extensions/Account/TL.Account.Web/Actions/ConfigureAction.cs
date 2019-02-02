using ExtCore.Infrastructure.Actions;
using Microsoft.AspNetCore.Builder;
using System;

namespace TL.Account.Web.Actions
{
    public class ConfigureAction : IConfigureAction
    {
        public int Priority => int.MinValue;

        public void Execute(IApplicationBuilder applicationBuilder, IServiceProvider serviceProvider)
        {
            applicationBuilder.UseAuthentication();
        }
    }
}
