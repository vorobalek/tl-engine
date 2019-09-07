using ExtCore.Data.EntityFramework;
using Microsoft.EntityFrameworkCore;
using TL.Engine.SDK.Types;

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

            modelbuilder.Entity<Permission>().HasData(new Permission[]
            {
                Common.StoreRegistrySaUserPermission,
                Common.StoreRegistrySystemUserPermission,
                Common.StoreRegistrySaGroupPermission,
                Common.StoreRegistrySystemGroupPermission,
                Common.StoreRegistryFolderSaUserPermission,
                Common.StoreRegistryFolderSystemUserPermission,
                Common.StoreRegistryFolderSaGroupPermission,
                Common.StoreRegistryFolderSystemGroupPermission
            });
        }
    }
}
