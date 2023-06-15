using System.ComponentModel.DataAnnotations.Schema;

namespace NextwoIdentity2023.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string? ProductName { get; set; }
        public decimal? Price { get; set;}
        [ForeignKey("Gategory")]
        public int CategoryId { get; set; }
        public Category? Category { get; set; }


    }
}
