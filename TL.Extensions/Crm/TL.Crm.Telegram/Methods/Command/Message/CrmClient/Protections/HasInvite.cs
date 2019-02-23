using System;
using System.Linq;
using System.Threading.Tasks;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;
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
            var invite = inviteManager.Get(e => e.ReferralId.HasValue && e.ReferralId == originalLead.Id);

            if (invite == null)
            {
                if (message.Type == MessageType.Text && Guid.TryParse(message.Text, out Guid inviteGuid))
                {
                    var customInvite = inviteManager.Get(inviteGuid);
                    if (customInvite != null)
                    {
                        if (customInvite.ReferralId.HasValue && customInvite.ReferralId.Value != originalLead.Id || customInvite.IsActivated)
                        {
                            ;
                        }
                        else
                        {
                            customInvite.Referral = originalLead;
                            invite = inviteManager.Update(customInvite);
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
                    if (!invite.IsActivated)
                    {
                        var referrerContractor = contractorManager.GetOriginalContractor(invite.Referrer.Id);
                        var referrerLead = referrerContractor.GetOriginLead(serviceProvider);

                        if (originalLead.Phones.Count() == 0)
                        {
                            //Запрашиваем номер телефона
                            await Bot.SendAsync(new TlMessage()
                            {
                                MessageType = MessageType.Text,
                                ChatId = message.From.Id,
                                Text = $"🖐🏻 <b>Приступим?</b>\r\n\r\n" +
                                $"<b>{referrerLead?.Firstname} {referrerLead?.Lastname}</b> передаёт вам привет;)\r\n\r\n" +
                                $"Для начала отправьте мне свой сотовый номер телефона или просто нажмите кнопку ниже.",
                                ParseMode = ParseMode.Html,
                                ReplyMarkup = new ReplyKeyboardMarkup(new[]
                                {
                                    new[]
                                    {
                                        KeyboardButton.WithRequestContact("Отправить номер телефона")
                                    }
                                }, resizeKeyboard: true, oneTimeKeyboard: true)
                            });
                        }
                    }
                    else
                    {
                        throw new NotImplementedException();
                    }
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
