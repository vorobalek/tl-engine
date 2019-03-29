using ExtCore.Data.EntityFramework;
using Microsoft.EntityFrameworkCore;
using TL.Account.Data.Entities.Security;

namespace TL.Account.Data.EntityFramework.Security.UsersGroups
{
    public class UserGroupRegistrar : IEntityRegistrar
    {
        public void RegisterEntities(ModelBuilder modelbuilder)
        {
            modelbuilder.ApplyConfiguration(new UserGroupConfiguration());
        }
    }
}
