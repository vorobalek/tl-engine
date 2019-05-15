using Microsoft.AspNetCore.Http;
using System;
using TL.Engine.Data.Entities.Security;
using TL.Engine.SDK.Managers;

namespace TL.Engine.Data.Managers
{
    public interface IUserManager : IEntityComparableStoredManager<User, Guid>
    {
        User Get(string username);

        User Create(string username, string password, string description = null);

        User GetOrCreate(string username, string password = null, string description = null);

        bool ValidatePassword(User user, string password);

        User ChangePassword(User user, string password);

        void Authenticate(User user, HttpContext httpContext);
    }
}
