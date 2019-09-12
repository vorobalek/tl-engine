using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using TL.Api.SDK.Attributes.Http;
using TL.Api.SDK.Extensions;
using TL.JustBot.Data.Entities.Common;
using TL.JustBot.Data.Entities.Security;
using TL.JustBot.Data.Managers;

namespace TL.JustBot.Web.Api.JustBot
{
    public class AskController : _JustBotApiController
    {
        public override string Command => "justbot.Ask";

        public override string Description => "Используйте для общения с системой JustBot";

        IPersonManager PersonManager { get; }

        IHistoryManager HistoryManager { get;  }

        public AskController(IPersonManager personManager, IHistoryManager historyManager)
        {
            PersonManager = personManager;
            HistoryManager = historyManager;
        }

        [ApiHttpGet("{token}", UsageDescription = "Укажите ваш индивидуальный токен как часть маршрута, чтобы персонализировать ваше общение с системой JustBot. Передавайте текст сообщения как параметр запроса, именованный \"m\"", UsageSample = "/<TOKEN>?m=Привет!")]
        public IActionResult Get(string token, [FromQuery]string m)
        {
            if (PersonManager.Get(p => p.Token == token) is Person person)
            {
                var history = HistoryManager.GetAll(h => h.AuthorId == person.Id);
                HistoryManager.Create(new History()
                {
                    AuthorId = person.Id,
                    Text = m
                });

                return this.JsonResponse(true, history.Select(h => h.Text), description: m);
            }
            return this.JsonResponse(false, error_code: StatusCodes.Status403Forbidden, description: $"Sorry, your token is invalid. Use {HttpContext.Request.Host}/api/justbot.Me for generate new.");
        }
    }
}
