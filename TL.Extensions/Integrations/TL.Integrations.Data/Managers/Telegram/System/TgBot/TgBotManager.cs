using ExtCore.Data.Abstractions;
using Microsoft.Extensions.Logging;
using System;
using TL.Engine.SDK.Managers;
using TL.Engine.SDK.Services;
using TL.Integrations.Data.Abstractions.Telegram.System;
using TL.Integrations.Data.Entities.Telegram.System;
using TL.Integrations.SDK.Telegram.Services;

namespace TL.Integrations.Data.Managers
{
    internal class TgBotManager : EntityComparableStoredManager<TgBot, Guid>, ITgBotManager
    {
        public TgBotManager(ITelegramBotProviderService telegramBotProvider, IActivatorService activator, ILoggerFactory loggerFactory, IStorage storage) : base(activator, loggerFactory, storage)
        {
            TelegramBotProvider = telegramBotProvider;
        }

        public ITelegramBotProviderService TelegramBotProvider { get; }

        public TgBot Get(string token, string typename)
        {
            var tgBot = Storage.GetRepository<ITgBotRepository>().GetByTokenAndType(token, typename);
            return tgBot;
        }

        public TgBot Create(string token, string typename, string username = null, string nativename = null, bool skip_updates = true, bool auto_start = false)
        {
            TgBot tgBot = null;
            try
            {
                tgBot = new TgBot()
                {
                    Token = token,
                    Username = username,
                    NativeName = nativename,
                    TypeName = typename,
                    SkipUpdates = skip_updates,
                    AutoStart = auto_start,
                    IsRelevant = true
                };

                Storage.GetRepository<ITgBotRepository>().Add(tgBot);
                Storage.Save();
            }
            catch (Exception ex)
            {
                Logger.TLogCritical($"Не удалось завершить транзакцию в БД\r\n{ex}");
            }

            return tgBot;
        }

        public TgBot GetOrCreate(string token, string typename, string username = null, string nativename = null, bool skip_updates = true, bool auto_start = false)
        {
            var tgBot = Get(token, typename);
            if (tgBot == null)
            {
                tgBot = Create(token, typename, username, nativename, skip_updates, auto_start);
            }
            return tgBot;
        }

        public TgBot UpdateOrCreate(string token, string typename, string username = null, string nativename = null, bool skip_updates = true, bool auto_start = false, DateTime? lastStartupDate = null)
        {
            var tgBot = Get(token, typename);
            if (tgBot == null)
            {
                tgBot = Create(token, typename, username, nativename, skip_updates, auto_start);
            }
            else
            {
                tgBot.Username = username;
                tgBot.NativeName = nativename;
                tgBot.SkipUpdates = skip_updates;
                tgBot.AutoStart = auto_start;

                if (tgBot.LastStartDate.GetValueOrDefault() < lastStartupDate.GetValueOrDefault())
                {
                    tgBot.LastStartDate = lastStartupDate;
                }

                Storage.GetRepository<ITgBotRepository>().Update(tgBot);
                Storage.Save();
            }
            return tgBot;
        }
    }
}
