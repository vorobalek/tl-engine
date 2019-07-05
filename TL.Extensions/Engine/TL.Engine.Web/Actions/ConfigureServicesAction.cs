using ExtCore.Infrastructure.Actions;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Security.Claims;
using TL.Engine.Data.Entities.Security;

namespace TL.Engine.Web.Actions
{
    public class ConfigureServicesAction : IConfigureServicesAction
    {
        public int Priority => 0;

        public void Execute(IServiceCollection serviceCollection, IServiceProvider serviceProvider)
        {
            var configuration = serviceProvider.GetService<IConfiguration>();

            serviceCollection
                .AddAuthentication(options =>
                {
                    options.DefaultScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                })
                .AddCookie(options =>
                {
                    if (configuration["Server:AllowHTTP"] == true.ToString())
                    {
                        options.Cookie.SecurePolicy = CookieSecurePolicy.None;
                    }
                    else
                    {
                        options.Cookie.SecurePolicy = CookieSecurePolicy.SameAsRequest;
                    }
                    options.Cookie.Name = "TL.Engine.Account";
                    options.LoginPath = "/account/login";
                    options.AccessDeniedPath = "/denied";
                });

            serviceCollection
                .AddAuthorization(options =>
                {
                    options.AddPolicy("SA", policy => policy.RequireClaim(ClaimsIdentity.DefaultRoleClaimType, Role.Sa.Name));
                });
        }
    }
}
