using ConferenceSuggestion.Application.Queries;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using static ConferenceSuggestion.Application.Queries.ListOfConferences.QueryHandler;

namespace RatingSystem.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuggestionsController : ControllerBase
    {
        private readonly MediatR.IMediator _mediator;

        public SuggestionsController(MediatR.IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Route("ListOfConference")]
        public async Task<List<Model>> GetListOfConference(CancellationToken cancellationToken)
        {
            var query = new ListOfConferences.Query();
            var result = await _mediator.Send(query, cancellationToken);
            return result;
        }
    }
}