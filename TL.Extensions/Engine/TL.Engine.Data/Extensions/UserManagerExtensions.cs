using ExtCore.Data.Abstractions;
using System;
using System.Linq;
using System.Security.Claims;
using TL.Engine.Data.Entities.Security;
using TL.Engine.Data.Managers;

namespace TL.Engine.Data.Extensions
{
    public static class UserManagerExtensions
    {
        public static User GetByClaims(this IUserManager userManager, ClaimsPrincipal claims)
        {
            var id = claims?.Claims?.FirstOrDefault(c => c.Type == nameof(User.Id))?.Value;
            if (!string.IsNullOrWhiteSpace(id) && Guid.TryParse(id, out Guid uid))
            {
                return userManager.GetByKey(uid);
            }
            return null;
        }
    }
}
