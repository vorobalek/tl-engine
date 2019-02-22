using System;
using TL.Crm.Data.Entities.Core;
using TL.Crm.Data.Managers;

namespace TL.Crm.Data.Extensions
{
    public static class LeadManagerExtensions
    {
        public static Lead GetOriginal(this ILeadManager leadManager, Guid key)
        {
            return leadManager.GetOriginal(e => e.Id == key);
        }

        public static Lead GetOriginal(this ILeadManager leadManager, Func<Lead, bool> predicate)
        {
            var lead = leadManager.Get(predicate);
            if (lead?.Original != null)
            {
                return leadManager.GetOriginal(lead.Original.Id);
            }
            else
            {
                return lead;
            }
        }
    }
}
