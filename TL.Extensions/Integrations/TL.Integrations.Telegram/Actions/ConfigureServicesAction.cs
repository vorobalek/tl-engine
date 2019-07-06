using ExtCore.Infrastructure.Actions;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace TL.Integrations.Telegram.Actions
{
    public class ConfigureServicesAction : IConfigureServicesAction
    {
        public int Priority => int.MaxValue - 1000;

        public void Execute(IServiceCollection serviceCollection, IServiceProvider serviceProvider)
        {
        }
    }
}
