using Domain.Common.BaseEntities;

namespace Domain.Models;

public class Location : BaseEntity
{
    public string Name { get; set; }
    public string Longitude { get; set; }
    public string Latitude { get; set; }
    public bool IsActive { get; set; }
    
}