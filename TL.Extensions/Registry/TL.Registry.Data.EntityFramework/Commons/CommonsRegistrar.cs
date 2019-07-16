using ExtCore.Data.EntityFramework;
using Microsoft.EntityFrameworkCore;

namespace TL.Registry.Data.EntityFramework.Commons
{
    public class CommonsRegistrar : IEntityRegistrar
    {
        public void RegisterEntities(ModelBuilder modelbuilder)
        {
            modelbuilder.Entity<Entities.Core.Registry>().HasData(new[]
            {
                Common.RootRegistry
            });

            modelbuilder.Entity<Entities.Core.Folder>().HasData(new[]
            {
                Common.RootRegistryFolder
            });

            modelbuilder.Entity<Entities.Security.UserPermission>().HasData(new[]
            {
                Common.RootRegistrySaUserPermission,
                Common.RootRegistrySystemUserPermission
            });

            modelbuilder.Entity<Entities.Security.GroupPermission>().HasData(new[]
            {
                Common.RootRegistrySaGroupPermission,
                Common.RootRegistrySystemGroupPermission
            });

            modelbuilder.Entity<Entities.Security.FolderUserPermission>().HasData(new[]
            {
                Common.RootRegistryFolderSaUserPermission,
                Common.RootRegistryFolderSystemUserPermission
            });

            modelbuilder.Entity<Entities.Security.FolderGroupPermission>().HasData(new[]
            {
                Common.RootRegistryFolderSaGroupPermission,
                Common.RootRegistryFolderSystemGroupPermission
            });
        }
    }
}
