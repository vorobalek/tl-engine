using ExtCore.Data.EntityFramework;
using Microsoft.EntityFrameworkCore;
using TL.Registry.Data.Entities.Security;

namespace TL.Registry.Data.EntityFramework.Security.FolderUserPermissions
{
    public class FolderUserPermissionRegistrar : IEntityRegistrar
    {
        public void RegisterEntities(ModelBuilder modelbuilder)
        {
            modelbuilder.ApplyConfiguration<FolderUserPermission>(new FolderUserPermissionConfiguration());
        }
    }
}
