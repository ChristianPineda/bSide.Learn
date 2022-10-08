using ApiRest.Model;
using ApiRest.Model.Repo;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ApiRest.Controllers
{
    [Route("products")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IMemoryProduct _repo;

        public ProductController(IMemoryProduct r)
        {
            this._repo = r;
        }

        [HttpGet]
        public IEnumerable<Product> GetProducts()
        {
            var listProducts = _repo.GetAll();
            return listProducts;
        }
        
        [HttpGet("{id}")]
        public ActionResult<Product> GetProduct(int id)
        {
            var product = _repo.GetById(id);
            if (product == null)
            {
                return NotFound();
            }
            return product;
        }
    }
}
