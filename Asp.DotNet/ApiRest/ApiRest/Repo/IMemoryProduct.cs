<<<<<<< HEAD
﻿using System.Collections;
using System.Collections.Generic;
=======
﻿using System.Collections.Generic;
>>>>>>> 0e6be7f39ab43ff09865e85f30ef9d3970fa1793
using System.Threading.Tasks;
using ApiRest.Model;

namespace ApiRest.Repo
{
    public interface IMemoryProduct
    {
<<<<<<< HEAD
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
=======
        Task<IEnumerable<Product>> GetAll(); //lista

        Task<Product> GetById(string code); //por sku
        Task CreateProduct(Product p); //crear
        
        Task UpdateProduct(Product p); //modificar
>>>>>>> 0e6be7f39ab43ff09865e85f30ef9d3970fa1793
        Task DeleteProduct(string code); //eliminar
    }
}
