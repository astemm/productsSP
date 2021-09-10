using ProductsSP.Models;
using ProductsSP.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ProductsSP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductsRepository productsRepository;

        public ProductsController(IProductsRepository productsRepository)
        {
            this.productsRepository = productsRepository;
        }
        
        // GET api/products
        [HttpGet]
        public ActionResult<List<Product>> GetProducts()
        {
            return Ok(productsRepository.GetAllProducts());
        }

        // GET api/products/5
        [HttpGet("{id}")]
        public ActionResult<Product> GetProduct(int id)
        {
            if (productsRepository.GetProduct(id)!= null)
            {
                return Ok(productsRepository.GetProduct(id));
            }
            else { return NotFound(); }

        }
    }
}