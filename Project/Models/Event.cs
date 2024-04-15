using Domain.Common.BaseEntities;
using Domain.Enums;

namespace Domain.Models;

public class Event : BaseEntity
{
    public string Name { get; set; }
    public string Description { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public Guid LocationId { get; set; }
    public EventCategory Category { get; set; }
    public Location? Location { get; set; }

    public ICollection<Participant>? Participants { get; set; }
    public ICollection<Organizer>? Organizers { get; set; }
}