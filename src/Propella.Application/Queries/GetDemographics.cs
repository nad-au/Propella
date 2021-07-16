using System.Threading;
using System.Threading.Tasks;
using Propella.Application.Interfaces;
using Propella.Domain.Results;

namespace Propella.Application.Queries
{
    public record GetDemographics : IQuery<Response<int>>
    {
        public class GetDemographicsHandler : IQueryHandler<GetDemographics, Response<int>>
        {
            private readonly IDemographicsService _demographicsService;

            public GetDemographicsHandler(IDemographicsService demographicsService)
            {
                _demographicsService = demographicsService;
            }
            
            public async Task<Response<int>> Handle(GetDemographics request, CancellationToken cancellationToken)
            {
                return new(await _demographicsService.GetCountAsync());
            }
        }
    }
}