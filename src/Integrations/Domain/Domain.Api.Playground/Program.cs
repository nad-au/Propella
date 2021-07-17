using System.Diagnostics;
using System.IO;
using Domain.Api.V2.Api;
using Domain.Api.V2.Client;
using Domain.Api.V2.Model;
using Microsoft.Extensions.Configuration;

namespace Domain.Api.Playground
{
    class Program
    {
        static void Main(string[] args)
        {
            var configuration = GetConfiguration();
            
            Configuration config = new Configuration();
            config.BasePath = configuration["Integrations:Domain:baseUrl"];
            config.ApiKey.Add("x-api-key", configuration["Integrations:Domain:apiKey"]);

            var apiInstance = new DemographicsApi(config);
            var state = "NSW";  // string | The Australian state abbreviation
            var suburb = "Pyrmont";  // string | Suburb name to retrieve data for
            var postcode = "2009";  // string | Suburb Post Code, optional, but required for suburbs with official post codes.
            var types = "Rent,TransportToWork";  // string | Comma separated list of census topics to retrieve demographic data for. Possible values include:              `AgeGroupOfPopulation`, `CountryOfBirth`, `NatureOfOccupancy`,              `Occupation`, `GeographicalPopulation`, `DwellingStructure`,              `EducationAttendance`, `HousingLoanRepayment`, `MaritalStatus`,              `Religion`, `TransportToWork`, `FamilyComposition`,              `HouseholdIncome`, `Rent`, `LabourForceStatus` (optional) 
            var year = 2016;  // int? | Census Year of data to return (optional) 

            try
            {
                // Search for demographics in a given geographic level.
                DemographicsV1DemographicsResults result = apiInstance.DemographicsGetByNamedSuburb(state, suburb, postcode, types, year);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DemographicsApi.DemographicsGetByNamedSuburb: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }        
        }
        
        private static IConfiguration GetConfiguration() => new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
            .AddEnvironmentVariables()
            .Build();
    }
}