using System.Threading;
using System.Threading.Tasks;
using Propella.Application.Interfaces;
using Propella.Domain.Results;

namespace Propella.Application.Queries
{
    public record GetResidentialSearch : IQuery<Response<int>>
    {
        public class GetResidentialSearchHandler : IQueryHandler<GetResidentialSearch, Response<int>>
        {
            private readonly IResidentialSearchService _residentialSearchService;

            public GetResidentialSearchHandler(IResidentialSearchService residentialSearchService)
            {
                _residentialSearchService = residentialSearchService;
            }
            
            public async Task<Response<int>> Handle(GetResidentialSearch request, CancellationToken cancellationToken)
            {
                return new(await _residentialSearchService.GetCountAsync());
            }
        }
    }
}