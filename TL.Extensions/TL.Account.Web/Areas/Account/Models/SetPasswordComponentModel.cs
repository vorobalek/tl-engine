using System.ComponentModel.DataAnnotations;

namespace TL.Account.Web.Areas.Account.Models
{
    public class SetPasswordComponentModel
    {
        [Required(ErrorMessage = "Не указан пароль")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Пароль введен неверно")]
        public string ConfirmPassword { get; set; }
    }
}
