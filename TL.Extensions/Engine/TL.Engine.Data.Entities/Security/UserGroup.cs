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
                CreationDate = DateTime.UnixEpoch,
                ModifiedDate = DateTime.UnixEpoch
            },

            new UserGroup()
            {
                UserId = User.Sa.Id,
                GroupId = Group.Sa.Id,
                CreationDate = DateTime.UnixEpoch,
                ModifiedDate = DateTime.UnixEpoch
            },

            new UserGroup()
            {
                UserId = User.Sa.Id,
                GroupId = Group.DefaultUser.Id,
                CreationDate = DateTime.UnixEpoch,
                ModifiedDate = DateTime.UnixEpoch
            },

            new UserGroup()
            {
                UserId = User.Sa.Id,
                GroupId = Group.System.Id,
                CreationDate = DateTime.UnixEpoch,
                ModifiedDate = DateTime.UnixEpoch
            },
        };

        public static UserGroup[] DefaultUser => new[]
        {
            new UserGroup()
            {
                UserId = User.DefaultUser.Id,
                GroupId = Group.All.Id,
                CreationDate = DateTime.UnixEpoch,
                ModifiedDate = DateTime.UnixEpoch
            },

            new UserGroup()
            {
                UserId = User.DefaultUser.Id,
                GroupId = Group.DefaultUser.Id,
                CreationDate = DateTime.UnixEpoch,
                ModifiedDate = DateTime.UnixEpoch
            }
        };

        public static UserGroup[] System => new[]
        {
            new UserGroup()
            {
                UserId = User.System.Id,
                GroupId = Group.All.Id,
                CreationDate = DateTime.UnixEpoch,
                ModifiedDate = DateTime.UnixEpoch
            },

            new UserGroup()
            {
                UserId = User.System.Id,
                GroupId = Group.System.Id,
                CreationDate = DateTime.UnixEpoch,
                ModifiedDate = DateTime.UnixEpoch
            }
        };
    }
}