using Microsoft.Extensions.DependencyInjection;
using System;
using TL.Account.Data.Entities.Security;
using TL.Crm.Data.Entities.Core;
using TL.Crm.Data.Managers;

namespace TL.Crm.Data.Extensions
{
    public static class AccountUserExtensions
    {
        public static Lead GetLead(this User user, IServiceProvider serviceProvider)
        {
            return serviceProvider.GetService<ILeadManager>().GetOriginal(e => e.UserId == user.Id);
        }

        public static Contractor GetContractor(this User user, IServiceProvider serviceProvider)
        {
            var lead = user.GetLead(serviceProvider);
            if (lead.Contractor != null)
            {
                var contractorManager = serviceProvider.GetService<IContractorManager>();
                return contractorManager.GetOriginal(lead.Contractor.Id);
            }
            else
            {
                return null;
            }
        }
    }
}
