using System;
using TL.Account.Data.Entities.Security;
using TL.Engine.SDK.Entities;

namespace TL.Engine.Data.Entities.System
{
    public class StringVariable : EntityComparableStored<Guid>
    {
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
