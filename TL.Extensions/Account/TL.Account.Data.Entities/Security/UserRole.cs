using ExtCore.Data.Entities.Abstractions;
using System;

namespace TL.Account.Data.Entities.Security
{
    public class UserRole : IEntity
    {
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
                RoleId = Role.System.Id,
            },
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
