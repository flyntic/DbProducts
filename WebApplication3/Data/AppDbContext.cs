using Microsoft.EntityFrameworkCore;
using WebApplication3.Model;

namespace WebApplication3.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
        
    }
}
