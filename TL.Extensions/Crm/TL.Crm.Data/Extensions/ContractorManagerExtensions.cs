using System;
using TL.Crm.Data.Entities.Core;
using TL.Crm.Data.Managers;

namespace TL.Crm.Data.Extensions
{
    public static class ContractorManagerExtensions
    {
        public static Contractor GetOriginalContractor(this IContractorManager contractorManager, Guid key)
        {
            return contractorManager.GetOriginalContractor(e => e.Id == key);
        }

        public static Contractor GetOriginalContractor(this IContractorManager contractorManager, Func<Contractor, bool> predicate)
        {
            var contractor = contractorManager.Get(predicate);
            if (contractor?.Original != null)
            {
                return contractorManager.GetOriginalContractor(contractor.Original.Id);
            }
            else
            {
                return contractor;
            }
        }
    }
}
