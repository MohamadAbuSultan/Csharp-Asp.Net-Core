using Microsoft.EntityFrameworkCore;

namespace EFCore.Data
{
    class AppDbContext : DbContext
    {
        public string ConnectionString { get; }
        public AppDbContext()
        {
            ConnectionString = "";
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);
        }
    }
}
