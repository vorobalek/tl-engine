using ExtCore.Data.Abstractions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using TL.Engine.Data.Abstractions.Security;
using TL.Engine.Data.Entities.Security;
using TL.Engine.Data.Extensions;
using TL.Engine.SDK.Attributes.Api.Executable;
using TL.Engine.SDK.Extensions;
using TL.Engine.SDK.Managers;

namespace TL.Engine.Data.Managers
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
            if (string.IsNullOrWhiteSpace(password))
            {
                throw new ArgumentNullException(nameof(password), $"Запрещено создавать пользователей без пароля!");
            }

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
                            RoleId = Role.DefaultUser.Id
                        }
                    }),
                    UserGroups = new HashSet<UserGroup>(new[]
                    {
                        new UserGroup()
                        {
                            UserId = user_id,
                            GroupId = Group.All.Id,
                        },
                        new UserGroup()
                        {
                            UserId = user_id,
                            GroupId = Group.DefaultUser.Id,
                        },
                        new UserGroup()
                        {
                            UserId = user_id,
                            GroupId = Storage.GetRepository<IGroupRepository>().Add(new Group()
                            {
                                Name = user_id.ToString()
                            }).Id,
                        }
                    })
                };

                return Create(user);
            }
            catch (Exception ex)
            {
                Logger.TLogCritical($"Ошибка при создании экземпляра {typeof(User).GetFullName()}\r\n{ex}");
            }
            return user;
        }

        [PrivateApi(Description = "Получить существующего пользователя или создать нового")]
        public User GetOrCreate(string username, string password = null, string description = null)
        {
            var user = Get(username);
            if (user == null)
            {
                user = Create(username, password, description);
            }
            return user;
        }

        public void Authenticate(User user, HttpContext httpContext)
        {
            user.Authenticate(Storage, httpContext);
        }

        [PrivateApi(Description = "Получить всех пользователей")]
        public override IEnumerable<User> GetAll(bool loadDeleted = false)
        {
            return base.GetAll(loadDeleted);
        }
    }
}
