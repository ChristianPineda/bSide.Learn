using ApiRest.Model;
using ApiRest.Model.Repo;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ApiRest.Controllers
{
    [Route("products")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly MemoryProduct repo;

        public ProductController()
        {
            repo = new MemoryProduct();
        }
        
        [HttpGet]
        public IEnumerable<Product> GetProducts()
        {
            var listProducts = repo.GetAll();
            return listProducts;
        }
        [HttpGet("{id}")]
        public ActionResult<Product> GetProduct(int id)
        {
            var product = repo.GetById(id);
            if (product == null)
            {
                return NotFound();
            }
            return product;
        }
    }
}
