using MediatR;
using System;

namespace ConferenceSuggestion.PublishedLanguage.Events
{
    public class SuggestionCreated: INotification
    {
        public string Name { get; set; }
        public string OrganizerEmail { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public SuggestionCreated(string name, string organizerEmail, DateTime startDate, DateTime endDate)
        {
            Name = name;
            OrganizerEmail = organizerEmail;
            StartDate = startDate;
            EndDate = endDate;
        }
    }
}