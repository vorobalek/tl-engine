using ExtCore.Mvc.Infrastructure.Actions;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;
using System;

namespace TL.Integrations.Web.Actions
{
    public class UseMvcAction : IUseMvcAction
    {
        public int Priority => 1000;

        public void Execute(IRouteBuilder routeBuilder, IServiceProvider serviceProvider)
        {
            routeBuilder.MapRoute(
               name: "Integrations.Web",
               template: "Integrations/{controller}/{action}/{id?}",
               constraints: new { area = "Integrations" },
               defaults: new { area = "Integrations", controller = "Home", action = "Index" }
           );
        }
    }
}
