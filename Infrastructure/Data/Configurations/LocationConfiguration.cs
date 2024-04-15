using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Infrastructure.Models;  

namespace Infrastructure.Data.Configurations  
{
    public class LocationConfiguration : IEntityTypeConfiguration<Location>
    {
        public void Configure(EntityTypeBuilder<Location> builder)
        {
            builder.HasKey(l => l.Id);
            builder.Property(l => l.Name).IsRequired();
            builder.Property(l => l.Longitude);
            builder.Property(l => l.IsActive);
            builder.Property(l => l.CreatedDate);
            builder.Property(l => l.UpdatedDate);
        }
    }
}