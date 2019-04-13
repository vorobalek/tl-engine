using ExtCore.Mvc.Infrastructure.Actions;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;
using System;

namespace TL.Linker.Web.Actions
{
    public class UseMvcAction : IUseMvcAction
    {
        public int Priority => 1000;

        public void Execute(IRouteBuilder routeBuilder, IServiceProvider serviceProvider)
        {
            routeBuilder.MapRoute(
               name: "Linker.Web",
               template: "linker/{controller}/{action}/{id?}",
               constraints: new { area = "Linker" },
               defaults: new { area = "Linker", controller = "Get", action = "Index" }
           );
        }
    }
}
