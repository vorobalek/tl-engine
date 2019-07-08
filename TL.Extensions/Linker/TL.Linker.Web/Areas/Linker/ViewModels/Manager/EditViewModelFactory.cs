namespace TL.Linker.Web.Areas.Linker.ViewModels.Manager
{
    public class EditViewModelFactory
    {
        public EditViewModel Create(LinkViewModel link, string message = null)
        {
            return new EditViewModel(link, message);
        }
    }
}
