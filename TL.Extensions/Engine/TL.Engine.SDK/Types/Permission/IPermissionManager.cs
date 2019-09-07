using System;
using System.Collections.Generic;
using TL.Engine.SDK.Entities;
using TL.Engine.SDK.Types;

namespace TL.Engine.SDK.Managers
{
    public interface IPermissionManager : IEntityComparableManager<Permission, (byte[], byte[])>
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
