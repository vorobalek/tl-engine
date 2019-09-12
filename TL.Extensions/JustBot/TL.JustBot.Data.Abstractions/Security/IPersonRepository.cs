using System;
using TL.Engine.SDK.Repositories;
using TL.JustBot.Data.Entities.Security;

namespace TL.JustBot.Data.Abstractions.Security
{
    public interface IPersonRepository : IEntityComparableRepository<Person, Guid>
    {
    }
}
