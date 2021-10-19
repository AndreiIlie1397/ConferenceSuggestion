using System;

#nullable disable

namespace ConferenceSuggestion.Models
{
    public partial class Conference
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string OrganizerEmail { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int StatusId { get; set; }
        public int CategoryId { get; set; }
        public int LocationId { get; set; }
        public int ConferenceTypeId { get; set; }
    }
}
