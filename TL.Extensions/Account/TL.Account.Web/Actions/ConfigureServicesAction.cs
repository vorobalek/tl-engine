using ExtCore.Infrastructure.Actions;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace TL.Account.Web.Actions
{
    public class ConfigureServicesAction : IConfigureServicesAction
    {
        public int Priority => 1000;

        public void Execute(IServiceCollection serviceCollection, IServiceProvider serviceProvider)
        {
            serviceCollection
                .AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
               .AddCookie(options => 
               {
                   options.LoginPath = new Microsoft.AspNetCore.Http.PathString("/Account/Home/Login");
               });
        }
    }
}
