using ExtCore.Mvc.Infrastructure.Actions;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;
using System;

namespace TL.Translator.Web.Actions
{
    public class UseMvcAction : IUseMvcAction
    {
        public int Priority => 1000;

        public void Execute(IRouteBuilder routeBuilder, IServiceProvider serviceProvider)
        {
            routeBuilder.MapRoute(
               name: "Translator.Web",
               template: "Translator/{controller}/{action}/{id?}",
               constraints: new { area = "Translator" },
               defaults: new { area = "Translator", controller = "Home", action = "Index" }
           );
        }
    }
}
