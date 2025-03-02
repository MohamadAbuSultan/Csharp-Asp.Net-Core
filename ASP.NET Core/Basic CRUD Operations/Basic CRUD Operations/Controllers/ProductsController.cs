using Basic_CRUD_Operations.Data;
using Microsoft.AspNetCore.Mvc;

namespace Basic_CRUD_Operations.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly ApplicationDbContext _dbContext;

        public ProductsController(ApplicationDbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        [HttpGet]
        [Route("")]
        public ActionResult<IEnumerable<Product>> GetAll(Product product)
        {
            var records = _dbContext.Set<Product>().ToList();
            return Ok(records);
        }

        [HttpGet]
        [Route("{id}")]
        public ActionResult<Product> GetById(int id)
        {
            var record = _dbContext.Set<Product>().Find(id);
            return record == null ? NotFound() : Ok(record);
        }

        [HttpPost]
        [Route("")]
        public ActionResult<int> CreateProduct(Product product)
        {
            product.Id = 0;
            _dbContext.Set<Product>().Add(product);
            _dbContext.SaveChanges();
            return Ok(product.Id);
        }

        [HttpPut]
        [Route("")]
        public ActionResult UpdateProduct(Product product)
        {
            var existingProduct = _dbContext.Set<Product>().Find(product.Id);
            existingProduct.Name = product.Name;
            existingProduct.Sku = product.Sku;
            _dbContext.Set<Product>().Update(existingProduct);
            _dbContext.SaveChanges();
            return Ok();
        }

        [HttpDelete]
        [Route("{id}")]
        public ActionResult DeleteProduct(int id)
        {
            var existingProduct = _dbContext.Set<Product>().Find(id);
            _dbContext.Set<Product>().Remove(existingProduct);
            _dbContext.SaveChanges();
            return Ok();
        }
    }
}
