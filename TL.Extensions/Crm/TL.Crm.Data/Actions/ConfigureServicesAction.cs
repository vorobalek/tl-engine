using ExtCore.Infrastructure.Actions;
using Microsoft.Extensions.DependencyInjection;
using System;
using TL.Crm.Data.Managers;

namespace TL.Crm.Data.Actions
{
    public class ConfigureServicesAction : IConfigureServicesAction
    {
        public int Priority => 1000;

        public void Execute(IServiceCollection serviceCollection, IServiceProvider serviceProvider)
        {
            serviceCollection.AddScoped<IContractorManager, ContractorManager>();
            serviceCollection.AddScoped<IInviteManager, InviteManager>();
            serviceCollection.AddScoped<ILeadManager, LeadManager>();
            serviceCollection.AddScoped<ILeadPhoneManager, LeadPhoneManager>();
        }
    }
}
