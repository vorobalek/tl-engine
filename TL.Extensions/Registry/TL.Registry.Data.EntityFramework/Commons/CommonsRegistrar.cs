using ExtCore.Data.EntityFramework;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using TL.Engine.Data.Entities.Security;

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

            modelbuilder.Entity<Entities.Security.UserPermission>().HasData(new[]
            {
                Common.RootRegistrySaUserPermission,
                Common.RootRegistrySystemUserPermission
            });

            modelbuilder.Entity<Entities.Security.GroupPermission>().HasData(new[]
            {
                Common.RootRegistrySaGroupPermission,
                Common.RootRegistrySystemGroupPermission,
            });

            modelbuilder.Entity<Entities.Security.RolePermission>().HasData(new[]
            {
                Common.RootRegistrySaRolePermission,
                Common.RootRegistrySystemRolePermission,
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

            modelbuilder.Entity<Entities.Security.FolderRolePermission>().HasData(new[]
            {
                Common.RootRegistryFolderSaRolePermission,
                Common.RootRegistryFolderSystemRolePermission
            });
        }
    }
}
