using System.Collections.Generic;
using System.Threading.Tasks;
using ApiRest.Model;

namespace ApiRest.Repo
{
    public interface IMemoryProduct
    {
        Task<IEnumerable<Product>> GetAll(); //lista

        Task<Product> GetById(string code); //por sku
        Task CreateProduct(Product p); //crear
        
        Task UpdateProduct(Product p); //modificar
        Task DeleteProduct(string code); //eliminar
    }
}
