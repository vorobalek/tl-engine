using ExtCore.Data.Entities.Abstractions;
using System;
using System.Collections.Generic;
using TL.Account.Data.Entities.Security;

namespace TL.Integrations.Data.Entities.Telegram.Security
{
    public class TgUser : IEntity
    {
        public Guid Id { get; set; }

        public int TgId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Username { get; set; }

        public virtual IEnumerable<TgUserRole> UserRoles { get; set; }

        public Guid? UserId { get; set; }

        public virtual User User { get; set; }

        public TgUser()
        {
            UserRoles = new HashSet<TgUserRole>();
        }
    }
}
