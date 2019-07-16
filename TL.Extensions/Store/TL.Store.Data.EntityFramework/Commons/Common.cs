using System;
using TL.Engine.Data.Entities.Security;
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
                RootId = StoreRegistryFolder.Id
            };

        public static Registry.Data.Entities.Core.Folder StoreRegistryFolder =>
            new Registry.Data.Entities.Core.Folder()
            {
                Id = Guid.Parse("ff44803e-e998-451f-8507-d1ecbfcbcf79"),
                Name = "Module Store Registry Folder",
                OwnerId = User.System.Id,
                
                ParantId = Registry.Data.EntityFramework.Commons.Common.RootRegistryFolder.Id,
            };

        public static Registry.Data.Entities.Security.UserPermission StoreRegistrySaUserPermission =>
            new Registry.Data.Entities.Security.UserPermission()
            {
                SubjectId = User.Sa.Id,
                ObjectId = StoreRegistry.Id,
                Mode = AccessMode.All
            };

        public static Registry.Data.Entities.Security.UserPermission StoreRegistrySystemUserPermission =>
            new Registry.Data.Entities.Security.UserPermission()
            {
                SubjectId = User.System.Id,
                ObjectId = StoreRegistry.Id,
                Mode = AccessMode.All
            };

        public static Registry.Data.Entities.Security.GroupPermission StoreRegistrySaGroupPermission =>
            new Registry.Data.Entities.Security.GroupPermission()
            {
                SubjectId = User.Sa.Id,
                ObjectId = StoreRegistry.Id,
                Mode = AccessMode.All
            };

        public static Registry.Data.Entities.Security.GroupPermission StoreRegistrySystemGroupPermission =>
            new Registry.Data.Entities.Security.GroupPermission()
            {
                SubjectId = User.System.Id,
                ObjectId = StoreRegistry.Id,
                Mode = AccessMode.All
            };

        public static Registry.Data.Entities.Security.FolderUserPermission StoreRegistryFolderSaUserPermission =>
            new Registry.Data.Entities.Security.FolderUserPermission()
            {
                SubjectId = User.Sa.Id,
                ObjectId = StoreRegistryFolder.Id,
                Mode = AccessMode.All
            };

        public static Registry.Data.Entities.Security.FolderUserPermission StoreRegistryFolderSystemUserPermission =>
            new Registry.Data.Entities.Security.FolderUserPermission()
            {
                SubjectId = User.System.Id,
                ObjectId = StoreRegistryFolder.Id,
                Mode = AccessMode.All
            };

        public static Registry.Data.Entities.Security.FolderGroupPermission StoreRegistryFolderSaGroupPermission =>
            new Registry.Data.Entities.Security.FolderGroupPermission()
            {
                SubjectId = User.Sa.Id,
                ObjectId = StoreRegistryFolder.Id,
                Mode = AccessMode.All
            };

        public static Registry.Data.Entities.Security.FolderGroupPermission StoreRegistryFolderSystemGroupPermission =>
            new Registry.Data.Entities.Security.FolderGroupPermission()
            {
                SubjectId = User.System.Id,
                ObjectId = StoreRegistryFolder.Id,
                Mode = AccessMode.All
            };
    }
}
