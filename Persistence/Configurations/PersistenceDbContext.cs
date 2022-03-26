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

            modelBuilder.Entity<City>().HasData(
                new City("Cidade N").AddAccommodation(new Accommodation("Acomodação A", 5)),
                new City("Cidade S").AddAccommodation(new Accommodation("Acomodação B", 5)),
                new City("Cidade L").AddAccommodation(new Accommodation("Acomodação C", 5)),
                new City("Cidade O").AddAccommodation(new Accommodation("Acomodação D", 5))
                );
        }
    }
}