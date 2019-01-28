using Microsoft.Extensions.Logging;
using System;
using System.Threading;
using System.Threading.Tasks;
using Telegram.Bot.Args;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;
using TL.Engine.SDK.Extensions;
using TL.Engine.SDK.Integrations.Telegram.Handlers;
using TL.Engine.SDK.Integrations.Telegram.Messages;
using TL.Integrations.Telegram.Handlers;

namespace TL.Integrations.Telegram.Bots
{
    public abstract class BaseBot : Engine.SDK.Integrations.Telegram.Bots.BaseBot
    {
        public virtual IHandlerBase CommandHandler { get; protected set; }

        public virtual IHandlerBase MessageHandler { get; protected set; }

        protected virtual ILogger Logger { get; }

        public BaseBot(ILoggerFactory loggerFactory, string token, string name = null) : base(token, name)
        {
            Logger = loggerFactory.CreateLogger(GetType());

            CommandHandler = new HCommand(this).ImportBaseMethods<BaseBot>();
            MessageHandler = new HMessage(this).ImportBaseMethods<BaseBot>();

            Logger.TLogInformation($"Бот {name} сконфигурирован.");
        }

        public override async Task StartAsync()
        {
            try
            {
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
            catch
            {
                Logger.LogCritical($"Остановка не удалась - @{Username} Попытка повтора через {TimeSpan.FromMilliseconds(RetryPeriod).TotalSeconds} сек...");
                await Task.Delay(RetryPeriod);

                await StopAsync();
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
            if ((await CommandHandler.ExecuteAsync(e.Update)).Ok)
            {
                ;
            }
            else if ((await MessageHandler.ExecuteAsync(e.Update)).Ok)
            {
                ;
            }
            else
            {
                await SendAsync(new Message()
                {
                    MessageType = MessageType.Text,
                    ChatId = e.Update.GetSenderChatId(),
                    Text = $"‼️ <b>Разработчики ещё не запилили это!</b>\r\n\r\n" +
                    $"Тип взаимодействия <b>{e.Update.Type}:{e.Update.GetGenericTypeString()}</b> не поддерживается или для него не найден подходящий хэндлер.",
                    ParseMode = ParseMode.Html
                });
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
                                TgClient.EditMessageTextAsync(
                                    message.ChatId,
                                    message.EditMessageId,
                                    message.Text,
                                    message.ParseMode,
                                    message.DisableWebPagePreview,
                                    message.ReplyMarkup as InlineKeyboardMarkup,
                                    message.CancellationToken).Wait();
                            }
                            catch { }
                        }
                        else
                        {
                            try
                            {
                                TgClient.SendTextMessageAsync(
                                    message.ChatId,
                                    message.Text,
                                    message.ParseMode,
                                    message.DisableWebPagePreview,
                                    message.DisableNotification,
                                    message.ReplyToMessageId,
                                    message.ReplyMarkup,
                                    message.CancellationToken).Wait();
                            }
                            catch { }
                        }

                        if (message.IsCallbackAnswer)
                        {
                            try
                            {
                                TgClient.AnswerCallbackQueryAsync(
                                    message.CallbackQueryId,
                                    message.CallbackAnswerText,
                                    message.CallbackShowAlert,
                                    message.CallbackUrl,
                                    message.CallbackCacheTime,
                                    message.CancellationToken).Wait();
                            }
                            catch { }
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
