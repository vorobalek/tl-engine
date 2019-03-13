using System;
using System.Linq;
using System.Threading.Tasks;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;
using TL.Crm.Data.Extensions;
using TL.Crm.Data.Managers;
using TL.Engine.SDK.Integrations.Telegram.Handlers;
using TlMessage = TL.Engine.SDK.Integrations.Telegram.Messages.Message;

namespace TL.Crm.Telegram.Methods.Command.Message.CrmClient.Protections
{
    public class HasLastname : Protection
    {
        public override int Priority => 50;

        public override string Description => "Служебный слой проверки фамилии";

        protected override async Task<IHandlerMethodResult> ExecuteProtectionAsync(global::Telegram.Bot.Types.Message message, IServiceProvider serviceProvider, Account.Data.Entities.Security.User user, ILeadManager leadManager, IInviteManager inviteManager, ILeadPhoneManager leadPhoneManager, IContractorManager contractorManager)
        {
            var originalLead = user.GetOriginalLead(serviceProvider);
            var leadPhone = leadPhoneManager.Get(e => e.LeadId == originalLead.Id);

            if (string.IsNullOrWhiteSpace(originalLead.Lastname))
            {
                if (message.Type == MessageType.Text && !string.IsNullOrWhiteSpace(message.Text))
                {
                    originalLead.Lastname = message.Text;
                    leadManager.Update(originalLead);
                }
                if (string.IsNullOrWhiteSpace(originalLead.Lastname))
                {
                    //запрашиваем фамилию
                    await Bot.SendAsync(new TlMessage()
                    {
                        MessageType = MessageType.Text,
                        ChatId = message.From.Id,
                        Text = $"👌🏻 <b>Продолжим?</b>\r\n\r\n" +
                        $"Я сохранил ваши данные:\r\n" +
                        $"☑️ <b>Номер телефона:</b> {leadPhone.PhoneNumber}\r\n" +
                        $"☑️ <b>Имя:</b> {originalLead.Firstname}\r\n\r\n" +
                        $"Теперь отправьте мне свою фамилию, пожалуйста.",
                        ParseMode = ParseMode.Html,
                        ReplyMarkup = new ReplyKeyboardRemove()
                    });
                }
                else
                {
                    //запрашиваем отчество
                    await Bot.SendAsync(new TlMessage()
                    {
                        MessageType = MessageType.Text,
                        ChatId = message.From.Id,
                        Text = $"👌🏻 <b>Продолжим?</b>\r\n\r\n" +
                        $"Я сохранил ваши данные:\r\n" +
                        $"☑️ <b>Номер телефона:</b> {leadPhone.PhoneNumber}\r\n" +
                        $"☑️ <b>Имя:</b> {originalLead.Firstname}\r\n" +
                        $"☑️ <b>Фамилия:</b> {originalLead.Lastname}\r\n\r\n" +
                        $"Теперь отправьте мне своё отчество, пожалуйста.",
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
