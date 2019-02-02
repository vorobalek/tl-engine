using ExtCore.Data.Abstractions;
using System;
using System.Linq;
using System.Security.Claims;
using TL.Account.Data.Abstractions.Security;
using TL.Account.Data.Entities.Security;

namespace TL.Account.Data.Extensions
{
    public static class ClaimsPrincipalExtensions
    {
        public static User GetUser(this ClaimsPrincipal claims, IStorage storage)
        {
            var id = claims.Claims.FirstOrDefault(c => c.Type == nameof(User.Id)).Value;
            if (!string.IsNullOrWhiteSpace(id) && Guid.TryParse(id, out Guid uid))
            {
                var user = storage.GetRepository<IUserRepository>().GetById(uid);
                return user;
            }
            return null;
        }
    }
}
