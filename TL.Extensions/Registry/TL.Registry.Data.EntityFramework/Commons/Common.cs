using System;
using TL.Engine.Data.Entities.Security;
using TL.Engine.SDK.Types;
using TL.Engine.SDK.Types.Enums;
using TL.Registry.Data.Entities.Core;

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

        public static Permission RootRegistrySaUserPermission =>
            Permission.Generic((User.Sa.Id, RootRegistry.Id), AccessMode.All);

        public static Permission RootRegistrySystemUserPermission =>
            Permission.Generic((User.System.Id, RootRegistry.Id), AccessMode.All);

        public static Permission RootRegistrySaGroupPermission =>
            Permission.Generic((Group.Sa.Id, RootRegistry.Id), AccessMode.All);

        public static Permission RootRegistrySystemGroupPermission =>
            Permission.Generic((Group.System.Id, RootRegistry.Id), AccessMode.All);

        public static Permission RootRegistrySaRolePermission =>
            Permission.Generic((Role.Sa.Id, RootRegistry.Id), AccessMode.All);

        public static Permission RootRegistrySystemRolePermission =>
            Permission.Generic((Role.System.Id, RootRegistry.Id), AccessMode.All);

        #endregion

        #region RegistryFolderPermissions

        public static Permission RootRegistryFolderSaUserPermission =>
            Permission.Generic((User.Sa.Id, RootRegistryFolder.Id), AccessMode.All);

        public static Permission RootRegistryFolderSystemUserPermission =>
            Permission.Generic((User.System.Id, RootRegistryFolder.Id), AccessMode.All);

        public static Permission RootRegistryFolderSaGroupPermission =>
            Permission.Generic((Group.Sa.Id, RootRegistryFolder.Id), AccessMode.All);

        public static Permission RootRegistryFolderSystemGroupPermission =>
            Permission.Generic((Group.System.Id, RootRegistryFolder.Id), AccessMode.All);

        public static Permission RootRegistryFolderSaRolePermission =>
            Permission.Generic((Role.Sa.Id, RootRegistryFolder.Id), AccessMode.All);

        public static Permission RootRegistryFolderSystemRolePermission =>
            Permission.Generic((Role.System.Id, RootRegistryFolder.Id), AccessMode.All);

        #endregion

        #endregion

        #endregion
    }
}
