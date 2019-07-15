using System;
using TL.Api.Data.Entities.Security;
using TL.Engine.SDK.Managers;

namespace TL.Api.Data.Managers
{
    public interface ITokenManager : IEntityComparableManager<Token, Guid>
    {
    }
}
