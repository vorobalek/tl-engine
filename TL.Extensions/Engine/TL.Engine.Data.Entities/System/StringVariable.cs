using System;
using TL.Engine.Data.Entities.Security;
using TL.Engine.SDK.Attributes.EntityIndexer;
using TL.Engine.SDK.Entities;

namespace TL.Engine.Data.Entities.System
{
    public class StringVariable : EntityComparableStored<Guid>
    {
        [StringIndex]
        public string Name { get; set; }

        public string Value { get; set; }

        public Guid AuthorId { get; set; } = User.System.Id;

        public virtual User Author { get; set; }

        public StringVariable(string name, string value)
        {
            Name = name;
            Value = value;
            AuthorId = User.System.Id;
        }
    }
}
