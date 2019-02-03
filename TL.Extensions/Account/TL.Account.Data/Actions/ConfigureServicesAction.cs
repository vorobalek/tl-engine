using ExtCore.Infrastructure.Actions;
using Microsoft.Extensions.DependencyInjection;
using System;
using TL.Account.Data.Managers.User;

namespace TL.Account.Data.Actions
{
    public class ConfigureServicesAction : IConfigureServicesAction
    {
        public int Priority => int.MinValue;

        public void Execute(IServiceCollection serviceCollection, IServiceProvider serviceProvider)
        {
            serviceCollection.AddSingleton<IUserManager, UserManager>();
        }
    }
}
