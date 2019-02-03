using ExtCore.Data.Abstractions;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Security.Claims;
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

        public Task<TUser> GetAcync(string username)
        {
            return Task.Run(() =>
            {
                return username.GetUser(Storage);
            });
        }

        public Task<TUser> Get(Guid id)
        {
            throw new NotImplementedException();
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

        public async Task<TUser> TryCreateAsync(string username, string password, string description = null)
        {
            var user = await GetAcync(username);
            if (user == null)
            {
                return await CreateAsync(username, password, description);
            }
            else
            {
                return null;
            }
        }

        public Task AuthenticateAsync(TUser user, HttpContext httpContext)
        {
            return Task.Run(async () =>
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimsIdentity.DefaultNameClaimType, user.Username),
                    new Claim(nameof(TUser.Id), user.Id.ToString())
                };

                var roles = Storage.GetRepository<IUserRoleRepository>().GetByUser(user);
                foreach (var userRole in roles)
                {
                    var role = Storage.GetRepository<IRoleRepository>().GetById(userRole.RoleId);
                    claims.Add(new Claim(ClaimsIdentity.DefaultRoleClaimType, role.Name));
                }

                ClaimsIdentity id = new ClaimsIdentity(claims, "ApplicationCookie", ClaimsIdentity.DefaultNameClaimType, ClaimsIdentity.DefaultRoleClaimType);

                await httpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(id));
            });
        }
    }
}
