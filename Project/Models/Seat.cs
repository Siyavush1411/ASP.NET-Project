using Domain.Common.BaseEntities;

namespace Domain.Models;

public class Seat : BaseEntity
{
    public string Number { get; set; }
    public bool IsBusy { get; set; }
    public Guid LocationId { get; set; }
    public Location? Location { get; set; }
}