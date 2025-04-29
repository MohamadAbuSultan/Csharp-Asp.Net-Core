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


        //-------------------
        // GET: Get All Products
        //-------------------

        [HttpGet]
        [Route("")]
        public ActionResult<IEnumerable<Product>> GetAll(Product product)
        {
            var records = _dbContext.Set<Product>().ToList();
            return Ok(records);
        }



        //-------------------
        // GET: Get Product by Id
        //-------------------

        [HttpGet]
        [Route("{id}")]
        public ActionResult<Product> GetById(int id)
        {
            var record = _dbContext.Set<Product>().Find(id);
            return record == null ? NotFound() : Ok(record);
        }


        //-------------------
        // POST: Create New Product
        //-------------------

        [HttpPost]
        [Route("")]
        public ActionResult<int> CreateProduct(Product product)
        {
            product.Id = 0; // نخلي الـ Id صفر علشان SQL Server يحط Id جديد تلقائي
            _dbContext.Set<Product>().Add(product);
            _dbContext.SaveChanges();
            return Ok(product.Id); // رجعنا Id اللي انضاف
        }


        //-------------------
        // PUT: Update Product
        //-------------------

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

        //-------------------
        // DELETE: Delete Product
        //-------------------

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
