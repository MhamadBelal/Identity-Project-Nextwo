using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using NextwoIdentity2023.Models;

namespace NextwoIdentity2023.Data
{
    public class NextwoDbContext:IdentityDbContext
    {
        public NextwoDbContext(DbContextOptions<NextwoDbContext> options):base(options)
        {
            
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
