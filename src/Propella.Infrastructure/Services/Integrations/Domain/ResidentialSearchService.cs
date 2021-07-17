using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.Api.V1.Api;
using Domain.Api.V1.Model;
using Propella.Application.Interfaces;

namespace Propella.Infrastructure.Services.Integrations.Domain
{
    public class ResidentialSearchService : IResidentialSearchService
    {
        private readonly IListingsApiAsync _listingsApi;

        public ResidentialSearchService(IListingsApiAsync listingsApi)
        {
            _listingsApi = listingsApi;
        }
        
        public async Task<int> GetCountAsync()
        {
            var result = await _listingsApi.ListingsDetailedResidentialSearchAsync(
                new DomainSearchServiceV2ModelDomainSearchWebApiV2ModelsSearchParameters
                {
                    ListingType = DomainSearchServiceV2ModelDomainSearchWebApiV2ModelsSearchParameters.ListingTypeEnum
                        .Sale,
                    PropertyTypes =
                        new List<DomainSearchServiceV2ModelDomainSearchWebApiV2ModelsSearchParameters.PropertyTypesEnum>
                        {
                            DomainSearchServiceV2ModelDomainSearchWebApiV2ModelsSearchParameters.PropertyTypesEnum.House
                        },
                    MinBedrooms = 2,
                    MaxPrice = 1500000,
                    Locations = new List<DomainSearchServiceV2ModelDomainSearchWebApiV2ModelsSearchLocation>
                    {
                        new DomainSearchServiceV2ModelDomainSearchWebApiV2ModelsSearchLocation
                        {
                            State = DomainSearchServiceV2ModelDomainSearchWebApiV2ModelsSearchLocation.StateEnum.NSW,
                            Suburb = "Hornsby",
                            IncludeSurroundingSuburbs = false
                        }
                    }
                });

            return result.Count;
        }
    }
}