using System;
using System.Collections.Generic;
using TL.Engine.Data.Entities.Security;
using TL.Engine.SDK.Attributes.EntityIndexer;
using TL.Engine.SDK.Entities;

namespace TL.Engine.Data.Entities.System
{
    public class StaticFile : EntityDuplicateComparableStored<Guid>
    {
        [StringIndex]
        public string FileName { get; set; }

        [StringIndex]
        public string Extension { get; set; }

        [StringIndex]
        public string FullName { get; set; }

        [StringIndex]
        public string DisplayName { get; set; }

        [StringIndex]
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
