using System;
using TL.Crm.Data.Entities.Core;
using TL.Crm.Data.Managers;

namespace TL.Crm.Data.Extensions
{
    public static class LeadManagerExtensions
    {
        public static Lead GetOriginalLead(this ILeadManager leadManager, Guid key)
        {
            return leadManager.GetOriginalLead(e => e.Id == key);
        }

        public static Lead GetOriginalLead(this ILeadManager leadManager, Func<Lead, bool> predicate)
        {
            var lead = leadManager.Get(predicate);
            if (lead?.Original != null)
            {
                return leadManager.GetOriginalLead(lead.Original.Id);
            }
            else
            {
                return lead;
            }
        }
    }
}
