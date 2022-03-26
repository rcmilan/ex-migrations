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
            modelBuilder.ApplyConfiguration(new CityEntityTypeConfiguration());
            
            SeedData(modelBuilder);
        }

        private static void SeedData(ModelBuilder modelBuilder)
        {
            List<City> cities = new()
            {
                new City("Cidade N") { Id = Guid.Parse("0a6ad2fe-6318-454f-907e-a67b0893537a") },
                new City("Cidade S") { Id = Guid.Parse("0a6bd2fe-6318-454f-907e-b67b0893537a") },
                new City("Cidade L") { Id = Guid.Parse("0a6cd2fe-6318-454f-907e-c67b0893537a") },
                new City("Cidade O") { Id = Guid.Parse("0a6dd2fe-6318-454f-907e-d67b0893537a") }
            };

            modelBuilder.Entity<City>().HasData(cities);
        }
    }
}