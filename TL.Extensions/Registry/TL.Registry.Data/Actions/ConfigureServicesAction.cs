using ExtCore.Infrastructure.Actions;
using Microsoft.Extensions.DependencyInjection;
using System;
using TL.Registry.Data.Managers;

namespace TL.Registry.Data.Actions
{
    public class ConfigureServicesAction : IConfigureServicesAction
    {
        public int Priority => 1000;

        public void Execute(IServiceCollection serviceCollection, IServiceProvider serviceProvider)
        {
            serviceCollection.AddScoped<IRegistryManager, RegistryManager>();
            serviceCollection.AddScoped<IFileManager, FileManager>();
            serviceCollection.AddScoped<IFolderManager, FolderManager>();
        }
    }
}
