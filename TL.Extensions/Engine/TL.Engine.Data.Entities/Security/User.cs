using System;
using System.Collections.Generic;
using TL.Engine.SDK.Entities;

namespace TL.Engine.Data.Entities.Security
{
    public class User : EntityComparableStored<Guid>
    {
        public string Username { get; set; }

        public string Description { get; set; }

        public bool HasPassword { get => !string.IsNullOrWhiteSpace(PasswordHash); }

        public string PasswordHash { get; set; }

        public bool IsClosed { get; set; } = false;

        public DateTime LastActivity { get; set; }

        public DateTime LastLogon { get; set; }

        public virtual IEnumerable<UserRole> UserRoles { get; set; }

        public virtual IEnumerable<UserGroup> UserGroups { get; set; }

        public User() : base()
        {
            UserRoles = new HashSet<UserRole>();
            UserGroups = new HashSet<UserGroup>();
        }

        public static User Sa => 
            new User()
            {
                Id = Guid.Parse("ffffffff-ffff-ffff-ffff-ffffffffffff"),
                Username = "sa",
                Description = "Супер-пользователь системы TL Engine"
            };

        public static User DefaultUser =>
            new User()
            {
                Id = Guid.Parse("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"),
                Username = "user",
                Description = "Шаблонный пользователь системы TL Engine",
                IsClosed = true,
            };

        public static User System =>
            new User()
            {
                Id = Guid.Parse("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"),
                Username = "system",
                Description = "Автоматика системы TL Engine",
                IsClosed = true,
            };
    }
}
