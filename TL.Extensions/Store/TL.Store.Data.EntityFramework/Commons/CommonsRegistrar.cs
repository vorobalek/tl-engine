using ExtCore.Data.EntityFramework;
using Microsoft.EntityFrameworkCore;

namespace TL.Store.Data.EntityFramework.Commons
{
    public class CommonsRegistrar : IEntityRegistrar
    {
        public void RegisterEntities(ModelBuilder modelbuilder)
        {
            modelbuilder.Entity<Registry.Data.Entities.Core.Registry>().HasData(new[]
            {
                Common.StoreRegistry
            });

            modelbuilder.Entity<Registry.Data.Entities.Core.Folder>().HasData(new[]
            {
                Common.StoreRegistryFolder
            });

            modelbuilder.Entity<Registry.Data.Entities.Security.UserPermission>().HasData(new[]
            {
                Common.StoreRegistrySaUserPermission,
                Common.StoreRegistrySystemUserPermission
            });

            modelbuilder.Entity<Registry.Data.Entities.Security.GroupPermission>().HasData(new[]
            {
                Common.StoreRegistrySaGroupPermission,
                Common.StoreRegistrySystemGroupPermission
            });

            modelbuilder.Entity<Registry.Data.Entities.Security.FolderUserPermission>().HasData(new[]
            {
                Common.StoreRegistryFolderSaUserPermission,
                Common.StoreRegistryFolderSystemUserPermission
            });

            modelbuilder.Entity<Registry.Data.Entities.Security.FolderGroupPermission>().HasData(new[]
            {
                Common.StoreRegistryFolderSaGroupPermission,
                Common.StoreRegistryFolderSystemGroupPermission
            });
        }
    }
}
