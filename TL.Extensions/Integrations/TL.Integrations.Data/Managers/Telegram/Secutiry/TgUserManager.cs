using ExtCore.Data.Abstractions;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using TL.Account.Data.Managers;
using TL.Engine.SDK.Extensions;
using TL.Engine.SDK.Managers;
using TL.Integrations.Data.Abstractions.Telegram.Security;
using TL.Integrations.Data.Entities.Telegram.Security;
using TL.Integrations.Data.Extensions;

namespace TL.Integrations.Data.Managers
{
    public class TgUserManager : EntityComparableStoredManager<TgUser, Guid>,  ITgUserManager
    {
        public TgUserManager(IUserManager userManager, IServiceProvider serviceProvider, IStorage storage, ILoggerFactory loggerFactory) : base(serviceProvider, storage, loggerFactory)
        {
            UserManager = userManager;
        }

        public IUserManager UserManager { get; }

        public TgUser Create(int id, string username = null, string firstname = null, string lastname = null)
        {
            TgUser tgUser = null;
            try
            {
                var tgUserId = Guid.NewGuid();
                tgUser = new TgUser()
                {
                    Id = tgUserId,
                    TgId = id,
                    Username = username,
                    FirstName = firstname,
                    LastName = lastname,
                    UserRoles = new HashSet<TgUserRole>(new[]
                    {
                        new TgUserRole()
                        {
                            UserId = tgUserId,
                            RoleId = TgRole.User.Id,
                        }
                    })
                };

                var password = Guid.NewGuid().ToString();
                var user = UserManager.GetOrCreate($"tg:{id}", password, "Этот аккаунт создан автоматически системой интеграции с Telegram");
                tgUser.UserId = user.Id;

                Storage.GetRepository<ITgUserRepository>().Add(tgUser);
                Storage.Save();
            }
            catch (Exception ex)
            {
                Logger.TLogCritical($"Не удалось завершить транзакцию в БД\r\n{ex}");
            }
            return tgUser;
        }

        public TgUser Get(int id)
        {
            return id.GetTgUser(Storage);
        }

        public TgUser GetOrCreate(int id, string username = null, string firstname = null, string lastname = null)
        {
            var tgUser = Get(id);
            if (tgUser == null)
            {
                tgUser = Create(id, username, firstname, lastname);
            }

            return tgUser;
        }
    }
}
