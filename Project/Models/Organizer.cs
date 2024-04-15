using Domain.Common.BaseEntities;

namespace Domain.Models;

public class Organizer : BaseEntity
{
    public string Name { get; set; }
    public ContactInformation? ContactInformation { get; set; }
    public string Description { get; set; }
    public bool IsActive { get; set; }
}