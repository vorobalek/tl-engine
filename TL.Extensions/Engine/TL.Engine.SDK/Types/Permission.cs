using System;
using TL.Engine.SDK.Entities;
using TL.Engine.SDK.Types.Enums;

namespace TL.Engine.SDK.Types
{
    public abstract class Permission<TSubject, TSubjectKey, TObject, TObjectKey> : EntityComparableStored<(TSubjectKey, TObjectKey)>, IPermission
        where TSubject : class, IEntityComparable<TSubjectKey>
        where TSubjectKey : IComparable
        where TObject : class, IEntityComparable<TObjectKey>
        where TObjectKey : IComparable
    {
        public Type SubjectType => typeof(TSubject);
        public Type ObjectType => typeof(TObject);
        public AccessMode Mode { get; set; }
        public TSubjectKey SubjectId { get; set; }
        public TObjectKey ObjectId { get; set; }

        /// <summary>
        /// Сущность, которая имеет привелегии для доступа к объекту.
        /// </summary>
        public virtual TSubject Subject { get; set; }

        /// <summary>
        /// Объект, для которого устанавливаются правила доступа от сущностей субъекта.
        /// </summary>
        public virtual TObject Object { get; set; }
    }
}
