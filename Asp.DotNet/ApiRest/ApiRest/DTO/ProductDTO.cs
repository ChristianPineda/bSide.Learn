using System.ComponentModel.DataAnnotations;

namespace ApiRest.DTO
{
    public class ProductDto
    {
        [Required]
        public string Name { get; set; }
        [Required] 
        public string Description { get; set; }
        [Required]
        [Range(1, 1000, ErrorMessage = "The price {0} must be between {1} y {2}")]
        public decimal Price { get; set; }
        [Required] 
        public string Sku { get; set; }
    }
}
