using System.Threading.Tasks;
using Domain.Api.V2.Client.Api;
using Propella.Application.Interfaces;

namespace Propella.Infrastructure.Services.Integrations.Domain
{
    public class DemographicsService : IDemographicsService
    {
        private readonly IDemographicsApiAsync _demographicsApi;

        public DemographicsService(IDemographicsApiAsync demographicsApi)
        {
            _demographicsApi = demographicsApi;
        }
        
        public async Task<int> GetCountAsync()
        {
            var state = "NSW";  // string | The Australian state abbreviation
            var suburb = "Pyrmont";  // string | Suburb name to retrieve data for
            var postcode = "2009";  // string | Suburb Post Code, optional, but required for suburbs with official post codes.
            var types = "Rent,TransportToWork";  // string | Comma separated list of census topics to retrieve demographic data for. Possible values include:              `AgeGroupOfPopulation`, `CountryOfBirth`, `NatureOfOccupancy`,              `Occupation`, `GeographicalPopulation`, `DwellingStructure`,              `EducationAttendance`, `HousingLoanRepayment`, `MaritalStatus`,              `Religion`, `TransportToWork`, `FamilyComposition`,              `HouseholdIncome`, `Rent`, `LabourForceStatus` (optional) 
            var year = 2016;  // int? | Census Year of data to return (optional) 

            var result = await _demographicsApi.DemographicsGetByNamedSuburbAsync(state, suburb, postcode, types, year);
            return result.Demographics.Count;
        }
    }
}