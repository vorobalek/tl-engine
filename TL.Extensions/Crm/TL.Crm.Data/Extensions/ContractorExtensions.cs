using ExtCore.Data.Abstractions;
using TL.Crm.Data.Abstractions.Core;
using TL.Crm.Data.Entities.Core;

namespace TL.Crm.Data.Extensions
{
    public static class ContractorExtensions
    {
        public static Contractor GetOriginal(this Contractor contractor, IStorage storage)
        {
            if (contractor.OriginalId == null) return contractor;

            return storage.GetRepository<IContractorRepository>().GetById(contractor.OriginalId.Value).GetOriginal(storage);
        }
    }
}
