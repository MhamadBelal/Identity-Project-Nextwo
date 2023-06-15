using System.ComponentModel.DataAnnotations;

namespace NextwoIdentity2023.Models.ViewModels
{
    public class RegisterViewModel
    {
        [EmailAddress]
        [Required(ErrorMessage ="Enter Email")]
        public string? Email { get; set; }
        [DataType(DataType.Password)]
        [Required(ErrorMessage ="Enter Password")]
        public string? Password { get; set; }
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Enter Confirm Password")]
        [Compare("Password",ErrorMessage ="Confirm and Paswword not match")]
        public string? ConfirmPassword { get; set; }
        public string? Phone { get;}
    }
}
