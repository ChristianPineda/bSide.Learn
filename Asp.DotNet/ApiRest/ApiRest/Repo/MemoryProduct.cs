<<<<<<< HEAD
﻿//using System;
//using System.Collections.Generic;
//using ApiRest.Model;
=======
﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ApiRest.Model;
>>>>>>> 0e6be7f39ab43ff09865e85f30ef9d3970fa1793

//namespace ApiRest.Repo
//{
//    public class MemoryProduct: IMemoryProduct
//    {
//        private readonly List<Product> _products = new()
//        {
//            new Product
//            {
//                Id = 1, 
//                Name = "Martillo", 
//                Description = "Descripción 1", 
//                Price = 10, 
//                DateUpload = DateTime.Now,
//                Sku = "SKU1"
//            },
//            new Product
//            {
//                Id = 2, 
//                Name = "Clavos", 
//                Description = "Descripción 2", 
//                Price = 20, 
//                DateUpload = DateTime.Now,
//                Sku = "SKU2"
//            },
//            new Product
//            {
//                Id = 3, 
//                Name = "Bombilla", 
//                Description = "Descripción 3", 
//                Price = 30, 
//                DateUpload = DateTime.Now,
//                Sku = "SKU3"
//            }
//        };

<<<<<<< HEAD
//        public void CreateProduct(Product p)
//        {
//            _products.Add(p);
//        }
//        public IEnumerable<Product> GetAll()
//        {
//            return _products;
//        }

//        public Product GetById(string code)
//        {
//            return _products.Find(p => p.Sku == code);
//        }

//        public void ModifyProduct(Product p)
//        {
//            int index = _products.FindIndex(exists => exists.Sku == p.Sku);
//            _products [index] = p;
//        }
//        public void DeleteProduct(string code)
//        {
//            int index = _products.FindIndex(exists => exists.Sku == code);
//            _products.RemoveAt(index);
//        }
//    }
//}
=======
        public async Task CreateProduct(Product p)
        {
            _products.Add(p);
            await Task.CompletedTask;
        }
        public async Task<IEnumerable<Product>> GetAll()
        {
            return await Task.FromResult(_products);
        }

        public async Task<Product> GetById(string code)
        {
            return await Task.FromResult(_products.Find(p => p.Sku == code));
        }

        public async Task UpdateProduct(Product p)
        {
            int index = _products.FindIndex(exists => exists.Sku == p.Sku);
            _products [index] = p;
            await Task.CompletedTask;
        }
        public async Task DeleteProduct(string code)
        {
            int index = _products.FindIndex(exists => exists.Sku == code);
            _products.RemoveAt(index);
            await Task.CompletedTask;
        }
    }
}
>>>>>>> 0e6be7f39ab43ff09865e85f30ef9d3970fa1793
