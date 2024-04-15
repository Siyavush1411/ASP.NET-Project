using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Infrastructure.Models;  

namespace Infrastructure.Data.Configurations  
{
    public class OrganizerConfiguration : IEntityTypeConfiguration<Organizer>
    {
        public void Configure(EntityTypeBuilder<Organizer> builder)
        {
            builder.HasKey(o => o.Id);
            builder.Property(o => o.Name).IsRequired();
            builder.Property(o => o.ContactInformationId).IsRequired();
            builder.Property(o => o.Description);
            builder.Property(o => o.IsActive);
            builder.Property(o => o.CreatedDate);
            builder.Property(o => o.UpdatedDate);
        }
    }
}