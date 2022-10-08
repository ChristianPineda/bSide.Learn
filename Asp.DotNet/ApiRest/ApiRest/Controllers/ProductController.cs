using ApiRest.Model.Repo;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using ApiRest.DTO;

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
        public IEnumerable<ProductDto> GetProducts()
        {
            var listProducts = _repo.GetAll().Select(p => p.Trans()); //Selecciona varios elementos y usa el modelo del DTO
            return listProducts;
        }
        
        [HttpGet("{code}")]
        public ActionResult<ProductDto> GetProduct(string code)
        {
            var product = _repo.GetById(code).Trans();// Usa lo del DTO
            if (product == null)
            {
                return NotFound();
            }
            return product;
        }
    }
}
