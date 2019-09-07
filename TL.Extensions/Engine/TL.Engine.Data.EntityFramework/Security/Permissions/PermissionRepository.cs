using System;
using System.Collections.Generic;
using System.Linq;
using TL.Engine.SDK.Entities;
using TL.Engine.SDK.Extensions;
using TL.Engine.SDK.Repositories;
using TL.Engine.SDK.Types;

namespace TL.Engine.Data.EntityFramework.Security.Permissions
{
    public class PermissionRepository : EntityComparableRepository<Permission, (byte[], byte[])>, IPermissionRepository
    {
        public Permission Get<TSubject, TSubjectKey, TObject, TObjectKey>(TSubject subject, TObject @object, bool loadDeleted = false)
            where TSubject : IEntityComparable<TSubjectKey>
            where TSubjectKey : IComparable
            where TObject : IEntityComparable<TObjectKey>
            where TObjectKey : IComparable
        {
            var result = dbSet.Find((subject.Id.ToByteArray(), @object.Id.ToByteArray()));
            if ((result.IsDeleted && loadDeleted) || (!result.IsDeleted)) return result;
            else return null;
        }

        public IEnumerable<Permission> GetAll<TSubject, TSubjectKey>(TSubject subject, bool loadDeleted = false)
            where TSubject : IEntityComparable<TSubjectKey>
            where TSubjectKey : IComparable
        {
            return base.GetAll(e => e.SubjectId.SequenceEqual(subject.Id.ToByteArray()), loadDeleted);
        }
    }
}
