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
    }
}
