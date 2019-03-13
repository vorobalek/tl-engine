using System;
using System.Threading.Tasks;
using TL.Crm.Data.Entities.Core;
using TL.Crm.Data.Extensions;
using TL.Crm.Data.Managers;
using TL.Engine.SDK.Integrations.Telegram.Handlers;
using TlUser = TL.Account.Data.Entities.Security.User;

namespace TL.Crm.Telegram.Methods.Command.Message.CrmClient.Protections
{
    public class HasLead : Protection
    {
        public override int Priority => 10;

        public override string Description => "Служебный слой проверки существования лида";

        protected override async Task<IHandlerMethodResult> ExecuteProtectionAsync(global::Telegram.Bot.Types.Message message, IServiceProvider serviceProvider, TlUser user, ILeadManager leadManager, IInviteManager inviteManager, ILeadPhoneManager leadPhoneManager, IContractorManager contractorManager)
        {
            var originalLead = user.GetOriginalLead(serviceProvider);

            if (originalLead == null)
            {
                originalLead = leadManager.Create(new Lead()
                {
                    User = user
                });
            }

            ContinueExecute();
            return new HandlerMethodResult(true);
        }
    }
}
