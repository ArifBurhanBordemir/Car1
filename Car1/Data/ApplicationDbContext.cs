using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Car1.Models;

namespace Car1.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Car1.Models.Car> Car { get; set; } = default!;
        public DbSet<Car1.Models.Brand> Brand { get; set; } = default!;
    }
}
