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
    public class HasMiddlename : Protection
    {
        public override int Priority => 60;

        public override string Command => "";

        public override string Description => "Служебный слой проверки отчества";

        protected override async Task<IHandlerMethodResult> ExecuteProtectionAsync(global::Telegram.Bot.Types.Message message, IServiceProvider serviceProvider, Account.Data.Entities.Security.User user, ILeadManager leadManager, IInviteManager inviteManager, ILeadPhoneManager leadPhoneManager, IContractorManager contractorManager)
        {
            var originalLead = user.GetOriginalLead(serviceProvider);
            var leadPhones = leadPhoneManager.GetAll(e => e.LeadId == originalLead.Id);

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
                        $"☑️ <b>Номер телефона:</b> {leadPhones.LastOrDefault().PhoneNumber}\r\n" +
                        $"☑️ <b>Имя:</b> {originalLead.Firstname}\r\n" +
                        $"☑️ <b>Фамилия:</b> {originalLead.Lastname}\r\n\r\n" +
                        $"Теперь отправьте мне своё отчество, пожалуйста.",
                        ParseMode = ParseMode.Html,
                        ReplyMarkup = new ReplyKeyboardRemove()
                    });
                }
                else
                {
                    //запрашиваем подтверждение активации
                    await Bot.SendAsync(new TlMessage()
                    {
                        MessageType = MessageType.Text,
                        ChatId = message.From.Id,
                        Text = $"👌🏻 <b>Всё верно?</b>\r\n\r\n" +
                        $"Я сохранил ваши данные:\r\n" +
                        $"☑️ <b>Номер телефона:</b> {leadPhones.LastOrDefault().PhoneNumber}\r\n" +
                        $"☑️ <b>Имя:</b> {originalLead.Firstname}\r\n" +
                        $"☑️ <b>Фамилия:</b> {originalLead.Lastname}\r\n" +
                        $"☑️ <b>Отчество:</b> {originalLead.Middlename}\r\n\r\n" +
                        $"Всё верно? Или начнём сначала?",
                        ParseMode = ParseMode.Html,
                        ReplyMarkup = new InlineKeyboardMarkup(new[]
                        {
                            new[]
                            {
                                InlineKeyboardButton.WithCallbackData("✅ Всё верно", "crm.registry.accept"),
                                InlineKeyboardButton.WithCallbackData("❌ Начать сначала", "crm.registry.decline"),
                            }
                        })
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
