using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading.Tasks;
using Telegram.Bot.Types;
using TL.Account.Data.Managers.User;
using TL.Engine.SDK.Extensions;
using TUser = TL.Account.Data.Entities.Security.User;

namespace TL.Integrations.Data.Extensions
{
    public static class UpdateExtensions
    {
        public static async Task<TUser> GetOrCreateUserAsync(this Update update, IServiceProvider serviceProvider)
        {
            var userManager = serviceProvider.GetService<IUserManager>();

            var chatId = update.GetSenderChatId();
            var fromId = update.GetSenderId();
            var username = $"tg:{fromId.Identifier}";
            var password = Guid.NewGuid().ToString();

            if (chatId.Identifier == fromId.Identifier)
            {
                return await userManager.GetOrCreateAsync(username, password, "Этот аккаунт создан автоматически системой интеграции с Telegram");
            }

            return null;
        }
    }
}
