using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Telegram.Bot.Args;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;
using TL.Engine.Data.Managers;
using TL.Engine.SDK.Extensions;
using TL.Integrations.SDK.Telegram.Extensions;
using TL.Integrations.SDK.Telegram.Handlers;
using TL.Integrations.SDK.Telegram.Messages;
using TL.Integrations.Telegram.Extensions;
using TL.Integrations.Telegram.Handlers;

namespace TL.Integrations.Telegram.Bots
{
    public abstract class BaseBot : SDK.Telegram.Bots.BaseBot
    {
        public virtual IHandlerBase CommandHandler { get; protected set; }

        protected virtual ILogger Logger { get; }

        protected virtual IServiceProvider ServiceProvider { get; }

        protected virtual IUserManager UserManager { get; }

        public BaseBot(IServiceProvider serviceProvider, string token, bool skipUpdates) : this(serviceProvider, token, null, skipUpdates)
        {
        }

        public BaseBot(IServiceProvider serviceProvider, string token, string name = null, bool skipUpdates = false) : base(token, name, skipUpdates)
        {
            ServiceProvider = serviceProvider;

            Logger = ServiceProvider.GetService<ILoggerFactory>().CreateLogger(GetType());
            Logger.TLogWarning($"Логгер для бота {name} сконфигурирован.");

            UserManager = ServiceProvider.GetService<IUserManager>();
            Logger.TLogWarning($"UserManager для бота {name} сконфигурирован.");

            CommandHandler = new HCommand(this).ImportBaseMethods<BaseBot>();
            Logger.TLogWarning($"Бот {name} сконфигурирован.");
        }

        public override async Task<bool> StartAsync()
        {
            try
            {
                SkippedUpdatesCount = (await TgClient.GetUpdatesAsync()).Length;
                await base.StartAsync();

                Username = (await TgClient.GetMeAsync(new CancellationTokenSource(CancelTimeout).Token)).Username;
                Logger.TLogWarning($"@{Username} запущен.");
                return true;
            }
            catch
            {
                Logger.TLogWarning($"Запуск не удался - @{Username}");
                await StopAsync();
                return false;
            }
        }

        public override async Task<bool> StopAsync()
        {
            try
            {
                await base.StopAsync();
                Logger.TLogWarning($"@{Username} остановлен.");
                return true;
            }
            catch (Exception ex)
            {
                Logger.LogCritical($"Остановка не удалась - @{Username}\r\n{ex}");
                return false;
            }
        }

        public override void Send(IMessage message)
        {
            MessagesQueue.Enqueue(message);
        }

        public override async Task SendAsync(IMessage message)
        {
            await Task.Run(() => MessagesQueue.Enqueue(message));
        }

        protected override void TgClient_OnUpdate(object sender, UpdateEventArgs e)
        {
            base.TgClient_OnUpdate(sender, e);

            if (SkipUpdates)
            {
                Logger.TLogWarning($"Обновление {UpdatesSummaryCount} из {SkippedUpdatesCount} проигнорировано.");
                return;
            }

            var user = e.Update.GetOrCreateUser(this, ServiceProvider);

            var hresult = CommandHandler.ExecuteAsync(e.Update, ServiceProvider, user).Result;
            if (hresult.IsOk)
            {
                Logger.TLogWarning($"Успешно обработано обновление {e.Update.GetGenericTypeString()} от {e.Update.GetSenderChatId()}");
            }
            else
            {
                var exceptions = string.Join("\r\n", hresult.Results.Select(r => r.Exception));
                SendAsync(new Message()
                {
                    MessageType = MessageType.Text,
                    ChatId = e.Update.GetSenderChatId(),
                    Text = $"‼️ <b>Произошла одна или несколько ошибок!</b>\r\n\r\n" +
                    $"<pre>{exceptions}</pre>",
                    ParseMode = ParseMode.Html
                }).Wait();
                Logger.TLogError($"Произошла одна или несколько ошибок при обновлении {e.Update.GetGenericTypeString()} от {e.Update.GetSenderChatId()}\r\n{exceptions}");
            }
        }

        protected override void TgClient_OnReceiveError(object sender, ReceiveErrorEventArgs e)
        {
            Logger.TLogCritical($"Ошибка приёма на боте {NativeName}:@{Username}. {e.ApiRequestException}");
            Thread.Sleep(1000);
        }

        protected override void Process()
        {
            var f = MessagesQueue.TryDequeue(out IMessage message);
            if (f)
            {
                var start = DateTime.Now;

                switch (message.MessageType)
                {
                    case MessageType.Text:
                        if (message.IsEditMessage)
                        {
                            try
                            {
                                Logger.TLogWarning($"Попытка отредактировать сообщение для {message.ChatId}");
                                TgClient.EditMessageTextAsync(
                                    message.ChatId,
                                    message.EditMessageId,
                                    message.Text,
                                    message.ParseMode,
                                    message.DisableWebPagePreview,
                                    message.ReplyMarkup as InlineKeyboardMarkup,
                                    message.CancellationToken).Wait();
                                Logger.TLogWarning($"Успешно отредактировано сообщение для {message.ChatId}");
                            }
                            catch (Exception ex)
                            {
                                Logger.TLogError($"Ошибка редактирования сообщения для {message.ChatId}\r\n{ex}");
                            }
                        }
                        else
                        {
                            if (!message.IsCallbackAnswer)
                            {
                                try
                                {
                                    Logger.TLogWarning($"Попытка отправить сообщение для {message.ChatId}");
                                    TgClient.SendTextMessageAsync(
                                        message.ChatId,
                                        message.Text,
                                        message.ParseMode,
                                        message.DisableWebPagePreview,
                                        message.DisableNotification,
                                        message.ReplyToMessageId,
                                        message.ReplyMarkup,
                                        message.CancellationToken).Wait();
                                    Logger.TLogWarning($"Успешно отправлено сообщение для {message.ChatId}");
                                }
                                catch (Exception ex)
                                {
                                    Logger.TLogError($"Ошибка отправки сообщения для {message.ChatId}\r\n{ex}");
                                }
                            }
                        }

                        if (message.IsEditMessage || message.IsCallbackAnswer)
                        {
                            try
                            {
                                Logger.TLogWarning($"Попытка отправить отклик для {message.ChatId}");
                                TgClient.AnswerCallbackQueryAsync(
                                    message.CallbackQueryId,
                                    message.CallbackAnswerText,
                                    message.CallbackShowAlert,
                                    message.CallbackUrl,
                                    message.CallbackCacheTime,
                                    message.CancellationToken).Wait();
                                Logger.TLogWarning($"Успешно отправлен отклик для {message.ChatId}");
                            }
                            catch (Exception ex)
                            {
                                Logger.TLogError($"Ошибка отправки отклика для {message.ChatId}\r\n{ex}");
                            }
                        }
                        break;
                    case MessageType.Photo:
                        break;
                    case MessageType.Audio:
                        break;
                    case MessageType.Video:
                        break;
                    case MessageType.Voice:
                        break;
                    case MessageType.Document:
                        break;
                    case MessageType.Sticker:
                        break;
                    case MessageType.Location:
                        break;
                    case MessageType.Contact:
                        break;
                    case MessageType.Venue:
                        break;
                    case MessageType.SuccessfulPayment:
                        break;
                    default:
                        break;
                }

                var stop = DateTime.Now;
                Logger.TLogInformation($"@{this.Username} performance {(stop - start).TotalMilliseconds}ms");
            }
        }
    }
}
