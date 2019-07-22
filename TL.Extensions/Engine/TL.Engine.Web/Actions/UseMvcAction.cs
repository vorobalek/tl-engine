using ExtCore.Mvc.Infrastructure.Actions;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;
using System;

namespace TL.Engine.Web.Actions
{
    public class UseMvcAction : IUseMvcAction
    {
        public int Priority => 1000;

        public void Execute(IRouteBuilder routeBuilder, IServiceProvider serviceProvider)
        {
            routeBuilder.MapRoute(
                name: "Areas",
                template: "{area}/{controller}/{action=index}"
            );

            routeBuilder.MapRoute(
                name: "Web",
                template: "{controller}/{action}/{id?}",
                defaults: new { controller = "home", action = "index" }
            );

            routeBuilder.MapRoute(
               name: "Account",
               template: "account/{controller}/{action}/{id?}"
            );

            routeBuilder.MapRoute(
               name: "Admin",
               template: "admin/{controller}/{action}/{id?}",
               defaults: new { area = "admin", controller = "home", action = "index" }
            );
        }
    }
}
