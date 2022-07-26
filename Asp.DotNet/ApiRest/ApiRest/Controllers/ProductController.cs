﻿using System;
using ApiRest.Repo;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using ApiRest.DTO;
using ApiRest.Model;

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
        public IEnumerable<ProductDto> GetProducts()
        {
            var listProducts =
                _repo.GetAll().Select(p => p.Trans()); //Selecciona varios elementos y usa el modelo del DTO
            return listProducts;
        }

        [HttpGet("{code}")]
        public ActionResult<ProductDto> GetProduct(string code)
        {
            var product = _repo.GetById(code).Trans(); // Usa lo del DTO
            if (product == null)
            {
                return NotFound();
            }

            return product;
        }

        [HttpPost]
        public ActionResult<ProductDto> CreateProduct(ProductDto p)
        {
            Product product = new Product
            {
                //Id = _repo.GetAll().Max(x => x.Id) + 1, //No es necesario porque se genera automaticamente
                Name = p.Name,
                Description = p.Description,
                Price = p.Price,
                DateUpload = DateTime.Now,
                Sku = p.Sku
            };
            _repo.CreateProduct(product);
            return product.Trans();
        }

        [HttpPut("{code}")]
        public ActionResult<ProductUpdateDTO> UpdateProduct(ProductUpdateDTO p, string code)
        {
            var product = _repo.GetById(code);
            if (product == null)
            {
                return NotFound();
            }

            product.Name = p.Name;
            product.Description = p.Description;
            product.Price = p.Price;
            _repo.ModifyProduct(product);
            return product.TransUp();
        }
        [HttpDelete("{code}")]
        public ActionResult DeleteProduct(string code)
        {
            var product = _repo.GetById(code);
            if (product == null)
            {
                return NotFound();
            }

            _repo.DeleteProduct(code);
            return NoContent();
        }
    }
}
