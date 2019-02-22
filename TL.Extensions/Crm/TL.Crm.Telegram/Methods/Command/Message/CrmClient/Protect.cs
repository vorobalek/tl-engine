using ExtCore.Data.Abstractions;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using System.Threading.Tasks;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;
using TL.Crm.Data.Abstractions.Core;
using TL.Crm.Data.Abstractions.Periphery;
using TL.Crm.Data.Entities.Core;
using TL.Crm.Data.Extensions;
using TL.Crm.Data.Managers;
using TL.Engine.SDK.Integrations.Telegram.Handlers;
using TgMessage = TL.Engine.SDK.Integrations.Telegram.Messages.Message;
using TLUser = TL.Account.Data.Entities.Security.User;

namespace TL.Crm.Telegram.Methods.Command.Message.CrmClient
{
    public class Protect : CrmClientBotMessageHCommandMethod
    {
        public override int Priority => -1;

        public override bool IsPrivate => true;

        public override bool IsBlocker => false;

        public override string Command => "";

        public override string Description => "Служебный слой";

        public override bool IsRelevantMethod(Update update, params object[] args)
        {
            return true;
        }

        protected override async Task<IHandlerMethodResult> ExecuteAsync(global::Telegram.Bot.Types.Message message, params object[] args)
        {
            if (args[0] is IServiceProvider serviceProvider)
            {
                if (args[1] is TLUser user)
                {
                    var lead = user.GetLead(serviceProvider);
                    if (lead == null)
                    {
                        //Создаем лида
                    }
                    else
                    {
                        if (lead.Invite == null)
                        {
                            //Запрашиваем инвайт
                        }
                        else
                        {
                            var inviteManager = serviceProvider.GetService<IInviteManager>();
                            var invite = inviteManager.Get(lead.Invite.Id);

                            if(!invite.IsActivated)
                            {
                                if (lead.Phones.Count() == 0)
                                {
                                    //Запрашиваем номер телефона
                                }
                                else
                                {
                                    if (string.IsNullOrWhiteSpace(lead.Firstname))
                                    {
                                        // Запрашиваем имя
                                    }
                                    else
                                    {
                                        if (string.IsNullOrWhiteSpace(lead.Lastname))
                                        {
                                            //запрашиваем фамилию
                                        }
                                        else
                                        {
                                            if (string.IsNullOrWhiteSpace(lead.Middlename))
                                            {
                                                //запрашиваем отчество
                                            }
                                            else
                                            {
                                                //запрашиваем подтверждение активации
                                            }
                                        }
                                    }
                                }
                            }
                            else
                            {
                                //Продолжаем работу
                            }
                        }
                    }
                }
            }

            return new HandlerMethodResult(true);
        }
    }
}
