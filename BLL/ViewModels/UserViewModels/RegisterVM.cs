using MODEL.Abstract.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.ViewModels.UserViewModels
{
    public class RegisterVM
    {
        [Required(ErrorMessage ="Kullanıcı adı boş geçilemez")]
        public string UserName { get; set; }
        [Required(ErrorMessage ="Email boş geçilemez")]
        [EmailAddress(ErrorMessage ="Email formatında bir değer giriniz")]
        public string Email { get; set; }
        [Required(ErrorMessage ="Şifre boş geçilemez")]
        public string Password { get; set; }
        [Required(ErrorMessage ="şifre tekrarı boş geçilemez")]
        [Compare("Password",ErrorMessage ="Şifreler uyuşmamaktadır")]
        public string ConfirmPassword { get; set; }

        public string Address {  get; set; }

        public MembershipType MembershipType { get; set; }
    }
}
