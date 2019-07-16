using ExtCore.Data.EntityFramework;
using Microsoft.EntityFrameworkCore;
using TL.Registry.Data.Entities.Security;

namespace TL.Registry.Data.EntityFramework.Security.GroupPermissions
{
    public class GroupPermissionRegistrar : IEntityRegistrar
    {
        public void RegisterEntities(ModelBuilder modelbuilder)
        {
            modelbuilder.ApplyConfiguration<GroupPermission>(new GroupPermissionConfiguration());
        }
    }
}
