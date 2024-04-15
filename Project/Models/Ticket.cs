using Domain.Common.BaseEntities;
using Domain.Enums;

namespace Domain.Models;

public class EventBooking : BaseEntity
{
    public Guid EventId { get; set; }
    public Guid EventBookingId { get; set; }
    public Guid ParticipantId { get; set; }
    public Guid SeatId { get; set; }
    public DateTime EventDate { get; set; }
    public bool IsActive { get; set; }


    public Event? Event { get; set; }
    public EventBooking? EventBooking { get; set; }
    public Participant? Participant { get; set; }
    public Seat? Seat { get; set; }
}