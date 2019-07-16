using ExtCore.Data.EntityFramework;
using Microsoft.EntityFrameworkCore;
using TL.Registry.Data.Entities.Security;

namespace TL.Registry.Data.EntityFramework.Security.FolderGroupPermissions
{
    public class FolderGroupPermissionRegistrar : IEntityRegistrar
    {
        public void RegisterEntities(ModelBuilder modelbuilder)
        {
            modelbuilder.ApplyConfiguration<FolderGroupPermission>(new FolderGroupPermissionConfiguration());
        }
    }
}
