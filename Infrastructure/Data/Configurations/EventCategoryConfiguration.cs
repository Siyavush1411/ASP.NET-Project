using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Infrastructure.Models;  

namespace Infrastructure.Data.Configurations  
{
    public class EventCategoryConfiguration : IEntityTypeConfiguration<EventCategory>
    {
        public void Configure(EntityTypeBuilder<EventCategory> builder)
        {
            builder.HasKey(ec => ec.Id);
            builder.Property(ec => ec.Name).IsRequired();
            builder.Property(ec => ec.Description);
            builder.Property(ec => ec.IsActive);
            builder.Property(ec => ec.CreatedDate);
            builder.Property(ec => ec.UpdatedDate);
        }
    }
} 