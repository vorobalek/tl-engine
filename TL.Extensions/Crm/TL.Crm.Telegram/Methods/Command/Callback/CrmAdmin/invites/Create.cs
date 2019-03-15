using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using System.Threading.Tasks;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;
using TL.Crm.Data.Entities.Core;
using TL.Crm.Data.Managers;
using TL.Engine.SDK.Integrations.Telegram.Handlers;
using TlMessage = TL.Engine.SDK.Integrations.Telegram.Messages.Message;
using TlUser = TL.Account.Data.Entities.Security.User;

namespace TL.Crm.Telegram.Methods.Command.Callback.CrmAdmin.invites
{
    public class Create : CrmAdminBotCallbackHCommandMethod
    {
        public override string Command => "invites.create";

        public override string Description => "Создать новый инвайт";

        protected override async Task<IHandlerMethodResult> ExecuteAsync(CallbackQuery callbackQuery, params object[] args)
        {
            if (args[0] is IServiceProvider serviceProvider)
            {
                if (args[1] is TlUser user)
                {
                    var strContractorId = callbackQuery.Data.Split(".").Last();
                    if (!Guid.TryParse(strContractorId, out Guid contractorId))
                    {
                        contractorId = Contractor.System.Id;
                    }

                    var inviteManager = serviceProvider.GetService<IInviteManager>();
                    var invite = inviteManager.Create(new Invite()
                    {
                        ReferrerId = contractorId,
                    });

                    var leadManager = serviceProvider.GetService<ILeadManager>();
                    var lead = leadManager.GetOriginal(e => e.ContractorId == contractorId);

                    var localInviteTimeOut = invite.TimeOut.ToLocalTime();

                    await Bot.SendAsync(new TlMessage()
                    {
                        IsEditMessage = true,

                        MessageType = MessageType.Text,
                        ChatId = callbackQuery.From.Id,

                        Text = $"➕ <b>Создать новый инвайт</b>\r\n" +
                        $"\r\n" +
                        $"Создан инвайт от имени пользователя <b>{lead.Firstname} {lead.Lastname} {lead.Middlename}</b>\r\n\r\n" +
                        $"Код инвайта: <code>{invite.Id.ToString()}</code>",
                        ReplyMarkup = new InlineKeyboardMarkup(new[]
                        {
                            new[]
                            {
                                InlineKeyboardButton.WithCallbackData($"{(invite.TimeOut < DateTime.Now.ToUniversalTime() ? "⌛️" : "⏳")} {localInviteTimeOut.Day}/{localInviteTimeOut.Month}/{localInviteTimeOut.Year} {localInviteTimeOut.Hour}:{localInviteTimeOut.Minute}:{localInviteTimeOut.Second}", "invites.change.time"),
                                InlineKeyboardButton.WithCallbackData($"🙎🏼‍ Лимит {invite.Referrals.Count()} из {invite.MaxMembersCount}", "invites.change.count"),
                            },
                            new[]
                            {
                                InlineKeyboardButton.WithCallbackData("⬅️ Назад", "invites.main"),
                            }
                        }),
                        ParseMode = ParseMode.Html,

                        CallbackQueryId = callbackQuery.Id,
                        EditMessageId = callbackQuery.Message.MessageId,
                    });

                    return new HandlerMethodResult(true);
                }
            }

            return new HandlerMethodResult(false, null, $"{new ArgumentException($"В {nameof(args)} переданы неверные аргументы.")}");
        }
    }
}
