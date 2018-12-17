using ExtCore.Data.Entities.Abstractions;
using System;

namespace TL.Account.Data.Entities.Secutiry
{
    public class User : IEntity
    {
        public Guid Id { get; set; }

        public string Username { get; set; }

        public bool HasPassword { get => !string.IsNullOrWhiteSpace(PasswordHash); }

        public string PasswordHash { get; set; }

        public Guid? RoleId { get; set; }

        public Role Role { get; set; }

        public static User SA => 
            new User()
            {
                Id = Guid.Parse("3f358db5-090e-4a93-8a1b-27a8aaedcef2"),
                Username = "SA",
                RoleId = Guid.Parse("2e8036a5-95d2-4137-996e-a72d559d09a4")
            };
    }
}
