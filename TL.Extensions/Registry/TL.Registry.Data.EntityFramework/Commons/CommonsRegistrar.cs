using ExtCore.Data.EntityFramework;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using TL.Engine.Data.Entities.Security;
using TL.Engine.SDK.Types;

namespace TL.Registry.Data.EntityFramework.Commons
{
    public class CommonsRegistrar : IEntityRegistrar
    {
        public void RegisterEntities(ModelBuilder modelbuilder)
        {
            modelbuilder.Entity<Role>().HasData(new[]
            {
                Common.RegistryCreator,
                Common.RegistryFolderCreator,
                Common.RegistryFileCreator
            });

            modelbuilder.Entity<UserRole>().HasData(
                Common.SaCommonRoles.Concat(
                Common.SystemCommonRoles));

            modelbuilder.Entity<Entities.Core.Registry>().HasData(new[]
            {
                Common.RootRegistry
            });

            modelbuilder.Entity<Entities.Core.Folder>().HasData(new[]
            {
                Common.RootRegistryFolder
            });

            modelbuilder.Entity<Permission>().HasData(new Permission[]
            {
                Common.RootRegistrySaUserPermission,
                Common.RootRegistrySystemUserPermission,
                Common.RootRegistrySaGroupPermission,
                Common.RootRegistrySystemGroupPermission,
                Common.RootRegistrySaRolePermission,
                Common.RootRegistrySystemRolePermission,
                Common.RootRegistryFolderSaUserPermission,
                Common.RootRegistryFolderSystemUserPermission,
                Common.RootRegistryFolderSaGroupPermission,
                Common.RootRegistryFolderSystemGroupPermission,
                Common.RootRegistryFolderSaRolePermission,
                Common.RootRegistryFolderSystemRolePermission
            });
        }
    }
}
