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
            },

            new UserRole()
            {
                UserId = User.Sa.Id,
                RoleId = Role.DefaultUser.Id,
            },

            new UserRole()
            {
                UserId = User.Sa.Id,
                RoleId = Role.System.Id,
            },
        };

        public static UserRole[] DefaultUser => new[]
        {
            new UserRole()
            {
                UserId = User.DefaultUser.Id,
                RoleId = Role.DefaultUser.Id,
            }
        };

        public static UserRole[] System => new[]
        {
            new UserRole()
            {
                UserId = User.System.Id,
                RoleId = Role.System.Id
            }
        };
    }
}