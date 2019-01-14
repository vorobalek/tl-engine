using System.Collections.Generic;
using TL.Engine.SDK.Objects;

namespace TL.Engine.SDK.Models
{
    public class ApiObjectModel : JsonApiObject
    {
        protected override string _Description => "Модель объекта API";

        public string Name { get; set; }
        
        public IList<ApiPropertyModel> Properties { get; set; }

        public string Description { get; set; }
    }
}
