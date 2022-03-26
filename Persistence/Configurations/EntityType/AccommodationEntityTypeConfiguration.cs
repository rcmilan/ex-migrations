using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configurations.EntityType
{
    internal class AccommodationEntityTypeConfiguration : IEntityTypeConfiguration<Accommodation>
    {
        public void Configure(EntityTypeBuilder<Accommodation> builder)
        {
            builder.HasKey(a => a.Id);

            builder.Property(a => a.Id).ValueGeneratedOnAdd();
            builder.Property(a => a.Name);
            builder.Property(a => a.Rooms);

            builder.OwnsMany(a => a.Addresses, a =>
            {
                a.HasKey(a => a.Id);
                a.Property(a => a.Id).ValueGeneratedOnAdd();
                a.Property(a => a.Street);
                a.Property(a => a.District);
                a.Property(a => a.ZipCode);
                a.Property(a => a.Number);
                a.Property(a => a.Complement);
            });
        }
    }
}
