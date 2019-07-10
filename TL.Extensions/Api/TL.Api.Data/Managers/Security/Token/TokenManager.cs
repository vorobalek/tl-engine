using ExtCore.Data.Abstractions;
using Microsoft.Extensions.Logging;
using System;
using TL.Api.Data.Entities.Security;
using TL.Engine.SDK.Managers;
using TL.Engine.SDK.Services;

namespace TL.Api.Data.Managers
{
    internal class TokenManager : EntityComparableStoredManager<Token, Guid>, ITokenManager
    {
        public TokenManager(IActivatorService activator, ILoggerFactory loggerFactory, IStorage storage) : base(activator, loggerFactory, storage)
        {
        }
    }
}
