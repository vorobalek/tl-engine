using ExtCore.Infrastructure.Actions;
using Microsoft.Extensions.DependencyInjection;
using System;
using TL.Engine.SDK.Services;

namespace TL.Engine.Actions
{
    public class ConfigureServicesAction : IConfigureServicesAction
    {
        public int Priority => int.MinValue;

        public void Execute(IServiceCollection serviceCollection, IServiceProvider serviceProvider)
        {
            serviceCollection.AddSingleton<IStartupService, StartupService>();
            serviceCollection.AddSingleton<IEntityIndexerService, EntityIndexerService>();
        }
    }
}
