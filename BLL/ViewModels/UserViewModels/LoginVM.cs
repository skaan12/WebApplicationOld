using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.ViewModels.UserViewModels
{
    public class LoginVM
    {
        [Required(ErrorMessage = "E-mail boş geçilemez")]
        [EmailAddress(ErrorMessage = "E-mail formatında bir değer giriniz")]
        public string Email { get; set; }
        [Required(ErrorMessage = "şifre boş geçilemez")]
        public string Password { get; set; }

        public bool RememberMe { get; set; }
    }
}
