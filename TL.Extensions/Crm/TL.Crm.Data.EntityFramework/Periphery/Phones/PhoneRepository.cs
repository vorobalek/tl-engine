using TL.Crm.Data.Abstractions.Periphery;
using TL.Crm.Data.Entities.Periphery;
using TL.Engine.SDK.Repositories;

namespace TL.Crm.Data.EntityFramework.Periphery.Phones
{
    public class PhoneRepository : EntityRepository<Phone>, IPhoneRepository
    {
    }
}
