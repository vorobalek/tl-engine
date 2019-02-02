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
               template: "account/{controller}/{action}/{id?}",
               constraints: new { area = "account" },
               defaults: new { area="account", controller = "home", action = "index" }
           );
        }
    }
}
