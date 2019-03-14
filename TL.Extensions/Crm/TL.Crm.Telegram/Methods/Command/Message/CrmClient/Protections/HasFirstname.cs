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
    public class HasFirstname : Protection
    {
        public override int Priority => 40;

        public override string Description => "Служебный слой проверки имени";

        protected override async Task<IHandlerMethodResult> ExecuteProtectionAsync(global::Telegram.Bot.Types.Message message, IServiceProvider serviceProvider, Account.Data.Entities.Security.User user, ILeadManager leadManager, IInviteManager inviteManager, ILeadPhoneManager leadPhoneManager, IContractorManager contractorManager)
        {
            var originalLead = user.GetOriginalLead(serviceProvider);
            var leadPhone = leadPhoneManager.Get(e => e.LeadId == originalLead.Id);

            if (string.IsNullOrWhiteSpace(originalLead.Firstname))
            {
                if (message.Type == MessageType.Text && !string.IsNullOrWhiteSpace(message.Text))
                {
                    originalLead.Firstname = message.Text;
                    leadManager.Update(originalLead);
                }
                if (string.IsNullOrWhiteSpace(originalLead.Firstname))
                {
                    // Запрашиваем имя
                    await Bot.SendAsync(new TlMessage()
                    {
                        MessageType = MessageType.Text,
                        ChatId = message.From.Id,
                        Text = $"👌🏻 <b>Продолжим?</b>\r\n\r\n" +
                        $"Я сохранил ваши данные:\r\n" +
                        $"☑️ <b>Номер телефона:</b> {leadPhone.PhoneNumber}\r\n\r\n" +
                        $"Теперь отправьте мне своё <b>имя</b>, пожалуйста.",
                        ParseMode = ParseMode.Html,
                        ReplyMarkup = new ReplyKeyboardRemove()
                    });
                }
                else
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
                        $"Теперь отправьте мне свою <b>фамилию</b>, пожалуйста.",
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
