using ExtCore.Data.Abstractions;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;
using TL.Crm.Data.Abstractions.Core;
using TL.Crm.Data.Abstractions.Periphery;
using TL.Crm.Data.Entities.Core;
using TL.Crm.Data.Extensions;
using TL.Engine.SDK.Integrations.Telegram.Handlers;
using TLUser = TL.Account.Data.Entities.Security.User;

namespace TL.Crm.Telegram.Methods.Command.Message.CrmClient
{
    public class Start : CrmClientBotMessageHCommandMethod
    {
        public override string Command => "/start";

        public override string Description => "Начать работу с ботом";

        protected override async Task<IHandlerMethodResult> ExecuteAsync(global::Telegram.Bot.Types.Message message, params object[] args)
        {
            if (args[0] is IServiceProvider serviceProvider)
            {
                if (args[1] is TLUser user)
                {
                    var storage = serviceProvider.GetService<IStorage>();
                    var leadRepository = storage.GetRepository<ILeadRepository>();
                    var lead = leadRepository.GetByUserId(user.Id);
                    if (lead == null)
                    {
                        lead = leadRepository.Add(new Lead()
                        {
                            User = user,
                        });
                        storage.Save();
                    }

                    if (lead.Invite == null)
                    {
                        //Запрашиваем инвайт
                    }
                    else
                    {
                        var invite = storage.GetRepository<IInviteRepository>().GetById(lead.InviteId.Value);
                        if (invite != null)
                        {
                            if (!invite.IsActivated)
                            {
                                var contractor = storage.GetRepository<IContractorRepository>().GetById(invite.ReferrerId).GetOriginal(storage);

                                //Ваш контрагент передает вам привет и предлагает зарегистрироваться)
                                //Запрашиваем номер телефона
                                //Активируем инвайт

                                await Bot.SendAsync(new Engine.SDK.Integrations.Telegram.Messages.Message()
                                {
                                    ChatId = message.From.Id,
                                    MessageType = MessageType.Text,
                                    Text = "Номер телефона, пожалуйста",
                                    ReplyMarkup = new ReplyKeyboardMarkup(new[]
                                    {
                                        new[]
                                        {
                                            KeyboardButton.WithRequestContact("Отправить номер"),
                                        }
                                    }, true, true)
                                });
                            }
                            else
                            {
                                if (lead.Phones.Count() > 0)
                                {
                                    var leadPhones = lead.Phones.Select(e => storage.GetRepository<ILeadPhoneRepository>().GetById(e.Id));
                                    //Запрашиваем ФИО
                                }
                                else
                                {
                                    //запрашиваем номер телефона
                                }
                            }
                        }
                        else
                        {
                            //Инвайт не найден или недействителен
                        }
                    }
                }
            }

            return new HandlerMethodResult(true);
        }
    }
}
