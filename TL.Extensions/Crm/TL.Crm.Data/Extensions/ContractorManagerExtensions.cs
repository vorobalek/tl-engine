using System;
using TL.Crm.Data.Entities.Core;
using TL.Crm.Data.Managers;

namespace TL.Crm.Data.Extensions
{
    public static class ContractorManagerExtensions
    {
        public static Contractor GetOriginal(this IContractorManager contractorManager, Guid key)
        {
            return contractorManager.GetOriginal(e => e.Id == key);
        }

        public static Contractor GetOriginal(this IContractorManager contractorManager, Func<Contractor, bool> predicate)
        {
            var contractor = contractorManager.Get(predicate);
            if (contractor?.Original != null)
            {
                return contractorManager.GetOriginal(contractor.Original.Id);
            }
            else
            {
                return contractor;
            }
        }
    }
}
