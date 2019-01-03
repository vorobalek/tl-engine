using ExtCore.Mvc.Infrastructure.Actions;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;
using System;

namespace TL.Api.Web.Actions
{
    public class UseMvcAction : IUseMvcAction
    {
        public int Priority => 1000;

        public void Execute(IRouteBuilder routeBuilder, IServiceProvider serviceProvider)
        {
            routeBuilder.MapRoute(
                name: "Api",
                template: "{controller}/{action}/{id?}",
                defaults: new { contoller = "Help", action = "Get" }
            );
            routeBuilder.MapRoute(
               name: "Api.Help",
               template: "ApiHelp/{controller}/{action}/{id?}",
               constraints: new { area = "ApiHelp" },
               defaults: new { area = "ApiHelp", controller = "Home", action = "Index" }
           );
        }
    }
}
