using System.Collections.Generic;
using TL.Engine.SDK.Entities;

namespace TL.Engine.SDK.Services
{
    public interface IStringIndexerService
    {
        bool Add(string source);
        bool Find(string source);
    }
}