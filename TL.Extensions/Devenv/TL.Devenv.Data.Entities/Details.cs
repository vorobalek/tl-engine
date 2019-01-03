using TL.Engine.SDK.Modules;

namespace TL.Devenv.Data.Entities
{
    public class Details : ModuleBase
    {
        public override string Name => "TL.Devenv.Data.Entities";

        public override string Owner => "TL.Devenv";

        public override string Icon => "/Areas/Devenv/Styles/images/package.png";

        public override string Description =>
            $"Модуль сущностей данных. Основной слой, описывающий объекты модуля {Owner}, отображаемые в базу данных.";

        public override string Authors => "Alexey Vorobev";
    }
}
