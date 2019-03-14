using System.Linq;
using System.Threading.Tasks;
using Telegram.Bot.Types;
using Telegram.Bot.Types.ReplyMarkups;
using TL.Engine.SDK.Integrations.Telegram.Handlers;

namespace TL.Integrations.Telegram.Methods.Command.Callback.Base
{
    public class NotImplementated : BaseBotCallbackHCommandMethod
    {
        public override bool IsPrivate => true;

        public override string Command => "";

        public override string Description => "";

        public override int Priority => int.MaxValue;

        protected override async Task<IHandlerMethodResult> ExecuteAsync(CallbackQuery callbackQuery, params object[] args)
        {
            var commands_arr = Bot.CommandHandler.Methods
              .Where(it => (!it.IsPrivate)
                  && it.IsPolicyAcceptable(new Update() { CallbackQuery = callbackQuery })
                  && (it.UpdateType == global::Telegram.Bot.Types.Enums.UpdateType.Message))
              .OrderBy(it => it.Command)
              .Select(it => $"{it.Command} {it.Description}");

            var commands = string.Join("\r\n", commands_arr);

            await Bot.SendAsync(new Engine.SDK.Integrations.Telegram.Messages.Message()
            {
                MessageType = global::Telegram.Bot.Types.Enums.MessageType.Text,
                IsEditMessage = true,

                ChatId = callbackQuery.Message.Chat.Id,
                EditMessageId = callbackQuery.Message.MessageId,

                CallbackQueryId = callbackQuery.Id,

                Text = $"‼️ <b>Разработчики ещё не запилили это!</b>\r\n\r\n" +
                $"Нет, мы не ленивые, мы работаем. Если вы видите это сообщение, значит скоро тут появится новый функционал. (Разработчик №0)\r\n\r\n" +
                $"🖖🏻 <b>Я вас не понимаю, но вот список команд, которые я в состоянии понять</b>\r\n\r\n{commands}",
                ReplyMarkup = new InlineKeyboardMarkup(new[]
                {
                    new[]
                    {
                        InlineKeyboardButton.WithCallbackData("⬅️ В начало", "main"),
                    },
                }),
                ParseMode = global::Telegram.Bot.Types.Enums.ParseMode.Html
            });

            return new HandlerMethodResult(true);
        }
    }
}
