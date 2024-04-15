using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Infrastructure.Models; // замените YourNamespace на вашу namespace

namespace Infrastructure.Data.Configurations // замените YourNamespace на вашу namespace
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
			builder.Property(eb => eb.CreatedDate);
			builder.Property(eb => eb.UpdatedDate);
			builder.HasOne(eb => eb.Payment).WithOne().HasForeignKey<EventBooking>(eb => eb.PaymentId);
		}
	}
}