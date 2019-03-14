using System;
using System.Threading.Tasks;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;
using TL.Crm.Data.Entities.Core;
using TL.Crm.Data.Extensions;
using TL.Crm.Data.Managers;
using TL.Engine.SDK.Integrations.Telegram.Handlers;
using TlMessage = TL.Engine.SDK.Integrations.Telegram.Messages.Message;
using TlUser = TL.Account.Data.Entities.Security.User;

namespace TL.Crm.Telegram.Methods.Command.Message.CrmClient.Protections
{
    public class HasInvite : Protection
    {
        public override int Priority => 20;

        public override string Description => "Служебный слой проверки инвайта";

        protected override async Task<IHandlerMethodResult> ExecuteProtectionAsync(global::Telegram.Bot.Types.Message message, IServiceProvider serviceProvider, TlUser user, ILeadManager leadManager, IInviteManager inviteManager, ILeadPhoneManager leadPhoneManager, IContractorManager contractorManager)
        {
            var originalLead = user.GetOriginalLead(serviceProvider);
            Invite invite = null;

            if (!originalLead.InviteId.HasValue)
            {
                if (message.Type == MessageType.Text && Guid.TryParse(message.Text, out Guid inviteGuid))
                {
                    var customInvite = inviteManager.Get(inviteGuid);
                    if (customInvite != null)
                    {
                        if (customInvite.IsActivated)
                        {
                            ;
                        }
                        else
                        {
                            originalLead.Invite = customInvite;
                            invite = inviteManager.Get(leadManager.Update(originalLead).InviteId.Value);
                        }
                    }
                }

                if (invite == null)
                {
                    await Bot.SendAsync(new TlMessage()
                    {
                        MessageType = MessageType.Text,
                        ChatId = message.From.Id,
                        Text = $"‼️ <b>Требуется инвайт!</b>\r\n\r\n" +
                        $"Отправьте мне код вашего инвайта текстом, либо специальным QR кодом.",
                        ParseMode = ParseMode.Html
                    });
                    return new HandlerMethodResult(true);
                }
                else
                {
                    await Bot.SendAsync(new TlMessage()
                    {
                        MessageType = MessageType.Text,
                        ChatId = message.From.Id,
                        Text = $"🖐🏻 <b>Добро пожаловать!</b>\r\n\r\n" +
                        $"Осталось совсем немного. Заполним небольшую анкету?",
                        ParseMode = ParseMode.Html,

                        ReplyMarkup = new InlineKeyboardMarkup(new[]
                        {
                            new[]
                            {
                                InlineKeyboardButton.WithCallbackData("👌🏻 Продолжить!", "registry.next"),
                            }
                        }),
                    });
                    return new HandlerMethodResult(true);
                }
            }
            else
            {
                ContinueExecute();
            }

            return new HandlerMethodResult(true);
        }
    }
}
