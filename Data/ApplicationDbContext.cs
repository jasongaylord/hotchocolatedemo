using Microsoft.EntityFrameworkCore;

namespace hotchocolatedemo.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        { }

        public DbSet<Manufacturer> Manufacturers { get; set; } = default!;
        public DbSet<Product> Products { get; set; } = default!;
    }
}