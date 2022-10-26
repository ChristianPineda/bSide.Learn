using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using ApiRest.Model;

namespace ApiRest.Repo
{
    public interface IMemoryProduct
    {
        //#1
        //IEnumerable<Product> GetAll(); //lista
        Task<IEnumerable<Product>> GetAll(); //Lista con async
        //Product GetById(string code); //por sku
        Task<Product> GetById(string code); //por sku, el model va dentro de la task e instancia GetById
        //void CreateProduct(Product p); //crear
        Task CreateProduct(Product p); //crear
        //void ModifyProduct(Product p); //modificar
        Task ModifyProduct(Product p); //modificar
        //void DeleteProduct(string code); //eliminar
        Task DeleteProduct(string code); //eliminar
    }
}
