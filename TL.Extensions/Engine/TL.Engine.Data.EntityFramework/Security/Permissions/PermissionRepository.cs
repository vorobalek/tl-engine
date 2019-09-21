using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
            return GetAll($"select * from [core.permissions] where SubjectId = @subjectId and ObjectId = @objectId{(loadDeleted ? "" : " and IsDeleted = 0")}", 
                new SqlParameter("@subjectId", subject.Id.ToByteArray()),
                new SqlParameter("@objectId", @object.Id.ToByteArray()))
                .FirstOrDefault();
        }

        public IEnumerable<Permission> GetAll<TSubject, TSubjectKey>(TSubject subject, bool loadDeleted = false)
            where TSubject : IEntityComparable<TSubjectKey>
            where TSubjectKey : IComparable
        {
            return GetAll($"select * from [core.permissions] where SubjectId = @subjectId{(loadDeleted ? "" : " and IsDeleted = 0")}", 
                new SqlParameter("@subjectId", subject.Id.ToByteArray()));
        }
    }
}
