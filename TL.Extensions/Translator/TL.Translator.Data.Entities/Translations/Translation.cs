using ExtCore.Data.Entities.Abstractions;
using System;
using TL.Account.Data.Entities.Security;

namespace TL.Translator.Data.Entities.Translations
{
    public class Translation : IEntity
    {
        public Guid Id { get; set; }

        public Guid AuthorId { get; set; }

        public string InputCulture { get; set; }

        public string InputText { get; set; }

        public string OutputCulture { get; set; }

        public string OutputText { get; set; }

        public DateTime Date { get; set; }
    }
}
