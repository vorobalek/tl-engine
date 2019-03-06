using System.Collections.Generic;
using TL.Api.SDK.Objects;

namespace TL.Api.SDK.Models
{
    public class ApiObjectModel : JsonApiObject
    {
        protected override string _Description => "Модель объекта API";

        public string Name { get; set; }
        
        public IList<ApiPropertyModel> Properties { get; set; }

        public string Description { get; set; }
    }
}
