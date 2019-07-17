using System;
using System.Collections.Generic;
using TL.Engine.SDK.Attributes.EntityIndexer;
using TL.Engine.SDK.Entities;

namespace TL.Engine.Data.Entities.Security
{
    public class User : EntityComparableStored<Guid>
    {
        [StringIndex]
        public string Username { get; set; }

        [StringIndex]
        public string Description { get; set; }

        public bool HasPassword { get => !string.IsNullOrWhiteSpace(PasswordHash); }

        public string PasswordHash { get; set; }

        public bool IsClosed { get; set; } = false;

        public Guid WebTicket { get; set; } = Guid.NewGuid();

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
                Id = Guid.Parse("998207b8-f18a-4508-a415-0fb6d16e1615"),
                Username = "sa",
                Description = "Супер-пользователь системы TL Engine",
                CreationDate = DateTime.UnixEpoch,
                ModifiedDate = DateTime.UnixEpoch
            };

        public static User DefaultUser =>
            new User()
            {
                Id = Guid.Parse("544c8d71-91ba-44f4-81c6-63fee3c50b9f"),
                Username = "user",
                Description = "Шаблонный пользователь системы TL Engine",
                IsClosed = true,
                CreationDate = DateTime.UnixEpoch,
                ModifiedDate = DateTime.UnixEpoch
            };

        public static User System =>
            new User()
            {
                Id = Guid.Parse("2c73ecab-ba81-4690-a96e-39986850a47a"),
                Username = "system",
                Description = "Автоматика системы TL Engine",
                IsClosed = true,
                CreationDate = DateTime.UnixEpoch,
                ModifiedDate = DateTime.UnixEpoch
            };
    }
}
