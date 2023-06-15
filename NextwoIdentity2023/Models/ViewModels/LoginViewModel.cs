using System.ComponentModel.DataAnnotations;

namespace NextwoIdentity2023.Models.ViewModels
{
    public class LoginViewModel
    {
        [EmailAddress]
        [Required(ErrorMessage = "Enter Email")]
        public string? Email { get; set; }
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Enter Password")]
        public string? Password { get; set; }
    }
}
