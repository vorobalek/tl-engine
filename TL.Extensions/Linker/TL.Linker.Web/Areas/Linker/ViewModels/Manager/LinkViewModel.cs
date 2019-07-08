using System;

namespace TL.Linker.Web.Areas.Linker.ViewModels.Manager
{
    public class LinkViewModel
    {
        public Guid Id { get; set; }
        public string Path { get; set; }
        public string OriginalPath { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }
        public LinkViewModel(Guid id, string path, string originalPath, DateTime creationDate, DateTime modifiedDate, bool isDeleted)
        {
            Id = id;
            Path = path;
            OriginalPath = originalPath;
            CreationDate = creationDate;
            ModifiedDate = modifiedDate;
            IsDeleted = isDeleted;
        }
        public LinkViewModel()
        {
        }
    }
}
