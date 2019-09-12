using System;
using TL.Engine.SDK.Repositories;
using TL.JustBot.Data.Abstractions.Security;
using TL.JustBot.Data.Entities.Security;

namespace TL.JustBot.Data.EntityFramework.Security
{
    public class PersonRepository : EntityComparableRepository<Person, Guid>, IPersonRepository
    {
    }
}
