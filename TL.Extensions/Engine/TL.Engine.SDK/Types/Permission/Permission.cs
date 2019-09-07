using System;
using TL.Engine.SDK.Entities;
using TL.Engine.SDK.Extensions;
using TL.Engine.SDK.Types.Enums;

namespace TL.Engine.SDK.Types
{
    public class Permission : EntityComparableStored<(byte[], byte[])>
    {
        public override (byte[], byte[]) Id
        {
            get => (SubjectId, ObjectId);
            set => (SubjectId, ObjectId) = value;
        }

        public AccessMode Mode { get; set; }
        public virtual byte[] SubjectId { get; set; }
        public virtual byte[] ObjectId { get; set; }

        public static Permission Generic<TSubjectKey, TObjectKey>((TSubjectKey, TObjectKey) id, AccessMode mode)
            where TSubjectKey : IComparable
            where TObjectKey : IComparable
        {
            return Generic<TSubjectKey, TObjectKey>(id, mode, DateTime.UnixEpoch, DateTime.UnixEpoch);
        }

        public static Permission Generic<TSubjectKey, TObjectKey>((TSubjectKey, TObjectKey) id, AccessMode mode, DateTime creationDate, DateTime modifiedDate)
            where TSubjectKey : IComparable
            where TObjectKey : IComparable
        {
            return new Permission()
            {
                Id = (id.Item1.ToByteArray(), id.Item2.ToByteArray()),
                Mode = mode,
                CreationDate = creationDate,
                ModifiedDate = modifiedDate,
            };
        }
    }
}
