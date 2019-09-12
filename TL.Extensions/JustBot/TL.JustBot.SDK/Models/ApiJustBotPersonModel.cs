using System;
using TL.Api.SDK.Objects;

namespace TL.JustBot.SDK.Models
{
    public class ApiJustBotPersonModel : JsonApiObject
    {
        public string Token { get; set; }
        public DateTime CreateionDate { get; set; }
        public DateTime ModifiedDate { get; set; }

        protected override string _Description => "Объект, представляющий уникальную личность диалоговой системы JustBot";
    }
}
