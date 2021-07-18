using System.Threading;
using System.Threading.Tasks;
using Propella.Application.Interfaces;
using Propella.Application.Results;

namespace Propella.Application.Queries.GetDemographics
{
    public record GetDemographicsQuery(int? SomeVar)  : IQuery<Response<int>>
    {
        public class GetDemographicsQueryHandler : IQueryHandler<GetDemographicsQuery, Response<int>>
        {
            private readonly IDemographicsService _demographicsService;

            public GetDemographicsQueryHandler(IDemographicsService demographicsService)
            {
                _demographicsService = demographicsService;
            }
            
            public async Task<Response<int>> Handle(GetDemographicsQuery request, CancellationToken cancellationToken)
            {
                return new(await _demographicsService.GetCountAsync());
            }
        }
    }
}