using System;
using System.Threading.Tasks;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using TL.Engine.SDK.Integrations.Telegram.Bots;

namespace TL.Engine.SDK.Integrations.Telegram.Handlers
{
    public interface IHandlerMethodBase
    {
        IBaseBot Bot { get; }
        IHandlerBase Handler { get; set; }

        string Command { get; }
        string Description { get; }

        bool IsPrivate { get; }
        bool IsTerminated { get; }

        bool IsRelevantMethod(Update update);
        bool IsPolicyAcceptable(Update update);

        Type BotType { get; }
        Type HandlerType { get; }

        UpdateType UpdateType { get; }

        Task<IHandlerMethodResult> ExecuteAsync(Update update);
    }
}
