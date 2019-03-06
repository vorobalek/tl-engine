using System;
using TL.Crm.Data.Entities.Periphery;
using TL.Engine.SDK.Repositories;

namespace TL.Crm.Data.Abstractions.Periphery
{
    public interface ILeadPhoneRepository : IEntityComparableStoredRepository<LeadPhone, Guid>
    {
    }
}
