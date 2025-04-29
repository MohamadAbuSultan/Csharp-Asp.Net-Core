using Microsoft.EntityFrameworkCore;

namespace Basic_CRUD_Operations.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // قلنا له: الكيان Product ارتبط بتيبل اسمه "Products"
            modelBuilder.Entity<Product>().ToTable("Products");
            // ملاحظة: ما كتبنا HasKey لأن اسم البرايمري كي "Id" والـ EF فاهم لحاله 
        }
    }
}
