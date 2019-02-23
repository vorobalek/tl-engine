using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading.Tasks;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using TL.Crm.Data.Managers;
using TL.Engine.SDK.Integrations.Telegram.Handlers;
using TlUser = TL.Account.Data.Entities.Security.User;

namespace TL.Crm.Telegram.Methods.Command.Message.CrmClient.Protections
{
    public abstract class Protection : CrmClientBotMessageHCommandMethod
    {
        public override bool IsPrivate => true;

        public override bool IsBlocker => false;

        public override bool IsRelevantMethod(Update update, params object[] args)
        {
            return update.Type == UpdateType.Message;
        }

        protected override async Task<IHandlerMethodResult> ExecuteAsync(global::Telegram.Bot.Types.Message message, params object[] args)
        {
            if (args[0] is IServiceProvider serviceProvider)
            {
                if (args[1] is TlUser user)
                {
                    var leadManager = serviceProvider.GetService<ILeadManager>();
                    var inviteManager = serviceProvider.GetService<IInviteManager>();
                    var leadPhoneManager = serviceProvider.GetService<ILeadPhoneManager>();
                    var contractorManager = serviceProvider.GetService<IContractorManager>();

                    return await ExecuteProtectionAsync(message, serviceProvider, user, leadManager, inviteManager, leadPhoneManager, contractorManager);
                }
            }

            return new HandlerMethodResult(false, null, $"{new ArgumentException($"В {nameof(args)} переданы неверные аргументы.")}");
        }

        protected abstract Task<IHandlerMethodResult> ExecuteProtectionAsync(global::Telegram.Bot.Types.Message message, IServiceProvider serviceProvider, TlUser user, ILeadManager leadManager, IInviteManager inviteManager, ILeadPhoneManager leadPhoneManager, IContractorManager contractorManager);
    }
}
