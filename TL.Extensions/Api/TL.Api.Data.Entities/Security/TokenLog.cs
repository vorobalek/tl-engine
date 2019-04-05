using System;
using TL.Engine.Data.Entities.Security;
using TL.Engine.SDK.Entities;

namespace TL.Api.Data.Entities.Security
{
    public class TokenLog : EntityComparableStored<Guid>
    {
        public Guid? UserId { get; set; }

        public virtual User User { get; set; }

        public Guid TokenId { get; set; }

        public virtual Token Token { get; set; }

        public string Method { get; set; }

        public string Parameters { get; set; }

        public int StatusCode { get; set; }
    }
}
