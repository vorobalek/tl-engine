using System;
using System.Collections.Generic;
using TL.Engine.SDK.Entities;
using TL.JustBot.Data.Entities.Common;

namespace TL.JustBot.Data.Entities.Security
{
    public class Person : EntityComparableStored<Guid>
    {
        public string Token { get; set; }

        public IEnumerable<History> History { get; set; }
    }
}
