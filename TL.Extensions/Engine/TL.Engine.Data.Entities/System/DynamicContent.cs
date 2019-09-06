using System;
using System.Collections.Generic;
using System.Text;
using TL.Engine.Data.Entities.Security;
using TL.Engine.SDK.Attributes.EntityIndexer;
using TL.Engine.SDK.Entities;

namespace TL.Engine.Data.Entities.System
{
    public class DynamicContent : EntityComparableStored<Guid>
    {
        [StringIndex]
        public string Url { get; set; }

        public string Content { get; set; }

        public Guid AuthorId { get; set; }

        public virtual User Author { get; set; }
    }
}
