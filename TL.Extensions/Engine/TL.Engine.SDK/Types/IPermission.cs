using System;
using TL.Engine.SDK.Entities;
using TL.Engine.SDK.Types.Enums;

namespace TL.Engine.SDK.Types
{
    public interface IPermission : IEntityStored
    {
        Type SubjectType { get; }
        Type ObjectType { get; }
        AccessMode Mode { get; set; }
    }
}
