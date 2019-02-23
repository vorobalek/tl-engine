using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using System.Threading.Tasks;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;
using TL.Crm.Data.Entities.Core;
using TL.Crm.Data.Extensions;
using TL.Crm.Data.Managers;
using TL.Engine.SDK.Integrations.Telegram.Handlers;
using TlMessage = TL.Engine.SDK.Integrations.Telegram.Messages.Message;
using TlUser = TL.Account.Data.Entities.Security.User;

namespace TL.Crm.Telegram.Methods.Command.Callback.CrmClient.registry
{
    public class Accept : CrmClientBotCallbackHCommandMethod
    {
        public override string Command => "crm.registry.accept";

        public override string Description => "Зарегистрировать введенные данные";

        protected override async Task<IHandlerMethodResult> ExecuteAsync(CallbackQuery callbackQuery, params object[] args)
        {
            if (args[0] is IServiceProvider serviceProvider)
            {
                if (args[1] is TlUser user)
                {
                    var inviteManager = serviceProvider.GetService<IInviteManager>();
                    var contractorManager = serviceProvider.GetService<IContractorManager>();
                    var leadPhoneManager = serviceProvider.GetService<ILeadPhoneManager>();

                    var originalContractor = user.GetOriginalContractor(serviceProvider);
                    var originalLead = user.GetOriginalLead(serviceProvider);
                    var leadPhones = leadPhoneManager.GetAll(e => e.LeadId == originalLead.Id);

                    if (originalLead != null)
                    {
                        if (originalContractor == null)
                        {
                            contractorManager.Create(new Contractor()
                            {
                                Leads = new[]
                                {
                                    originalLead
                                },
                            });

                            var invite = inviteManager.Get(e => e.ReferralId.HasValue && e.ReferralId == originalLead.Id);
                            invite.IsActivated = true;
                            inviteManager.Update(invite);

                            await Bot.SendAsync(new TlMessage()
                            {
                                IsEditMessage = true,

                                MessageType = MessageType.Text,
                                ChatId = callbackQuery.From.Id,

                                Text = $"🏅 <b>Поздравляем, вы зарегистрированы!</b>\r\n\r\n" +
                                $"☑️ <b>Номер телефона:</b> {leadPhones.LastOrDefault().PhoneNumber}\r\n" +
                                $"☑️ <b>Имя:</b> {originalLead.Firstname}\r\n" +
                                $"☑️ <b>Фамилия:</b> {originalLead.Lastname}\r\n" +
                                $"☑️ <b>Отчество:</b> {originalLead.Middlename}",
                                ReplyMarkup = new ReplyKeyboardRemove(),
                                ParseMode = ParseMode.Html,

                                CallbackQueryId = callbackQuery.Id,
                                EditMessageId = callbackQuery.Message.MessageId,
                            });
                        }
                    }
                }
            }

            return new HandlerMethodResult(true);
        }
    }
}
