using System.ComponentModel.DataAnnotations;

namespace NextwoIdentity2023.Models
{
    public class Category
    {
            public int CategoryId { get; set; }
            [Required]
            public string? CategoryName { get; set; }
        
    }
}
