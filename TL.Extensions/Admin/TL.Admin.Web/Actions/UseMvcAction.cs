using ExtCore.Mvc.Infrastructure.Actions;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;
using System;

namespace TL.Admin.Web.Actions
{
    public class UseMvcAction : IUseMvcAction
    {
        public int Priority => 1000;

        public void Execute(IRouteBuilder routeBuilder, IServiceProvider serviceProvider)
        {
            routeBuilder.MapRoute(
               name: "Admin.Web",
               template: "Admin/{controller}/{action}/{id?}",
               constraints: new { area = "Admin" },
               defaults: new { area = "Admin", controller = "Home", action = "Index" }
           );
        }
    }
}
