using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configurations.EntityType
{
    internal class CityEntityTypeConfiguration : IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id).ValueGeneratedOnAdd();
            builder.Property(c => c.Name);
            builder.Property(c => c.Foundation);

            builder.HasMany(c => c.Schools)
                .WithOne(s => s.City);

            builder.Ignore(c => c.Accommodations);

            builder.OwnsMany(c => c.CityAccommodations, c => {
                c.HasKey(c => c.Id);

                c.Property(c => c.Id).ValueGeneratedOnAdd();

                c.WithOwner(c => c.City);
            });
        }
    }
}
