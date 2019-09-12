using ExtCore.Mvc.Infrastructure.Actions;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;
using System;

namespace TL.JustBot.Web.Actions
{
    public class UseMvcAction : IUseMvcAction
    {
        public int Priority => 1000;

        public void Execute(IRouteBuilder routeBuilder, IServiceProvider serviceProvider)
        {
            routeBuilder.MapRoute(
               name: "JustBot.Web",
               template: "JustBot/{controller}/{action}/{id?}",
               constraints: new { area = "JustBot" },
               defaults: new { area = "JustBot", controller = "Home", action = "Index" }
           );
        }
    }
}
