using Microsoft.Extensions.DependencyInjection;
using System;
using TL.Account.Data.Entities.Security;
using TL.Crm.Data.Entities.Core;
using TL.Crm.Data.Managers;

namespace TL.Crm.Data.Extensions
{
    public static class AccountUserExtensions
    {
        public static Lead GetOriginalLead(this User user, IServiceProvider serviceProvider)
        {
            return serviceProvider.GetService<ILeadManager>().GetOriginalLead(e => e.UserId == user.Id);
        }

        public static Contractor GetOriginalContractor(this User user, IServiceProvider serviceProvider)
        {
            var lead = user.GetOriginalLead(serviceProvider);
            if (lead?.Contractor != null)
            {
                var contractorManager = serviceProvider.GetService<IContractorManager>();
                return contractorManager.GetOriginalContractor(lead.Contractor.Id);
            }
            else
            {
                return null;
            }
        }
    }
}
