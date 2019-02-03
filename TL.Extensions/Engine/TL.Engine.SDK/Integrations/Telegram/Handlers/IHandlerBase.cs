using System.Collections.Generic;
using System.Threading.Tasks;
using Telegram.Bot.Types;
using TL.Engine.SDK.Integrations.Telegram.Bots;

namespace TL.Engine.SDK.Integrations.Telegram.Handlers
{
    public interface IHandlerBase
    {
        IBaseBot Bot { get; }

        List<IHandlerMethodBase> Methods { get; }

        Task<IHandlerResult> ExecuteAsync(Update update, params object[] args);
    }
}