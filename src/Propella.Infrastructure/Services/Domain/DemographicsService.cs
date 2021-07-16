using System.Threading.Tasks;
using Domain.Api.V2.Client.Api;
using Domain.Api.V2.Client.Client;
using Microsoft.Extensions.Configuration;
using Propella.Application.Interfaces;

namespace Propella.Infrastructure.Services.Domain
{
    public class DemographicsService : IDemographicsService
    {
        private readonly IConfiguration _configuration;

        public DemographicsService(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        
        public async Task<int> GetCountAsync()
        {
            Configuration config = new Configuration();
            config.BasePath = _configuration["Integrations:Domain:baseUrl"];
            config.ApiKey.Add("x-api-key", _configuration["Integrations:Domain:apiKey"]);

            var apiInstance = new DemographicsApi(config);
            var state = "NSW";  // string | The Australian state abbreviation
            var suburb = "Pyrmont";  // string | Suburb name to retrieve data for
            var postcode = "2009";  // string | Suburb Post Code, optional, but required for suburbs with official post codes.
            var types = "Rent,TransportToWork";  // string | Comma separated list of census topics to retrieve demographic data for. Possible values include:              `AgeGroupOfPopulation`, `CountryOfBirth`, `NatureOfOccupancy`,              `Occupation`, `GeographicalPopulation`, `DwellingStructure`,              `EducationAttendance`, `HousingLoanRepayment`, `MaritalStatus`,              `Religion`, `TransportToWork`, `FamilyComposition`,              `HouseholdIncome`, `Rent`, `LabourForceStatus` (optional) 
            var year = 2016;  // int? | Census Year of data to return (optional) 

            var result = await apiInstance.DemographicsGetByNamedSuburbAsync(state, suburb, postcode, types, year);
            return result.Demographics.Count;
        }
    }
}