using ExtCore.Infrastructure.Actions;
using Microsoft.Extensions.DependencyInjection;
using System;
using TL.Integrations.Data.Managers;

namespace TL.Integrations.Data.Actions
{
    public class ConfigureServicesAction : IConfigureServicesAction
    {
        public int Priority => 1000;

        public void Execute(IServiceCollection serviceCollection, IServiceProvider serviceProvider)
        {
            serviceCollection.AddScoped<ITgBotManager, TgBotManager>();
            serviceCollection.AddScoped<ITgUserManager, TgUserManager>();
            serviceCollection.AddScoped<ITgRoleManager, TgRoleManager>();
            serviceCollection.AddScoped<ITgUserRoleManager, TgUserRoleManager>();
        }
    }
}
