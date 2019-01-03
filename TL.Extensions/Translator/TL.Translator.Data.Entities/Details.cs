using TL.Engine.SDK.Modules;

namespace TL.Translator.Data.Entities
{
    public class Details : ModuleBase
    {
        public override string Name => "TL.Translator.Data.Entities";

        public override string Owner => "TL.Translator";

        public override string Icon => "/Areas/Translator/Styles/images/package.png";

        public override string Description =>
            $"Модуль сущностей данных. Основной слой, описывающий объекты модуля {Owner}, отображаемые в базу данных.";

        public override string Authors => "Alexey Vorobev";
    }
}
