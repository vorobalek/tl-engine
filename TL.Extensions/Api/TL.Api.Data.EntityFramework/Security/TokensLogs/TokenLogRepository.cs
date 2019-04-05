using System;
using TL.Api.Data.Abstractions.Security;
using TL.Api.Data.Entities.Security;
using TL.Engine.SDK.Repositories;

namespace TL.Api.Data.EntityFramework.Security.TokensLogs
{
    public class TokenLogRepository : EntityComparableStoredRepository<TokenLog, Guid>, ITokenLogRepository
    {
    }
}
