using System;
using TL.Crm.Data.Abstractions.Core;
using TL.Crm.Data.Entities.Core;
using TL.Engine.SDK.Repositories;

namespace TL.Crm.Data.EntityFramework.Core.Invites
{
    public class InviteRepository : EntityComparableStoredRepository<Invite, Guid>, IInviteRepository
    {
    }
}
