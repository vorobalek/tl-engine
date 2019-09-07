using System;
using System.Collections.Generic;
using TL.Engine.SDK.Entities;
using TL.Engine.SDK.Repositories;

namespace TL.Engine.SDK.Types
{
    public interface IPermissionRepository : IEntityComparableRepository<Permission, (byte[], byte[])>
    {
        Permission Get<TSubject, TSubjectKey, TObject, TObjectKey>(TSubject subject, TObject @object, bool loadDeleted = false)
            where TSubject : IEntityComparable<TSubjectKey>
            where TSubjectKey : IComparable
            where TObject : IEntityComparable<TObjectKey>
            where TObjectKey : IComparable;

        IEnumerable<Permission> GetAll<TSubject, TSubjectKey>(TSubject subject, bool loadDeleted = false)
            where TSubject : IEntityComparable<TSubjectKey>
            where TSubjectKey : IComparable;
    }
}
