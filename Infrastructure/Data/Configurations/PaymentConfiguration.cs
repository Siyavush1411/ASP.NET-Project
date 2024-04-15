using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Infrastructure.Models;  

namespace Infrastructure.Data.Configurations  
{
    public class PaymentConfiguration : IEntityTypeConfiguration<Payment>
    {
        public void Configure(EntityTypeBuilder<Payment> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.EventBookingId).IsRequired();
            builder.Property(p => p.ParticipantId).IsRequired();
            builder.Property(p => p.Status).IsRequired();
            builder.Property(p => p.PaymentDate);
        }
    }
}