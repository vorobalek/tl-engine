using TL.Engine.SDK.Modularity;

namespace TL.Blog.Data
{
    public class Metadata : BaseMetadata
    {
        public override string Name => "TL.Blog.Data";

        public override string Owner => "TL.Blog";

        public override string Description =>
                $"Модуль работы с данными. Дополнительный слой для доступа к данным {Owner} из других модулей системы TL Engine.";
    }
}
