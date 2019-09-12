using System;
using TL.Engine.SDK.Entities;
using TL.JustBot.Data.Entities.Security;

namespace TL.JustBot.Data.Entities.Common
{
    public class History : EntityComparableStored<Guid>
    {
        public string Text { get; set; }

        public Guid AuthorId { get; set; }

        public virtual Person Author { get; set; }
    }
}
