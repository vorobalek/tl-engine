using System;
using System.Linq;
using Telegram.Bot.Args;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;
using TL.Engine.SDK.Extensions;
using TL.Engine.SDK.Integrations.Telegram.Messages;
using TL.Integrations.Telegram.Extensions;

namespace TL.Integrations.Telegram.Bots
{
    public class DefaultBot : BaseBot
    {
        public DefaultBot(IServiceProvider serviceProvider, string token, string name = null, bool skipUpdates = false) : base(serviceProvider, token, name, skipUpdates)
        {
        }

        public DefaultBot(IServiceProvider serviceProvider, string token, bool skipUpdates) : base(serviceProvider, token, skipUpdates)
        {
        }

        protected override void TgClient_OnUpdate(object sender, UpdateEventArgs e)
        {
            base.TgClient_OnUpdate(sender, e);
            if (SkipUpdates) return;

            var user = e.Update.GetOrCreateUser(this, ServiceProvider);

            var hresult = CommandHandler.ExecuteAsync(e.Update, user).Result;
            if (hresult.IsOk)
            {
                Logger.TLogWarning($"Успешно обработано обновление {e.Update.GetGenericTypeString()} от {e.Update.GetSenderChatId()}");
            }
            else
            {
                if (hresult.IsFill)
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

                    SendAsync(new Message()
                    {
                        MessageType = MessageType.Text,
                        ChatId = e.Update.GetSenderChatId(),
                        Text = $"‼️ <b>Разработчики ещё не запилили это!</b>\r\n\r\n" +
                        $"Нет, мы не ленивые, мы работаем. Если вы видите это сообщение, значит скоро тут появится новый функционал. (Разработчик №0)\r\n\r\n" +
                        $"Тип взаимодействия <b>{e.Update.GetGenericTypeString()}</b> не поддерживается или для него не найден подходящий хэндлер.\r\n\r\n" +
                        $"🖖🏻 <b>Я вас не понимаю, но вот список команд, которые я в состоянии понять</b>\r\n\r\n{commands}",
                        ParseMode = ParseMode.Html
                    }).Wait();
                    Logger.TLogWarning($"Обновление {e.Update.GetGenericTypeString()} от {e.Update.GetSenderChatId()} не поддерживается или для него не найден подходящий хэндлер.");
                }
            }
        }

        public IMessage GetHelloMessage()
        {
            return new Message()
            {
                MessageType = MessageType.Text,
                Text = DateTime.Now.ToString(),
                ReplyMarkup = new InlineKeyboardMarkup(new[]
                {
                    new[]
                    {
                        InlineKeyboardButton.WithCallbackData("✅ Тык!", "some.query.request")
                    }
                })
            };
        }
    }
}
