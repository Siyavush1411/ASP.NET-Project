using Domain.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.Configuration
{
    public class EventBookingConfiguration : IEntityTypeConfiguration<EventBooking>
    {
        public void Configure(EntityTypeBuilder<EventBooking> builder)
        {
            builder.HasKey(eb => eb.Id);
            builder.Property(eb => eb.EventId).IsRequired();
            builder.Property(eb => eb.ParticipantId);
            builder.Property(eb => eb.BookingDate);
            builder.Property(eb => eb.SeatId);
            builder.Property(eb => eb.CreatedDateTime);
            builder.Property(eb => eb.UpdatedDateTime);
            builder.HasOne(eb => eb.Payment).WithOne().HasForeignKey<EventBooking>(eb => eb.PaymentId);

            builder.HasOne(eb => eb.Seat)
            .WithMany(s => s.EventBookings)
            .HasForeignKey(eb => eb.SeatId);

            builder.HasOne(eb => eb.Ticket)
                .WithOne(t => t.EventBooking)
                .HasForeignKey(eb => eb.TicketId);


        }
    }
}