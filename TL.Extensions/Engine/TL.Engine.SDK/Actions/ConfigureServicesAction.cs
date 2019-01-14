using ExtCore.Infrastructure.Actions;
using Microsoft.Extensions.DependencyInjection;
using System;
using TL.Engine.SDK.Services.ApiDocumentation;

namespace TL.Engine.SDK.Actions
{
    public class ConfigureServicesAction : IConfigureServicesAction
    {
        public int Priority => int.MinValue;

        public void Execute(IServiceCollection serviceCollection, IServiceProvider serviceProvider)
        {
            serviceCollection.AddTransient<IApiDocumentationService, ApiDocumentationService>();
        }
    }
}
