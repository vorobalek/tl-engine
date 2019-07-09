using ExtCore.Data.Abstractions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using TL.Engine.Data.Entities.Security;
using TL.Engine.Data.Extensions;
using TL.Engine.SDK.Extensions;
using TL.Engine.SDK.Managers;
using TL.Engine.SDK.Services;

namespace TL.Engine.Data.Managers
{
    internal class UserManager : EntityComparableStoredManager<User, Guid>, IUserManager
    {
        IRoleManager RoleManager { get; }
        IGroupManager GroupManager { get; }
        IUserRoleManager UserRoleManager { get; }
        IUserGroupManager UserGroupManager { get; }
        IServiceProvider ServiceProvider { get; }

        public UserManager(
            IRoleManager roleManager,
            IGroupManager groupManager,
            IUserRoleManager userRoleManager,
            IUserGroupManager userGroupManager,
            IServiceProvider serviceProvider,
            IActivatorService activator,
            ILoggerFactory loggerFactory,
            IStorage storage)
            : base(activator, loggerFactory, storage)
        {
            RoleManager = roleManager;
            GroupManager = groupManager;
            UserRoleManager = userRoleManager;
            UserGroupManager = userGroupManager;
            ServiceProvider = serviceProvider;
        }

        public User Get(string username)
        {
            return Get(e => e.Username == username);
        }

        public User Create(string username, string password, string description = null)
        {
            if (string.IsNullOrWhiteSpace(password))
            {
                throw new ArgumentNullException(nameof(password), $"Запрещено создавать пользователей без пароля!");
            }

            try
            {
                var passwordHasher = new PasswordHasher<User>();
                var user = new User()
                {
                    Username = username,
                    Description = description,
                };
                user.PasswordHash = passwordHasher.HashPassword(user, password);
                user = Create(user);
                var personalGroup = GroupManager.Create(new Group()
                {
                    Name = user.Id.ToString()
                });

                user.UserRoles = new HashSet<UserRole>(new[]
                {
                    new UserRole()
                    {
                        UserId = user.Id,
                        RoleId = Role.DefaultUser.Id
                    }
                }.Select(ur => UserRoleManager.Create(ur)));
                user.UserGroups = new HashSet<UserGroup>(new[]
                {
                    new UserGroup()
                    {
                        UserId = user.Id,
                        GroupId = Group.All.Id,
                    },
                    new UserGroup()
                    {
                        UserId = user.Id,
                        GroupId = Group.DefaultUser.Id,
                    },
                    new UserGroup()
                    {
                        UserId = user.Id,
                        GroupId = personalGroup.Id,
                    }
                }.Select(ug => UserGroupManager.Create(ug)));

                return Update(user);
            }
            catch (Exception ex)
            {
                Logger.TLogCritical($"Ошибка при создании экземпляра {typeof(User).GetFullName()}\r\n{ex}");
            }
            return null;
        }

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
            user.Authenticate(ServiceProvider, httpContext);
        }

        public override IEnumerable<User> GetAll(bool loadDeleted = false)
        {
            return base.GetAll(loadDeleted);
        }

        public bool ValidatePassword(User user, string password)
        {
            var passwordHasher = new PasswordHasher<User>();
            var result = passwordHasher.VerifyHashedPassword(user, user.PasswordHash, password);
            return result != PasswordVerificationResult.Failed;
        }

        public User ChangePassword(User user, string password)
        {
            var passwordHasher = new PasswordHasher<User>();
            user.PasswordHash = passwordHasher.HashPassword(user, password);
            user.WebTicket = Guid.NewGuid();

            return Update(user);
        }
    }
}
