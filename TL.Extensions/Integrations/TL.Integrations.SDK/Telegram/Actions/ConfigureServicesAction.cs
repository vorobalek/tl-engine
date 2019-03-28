using ExtCore.Infrastructure.Actions;
using Microsoft.Extensions.DependencyInjection;
using System;
using TL.Integrations.SDK.Telegram.Services;

namespace TL.Integrations.SDK.Telegram.Actions
{
    public class ConfigureServicesAction : IConfigureServicesAction
    {
        public int Priority => int.MinValue;

        public void Execute(IServiceCollection serviceCollection, IServiceProvider serviceProvider)
        {
            serviceCollection.AddSingleton<ITelegramBotProviderService, TelegramBotProviderService>();
        }
    }
}
