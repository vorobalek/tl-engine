using ExtCore.Data.EntityFramework;
using TL.Crm.Data.Abstractions.Core;
using TL.Crm.Data.Entities.Core;

namespace TL.Crm.Data.EntityFramework.Core.Leads
{
    public class LeadRepository : RepositoryBase<Lead>, ILeadRepository
    {
    }
}
