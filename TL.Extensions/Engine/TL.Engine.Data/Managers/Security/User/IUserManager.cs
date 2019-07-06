using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using TL.Engine.Data.Entities.Security;
using TL.Engine.SDK.Attributes.Api.Executable;
using TL.Engine.SDK.Managers;

namespace TL.Engine.Data.Managers
{
    public interface IUserManager : IEntityComparableStoredManager<User, Guid>
    {
        [PrivateApi(Description = "Получить пользователя по имени")]
        User Get(string username);

        [PrivateApi(Description = "Создать пользователя с логином, паролем и описанием")]
        User Create(string username, string password, string description = null);

        [PrivateApi(Description = "Получить существующего пользователя или создать нового")]
        User GetOrCreate(string username, string password = null, string description = null);

        bool ValidatePassword(User user, string password);

        User ChangePassword(User user, string password);

        void Authenticate(User user, HttpContext httpContext);

        [PrivateApi(Description = "Получить всех пользователей")]
        new IEnumerable<User> GetAll(bool loadDeleted = false);
    }
}
