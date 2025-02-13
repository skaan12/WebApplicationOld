using System.ComponentModel.DataAnnotations;

namespace MVC.Models.ViewModels
{
    public class AddAdminVM
    {
        [Required]
        public string UserName { get; set; }
        [Required,EmailAddress]
        public string Email {  get; set; }

        [Required,DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        public string CVC { get; set; }

        [Required]
        public string CreditCard {  get; set; }
    }
}
