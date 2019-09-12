using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using TL.Api.SDK.Attributes.Http;
using TL.Api.SDK.Extensions;
using TL.JustBot.Data.Entities.Security;
using TL.JustBot.Data.Managers;
using TL.JustBot.SDK.Models;

namespace TL.JustBot.Web.Api.JustBot
{
    public class MeController : _JustBotApiController
    {
        public override string Command => "justbot.Me";

        public override string Description => "Используйте для генерации и получения новой личности для общения с системой JustBot";

        IPersonManager PersonManager { get; }

        public MeController(IPersonManager personManager)
        {
            PersonManager = personManager;
        }

        [ApiHttpGet(UsageDescription = "Без параметров будет создана новая личность для общения с JustBot", ReturnableType = typeof(ApiJustBotPersonModel))]
        public IActionResult Get()
        {
            var person = PersonManager.CreateEmpty();
            return this.JsonResponse(true, PersonResponse(ref person));
        }

        [ApiHttpGet("{renew}", UsageDescription = "Укажите ваш старый индивидуальный токен как часть маршрута запроса, чтобы сгенерировать новый токен, но сохранить личность для общения с системой JustBot", ReturnableType = typeof(ApiJustBotPersonModel), UsageSample = "/<TOKEN>")]
        public IActionResult Get(string renew)
        {
            if (PersonManager.Get(p => p.Token == renew) is Person person)
            {
                return this.JsonResponse(true, PersonResponse(ref person));
            }
            return this.JsonResponse(false, error_code: StatusCodes.Status404NotFound, description: "No person found with this token.");
        }

        ApiJustBotPersonModel PersonResponse(ref Person person)
        {
            var result = new ApiJustBotPersonModel();

            person.Token = $"{string.Join("", Guid.NewGuid().ToString().Split('-'))}{string.Join("", Guid.NewGuid().ToString().Split('-'))}";
            PersonManager.Update(person);

            result.Token = person.Token;
            result.CreationDate = person.CreationDate;
            result.ModifiedDate = person.ModifiedDate;

            return result;
        }
    }
}
