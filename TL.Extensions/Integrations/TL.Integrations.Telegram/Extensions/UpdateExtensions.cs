using ExtCore.Data.Abstractions;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using TL.Engine.Data.Managers;
using TL.Integrations.Data.Abstractions.Telegram.Relationships;
using TL.Integrations.Data.Entities.Telegram.Relationships;
using TL.Integrations.Data.Managers;
using TL.Integrations.SDK.Telegram.Bots;
using TL.Integrations.SDK.Telegram.Extensions;
using User = TL.Engine.Data.Entities.Security.User;

namespace TL.Integrations.Telegram.Extensions
{
    public static class UpdateExtensions
    {
        public static User GetOrCreateUser(this Update update, IBaseBot bot, IServiceProvider serviceProvider)
        {
            try
            {
                var chatId = update.GetSenderChatId();
                var fromId = update.GetSenderId();

                var tgUserManager = serviceProvider.GetService<ITgUserManager>();

                var tgUser = tgUserManager.GetOrCreate((int)fromId.Identifier, fromId.Username);

                if (chatId.Identifier == fromId.Identifier)
                {
                    if (update.Type == UpdateType.Message)
                    {
                        var storage = serviceProvider.GetService<IStorage>();
                        var tgConnectionRepository = storage.GetRepository<ITgConnectionRepository>();

                        var tgBot = serviceProvider.GetService<ITgBotManager>().Get(bot.Token, bot.GetType().Name);
                        if (!tgConnectionRepository.GetMembers(tgBot).Contains(tgUser.Id))
                        {
                            tgConnectionRepository.Add(new TgConnection() { Bot = tgBot, User = tgUser });
                            storage.Save();

                            tgUser.FirstName = update.Message.From.FirstName;
                            tgUser.LastName = update.Message.From.LastName;
                            tgUser.Username = update.Message.From.Username;
                            tgUserManager.Update(tgUser);
                        }
                    }

                    return serviceProvider.GetService<IUserManager>().GetByKey(tgUser.UserId.Value);
                }
            }
            catch { }

            return null;
        }
    }
}
