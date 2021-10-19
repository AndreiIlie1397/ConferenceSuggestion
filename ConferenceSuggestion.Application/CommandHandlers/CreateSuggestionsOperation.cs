using ConferenceSuggestion.Data;
using ConferenceSuggestion.Models;
using ConferenceSuggestion.PublishedLanguage.Commands;
using MediatR;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace RatingSystem.Application.WriteOperations
{
    public class CreateSuggestionsOperation : IRequestHandler<CreateSuggestionsCommand>
    {
        private readonly ConferenceSuggestionDbContext _dbContext;

        public CreateSuggestionsOperation(ConferenceSuggestionDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task<Unit> Handle(CreateSuggestionsCommand request, CancellationToken cancellationToken)
        {
            Conference conference = new();

            if (request.Id.HasValue)
            {
                conference = _dbContext.Conferences.FirstOrDefault(x => x.Id == request.Id);
            }
            if (conference == null)
            {
                throw new Exception("Person not found");
            }

            return Task.FromResult(Unit.Value);
        }        
    }
}