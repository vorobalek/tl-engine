using System.Linq;
using System.Threading.Tasks;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using TL.Integrations.SDK.Telegram.Extensions;
using TL.Integrations.SDK.Telegram.Handlers;
using TgMessage = TL.Integrations.SDK.Telegram.Messages.Message;

namespace TL.Integrations.Telegram.Methods.Command.Message.Base
{
    public class HelpNotImplementated : Help
    {
        public override bool IsPrivate => true;

        public override string Command => "";

        public override int Priority => int.MaxValue - 1;

        public override bool IsRelevantMethod(Update update, params object[] args)
        {
            return update.Type == UpdateType.Message;
        }
    }

    public class NotImplementated : BaseBotMessageHCommandMethod
    {
        public override bool IsPrivate => true;

        public override string Command => "";

        public override string Description => "";

        public override int Priority => int.MaxValue;

        public override bool IsRelevantMethod(Update update, params object[] args)
        {
            return update.Type != UpdateType.CallbackQuery;
        }

        protected override async Task<IHandlerMethodResult> ExecuteAsync(Update update, params object[] args)
        {
            var commands_arr = Bot.CommandHandler.Methods
                        .Where(it => (!it.IsPrivate) && it.IsPolicyAcceptable(update, args) && (it.UpdateType == UpdateType.Message))
                        .OrderBy(it => it.Command)
                        .Select(it => $"{it.Command} {it.Description}");

            var commands = string.Join("\r\n", commands_arr);

            await Bot.SendAsync(new TgMessage()
            {
                MessageType = MessageType.Text,
                ChatId = update.GetSenderChatId(),
                Text = $"‼️ <b>Разработчики ещё не запилили это!</b>\r\n\r\n" +
                $"Нет, мы не ленивые, мы работаем. Если вы видите это сообщение, значит скоро тут появится новый функционал. (Разработчик №0)\r\n\r\n" +
                $"Тип взаимодействия <b>{update.GetGenericTypeString()}</b> не поддерживается или для него не найден подходящий хэндлер.\r\n\r\n" +
                $"🖖🏻 <b>Я вас не понимаю, но вот список команд, которые я в состоянии понять</b>\r\n\r\n{commands}",
                ParseMode = ParseMode.Html
            });

            return new HandlerMethodResult(true);
        }

        protected override Task<IHandlerMethodResult> ExecuteAsync(global::Telegram.Bot.Types.Message message, params object[] args)
        {
            throw new System.NotImplementedException();
        }
    }
}