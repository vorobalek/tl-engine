using ExtCore.Mvc.Infrastructure.Actions;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;
using System;

namespace $safeprojectname$.Actions
{
    public class UseMvcAction : IUseMvcAction
    {
        public int Priority => 1000;

        public void Execute(IRouteBuilder routeBuilder, IServiceProvider serviceProvider)
        {
            routeBuilder.MapRoute(
               name: "$saferootprojectname$.Web",
               template: "$saferootprojectname$/{controller}/{action}/{id?}",
               constraints: new { area = "$saferootprojectname$" },
               defaults: new { area= "$saferootprojectname$", controller = "Home", action = "Index" }
           );
        }
    }
}
