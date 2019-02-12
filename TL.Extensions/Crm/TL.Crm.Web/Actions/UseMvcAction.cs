using ExtCore.Mvc.Infrastructure.Actions;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;
using System;

namespace TL.Crm.Web.Actions
{
    public class UseMvcAction : IUseMvcAction
    {
        public int Priority => 1000;

        public void Execute(IRouteBuilder routeBuilder, IServiceProvider serviceProvider)
        {
            routeBuilder.MapRoute(
               name: "Crm.Web",
               template: "Crm/{controller}/{action}/{id?}",
               constraints: new { area = "Crm" },
               defaults: new { area = "Crm", controller = "Home", action = "Index" }
           );
        }
    }
}
