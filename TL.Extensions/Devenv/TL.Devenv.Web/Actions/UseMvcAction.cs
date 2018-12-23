using ExtCore.Mvc.Infrastructure.Actions;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;
using System;

namespace TL.Devenv.Web.Actions
{
    public class UseMvcAction : IUseMvcAction
    {
        public int Priority => 1000;

        public void Execute(IRouteBuilder routeBuilder, IServiceProvider serviceProvider)
        {
            routeBuilder.MapRoute(
               name: "Devenv.Web",
               template: "Devenv/{controller}/{action}/{id?}",
               constraints: new { area = "Devenv" },
               defaults: new { area = "Devenv", controller = "Home", action = "Index" }
           );
        }
    }
}
