using ExtCore.Mvc.Infrastructure.Actions;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;
using System;

namespace TL.Registry.Web.Actions
{
    public class UseMvcAction : IUseMvcAction
    {
        public int Priority => 1000;

        public void Execute(IRouteBuilder routeBuilder, IServiceProvider serviceProvider)
        {
            routeBuilder.MapRoute(
               name: "Registry.Web",
               template: "Registry/{controller}/{action}/{id?}",
               constraints: new { area = "Registry" },
               defaults: new { area = "Registry", controller = "Home", action = "Index" }
           );
        }
    }
}
