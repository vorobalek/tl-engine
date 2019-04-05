using ExtCore.Data.EntityFramework;
using Microsoft.EntityFrameworkCore;

namespace TL.Engine.Data.EntityFramework.Security.UsersRoles
{
    public class UserRoleRegistrar : IEntityRegistrar
    {
        public void RegisterEntities(ModelBuilder modelbuilder)
        {
            modelbuilder.ApplyConfiguration(new UserRoleConfiguration());
        }
    }
}
