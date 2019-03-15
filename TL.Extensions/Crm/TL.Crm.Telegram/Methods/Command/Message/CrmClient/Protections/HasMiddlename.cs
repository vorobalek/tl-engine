using System;
using System.Linq;
using System.Threading.Tasks;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;
using TL.Crm.Data.Entities.Core;
using TL.Crm.Data.Extensions;
using TL.Crm.Data.Managers;
using TL.Engine.SDK.Extensions;
using TL.Engine.SDK.Integrations.Telegram.Handlers;
using TlMessage = TL.Engine.SDK.Integrations.Telegram.Messages.Message;

namespace TL.Crm.Telegram.Methods.Command.Message.CrmClient.Protections
{
    public class HasMiddlename : Protection
    {
        public override int Priority => 60;

        public override string Description => "Служебный слой проверки отчества";

        protected override async Task<IHandlerMethodResult> ExecuteProtectionAsync(global::Telegram.Bot.Types.Message message, IServiceProvider serviceProvider, Account.Data.Entities.Security.User user, ILeadManager leadManager, IInviteManager inviteManager, ILeadPhoneManager leadPhoneManager, IContractorManager contractorManager)
        {
            var originalLead = user.GetOriginalLead(serviceProvider);
            var leadPhone = leadPhoneManager.Get(e => e.LeadId == originalLead.Id);

            if (string.IsNullOrWhiteSpace(originalLead.Middlename))
            {
                if (message.Type == MessageType.Text && !string.IsNullOrWhiteSpace(message.Text))
                {
                    originalLead.Middlename = message.Text;
                    leadManager.Update(originalLead);
                }
                if (string.IsNullOrWhiteSpace(originalLead.Middlename))
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
                        $"Теперь отправьте мне своё <b>отчество</b>, пожалуйста.",
                        ParseMode = ParseMode.Html,
                        ReplyMarkup = new ReplyKeyboardRemove()
                    });
                }
                else
                {
                    //запрашиваем пол
                    await Bot.SendAsync(new TlMessage()
                    {
                        MessageType = MessageType.Text,
                        ChatId = message.From.Id,
                        Text = $"👌🏻 <b>Продолжим?</b>\r\n\r\n" +
                           $"Я сохранил ваши данные:\r\n" +
                           $"☑️ <b>Номер телефона:</b> {leadPhone.PhoneNumber}\r\n" +
                           $"☑️ <b>Имя:</b> {originalLead.Firstname}\r\n" +
                           $"☑️ <b>Фамилия:</b> {originalLead.Lastname}\r\n" +
                           $"☑️ <b>Отчество:</b> {originalLead.Middlename}\r\n\r\n" +
                           $"Теперь выберите, пожалуйста свой <b>пол</b>.",
                        ParseMode = ParseMode.Html,
                        ReplyMarkup = new ReplyKeyboardMarkup(new[]
                        {
                            new[]
                            {
                                new KeyboardButton(SexType.Male.DisplayName()),
                                new KeyboardButton(SexType.Female.DisplayName()),
                            }
                        }, resizeKeyboard: true, oneTimeKeyboard: true)
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
