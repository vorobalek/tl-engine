using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using TL.Crm.Data.Entities.Core;
using TL.Crm.Data.Managers;

namespace TL.Crm.Data.Extensions
{
    public static class ContractorExtensions
    {
        public static Lead GetOriginLead(this Contractor contractor, IServiceProvider serviceProvider)
        {
            var leadManager = serviceProvider.GetService<ILeadManager>();
            var lead = contractor.Leads.FirstOrDefault();
            if (lead != null)
            {
                return leadManager.GetOriginalLead(lead.Id);
            }
            else
            {
                return null;
            }
        }
    }
}
