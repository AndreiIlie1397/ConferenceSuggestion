using MediatR;
using System;

namespace ConferenceSuggestion.PublishedLanguage.Commands
{
    public class CreateSuggestionsCommand : IRequest
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public string OrganizerEmail { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

    }
}
