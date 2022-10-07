using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;

namespace ApiRest.Model.Repo
{
    public class MemoryProduct
    {
        private readonly List<Product> products = new()
        {
            new Product
            {
                Id = 1, Name = "Martillo", Description = "Descripción 1", Price = 10, DateUpload = DateTime.Now
            },
            new Product
            {
                Id = 2, Name = "Clavos", Description = "Descripción 2", Price = 20, DateUpload = DateTime.Now
            },
            new Product
            {
                Id = 3, Name = "Bombilla", Description = "Descripción 3", Price = 30, DateUpload = DateTime.Now
            }
        };
        public IEnumerable<Product> GetAll() //Devuelve todos los productos
        {
            return products;
        }
        public Product GetById(int id) //Devuelve un producto por su id
        {
            return products.SingleOrDefault(p => p.Id == id);
        }
    }
}
