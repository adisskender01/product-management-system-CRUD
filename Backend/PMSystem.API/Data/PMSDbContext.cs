using Microsoft.EntityFrameworkCore;
using PMSystem.API.Models;

namespace PMSystem.API.Data
{
    public class PMSDbContext : DbContext
    {
        public PMSDbContext(DbContextOptions options) : base(options)
        {
            
        }
        public DbSet<Product> Products { get; set; }
    }
}
