using System;
using TL.Engine.Data.Entities.Security;
using TL.Engine.SDK.Types.Enums;

namespace TL.Registry.Data.EntityFramework.Commons
{
    public class Common
    {
        #region Roles

        public static Role RegistryCreator =>
            new Role()
            {
                Id = Guid.Parse("d90ae8ad-3d22-4a60-8342-b85b2c9b7965"),
                Name = "registry_creator",
                CreationDate = DateTime.UnixEpoch,
                ModifiedDate = DateTime.UnixEpoch
            };

        public static Role RegistryFolderCreator =>
            new Role()
            {
                Id = Guid.Parse("49b185ee-070d-4831-a614-fe9d6bf509d4"),
                Name = "registry_folder_creator",
                CreationDate = DateTime.UnixEpoch,
                ModifiedDate = DateTime.UnixEpoch
            };

        public static Role RegistryFileCreator =>
            new Role()
            {
                Id = Guid.Parse("dbd2c97b-db84-4fc3-a3ca-ad0c3953ca35"),
                Name = "registry_file_creator",
                CreationDate = DateTime.UnixEpoch,
                ModifiedDate = DateTime.UnixEpoch
            };

        #endregion

        #region UserRoles

        public static UserRole[] SaCommonRoles => new[]
        {
            new UserRole()
            {
                UserId = User.Sa.Id,
                RoleId = RegistryCreator.Id,
                CreationDate = DateTime.UnixEpoch,
                ModifiedDate = DateTime.UnixEpoch
            },

            new UserRole()
            {
                UserId = User.Sa.Id,
                RoleId = RegistryFolderCreator.Id,
                CreationDate = DateTime.UnixEpoch,
                ModifiedDate = DateTime.UnixEpoch
            },

            new UserRole()
            {
                UserId = User.Sa.Id,
                RoleId = RegistryFileCreator.Id,
                CreationDate = DateTime.UnixEpoch,
                ModifiedDate = DateTime.UnixEpoch
            }
        };

        public static UserRole[] SystemCommonRoles => new[]
        {
            new UserRole()
            {
                UserId = User.System.Id,
                RoleId = RegistryCreator.Id,
                CreationDate = DateTime.UnixEpoch,
                ModifiedDate = DateTime.UnixEpoch
            }
        };

        #endregion

        #region Registries

        public static Entities.Core.Registry RootRegistry =>
            new Entities.Core.Registry()
            {
                Id = Guid.Parse("5b0c75cf-e2a5-4028-afb4-f265b29d1bec"),
                Name = "<Root>",
                Description = "System Root Registry",
                Type = Entities.Core.RegistryType.Private,
                OwnerId = User.System.Id,
                RootId = RootRegistryFolder.Id,
                CreationDate = DateTime.UnixEpoch,
                ModifiedDate = DateTime.UnixEpoch
            };

        public static Entities.Core.Folder RootRegistryFolder =>
            new Entities.Core.Folder()
            {
                Id = Guid.Parse("a0c645fe-6239-4f06-8511-aeb6da5186f4"),
                Name = "System Root Registry Folder",
                OwnerId = User.System.Id,
                CreationDate = DateTime.UnixEpoch,
                ModifiedDate = DateTime.UnixEpoch
            };

        #region Permissions

        #region RegistryPermissions

        public static Entities.Security.UserPermission RootRegistrySaUserPermission =>
            new Entities.Security.UserPermission()
            {
                SubjectId = User.Sa.Id,
                ObjectId = RootRegistry.Id,
                Mode = AccessMode.All,
                CreationDate = DateTime.UnixEpoch,
                ModifiedDate = DateTime.UnixEpoch
            };

        public static Entities.Security.UserPermission RootRegistrySystemUserPermission =>
            new Entities.Security.UserPermission()
            {
                SubjectId = User.System.Id,
                ObjectId = RootRegistry.Id,
                Mode = AccessMode.All,
                CreationDate = DateTime.UnixEpoch,
                ModifiedDate = DateTime.UnixEpoch
            };

