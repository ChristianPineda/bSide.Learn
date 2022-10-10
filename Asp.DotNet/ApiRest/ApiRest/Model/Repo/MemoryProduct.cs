using System;
using System.Collections.Generic;

namespace ApiRest.Model.Repo
{
    public class MemoryProduct: IMemoryProduct
    {
        private readonly List<Product> _products = new()
        {
            new Product
            {
                Id = 1, 
                Name = "Martillo", 
                Description = "Descripción 1", 
                Price = 10, 
                DateUpload = DateTime.Now,
                Sku = "SKU1"
            },
            new Product
            {
                Id = 2, 
                Name = "Clavos", 
                Description = "Descripción 2", 
                Price = 20, 
                DateUpload = DateTime.Now,
                Sku = "SKU2"
            },
            new Product
            {
                Id = 3, 
                Name = "Bombilla", 
                Description = "Descripción 3", 
                Price = 30, 
                DateUpload = DateTime.Now,
                Sku = "SKU3"
            }
        };

        public void CreateProduct(Product p)
        {
            _products.Add(p);
        }

        public IEnumerable<Product> GetAll()
        {
            return _products;
        }

        public Product GetById(string code)
        {
            return _products.Find(p => p.Sku == code);
        }

        public void ModifyProduct(Product p)
        {
            int index = _products.FindIndex(exists => exists.Sku == p.Sku);
            _products [index] = p;
        }
    }
}
