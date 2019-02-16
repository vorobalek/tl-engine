using System;
using TL.Crm.Data.Entities.Core;
using TL.Engine.SDK.Repositories;

namespace TL.Crm.Data.Abstractions.Core
{
    public interface IContractorRepository : IEntityComparableStoredRepository<Contractor, Guid>
    {
    }
}
