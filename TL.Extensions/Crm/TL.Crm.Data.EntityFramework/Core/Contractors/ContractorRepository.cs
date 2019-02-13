using TL.Crm.Data.Abstractions.Core;
using TL.Crm.Data.Entities.Core;
using TL.Engine.SDK.Repositories;

namespace TL.Crm.Data.EntityFramework.Core.Contractors
{
    public class ContractorRepository : EntityRepository<Contractor>, IContractorRepository
    {
    }
}
