using System;
using TL.Engine.Data.Entities.Security;
using TL.Engine.SDK.Types;
using TL.Engine.SDK.Types.Enums;

namespace TL.Store.Data.EntityFramework.Commons
{
    public class Common
    {
        public static Registry.Data.Entities.Core.Registry StoreRegistry =>
            new Registry.Data.Entities.Core.Registry()
            {
                Id = Guid.Parse("b14abcc1-39a7-4420-ac70-2b18ed73e146"),
                Name = "M-Store",
                Description = "Module Store Registry",
                Type = Registry.Data.Entities.Core.RegistryType.Private,
                OwnerId = User.System.Id,
                RootId = StoreRegistryFolder.Id,
                CreationDate = DateTime.UnixEpoch,
                ModifiedDate = DateTime.UnixEpoch
            };

        public static Registry.Data.Entities.Core.Folder StoreRegistryFolder =>
            new Registry.Data.Entities.Core.Folder()
            {
                Id = Guid.Parse("ff44803e-e998-451f-8507-d1ecbfcbcf79"),
                Name = "Module Store Registry Folder",
                OwnerId = User.System.Id,
                
                ParantId = Registry.Data.EntityFramework.Commons.Common.RootRegistryFolder.Id,
                CreationDate = DateTime.UnixEpoch,
                ModifiedDate = DateTime.UnixEpoch
            };

        #region Permissions

        #region RegistryPermissions

        public static Permission StoreRegistrySaUserPermission =>
            Permission.Generic((User.Sa.Id, StoreRegistry.Id), AccessMode.All);

        public static Permission StoreRegistrySystemUserPermission =>
            Permission.Generic((User.System.Id, StoreRegistry.Id), AccessMode.All);

        public static Permission StoreRegistrySaGroupPermission =>
            Permission.Generic((Group.Sa.Id, StoreRegistry.Id), AccessMode.All);

        public static Permission StoreRegistrySystemGroupPermission =>
            Permission.Generic((Group.System.Id, StoreRegistry.Id), AccessMode.All);

        public static Permission StoreRegistrySaRolePermission =>
            Permission.Generic((Role.Sa.Id, StoreRegistry.Id), AccessMode.All);

        public static Permission StoreRegistrySystemRolePermission =>
            Permission.Generic((Role.System.Id, StoreRegistry.Id), AccessMode.All);

        #endregion

        #region RegistryFolderPermissions

        public static Permission StoreRegistryFolderSaUserPermission =>
            Permission.Generic((User.Sa.Id, StoreRegistryFolder.Id), AccessMode.All);

        public static Permission StoreRegistryFolderSystemUserPermission =>
            Permission.Generic((User.System.Id, StoreRegistryFolder.Id), AccessMode.All);

        public static Permission StoreRegistryFolderSaGroupPermission =>
            Permission.Generic((Group.Sa.Id, StoreRegistryFolder.Id), AccessMode.All);

        public static Permission StoreRegistryFolderSystemGroupPermission =>
            Permission.Generic((Group.System.Id, StoreRegistryFolder.Id), AccessMode.All);

        public static Permission StoreRegistryFolderSaRolePermission =>
            Permission.Generic((Role.Sa.Id, StoreRegistryFolder.Id), AccessMode.All);

        public static Permission StoreRegistryFolderSystemRolePermission =>
            Permission.Generic((Role.System.Id, StoreRegistryFolder.Id), AccessMode.All);

        #endregion

        #endregion
    }
}