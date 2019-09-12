using ExtCore.Infrastructure.Actions;
using Microsoft.Extensions.DependencyInjection;
using System;
using TL.JustBot.Data.Managers;

namespace TL.JustBot.Data.Actions
{
    public class ConfigureServicesAction : IConfigureServicesAction
    {
        public int Priority => 1000;

        public void Execute(IServiceCollection serviceCollection, IServiceProvider serviceProvider)
        {
            serviceCollection.AddScoped<IPersonManager, PersonManager>();
            serviceCollection.AddScoped<IHistoryManager, HistoryManager>();
        }
    }
}
