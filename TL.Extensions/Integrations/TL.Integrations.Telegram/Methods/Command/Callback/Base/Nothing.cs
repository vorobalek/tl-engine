using System.Threading.Tasks;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using TL.Engine.SDK.Integrations.Telegram.Handlers;
using TlMessage = TL.Engine.SDK.Integrations.Telegram.Messages.Message;

namespace TL.Integrations.Telegram.Methods.Command.Callback.Base
{
    public class Nothing : BaseBotCallbackHCommandMethod
    {
        public override string Command => "nothing";

        public override string Description => "";

        public override int Priority => int.MinValue;

        public override bool IsBlocker => false;

        public override bool IsPrivate => true;

        protected override async Task<IHandlerMethodResult> ExecuteAsync(CallbackQuery callbackQuery, params object[] args)
        {
            await Bot.SendAsync(new TlMessage()
            {
                MessageType = MessageType.Text,
                IsCallbackAnswer = true,

                ChatId = callbackQuery.From.Id,
                CallbackQueryId = callbackQuery.Id,
            });

            ContinueExecute();

            return new HandlerMethodResult(true);
        }
    }
}
