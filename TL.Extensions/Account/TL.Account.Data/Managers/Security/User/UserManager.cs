using ExtCore.Data.Abstractions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using TL.Account.Data.Abstractions.Security;
using TL.Account.Data.Entities.Relationships;
using TL.Account.Data.Entities.Security;
using TL.Account.Data.Extensions;
using TL.Api.SDK.Attributes.Executable;
using TL.Engine.SDK.Extensions;
using TL.Engine.SDK.Managers;

namespace TL.Account.Data.Managers
{
    public class UserManager : EntityComparableStoredManager<User, Guid>, IUserManager
    {
        public UserManager(IServiceProvider serviceProvider, IStorage storage, ILoggerFactory loggerFactory) : base(serviceProvider, storage, loggerFactory)
        {
        }

        [PublicApi(Description = "Получить пользователя по имени")]
        public User Get(string username)
        {
            return username.GetUser(Storage);
        }

        [PrivateApi(Description = "Создать пользователя с логином, паролем и описанием")]
        public User Create(string username, string password, string description = null)
        {
            User user = null;
            try
            {
                var passwordHasher = new PasswordHasher<User>();
                var user_id = Guid.NewGuid();

                user = new User()
                {
                    Id = user_id,
                    Username = username,
                    PasswordHash = passwordHasher.HashPassword(user, password),
                    Description = description,
                    UserRoles = new HashSet<UserRole>(new[]
                    {
                        new UserRole()
                        {
                            UserId = user_id,
                            RoleId = Role.User.Id
                        }
                    }),
                    Subscriptions = new HashSet<Subscription>(new[]
                    {
                            new Subscription()
                            {
                                FromId = user_id,
                                ToId = User.System.Id,
                                Quiet = true,
                            }
                        })
                };

                Storage.GetRepository<IUserRepository>().Add(user);
                Storage.Save();
            }
            catch (Exception ex)
            {
                Logger.TLogCritical($"Не удалось завершить транзакцию в БД\r\n{ex}");
            }
            return user;
        }

        [PrivateApi(Description = "Получить существующего пользователя или создать нового")]
        public User GetOrCreate(string username, string password = null, string description = null)
        {
            var user = Get(username);
            if (user == null)
            {
                if (password == null)
                {
                    throw new ArgumentNullException(nameof(password), $"Запрещено создавать пользователей без пароля!");
                }

                user = Create(username, password, description);
            }
            return user;
        }

        public void Authenticate(User user, HttpContext httpContext)
        {
            user.Authenticate(Storage, httpContext);
        }

        [PublicApi(Description = "Получить всех пользователей")]
        public override IEnumerable<User> GetAll(bool loadDeleted = false)
        {
            return base.GetAll(loadDeleted);
        }
    }
}
