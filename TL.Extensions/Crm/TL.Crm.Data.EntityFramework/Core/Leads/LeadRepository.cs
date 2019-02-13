using TL.Crm.Data.Abstractions.Core;
using TL.Crm.Data.Entities.Core;
using TL.Engine.SDK.Repositories;

namespace TL.Crm.Data.EntityFramework.Core.Leads
{
    public class LeadRepository : EntityRepository<Lead>, ILeadRepository
    {
    }
}
