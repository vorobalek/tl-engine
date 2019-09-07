using ExtCore.Data.Abstractions;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using TL.Engine.SDK.Entities;
using TL.Engine.SDK.Services;
using TL.Engine.SDK.Types;

namespace TL.Engine.SDK.Managers
{
    internal class PermissionManager : EntityComparableManager<Permission, (byte[], byte[])>, IPermissionManager
    {
        public PermissionManager(IActivatorService activator, ILoggerFactory loggerFactory, IStorage storage) : base(activator, loggerFactory, storage)
        {
        }

        public Permission Get<TSubject, TSubjectKey, TObject, TObjectKey>(TSubject subject, TObject @object, bool loadDeleted = false)
            where TSubject : IEntityComparable<TSubjectKey>
            where TSubjectKey : IComparable
            where TObject : IEntityComparable<TObjectKey>
            where TObjectKey : IComparable
        {
            return Storage.GetRepository<IPermissionRepository>().Get<TSubject, TSubjectKey, TObject, TObjectKey>(subject, @object, loadDeleted);
        }

        public IEnumerable<Permission> GetAll<TSubject, TSubjectKey>(TSubject subject, bool loadDeleted = false)
            where TSubject : IEntityComparable<TSubjectKey>
            where TSubjectKey : IComparable
        {
            return Storage.GetRepository<IPermissionRepository>().GetAll<TSubject, TSubjectKey>(subject, loadDeleted);
        }
    }
}
