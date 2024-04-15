using Domain.Common.BaseEntities;
using Domain.Enums;

namespace Domain.Models;

public class Payment : BaseEntity
{
    public Guid EventId { get; set; }
    public Guid EventBookingId { get; set; }
    public Guid ParticipantId { get; set; }
    public DateTime PaymentDate { get; set; }
    public float Price { get; set; }
    public bool Status { get; set; }


    public Event? Event { get; set; }
    public EventBooking? EventBooking { get; set; }
    public Participant? Participant { get; set; }
}