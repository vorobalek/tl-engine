using System;
using TL.Engine.SDK.Managers;
using TL.JustBot.Data.Entities.Security;

namespace TL.JustBot.Data.Managers
{
    public interface IPersonManager : IEntityComparableManager<Person, Guid>
    {
    }
}