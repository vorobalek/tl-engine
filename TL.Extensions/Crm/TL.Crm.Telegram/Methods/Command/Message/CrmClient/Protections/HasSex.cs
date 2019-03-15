using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;
using TL.Account.Data.Entities.Security;
using TL.Crm.Data.Entities.Core;
using TL.Crm.Data.Extensions;
using TL.Crm.Data.Managers;
using TL.Engine.SDK.Extensions;
using TL.Engine.SDK.Integrations.Telegram.Handlers;
using TlMessage = TL.Engine.SDK.Integrations.Telegram.Messages.Message;

namespace TL.Crm.Telegram.Methods.Command.Message.CrmClient.Protections
{
    public class HasSex : Protection
    {
        public override int Priority => 65;

        public override string Description => "Служебный слой проверки пола";

        protected override async Task<IHandlerMethodResult> ExecuteProtectionAsync(global::Telegram.Bot.Types.Message message, IServiceProvider serviceProvider, Account.Data.Entities.Security.User user, ILeadManager leadManager, IInviteManager inviteManager, ILeadPhoneManager leadPhoneManager, IContractorManager contractorManager)
        {
            var originalLead = user.GetOriginalLead(serviceProvider);
            var leadPhone = leadPhoneManager.Get(e => e.LeadId == originalLead.Id);

            if (!originalLead.SexType.HasValue)
            {
                if (message.Text != SexType.Male.DisplayName() && message.Text != SexType.Female.DisplayName())
                {
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
                else
                {
                    await Bot.SendAsync(new TlMessage()
                    {
                        MessageType = MessageType.Text,
                        ChatId = message.From.Id,
                        Text = $"👌🏻 Окей, <b>{message.Text}</b>",
                        ParseMode = ParseMode.Html,
                        ReplyMarkup = new ReplyKeyboardRemove()
                    });

                    if (message.Text == SexType.Male.DisplayName())
                    {
                        originalLead.SexType = SexType.Male;
                        originalLead = leadManager.Update(originalLead);
                    }

                    if (message.Text == SexType.Female.DisplayName())
                    {
                        originalLead.SexType = SexType.Female;
                        originalLead = leadManager.Update(originalLead);
                    }

                    //запрашиваем подтверждение активации
                    await Bot.SendAsync(new TlMessage()
                    {
                        MessageType = MessageType.Text,
                        ChatId = message.From.Id,
                        Text = $"👌🏻 <b>Всё верно?</b>\r\n\r\n" +
                        $"Я сохранил ваши данные:\r\n" +
                        $"☑️ <b>Номер телефона:</b> {leadPhone.PhoneNumber}\r\n" +
                        $"☑️ <b>Имя:</b> {originalLead.Firstname}\r\n" +
                        $"☑️ <b>Фамилия:</b> {originalLead.Lastname}\r\n" +
                        $"☑️ <b>Отчество:</b> {originalLead.Middlename}\r\n" +
                        $"☑️ <b>Пол:</b> {originalLead.SexType.DisplayName()}\r\n\r\n" +
                        $"Всё верно? Или начнём сначала?",
                        ParseMode = ParseMode.Html,
                        ReplyMarkup = new InlineKeyboardMarkup(new[]
                        {
                            new[]
                            {
                                InlineKeyboardButton.WithCallbackData("✅ Всё верно", "registry.accept"),
                                InlineKeyboardButton.WithCallbackData("❌ Начать сначала", "registry.decline"),
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
