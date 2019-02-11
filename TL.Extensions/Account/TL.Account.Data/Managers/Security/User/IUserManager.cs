using Microsoft.AspNetCore.Http;
using System;
using TL.Account.Data.Entities.Security;

namespace TL.Account.Data.Managers
{
    public interface IUserManager
    {
        User Get(Guid id);

        User Get(string username);

        User Create(string username, string password, string description = null);

        User GetOrCreate(string username, string password = null, string description = null);

        void Authenticate(User user, HttpContext httpContext);
    }
}
