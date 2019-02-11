using ExtCore.Data.Abstractions;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using System.Threading.Tasks;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using TL.Account.Data.Managers;
using TL.Engine.SDK.Extensions;
using TL.Engine.SDK.Integrations.Telegram.Bots;
using TL.Integrations.Data.Abstractions.Telegram.Relationships;
using TL.Integrations.Data.Abstractions.Telegram.Security;
using TL.Integrations.Data.Managers;
using User = TL.Account.Data.Entities.Security.User;

namespace TL.Integrations.Telegram.Extensions
{
    public static class UpdateExtensions
    {
        public static User GetOrCreateUser(this Update update, IBaseBot bot, IServiceProvider serviceProvider)
        {
            var chatId = update.GetSenderChatId();
            var fromId = update.GetSenderId();

            var tgUser = serviceProvider.GetService<ITgUserManager>().GetOrCreate((int)fromId.Identifier, fromId.Username);

            if (chatId.Identifier == fromId.Identifier)
            {
                if (update.Type == UpdateType.Message)
                {
                    var storage = serviceProvider.GetService<IStorage>();
                    var tgConnectionRepository = storage.GetRepository<ITgConnectionRepository>();

                    var tgBot = serviceProvider.GetService<ITgBotManager>().Get(bot.Token, bot.GetType().Name);
                    if (!tgConnectionRepository.GetMembers(tgBot).Contains(tgUser.Id))
                    {
                        tgUser.FirstName = update.Message.From.FirstName;
                        tgUser.LastName = update.Message.From.LastName;
                        tgUser.Username = update.Message.From.Username;
                        storage.GetRepository<ITgUserRepository>().Update(tgUser);

                        tgConnectionRepository.Add(tgBot, tgUser);
                        storage.Save();
                    }
                }

                return serviceProvider.GetService<IUserManager>().Get(tgUser.UserId.Value);
            }

            return null;
        }
    }
}
