using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Propella.Application.Results;
using Propella.Domain;

namespace Propella.Application.Queries.GetProperties
{
    public record GetPropertiesQuery : IQuery<Response<ICollection<Property>>>
    {
        public class GetPropertiesQueryHandler : IQueryHandler<GetPropertiesQuery, Response<ICollection<Property>>>
        {
            public Task<Response<ICollection<Property>>> Handle(GetPropertiesQuery request, CancellationToken cancellationToken)
            {
                return Task.FromResult(new Response<ICollection<Property>>(new List<Property>
                {
                    new() {Address = "123 East St", Bedrooms = 2, BuildingType = "Home"},
                    new() {Address = "42 Burdett St", Bedrooms = 1, BuildingType = "Unit"},
                }));
            }
        }
    }
}