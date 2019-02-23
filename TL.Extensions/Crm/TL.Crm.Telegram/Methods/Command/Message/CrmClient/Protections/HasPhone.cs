using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;
using TL.Crm.Data.Entities.Periphery;
using TL.Crm.Data.Extensions;
using TL.Crm.Data.Managers;
using TL.Engine.SDK.Integrations.Telegram.Handlers;
using TlMessage = TL.Engine.SDK.Integrations.Telegram.Messages.Message;

namespace TL.Crm.Telegram.Methods.Command.Message.CrmClient.Protections
{
    public class HasPhone : Protection
    {
        public override int Priority => 30;

        public override string Description => "Служебный слой проверки номера телефона";

        protected override async Task<IHandlerMethodResult> ExecuteProtectionAsync(global::Telegram.Bot.Types.Message message, IServiceProvider serviceProvider, Account.Data.Entities.Security.User user, ILeadManager leadManager, IInviteManager inviteManager, ILeadPhoneManager leadPhoneManager, IContractorManager contractorManager)
        {
            var originalLead = user.GetOriginalLead(serviceProvider);

            var invite = inviteManager.Get(e => e.ReferralId.HasValue && e.ReferralId == originalLead.Id);
            var referrerContractor = contractorManager.GetOriginalContractor(invite.Referrer.Id);
            var referrerLead = referrerContractor.GetOriginLead(serviceProvider);
            var leadPhone = leadPhoneManager.Get(e => e.LeadId == originalLead.Id);

            if (leadPhone == null)
            {
                if (message.Type == MessageType.Contact)
                {
                    leadPhone = leadPhoneManager.Create(new LeadPhone()
                    {
                        Lead = originalLead,
                        PhoneNumber = message.Contact.PhoneNumber,
                    });
                }

                if (message.Type == MessageType.Text)
                {
                    var regex = new Regex("^(\\+7|7|8)?[\\s\\-]?\\(?[489][0-9]{2}\\)?[\\s\\-]?[0-9]{3}[\\s\\-]?[0-9]{2}[\\s\\-]?[0-9]{2}$", RegexOptions.Compiled);
                    if (regex.IsMatch(message.Text))
                    {
                        leadPhone = leadPhoneManager.Create(new LeadPhone()
                        {
                            Lead = originalLead,
                            PhoneNumber = message.Text,
                        });
                    }
                }

                if (leadPhone == null)
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
                else
                {
                    // Запрашиваем имя
                    await Bot.SendAsync(new TlMessage()
                    {
                        MessageType = MessageType.Text,
                        ChatId = message.From.Id,
                        Text = $"👌🏻 <b>Продолжим?</b>\r\n\r\n" +
                        $"Я сохранил ваши данные:\r\n" +
                        $"☑️ <b>Номер телефона:</b> {leadPhone.PhoneNumber}\r\n\r\n" +
                        $"Теперь отправьте мне своё имя, пожалуйста.",
                        ParseMode = ParseMode.Html,
                        ReplyMarkup = new ReplyKeyboardRemove()
                    });
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
