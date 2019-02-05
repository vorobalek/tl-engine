using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Telegram.Bot.Args;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;
using TL.Account.Data.Entities.Security;
using TL.Account.Data.Managers.User;
using TL.Engine.SDK.Extensions;
using TL.Engine.SDK.Integrations.Telegram.Handlers;
using TL.Engine.SDK.Integrations.Telegram.Messages;
using TL.Integrations.Data.Extensions;
using TL.Integrations.Telegram.Handlers;

namespace TL.Integrations.Telegram.Bots
{
    public abstract class BaseBot : Engine.SDK.Integrations.Telegram.Bots.BaseBot
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

        public override async Task StartAsync()
        {
            try
            {
                SkippedUpdatesCount = (await TgClient.GetUpdatesAsync()).Length;
                await base.StartAsync();

                Username = (await TgClient.GetMeAsync(new CancellationTokenSource(CancelTimeout).Token)).Username;
                Logger.TLogWarning($"@{Username} запущен.");
            }
            catch
            {
                Logger.TLogWarning($"Запуск не удался - @{Username} Попытка повтора через {TimeSpan.FromMilliseconds(RetryPeriod).TotalSeconds} сек...");

                await Task.Delay(RetryPeriod);
                await StopAsync();
                await StartAsync();
            }
        }

        public override async Task StopAsync()
        {
            try
            {
                await base.StopAsync();
                Logger.TLogWarning($"@{Username} остановлен.");
            }
            catch (Exception ex)
            {
                Logger.LogCritical($"Остановка не удалась - @{Username}\r\n{ex}");
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

        protected override async void TgClient_OnUpdate(object sender, UpdateEventArgs e)
        {
            base.TgClient_OnUpdate(sender, e);

            if (SkipUpdates)
            {
                Logger.TLogWarning($"Обновление {UpdatesSummaryCount} из {SkippedUpdatesCount} проигнорировано.");
                return;
            }

            var user = e.Update.GetOrCreateUserAsync(ServiceProvider);

            var hresult = await CommandHandler.ExecuteAsync(e.Update, user);
            if (hresult.IsOk)
            {
                Logger.TLogWarning($"Успешно обработано обновление {e.Update.GetGenericTypeString()} от {e.Update.GetSenderChatId()}");
            }
            else
            {
                if (hresult.IsFill)
                {
                    var exceptions = string.Join("\r\n", hresult.Results.Select(r => r.Exception));
                    await SendAsync(new Message()
                    {
                        MessageType = MessageType.Text,
                        ChatId = e.Update.GetSenderChatId(),
                        Text = $"‼️ <b>Произошла одна или несколько ошибок!</b>\r\n\r\n" +
                        $"<pre>{exceptions}</pre>",
                        ParseMode = ParseMode.Html
                    });
                    Logger.TLogError($"Произошла одна или несколько ошибок при обновлении {e.Update.GetGenericTypeString()} от {e.Update.GetSenderChatId()}\r\n" +
                        $"{exceptions}");
                }
                else
                {
                    var commands_arr = CommandHandler.Methods
                        .Where(it => (!it.IsPrivate) && (it.UpdateType == UpdateType.Message))
                        .OrderBy(it => it.Command)
                        .Select(it => $"{it.Command} {it.Description}");

                    var commands = string.Join("\r\n", commands_arr);

                    await SendAsync(new Message()
                    {
                        MessageType = MessageType.Text,
                        ChatId = e.Update.GetSenderChatId(),
                        Text = $"‼️ <b>Разработчики ещё не запилили это!</b>\r\n\r\n" +
                        $"Нет, мы не ленивые, мы работаем. Если вы видите это сообщение, значит скоро тут появится новый функционал. (Разработчик №0)\r\n\r\n" +
                        $"Тип взаимодействия <b>{e.Update.GetGenericTypeString()}</b> не поддерживается или для него не найден подходящий хэндлер.\r\n\r\n" +
                        $"🖖🏻 <b>Я вас не понимаю, но вот список команд, которые я в состоянии понять</b>\r\n\r\n{commands}",
                        ParseMode = ParseMode.Html
                    });
                    Logger.TLogWarning($"Обновление {e.Update.GetGenericTypeString()} от {e.Update.GetSenderChatId()} не поддерживается или для него не найден подходящий хэндлер.");
                }
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
