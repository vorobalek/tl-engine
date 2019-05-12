using ExtCore.Infrastructure.Actions;
using Microsoft.Extensions.DependencyInjection;
using System;
using TL.Engine.Data.Managers;

namespace TL.Engine.Data.Actions
{
    public class ConfigureServicesAction : IConfigureServicesAction
    {
        public int Priority => 1000;

        public void Execute(IServiceCollection serviceCollection, IServiceProvider serviceProvider)
        {
            serviceCollection.AddScoped<IStringVariableManager, StringVariableManager>();
            serviceCollection.AddScoped<IUserManager, UserManager>();
            serviceCollection.AddScoped<IRoleManager, RoleManager>();
        }
    }
}
