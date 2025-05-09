using Microsoft.AspNetCore.Mvc;
using WebAPI2.Models;

namespace WebAPI2.Controllers
{
    [Route("api/[controller]")] // base route for the controller
    [ApiController]
    public class ProductsController : ControllerBase
    {
        ProductsContext db;
        public ProductsController(ProductsContext db)
        {
            this.db = db;
        }

        [HttpGet]
        public List<Product> Get()
        {
            return db.Products.ToList();
        }

        // [HttpGet("{id}")]
        [HttpGet("{id:int}")]
        public ActionResult GetProductById(int id)
        {
            Product? product = db.Products.Find(id);
            if (product == null) return NotFound();
            return Ok(product);
        }

        // [HttpGet("name/{name}")]
        [HttpGet("{name:alpha}")]
        public ActionResult GetProductByName(string name)
        {
            Product? product = db.Products.FirstOrDefault(p => p.Name == name);
            if (product == null) return NotFound();
            return Ok(product);
        }

        [HttpPost]
        public ActionResult Add(Product p)
        {
            if (ModelState.IsValid)
            {
                db.Products.Add(p);
                db.SaveChanges();
                return CreatedAtAction(nameof(GetProductById), new { id = p.Id }, p);
            }
            return BadRequest();
        }

        [HttpPut("{id}")]
        public ActionResult Edit(/*[FromBody]*/ int id, Product updatedProduct)
        {
            var product = db.Products.Find(id);
            if (product == null) return NotFound();

            if (!ModelState.IsValid) return BadRequest();

            db.Entry(product).CurrentValues.SetValues(updatedProduct);
            db.SaveChanges();
            return Ok(product);
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var product = db.Products.Find(id);
            if (product == null) return NotFound();

            db.Products.Remove(product);
            db.SaveChanges();
            return Ok(product);
        }
    }
}
