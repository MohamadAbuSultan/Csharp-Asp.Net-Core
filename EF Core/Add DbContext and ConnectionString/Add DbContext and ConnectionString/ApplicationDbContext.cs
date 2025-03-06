using Microsoft.EntityFrameworkCore;

namespace Add_DbContext_and_ConnectionString
{
    public class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\\ProjectModels;Initial Catalog=EFCore;Integrated Security=True;");

        public DbSet<Employee> Employees { get; set; }
    }
}
