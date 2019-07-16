using ExtCore.Data.EntityFramework;
using Microsoft.EntityFrameworkCore;
using TL.Registry.Data.Entities.Security;

namespace TL.Registry.Data.EntityFramework.Security.FileUserPermissions
{
    public class FileUserPermissionRegistrar : IEntityRegistrar
    {
        public void RegisterEntities(ModelBuilder modelbuilder)
        {
            modelbuilder.ApplyConfiguration<FileUserPermission>(new FileUserPermissionConfiguration());
        }
    }
}
