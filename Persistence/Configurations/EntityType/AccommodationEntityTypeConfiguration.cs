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

            builder.OwnsOne(a => a.Address);
        }
    }
}
