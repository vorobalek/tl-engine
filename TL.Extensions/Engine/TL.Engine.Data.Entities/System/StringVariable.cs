using ExtCore.Data.Entities.Abstractions;
using System;

namespace TL.Engine.Data.Entities.System
{
    public class StringVariable : IEntity
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Value { get; set; }
    }
}
