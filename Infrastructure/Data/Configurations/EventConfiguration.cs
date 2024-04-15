using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Infrastructure.Models; 

namespace Infrastructure.Data.Configurations  
{
    public class EventConfiguration : IEntityTypeConfiguration<Event>
    {
        public void Configure(EntityTypeBuilder<Event> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Name).IsRequired();
            builder.Property(e => e.Description);
            builder.Property(e => e.DateTime).IsRequired();
            builder.Property(e => e.LocationId).IsRequired();
            builder.Property(e => e.EventCategoryId).IsRequired();
            builder.Property(e => e.OrganizerId).IsRequired();
            builder.Property(e => e.UpdatedDate);
            builder.Property(e => e.CreatedDate);
        }
    }
}