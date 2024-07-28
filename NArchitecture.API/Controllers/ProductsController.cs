using Microsoft.AspNetCore.Mvc;
using NArchitecture.Core.Entities;
using NArchitecture.Service;

namespace NArchitecture.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productservice;
        public ProductsController(IProductService productservice)
        {
            _productservice = productservice;
        }

        [HttpGet]
        public ActionResult <IEnumerable<Product>>GetAll()
        {
            return Ok(_productservice.GetAllProducts());
        }

        [HttpGet("{id}")]
        public ActionResult<Product> Get(int id)
        {
            var product = _productservice.GetProductById(id);

            if (product == null) { 
            
                return NotFound();
            }

            return Ok(product);
        }

        [HttpPost]
        public ActionResult Add([FromBody] Product product)
        {
            _productservice.AddProduct(product);
            return CreatedAtAction(nameof(Get), new { id = product.Id }, product);
        }

        [HttpPut("{id}")]
        public ActionResult Update(int id,[FromBody] Product product)
        {

            if (id != product.Id)
            {
                return BadRequest();

            }
            _productservice.UpdateProduct(product);
            return NoContent();

        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            _productservice.DeleteProduct(id);
            return NoContent();

        }

        [HttpGet("search/{name}")]
        public ActionResult <IEnumerable<Product>>Search(string name)
        {
             
            return Ok(_productservice.SearchByProductName(name));

        }
    }
}
