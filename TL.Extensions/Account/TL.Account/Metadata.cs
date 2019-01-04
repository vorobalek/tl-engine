using TL.Engine.SDK.Modularity;

namespace TL.Account
{
    public class Metadata : MetadataBase
    {
        public override string Name => "TL.Account";

        public override string Owner => "";

        public override string Description =>
            "Отвечает за авторизацию и аутентификацию.";

        public override string Authors => "Alexey Vorobev";
    }
}
