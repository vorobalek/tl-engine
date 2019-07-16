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
                SubjectId = User.Sa.Id,
                ObjectId = RootRegistry.Id,
                Mode = AccessMode.All
            };

        public static Entities.Security.GroupPermission RootRegistrySystemGroupPermission =>
            new Entities.Security.GroupPermission()
            {
                SubjectId = User.System.Id,
                ObjectId = RootRegistry.Id,
                Mode = AccessMode.All
            };

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
                SubjectId = User.Sa.Id,
                ObjectId = RootRegistryFolder.Id,
                Mode = AccessMode.All
            };

        public static Entities.Security.FolderGroupPermission RootRegistryFolderSystemGroupPermission =>
            new Entities.Security.FolderGroupPermission()
            {
                SubjectId = User.System.Id,
                ObjectId = RootRegistryFolder.Id,
                Mode = AccessMode.All
            };
    }
}
