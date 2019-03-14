using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using System.Threading.Tasks;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;
using TL.Engine.Data.Entities.System;
using TL.Engine.Data.Managers;
using TL.Engine.SDK.Extensions;
using TL.Engine.SDK.Integrations.Telegram.Handlers;
using TL.Integrations.Data.Entities.Telegram.Security;
using TL.Integrations.Data.Managers;
using TlMessage = TL.Engine.SDK.Integrations.Telegram.Messages.Message;
using TlUser = TL.Account.Data.Entities.Security.User;

namespace TL.Crm.Telegram.Methods.Command.Message.CrmAdmin
{
    public class Protection : CrmAdminBotMessageHCommandMethod
    {
        public override bool IsPrivate => true;

        public override bool IsBlocker => false;

        public override string Command => "";

        public override int Priority => 10;

        public override string Description => "";

        public override bool IsRelevantMethod(Update update, params object[] args)
        {
            return true;
        }

        protected override async Task<IHandlerMethodResult> ExecuteAsync(Update update, params object[] args)
        {
            var message = update.Message ?? new global::Telegram.Bot.Types.Message()
            {
                Text = "",
                From = update.GetSenderUser(),
            };

            return await ExecuteAsync(message, args);
        }

        protected override async Task<IHandlerMethodResult> ExecuteAsync(global::Telegram.Bot.Types.Message message, params object[] args)
        {
            if (args[0] is IServiceProvider serviceProvider)
            {
                if (args[1] is TlUser user)
                {
                    var tgUserManager = serviceProvider.GetService<ITgUserManager>();
                    var tgRoleManager = serviceProvider.GetService<ITgRoleManager>();

                    var tgUser = tgUserManager.Get(message.From.Id);
                    if (tgUser.UserRoles.FirstOrDefault(e => e.RoleId == TgRole.Admin.Id) != null)
                    {
                        ContinueExecute();
                    }
                    else
                    {
                        var stringVariableManager = serviceProvider.GetService<IStringVariableManager>();
                        var tgSaPassword = stringVariableManager.Get(e => e.Name == TG_CRM_STRING_VARIABLES.TG_ADMIN_PWD);
                        if (tgSaPassword == null)
                        {
                            tgSaPassword = stringVariableManager.Create(new StringVariable(TG_CRM_STRING_VARIABLES.TG_ADMIN_PWD, "admin"));
                        }

                        if (message.Text == tgSaPassword.Value)
                        {
                            var userRoleManager = serviceProvider.GetService<ITgUserRoleManager>();
                            var newUserRole = userRoleManager.GetOrCreate(e => e.UserId == tgUser.Id && e.RoleId == TgRole.Admin.Id,
                                new TgUserRole()
                                {
                                    UserId = tgUser.Id,
                                    RoleId = TgRole.Admin.Id,
                                });

                            await Bot.SendAsync(new TlMessage()
                            {
                                MessageType = MessageType.Text,
                                ChatId = message.From.Id,
                                Text = $"‼️ <b>Внимательно прочитайте это сообщение!</b>\r\n" +
                                $"\r\n" +
                                $"Вам назначены <b>привелегии администратора</b>. Эти привелегии бессрочные и будут привязаны к <b>этой</b> учетной записи. " +
                                $"Вы сможете отказаться от них в любой момент в свём личном кабинете. Рекомендуется регулярно менять пароль для доступа к этим привелегиям.\r\n" +
                                $"\r\n" +
                                $"<b>‼️ ОБЯЗАТЕЛЬНО</b> удалите из диалога своё сообщение с паролем, чтобы он не был скомпрометирован.",
                                ParseMode = ParseMode.Html,

                                ReplyMarkup = new InlineKeyboardMarkup(new[]
                                {
                                    new[]
                                    {
                                        InlineKeyboardButton.WithCallbackData("✅ Перейти в личный кабинет", "main")
                                    }
                                })
                            });
                        }
                        else
                        {
                            await Bot.SendAsync(new TlMessage()
                            {
                                MessageType = MessageType.Text,
                                ChatId = message.From.Id,
                                Text = $"⛔️ <b>Отказано в доступе!</b>\r\n" +
                                $"\r\n" +
                                $"Для получения привелегий администратора отправьте пароль.",
                                ParseMode = ParseMode.Html
                            });
                        }
                    }

                    return new HandlerMethodResult(true);
                }
            }

            return new HandlerMethodResult(false, null, $"{new ArgumentException($"В {nameof(args)} переданы неверные аргументы.")}");
        }
    }
}
