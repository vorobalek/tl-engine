using ExtCore.Mvc.Infrastructure.Actions;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;
using System;

namespace TL.Account.Web.Actions
{
    public class UseMvcAction : IUseMvcAction
    {
        public int Priority => 1000;

        public void Execute(IRouteBuilder routeBuilder, IServiceProvider serviceProvider)
        {
            routeBuilder.MapRoute(
               name: "Account.Web",
               template: "Account/{controller}/{action}/{id?}",
               constraints: new { area = "Account" },
               defaults: new { area="Account", controller = "Home", action = "Index" }
           );
        }
    }
}
