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
               name: "Api.Help",
               template: "apihelp/{controller}/{action}/{id?}",
               constraints: new { area = "apihelp" },
               defaults: new { area = "apihelp", controller = "home", action = "index" }
           );
        }
    }
}
