using System;
using TL.Engine.SDK.Managers;
using TL.Linker.Data.Entities.Core;

namespace TL.Linker.Data.Managers
{
    public interface ILinkManager : IEntityComparableStoredManager<Link, Guid>
    {
        Link Get(ulong id);
        string GetLinkUrl(string url);
        Link Create(string url);
        string LinkConvert(ulong number);
        ulong LinkParse(string code);
    }
}
