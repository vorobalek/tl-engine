using ExtCore.Data.EntityFramework;
using Microsoft.EntityFrameworkCore;
using TL.Account.Data.Entities.Security;

namespace TL.Account.Data.EntityFramework.Security.UsersRoles
{
    public class UserRoleRegistrar : IEntityRegistrar
    {
        public void RegisterEntities(ModelBuilder modelbuilder)
        {
            modelbuilder.ApplyConfiguration(new UserRoleConfiguration());
        }
    }
}
