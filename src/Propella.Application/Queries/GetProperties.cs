using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Propella.Application.Results;
using Propella.Domain;

namespace Propella.Application.Queries
{
    public record GetProperties : IQuery<Response<ICollection<Property>>>
    {
        public class GetPropertiesHandler : IQueryHandler<GetProperties, Response<ICollection<Property>>>
        {
            public Task<Response<ICollection<Property>>> Handle(GetProperties request, CancellationToken cancellationToken)
            {
                return Task.FromResult(new Response<ICollection<Property>>(new List<Property>
                {
                    new() {Address = "123 East St", Bedrooms = 2, BuildingType = "Home"},
                    new() {Address = "12/3 George St", Bedrooms = 1, BuildingType = "Unit"},
                }));
            }
        }
    }
}