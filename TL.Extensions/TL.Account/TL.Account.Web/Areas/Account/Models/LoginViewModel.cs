using System.ComponentModel.DataAnnotations;

namespace TL.Account.Web.Areas.Account.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Не указан логин")]
        public string Username { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
