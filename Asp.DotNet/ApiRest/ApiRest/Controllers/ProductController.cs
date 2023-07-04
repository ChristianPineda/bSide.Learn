using System;
using ApiRest.Repo;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiRest.DTO;
using ApiRest.Model;
using System.Threading.Tasks;

namespace ApiRest.Controllers
{
    [Route("v1/products/storage/items")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IMemoryProduct _repo;

        public ProductController(IMemoryProduct r)
        {
            this._repo = r;
        }

        [HttpGet]
<<<<<<< HEAD
        public async Task<IEnumerable<ProductDto>> GetProducts() //add async task con body list of DTO
        {
            var listProducts =
                (await _repo.GetAll()).Select(p => p.Trans()); //Selecciona varios elementos y usa el modelo del DTO
=======
        public async Task<IEnumerable<ProductDto>> GetProducts()
        {
            var listProducts =
               (await _repo.GetAll()).Select(p => p.Trans()); //Selecciona varios elementos y usa el modelo del DTO
>>>>>>> 0e6be7f39ab43ff09865e85f30ef9d3970fa1793
            return listProducts;
        }

        [HttpGet("{code}")]
        public async Task<ActionResult<ProductDto>> GetProduct(string code)
        {
            var product = (await _repo.GetById(code)).Trans(); // Usa lo del DTO
<<<<<<< HEAD
            try
=======
            if (product == null)
>>>>>>> 0e6be7f39ab43ff09865e85f30ef9d3970fa1793
            {
                if (product == null)
                {
                    return BadRequest("Product not found");
                }
                return product;
            }
            catch (Exception e)
            {
                return BadRequest("Error: " + e);
            }
<<<<<<< HEAD
=======
            return product;
>>>>>>> 0e6be7f39ab43ff09865e85f30ef9d3970fa1793
        }

        [HttpPost]
        public async Task<ActionResult<ProductDto>> CreateProduct(ProductDto p)
        {
            Product product = new()
            {
                //Id = _repo.GetAll().Max(x => x.Id) + 1, //No es necesario porque se genera automaticamente en SQL
                Name = p.Name,
                Description = p.Description,
                Price = p.Price,
                DateUpload = DateTime.Now,
                Sku = p.Sku
            };
            await _repo.CreateProduct(product);
            return product.Trans();
        }

        [HttpPut("{code}")]
        public async Task<ActionResult<ProductUpdateDTO>> UpdateProduct(ProductUpdateDTO p, string code)
        {
            var product = await _repo.GetById(code);
            if (product == null)
            {
                return NotFound("Product not found");
            }

            product.Name = p.Name;
            product.Description = p.Description;
            product.Price = p.Price;
<<<<<<< HEAD
            await _repo.ModifyProduct(product);
=======

            await _repo.UpdateProduct(product);
            
>>>>>>> 0e6be7f39ab43ff09865e85f30ef9d3970fa1793
            return product.TransUp();
        }
        [HttpDelete("{code}")]
        public async Task<ActionResult> DeleteProduct(string code)
        {
            var product = await _repo.GetById(code);
            if (product == null)
            {
                return NotFound();
            }

            await _repo.DeleteProduct(code);
            return NoContent();
        }
    }
}
