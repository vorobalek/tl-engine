using System;
using TL.Engine.SDK.Entities;

namespace TL.Engine.Data.Entities.System
{
    public class StringVariable : EntityStored
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Value { get; set; }
    }
}
