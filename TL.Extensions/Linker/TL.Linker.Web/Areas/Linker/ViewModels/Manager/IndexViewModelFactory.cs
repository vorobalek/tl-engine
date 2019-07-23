namespace TL.Linker.Web.Areas.Linker.ViewModels.Manager
{
    public class IndexViewModelFactory
    {
        public IndexViewModel Create(long count, int page, int perPage)
        {
            return new IndexViewModel()
            {
                Current = page,
                PerPage = perPage,
                Pages = (int)((count + perPage - 1) / perPage),
            };
        }
    }
}
