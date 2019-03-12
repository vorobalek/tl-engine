using ExtCore.Data.Abstractions;
using Microsoft.Extensions.Logging;
using System;
using TL.Api.Data.Entities.Security;
using TL.Engine.SDK.Managers;

namespace TL.Api.Data.Managers
{
    public class TokenManager : EntityComparableStoredManager<Token, Guid>, ITokenManager
    {
        public TokenManager(IServiceProvider serviceProvider, IStorage storage, ILoggerFactory loggerFactory) : base(serviceProvider, storage, loggerFactory)
        {
        }
    }
}
