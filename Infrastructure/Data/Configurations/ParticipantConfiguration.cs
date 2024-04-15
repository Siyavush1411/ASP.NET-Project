using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Infrastructure.Models; 

namespace Infrastructure.Data.Configurations 
{
    public class ParticipantConfiguration : IEntityTypeConfiguration<Participant>
    {
        public void Configure(EntityTypeBuilder<Participant> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Username).IsRequired();
            builder.Property(p => p.FirstName).IsRequired();
            builder.Property(p => p.LastName).IsRequired();
            builder.Property(p => p.MiddleName);
            builder.Property(p => p.Position);
            builder.Property(p => p.ContactInformationId).IsRequired();
            builder.Property(p => p.CreatedDate);
            builder.Property(p => p.UpdatedDate);
        }
    }
}