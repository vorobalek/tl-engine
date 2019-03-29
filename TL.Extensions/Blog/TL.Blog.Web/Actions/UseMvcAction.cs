using ExtCore.Mvc.Infrastructure.Actions;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;
using System;

namespace TL.Blog.Web.Actions
{
    public class UseMvcAction : IUseMvcAction
    {
        public int Priority => 1000;

        public void Execute(IRouteBuilder routeBuilder, IServiceProvider serviceProvider)
        {
            routeBuilder.MapRoute(
               name: "Blog.Web",
               template: "Blog/{controller}/{action}/{id?}",
               constraints: new { area = "Blog" },
               defaults: new { area = "Blog", controller = "Home", action = "Index" }
           );
        }
    }
}
