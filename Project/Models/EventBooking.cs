using Domain.Common.BaseEntities;
using Domain.Enums;

namespace Domain.Models;

public class EventBooking : BaseEntity
{
    public Guid EventId { get; set; }
    public Guid ParticipantId { get; set; }
    public Guid SeatId { get; set; }
    public Guid PaymentId { get; set; }
    public DateOnly BookingDate { get; set; }

    public Event? Event { get; set; }
    public Participant? Participant { get; set; }
    public Seat? Seat { get; set; }
    public Payment? Payment { get; set; }
}