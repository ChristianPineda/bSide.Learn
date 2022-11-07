using System.Collections.Generic;
using ApiRest.Model;

namespace ApiRest.Repo
{
    public interface IMemoryProduct
    {
        IEnumerable<Product> GetAll(); //lista

        Product GetById(string code); //por sku
        void CreateProduct(Product p); //crear

        void UpdateProduct(Product p); //modificar
        void DeleteProduct(string code); //eliminar
    }
}