        public static Entities.Security.GroupPermission RootRegistrySaGroupPermission =>
            new Entities.Security.GroupPermission()
            {
                SubjectId = Group.Sa.Id,
                ObjectId = RootRegistry.Id,
                Mode = AccessMode.All,
                CreationDate = DateTime.UnixEpoch,
                ModifiedDate = DateTime.UnixEpoch
            };

        public static Entities.Security.GroupPermission RootRegistrySystemGroupPermission =>
            new Entities.Security.GroupPermission()
            {
                SubjectId = Group.System.Id,
                ObjectId = RootRegistry.Id,
                Mode = AccessMode.All,
                CreationDate = DateTime.UnixEpoch,
                ModifiedDate = DateTime.UnixEpoch
            };

        public static Entities.Security.RolePermission RootRegistrySaRolePermission =>
            new Entities.Security.RolePermission()
            {
                SubjectId = Role.Sa.Id,
                ObjectId = RootRegistry.Id,
                Mode = AccessMode.All,
                CreationDate = DateTime.UnixEpoch,
                ModifiedDate = DateTime.UnixEpoch
            };

        public static Entities.Security.RolePermission RootRegistrySystemRolePermission =>
            new Entities.Security.RolePermission()
            {
                SubjectId = Role.System.Id,
                ObjectId = RootRegistry.Id,
                Mode = AccessMode.All,
                CreationDate = DateTime.UnixEpoch,
                ModifiedDate = DateTime.UnixEpoch
            };

        #endregion

        #region RegistryFolderPermissions

        public static Entities.Security.FolderUserPermission RootRegistryFolderSaUserPermission =>
            new Entities.Security.FolderUserPermission()
            {
                SubjectId = User.Sa.Id,
                ObjectId = RootRegistryFolder.Id,
                Mode = AccessMode.All,
                CreationDate = DateTime.UnixEpoch,
                ModifiedDate = DateTime.UnixEpoch
            };

        public static Entities.Security.FolderUserPermission RootRegistryFolderSystemUserPermission =>
            new Entities.Security.FolderUserPermission()
            {
                SubjectId = User.System.Id,
                ObjectId = RootRegistryFolder.Id,
                Mode = AccessMode.All,
                CreationDate = DateTime.UnixEpoch,
                ModifiedDate = DateTime.UnixEpoch
            };

        public static Entities.Security.FolderGroupPermission RootRegistryFolderSaGroupPermission =>
            new Entities.Security.FolderGroupPermission()
            {
                SubjectId = Group.Sa.Id,
                ObjectId = RootRegistryFolder.Id,
                Mode = AccessMode.All,
                CreationDate = DateTime.UnixEpoch,
                ModifiedDate = DateTime.UnixEpoch
            };

        public static Entities.Security.FolderGroupPermission RootRegistryFolderSystemGroupPermission =>
            new Entities.Security.FolderGroupPermission()
            {
                SubjectId = Group.System.Id,
                ObjectId = RootRegistryFolder.Id,
                Mode = AccessMode.All,
                CreationDate = DateTime.UnixEpoch,
                ModifiedDate = DateTime.UnixEpoch
            };

        public static Entities.Security.FolderRolePermission RootRegistryFolderSaRolePermission =>
            new Entities.Security.FolderRolePermission()
            {
                SubjectId = Role.Sa.Id,
                ObjectId = RootRegistryFolder.Id,
                Mode = AccessMode.All,
                CreationDate = DateTime.UnixEpoch,
                ModifiedDate = DateTime.UnixEpoch
            };

        public static Entities.Security.FolderRolePermission RootRegistryFolderSystemRolePermission =>
            new Entities.Security.FolderRolePermission()
            {
                SubjectId = Role.System.Id,
                ObjectId = RootRegistryFolder.Id,
                Mode = AccessMode.All,
                CreationDate = DateTime.UnixEpoch,
                ModifiedDate = DateTime.UnixEpoch
            };

        #endregion

        #endregion

        #endregion
    }
}
