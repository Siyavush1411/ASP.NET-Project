using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Infrastructure.Models;  

namespace Infrastructure.Data.Configurations  
{
    public class TicketConfiguration : IEntityTypeConfiguration<Ticket>
    {
        public void Configure(EntityTypeBuilder<Ticket> builder)
        {
            builder.HasKey(t => t.Id);
            builder.Property(t => t.EventId).IsRequired();
            builder.Property(t => t.EventBookingId);
            builder.Property(t => t.Participantid);
            builder.Property(t => t.Seatid);
            builder.Property(t => t.IsActive);
            builder.Property(t => t.CreatedDate);
            builder.Property(t => t.UpdatedDate);
        }
    }
}