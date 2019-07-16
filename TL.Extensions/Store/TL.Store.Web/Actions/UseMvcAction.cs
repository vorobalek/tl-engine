using ExtCore.Mvc.Infrastructure.Actions;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;
using System;

namespace TL.Store.Web.Actions
{
    public class UseMvcAction : IUseMvcAction
    {
        public int Priority => 1000;

        public void Execute(IRouteBuilder routeBuilder, IServiceProvider serviceProvider)
        {
            routeBuilder.MapRoute(
               name: "Store.Web",
               template: "Store/{controller}/{action}/{id?}",
               constraints: new { area = "Store" },
               defaults: new { area = "Store", controller = "Home", action = "Index" }
           );
        }
    }
}
