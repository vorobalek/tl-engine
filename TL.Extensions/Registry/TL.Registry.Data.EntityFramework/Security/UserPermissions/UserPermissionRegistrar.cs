using ExtCore.Data.EntityFramework;
using Microsoft.EntityFrameworkCore;
using TL.Registry.Data.Entities.Security;

namespace TL.Registry.Data.EntityFramework.Security.UserPermissions
{
    public class UserPermissionRegistrar : IEntityRegistrar
    {
        public void RegisterEntities(ModelBuilder modelbuilder)
        {
            modelbuilder.ApplyConfiguration<UserPermission>(new UserPermissionConfiguration());
        }
    }
}
