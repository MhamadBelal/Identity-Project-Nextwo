using System.ComponentModel.DataAnnotations;

namespace NextwoIdentity2023.Models.ViewModels
{
    public class CreateRoleViewModel
    {
        [Required]
        public string? RoleName { get; set; }
    }
}
