using ExtCore.Data.Entities.Abstractions;
using System;
using System.Collections.Generic;

namespace TL.Integrations.Data.Entities.Telegram.Security
{
    public class TgUser : IEntity
    {
        public Guid Id { get; set; }

        public int TgId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Username { get; set; }

        public string LanguageCode { get; set; }

        public DateTime RegistrationDate { get; set; }

        public bool IsDeleted { get; set; } = false;

        public Guid? ReferrerId { get; set; }

        public virtual TgUser Referrer { get; set; }

        public virtual IEnumerable<TgUser> Referrals { get; set; }

        public virtual IEnumerable<TgUserRole> UserRoles { get; set; }

        public TgUser()
        {
            UserRoles = new HashSet<TgUserRole>();
            Referrals = new HashSet<TgUser>();
        }
    }
}
