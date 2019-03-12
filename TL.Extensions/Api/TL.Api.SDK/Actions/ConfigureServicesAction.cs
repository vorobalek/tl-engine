using ExtCore.Infrastructure.Actions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using System;
using TL.Api.SDK.Services.ApiDocumentation;

namespace TL.Engine.SDK.Actions
{
    public class ConfigureServicesAction : IConfigureServicesAction
    {
        public int Priority => int.MinValue;

        public void Execute(IServiceCollection serviceCollection, IServiceProvider serviceProvider)
        {
            serviceCollection.AddSingleton<IApiDocumentationService, ApiDocumentationService>();
            serviceCollection.Configure<MvcJsonOptions>(options =>
            {
                options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
            });
        }
    }
}
