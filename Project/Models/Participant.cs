using Domain.Common.BaseEntities;
using Domain.Enums;

namespace Domain.Models
{
    public class Participant
    {
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string Position { get; set; }
        public ContactInformation? ContactInformation { get; set; }
        public bool IsActive { get; set; }
    }
}
