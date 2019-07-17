using System;
using TL.Engine.Data.Entities.Security;
using TL.Engine.SDK.Types.Enums;

namespace TL.Registry.Data.EntityFramework.Commons
{
    public class Common
    {
        public static Entities.Core.Registry RootRegistry =>
            new Entities.Core.Registry()
            {
                Id = Guid.Parse("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"),
                Name = "<Root>",
                Description = "System Root Registry",
                Type = Entities.Core.RegistryType.Private,
                OwnerId = User.System.Id,
                RootId = RootRegistryFolder.Id
            };

        public static Entities.Core.Folder RootRegistryFolder =>
            new Entities.Core.Folder()
            {
                Id = Guid.Parse("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"),
                Name = "System Root Registry Folder",
                OwnerId = User.System.Id,
            };

        #region Permissions

        #region RegistryPermissions

        public static Entities.Security.UserPermission RootRegistrySaUserPermission =>
            new Entities.Security.UserPermission()
            {
                SubjectId = User.Sa.Id,
                ObjectId = RootRegistry.Id,
                Mode = AccessMode.All
            };

        public static Entities.Security.UserPermission RootRegistrySystemUserPermission =>
            new Entities.Security.UserPermission()
            {
                SubjectId = User.System.Id,
                ObjectId = RootRegistry.Id,
                Mode = AccessMode.All
            };

        public static Entities.Security.GroupPermission RootRegistrySaGroupPermission =>
            new Entities.Security.GroupPermission()
            {
                SubjectId = Group.Sa.Id,
                ObjectId = RootRegistry.Id,
                Mode = AccessMode.All
            };

        public static Entities.Security.GroupPermission RootRegistrySystemGroupPermission =>
            new Entities.Security.GroupPermission()
            {
                SubjectId = Group.System.Id,
                ObjectId = RootRegistry.Id,
                Mode = AccessMode.All
            };

        public static Entities.Security.RolePermission RootRegistrySaRolePermission =>
            new Entities.Security.RolePermission()
            {
                SubjectId = Role.Sa.Id,
                ObjectId = RootRegistry.Id,
                Mode = AccessMode.All
            };

        public static Entities.Security.RolePermission RootRegistrySystemRolePermission =>
            new Entities.Security.RolePermission()
            {
                SubjectId = Role.System.Id,
                ObjectId = RootRegistry.Id,
                Mode = AccessMode.All
            };

        #endregion

        #region RegistryFolderPermissions

        public static Entities.Security.FolderUserPermission RootRegistryFolderSaUserPermission =>
            new Entities.Security.FolderUserPermission()
            {
                SubjectId = User.Sa.Id,
                ObjectId = RootRegistryFolder.Id,
                Mode = AccessMode.All
            };

        public static Entities.Security.FolderUserPermission RootRegistryFolderSystemUserPermission =>
            new Entities.Security.FolderUserPermission()
            {
                SubjectId = User.System.Id,
                ObjectId = RootRegistryFolder.Id,
                Mode = AccessMode.All
            };

        public static Entities.Security.FolderGroupPermission RootRegistryFolderSaGroupPermission =>
            new Entities.Security.FolderGroupPermission()
            {
                SubjectId = Group.Sa.Id,
                ObjectId = RootRegistryFolder.Id,
                Mode = AccessMode.All
            };

        public static Entities.Security.FolderGroupPermission RootRegistryFolderSystemGroupPermission =>
            new Entities.Security.FolderGroupPermission()
            {
                SubjectId = Group.System.Id,
                ObjectId = RootRegistryFolder.Id,
                Mode = AccessMode.All
            };

        public static Entities.Security.FolderRolePermission RootRegistryFolderSaRolePermission =>
            new Entities.Security.FolderRolePermission()
            {
                SubjectId = Role.Sa.Id,
                ObjectId = RootRegistryFolder.Id,
                Mode = AccessMode.All
            };

        public static Entities.Security.FolderRolePermission RootRegistryFolderSystemRolePermission =>
            new Entities.Security.FolderRolePermission()
            {
                SubjectId = Role.System.Id,
                ObjectId = RootRegistryFolder.Id,
                Mode = AccessMode.All
            };

        #endregion

        #endregion
    }
}
