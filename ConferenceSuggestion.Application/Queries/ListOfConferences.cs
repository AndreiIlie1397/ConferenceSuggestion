using ConferenceSuggestion.Data;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using static ConferenceSuggestion.Application.Queries.ListOfConferences.QueryHandler;

namespace ConferenceSuggestion.Application.Queries
{
    public class ListOfConferences
    {

        public class Query : IRequest<List<Model>>
        {   
        }

        public class QueryHandler : IRequestHandler<Query, List<Model>>
        {
            private readonly ConferenceSuggestionDbContext _dbContext;

            public QueryHandler(ConferenceSuggestionDbContext dbContext)
            {
                _dbContext = dbContext;
            }

            public async Task<List<Model>> Handle(Query request, CancellationToken cancellationToken)
            {

                var db = _dbContext.Conferences;
                var result = db.Select(x => new Model
                {
                    Id = x.Id,
                    Name = x.Name,
                    OrganizerEmail = x.OrganizerEmail,
                    StartDate = x.StartDate,
                    EndDate = x.EndDate,
                    CategoryId = x.CategoryId,
                    LocationId = x.LocationId,
                    ConferenceTypeId = x.ConferenceTypeId
                }).Take(3).ToList();
                return await Task.FromResult(result);
            }

            public class Model
            {
                public int Id { get; set; }
                public string Name { get; set; }
                public string OrganizerEmail { get; set; }
                public DateTime StartDate { get; set; }
                public DateTime EndDate { get; set; }
                public int ConferenceTypeId { get; set; }
                public int CategoryId { get; set; }
                public int LocationId { get; set; }
            }
        }
    }
}