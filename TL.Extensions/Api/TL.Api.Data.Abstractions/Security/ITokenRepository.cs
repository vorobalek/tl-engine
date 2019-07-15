using System;
using TL.Api.Data.Entities.Security;
using TL.Engine.SDK.Repositories;

namespace TL.Api.Data.Abstractions.Security
{
    public interface ITokenRepository : IEntityComparableRepository<Token, Guid>
    {
    }
}
