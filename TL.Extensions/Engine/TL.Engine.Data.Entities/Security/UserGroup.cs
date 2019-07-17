using System;
using TL.Engine.SDK.Entities;

namespace TL.Engine.Data.Entities.Security
{
    public class UserGroup : EntityComparableStored<(Guid, Guid)>
    {
        public override (Guid, Guid) Id { get => (UserId, GroupId); set => (UserId, GroupId) = value; }

        public Guid UserId { get; set; }

        public virtual User User { get; set; }

        public Guid GroupId { get; set; }

        public virtual Group Group { get; set; }

        public static UserGroup[] Sa => new[]
        {
            new UserGroup()
            {
                UserId = User.Sa.Id,
                GroupId = Group.All.Id,
            },

            new UserGroup()
            {
                UserId = User.Sa.Id,
                GroupId = Group.Sa.Id,
            },

            new UserGroup()
            {
                UserId = User.Sa.Id,
                GroupId = Group.DefaultUser.Id,
            },

            new UserGroup()
            {
                UserId = User.Sa.Id,
                GroupId = Group.System.Id,
            },
        };

        public static UserGroup[] DefaultUser => new[]
        {
            new UserGroup()
            {
                UserId = User.DefaultUser.Id,
                GroupId = Group.All.Id,
            },

            new UserGroup()
            {
                UserId = User.DefaultUser.Id,
                GroupId = Group.DefaultUser.Id,
            }
        };

        public static UserGroup[] System => new[]
        {
            new UserGroup()
            {
                UserId = User.System.Id,
                GroupId = Group.All.Id,
            },

            new UserGroup()
            {
                UserId = User.System.Id,
                GroupId = Group.System.Id
            }
        };
    }
}