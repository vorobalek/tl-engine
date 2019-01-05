using ExtCore.Infrastructure.Actions;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Security.Claims;
using TL.Account.Data.Entities.Security;

namespace TL.Account.Web.Actions
{
    public class ConfigureServicesAction : IConfigureServicesAction
    {
        public int Priority => 1000;

        public void Execute(IServiceCollection serviceCollection, IServiceProvider serviceProvider)
        {
            serviceCollection
                .AddAuthentication(options =>
                {
                    options.DefaultScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                })
                .AddCookie(options =>
                {
                    options.Cookie.Name = "TL.Engine.Account";
                    options.LoginPath = "/Account/Login";
                    options.AccessDeniedPath = "/AccessDenied";
                });

            serviceCollection
                .AddAuthorization(options =>
                {
                    options.AddPolicy("SA", policy => policy.RequireClaim(ClaimsIdentity.DefaultRoleClaimType, Role.Sa.Id.ToString()));
                });
        }
    }
}
