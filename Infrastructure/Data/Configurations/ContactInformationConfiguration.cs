using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Infrastructure.Models; /

namespace Infrastructure.Data.Configurations 
{
    public class ContactInformationConfiguration : IEntityTypeConfiguration<ContactInformation>
    {
        public void Configure(EntityTypeBuilder<ContactInformation> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Phone);
            builder.Property(c => c.Email);
            builder.Property(c => c.Telegram);
            builder.Property(c => c.Instagram);
            builder.Property(c => c.Facebook);
        }
    }
}