using ExtCore.Infrastructure.Actions;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Security.Claims;
using TL.Engine.Data.Entities.Security;

namespace TL.Engine.Web.Actions
{
    public class ConfigureServicesAction : IConfigureServicesAction
    {
        public int Priority => int.MinValue;

        public void Execute(IServiceCollection serviceCollection, IServiceProvider serviceProvider)
        {
            serviceCollection
                .AddAuthentication(options =>
                {
                    options.DefaultScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                })
                .AddCookie(options =>
                {
                    options.Cookie.Name = "TLE.Account";
                    options.LoginPath = "/account/login";
                    options.AccessDeniedPath = "/denied";
                });

            serviceCollection
                .AddAuthorization(options =>
                {
                    options.AddPolicy("SA", policy => policy.RequireClaim(ClaimsIdentity.DefaultRoleClaimType, Role.Sa.Id.ToString()));
                });
        }
    }
}
