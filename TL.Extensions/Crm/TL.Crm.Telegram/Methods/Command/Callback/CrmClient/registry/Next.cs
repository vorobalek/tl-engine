using System.Threading.Tasks;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using TL.Engine.SDK.Integrations.Telegram.Handlers;
using TlMessage = TL.Engine.SDK.Integrations.Telegram.Messages.Message;

namespace TL.Crm.Telegram.Methods.Command.Callback.CrmClient.registry
{
    public class Next : CrmClientBotCallbackHCommandMethod
    {
        public override string Command => "registry.next";

        public override string Description => "Зарегистрировать введенные данные";

        public override int Priority => 0;

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