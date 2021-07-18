using System.Threading;
using System.Threading.Tasks;
using Propella.Application.Interfaces;
using Propella.Application.Results;

namespace Propella.Application.Queries.GetResidentialSearch
{
    public record GetResidentialSearchQuery : IQuery<Response<int>>
    {
        public class GetResidentialSearchQueryHandler : IQueryHandler<GetResidentialSearchQuery, Response<int>>
        {
            private readonly IResidentialSearchService _residentialSearchService;

            public GetResidentialSearchQueryHandler(IResidentialSearchService residentialSearchService)
            {
                _residentialSearchService = residentialSearchService;
            }
            
            public async Task<Response<int>> Handle(GetResidentialSearchQuery request, CancellationToken cancellationToken)
            {
                return new(await _residentialSearchService.GetCountAsync());
            }
        }
    }
}