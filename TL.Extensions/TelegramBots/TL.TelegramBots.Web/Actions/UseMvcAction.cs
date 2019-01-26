using ExtCore.Mvc.Infrastructure.Actions;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;
using System;

namespace TL.TelegramBots.Web.Actions
{
    public class UseMvcAction : IUseMvcAction
    {
        public int Priority => 1000;

        public void Execute(IRouteBuilder routeBuilder, IServiceProvider serviceProvider)
        {
            routeBuilder.MapRoute(
               name: "TelegramBots.Web",
               template: "TelegramBots/{controller}/{action}/{id?}",
               constraints: new { area = "TelegramBots" },
               defaults: new { area = "TelegramBots", controller = "Home", action = "Index" }
           );
        }
    }
}
