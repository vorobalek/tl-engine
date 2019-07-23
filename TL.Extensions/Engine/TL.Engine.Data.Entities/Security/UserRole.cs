using System;
using TL.Engine.SDK.Entities;

namespace TL.Engine.Data.Entities.Security
{
    public class UserRole : EntityComparableStored<(Guid, Guid)>
    {
        public override (Guid, Guid) Id { get => (UserId, RoleId); set => (UserId, RoleId) = value; }

        public Guid UserId { get; set; }

        public virtual User User { get; set; }

        public Guid RoleId { get; set; }

        public virtual Role Role { get; set; }

        public static UserRole[] Sa => new[]
        {
            new UserRole()
            {
                UserId = User.Sa.Id,
                RoleId = Role.Sa.Id,
                CreationDate = DateTime.UnixEpoch,
                ModifiedDate = DateTime.UnixEpoch
            },

            new UserRole()
            {
                UserId = User.Sa.Id,
                RoleId = Role.DefaultUser.Id,
                CreationDate = DateTime.UnixEpoch,
                ModifiedDate = DateTime.UnixEpoch
            },

            new UserRole()
            {
                UserId = User.Sa.Id,
                RoleId = Role.System.Id,
                CreationDate = DateTime.UnixEpoch,
                ModifiedDate = DateTime.UnixEpoch
            },

            new UserRole()
            {
                UserId = User.Sa.Id,
                RoleId = Role.UserCreator.Id,
                CreationDate = DateTime.UnixEpoch,
                ModifiedDate = DateTime.UnixEpoch
            },

            new UserRole()
            {
                UserId = User.Sa.Id,
                RoleId = Role.RoleCreator.Id,
                CreationDate = DateTime.UnixEpoch,
                ModifiedDate = DateTime.UnixEpoch
            },

            new UserRole()
            {
                UserId = User.Sa.Id,
                RoleId = Role.GroupCreator.Id,
                CreationDate = DateTime.UnixEpoch,
                ModifiedDate = DateTime.UnixEpoch
            },
        };

        public static UserRole[] DefaultUser => new[]
        {
            new UserRole()
            {
                UserId = User.DefaultUser.Id,
                RoleId = Role.DefaultUser.Id,
                CreationDate = DateTime.UnixEpoch,
                ModifiedDate = DateTime.UnixEpoch
            }
        };

        public static UserRole[] System => new[]
        {
            new UserRole()
            {
                UserId = User.System.Id,
                RoleId = Role.System.Id,
                CreationDate = DateTime.UnixEpoch,
                ModifiedDate = DateTime.UnixEpoch
            }
        };
    }
}