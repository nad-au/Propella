using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.Api.V1.Client.Api;
using Domain.Api.V1.Client.Client;
using Domain.Api.V1.Client.Model;
using Microsoft.Extensions.Configuration;
using Propella.Application.Interfaces;

namespace Propella.Infrastructure.Services.Domain
{
    public class ResidentialSearchService : IResidentialSearchService
    {
        private readonly IConfiguration _configuration;

        public ResidentialSearchService(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        
        public async Task<int> GetCountAsync()
        {
            Configuration config = new Configuration();
            config.BasePath = _configuration["Integrations:Domain:baseUrl"];
            config.ApiKey.Add("x-api-key", _configuration["Integrations:Domain:apiKey"]);

            var apiInstance = new ListingsApi(config);
            
            var result = await apiInstance.ListingsDetailedResidentialSearchAsync(
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