using System.Collections.Generic;
using TL.Api.Web.Objects.SDK;

namespace TL.Api.Web.Objects
{
    public class ApiObjectModel : __BaseApiObject__
    {
        protected override string ObjectDescription => "Модель объекта API";

        public string Name { get; set; }
        
        public IList<ApiPropertyModel> Properties { get; set; }

        public string Description { get; set; }
    }
}
