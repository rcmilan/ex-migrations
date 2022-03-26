using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Persistence.Configurations.EntityType;

namespace Persistence.Configurations
{
    internal class PersistenceDbContext : DbContext
    {
        public PersistenceDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Accommodation> Accommodations { get; set; }
        public DbSet<City> Cities { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseLazyLoadingProxies();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new AccommodationEntityTypeConfiguration());
        }
    }
}