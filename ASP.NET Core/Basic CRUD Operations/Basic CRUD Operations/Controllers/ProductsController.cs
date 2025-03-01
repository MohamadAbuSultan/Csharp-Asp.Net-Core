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

        [HttpPost]
        [Route("")]
        public ActionResult<int> CreateProduct(Product product)
        {
            product.Id = 0;
            _dbContext.Set<Product>().Add(product);
            _dbContext.SaveChanges();
            return Ok(product.Id);
        }
    }
}
