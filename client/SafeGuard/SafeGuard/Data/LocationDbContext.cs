using Microsoft.EntityFrameworkCore;
using SafeGuard.Models;

namespace SafeGuard.Data
{
    public class LocationDbContext : DbContext
    {
        public LocationDbContext(DbContextOptions<LocationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Location> Location { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Location>().ToTable("location");
        }
    }
}