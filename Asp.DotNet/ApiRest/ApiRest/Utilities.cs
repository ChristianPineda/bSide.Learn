using ApiRest.DTO;
using ApiRest.Model;

namespace ApiRest
{
    public static class Utilities
    {
        public static ProductDto Trans(this Product p)
        {
            try
            {
                return new ProductDto
                {
                    Name = p.Name,
                    Description = p.Description,
                    Price = p.Price,
                    Sku = p.Sku
                };
            }
            catch
            {
                return null; //Esta validación documenta para el controlador
            }
        }
        public static ProductUpdateDTO TransUp(this Product p)
        {
            try
            {
                return new ProductUpdateDTO
                {
                    Name = p.Name,
                    Description = p.Description,
                    Price = p.Price,
                };
            }
            catch
            {
                return null;
            }
        }
    }
}