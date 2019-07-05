using ExtCore.Infrastructure.Actions;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System;
using TL.Engine.SDK.Services;
using TL.Engine.StartupFilters;

namespace TL.Engine.Actions
{
    public class ConfigureServicesAction : IConfigureServicesAction
    {
        public int Priority => int.MinValue;

        public void Execute(IServiceCollection serviceCollection, IServiceProvider serviceProvider)
        {
            serviceCollection.AddSingleton<IStartupService, StartupService>();
            serviceCollection.AddSingleton<IEntityIndexerService, EntityIndexerService>();
            serviceCollection.AddSingleton<IStringIndexerService, StringIndexerService>();

            serviceCollection.AddTransient<IActivatorService, ActivatorService>();
            serviceCollection.AddSingleton<IStartupFilter, CoreStartupFilter>();
        }
    }
}
