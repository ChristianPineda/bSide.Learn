using ApiRest.DTO;
using ApiRest.Model;

namespace ApiRest
{
    public static class Utilities
    {
        public static ProductDto Trans(this Product p)
        {
            return new ProductDto
            {
                Name = p.Name,
                Description = p.Description,
                Price = p.Price,
                Sku = p.Sku
            };
        }
        public static ProductUpdateDTO TransUp(this Product p)
        {
            return new ProductUpdateDTO
            {
                Name = p.Name,
                Description = p.Description,
                Price = p.Price,
            };
        }
    }
}
