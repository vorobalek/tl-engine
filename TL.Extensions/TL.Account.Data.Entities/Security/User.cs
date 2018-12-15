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
    }
}
