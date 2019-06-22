using ExtCore.Data.Abstractions;
using Microsoft.Extensions.Logging;
using System;
using TL.Api.Data.Entities.Security;
using TL.Engine.SDK.Managers;
using TL.Engine.SDK.Services;

namespace TL.Api.Data.Managers
{
    public class TokenLogManager : EntityComparableStoredManager<TokenLog, Guid>, ITokenLogManager
    {
        public TokenLogManager(IActivatorService activator, ILoggerFactory loggerFactory, IStorage storage) : base(activator, loggerFactory, storage)
        {
        }
    }
}
