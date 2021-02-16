using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Data.LimeZander.Model;
using Data.LimeZander.Persistence.Repositories.Interfaces;

namespace Middleware.LimeZander.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly IProductRepository _productRepository;

        public ProductsController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        // GET: api/Products
        [HttpGet]
        [Route("")]
        public ActionResult<IEnumerable<Product>> GetProducts()
        {
            return _productRepository.GetProducts().ToList();
        }

        // GET: api/Products/0
        [HttpGet]
        [Route("products/{type}")]
        public ActionResult<IEnumerable<Product>> GetCategory(ProductType type)
        {
            return _productRepository.GetProductTypes(type).ToList();
        }

        // GET: api/Product/5
        [HttpGet]
        [Route("{id}")]
        public ActionResult<Product> GetProduct(int id)
        {
            var product = _productRepository.GetProduct(id);

            if (product == null)
            {
                return NotFound();
            }

            return product;
        }


        // POST: api/Products
        [HttpPost]
        [Route("")]
        public IActionResult PostProduct(Product product)
        {
            _productRepository.AddProduct(product);

            return Ok(product);
        }

        // PUT: api/Product/5
        [HttpPut]
        [Route("{id}")]
        public IActionResult PutProduct(int id, Product product)
        {
            if (id != product.Id)
            {
                return BadRequest();
            }

            _productRepository.UpdateProduct(product);

            return NoContent();
        }

        // DELETE: api/Products/5
        [HttpDelete]
        [Route("{id}")]
        public IActionResult DeleteProduct(int id)
        {
            var product = _productRepository.GetProduct(id);

            if (product == null)
            {
                return NotFound();
            }

            _productRepository.DeleteProduct(product);

            return NoContent();
        }             
    }
}
