using System.Threading.Tasks;
using Telegram.Bot.Types;
using Telegram.Bot.Types.ReplyMarkups;
using TL.Engine.SDK.Integrations.Telegram.Handlers;

namespace TL.Integrations.Telegram.Methods.Command.Callback.Base
{
    public class NotImplementated : BotCallbackHCommandMethod
    {
        public override bool IsPrivate => true;

        public override string Command => "notimplemented";

        public override string Description => "";

        public override int Priority => int.MinValue;

        protected override async Task<IHandlerMethodResult> ExecuteAsync(CallbackQuery callbackQuery)
        {
            await Bot.SendAsync(new Engine.SDK.Integrations.Telegram.Messages.Message()
            {
                MessageType = global::Telegram.Bot.Types.Enums.MessageType.Text,
                IsEditMessage = true,

                ChatId = callbackQuery.Message.Chat.Id,
                EditMessageId = callbackQuery.Message.MessageId,

                CallbackQueryId = callbackQuery.Id,

                Text = $"‼️ <b>Разработчики ещё не запилили это!</b>",
                ReplyMarkup = new InlineKeyboardMarkup(new[]
                {
                    new[]
                    {
                        InlineKeyboardButton.WithCallbackData("⬅️ В начало", "main"),
                    },
                }),
                ParseMode = global::Telegram.Bot.Types.Enums.ParseMode.Html
            });

            return new HandlerMethodResult(true, "asdasd");
        }
    }
}
