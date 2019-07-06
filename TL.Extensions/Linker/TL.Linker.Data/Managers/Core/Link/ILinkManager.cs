using System;
using TL.Engine.SDK.Attributes.Api.Executable;
using TL.Engine.SDK.Managers;
using TL.Linker.Data.Entities.Core;

namespace TL.Linker.Data.Managers
{
    public interface ILinkManager : IEntityComparableStoredManager<Link, Guid>
    {
        Link Get(ulong id);

        [PublicApi(Description = "Получить URL оригинальной ссылки по линку")]
        string GetLinkUrl(string url);
        Link Create(string url);

        [PublicApi(Description = "Преобразовать идентефикатор в линк")]
        string LinkConvert(ulong number);

        [PublicApi(Description = "Преобразовать линк в идентификатор")]
        ulong LinkParse(string code);
    }
}
