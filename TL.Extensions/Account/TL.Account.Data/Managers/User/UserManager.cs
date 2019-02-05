using ExtCore.Data.Abstractions;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TL.Account.Data.Abstractions.Security;
using TL.Account.Data.Entities.Relationships;
using TL.Account.Data.Entities.Security;
using TL.Account.Data.Extensions;

using TUser = TL.Account.Data.Entities.Security.User;

namespace TL.Account.Data.Managers.User
{
    public class UserManager : IUserManager
    {
        IStorage Storage { get; }

        public UserManager(IStorage storage)
        {
            Storage = storage;
        }

        public Task<TUser> GetAsync(Guid id)
        {
            return Task.Run(() =>
            {
                return id.GetUser(Storage);
            });
        }

        public Task<TUser> GetAsync(string username)
        {
            return Task.Run(() =>
            {
                return username.GetUser(Storage);
            });
        }

        public Task<TUser> CreateAsync(string username, string password, string description = null)
        {
            return Task.Run(() =>
            {
                var passwordHasher = new PasswordHasher<TUser>();
                var user_id = Guid.NewGuid();
                TUser user = null;

                user = new TUser()
                {
                    Id = user_id,
                    Username = username,
                    PasswordHash = passwordHasher.HashPassword(user, password),
                    RegistrationDate = DateTime.Now.ToUniversalTime(),
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
                            ToId = TUser.System.Id,
                            Quiet = true,
                        }
                    })
                };

                Storage.GetRepository<IUserRepository>().Add(user);
                Storage.Save();
                return user;
            });
        }

        public async Task<TUser> GetOrCreateAsync(string username, string password = null, string description = null)
        {
            var user = await GetAsync(username);
            if (user == null)
            {
                if (password == null)
                {
                    throw new ArgumentNullException(nameof(password), $"Запрещено создавать пользователей без пароля!");
                }

                user = await CreateAsync(username, password, description);
            }
            return user;
        }

        public Task AuthenticateAsync(TUser user, HttpContext httpContext)
        {
            return user.AuthenticateAsync(Storage, httpContext);
        }
    }
}
