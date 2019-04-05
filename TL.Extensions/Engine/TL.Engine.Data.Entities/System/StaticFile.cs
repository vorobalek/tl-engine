using System;
using System.Collections.Generic;
using TL.Engine.Data.Entities.Security;
using TL.Engine.SDK.Entities;

namespace TL.Engine.Data.Entities.System
{
    public class StaticFile : EntityDuplicateComparableStored<Guid>
    {
        public string FileName { get; set; }

        public string Extension { get; set; }

        public string FullName { get; set; }

        public string DisplayName { get; set; }

        public string LocalPath { get; set; }

        public Guid? AuthorId { get; set; }

        public virtual User Author { get; set; }

        public byte[] Data { get; set; }

        public StaticFile()
        {
            Duplicates = new HashSet<StaticFile>();
        }

        public virtual new StaticFile Original { get; set; }

        public virtual new IEnumerable<StaticFile> Duplicates { get; set; }
    }
}
