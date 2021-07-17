# Domain.Api.V2.Api.DemographicsApi

All URIs are relative to *http://api.domain.com.au*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DemographicsGetByNamedSuburb**](DemographicsApi.md#demographicsgetbynamedsuburb) | **GET** /v2/demographics/{state}/{suburb}/{postcode} | Search for demographics in a given geographic level.
[**DemographicsGetByNamedSuburbWithoutPostcode**](DemographicsApi.md#demographicsgetbynamedsuburbwithoutpostcode) | **GET** /v2/demographics/{state}/{suburb} | Search for demographics in a given geographic level.


<a name="demographicsgetbynamedsuburb"></a>
# **DemographicsGetByNamedSuburb**
> DemographicsV1DemographicsResults DemographicsGetByNamedSuburb (string state, string suburb, string postcode, string types = null, int? year = null)

Search for demographics in a given geographic level.

<br>Where available, all available topics and years will be returned if not supplied.  <br>Note that not all suburbs will have data available for all years and topics.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Domain.Api.V2.Api;
using Domain.Api.V2.Client;
using Domain.Api.V2.Model;

namespace Example
{
    public class DemographicsGetByNamedSuburbExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://api.domain.com.au";
            // Configure API key authorization: apikey
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DemographicsApi(config);
            var state = NSW;  // string | The Australian state abbreviation
            var suburb = Pyrmont;  // string | Suburb name to retrieve data for
            var postcode = 2009;  // string | Suburb Post Code, optional, but required for suburbs with official post codes.
            var types = Rent,TransportToWork;  // string | Comma separated list of census topics to retrieve demographic data for. Possible values include:              `AgeGroupOfPopulation`, `CountryOfBirth`, `NatureOfOccupancy`,              `Occupation`, `GeographicalPopulation`, `DwellingStructure`,              `EducationAttendance`, `HousingLoanRepayment`, `MaritalStatus`,              `Religion`, `TransportToWork`, `FamilyComposition`,              `HouseholdIncome`, `Rent`, `LabourForceStatus` (optional) 
            var year = 2016;  // int? | Census Year of data to return (optional) 

            try
            {
                // Search for demographics in a given geographic level.
                DemographicsV1DemographicsResults result = apiInstance.DemographicsGetByNamedSuburb(state, suburb, postcode, types, year);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DemographicsApi.DemographicsGetByNamedSuburb: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **state** | **string**| The Australian state abbreviation | 
 **suburb** | **string**| Suburb name to retrieve data for | 
 **postcode** | **string**| Suburb Post Code, optional, but required for suburbs with official post codes. | 
 **types** | **string**| Comma separated list of census topics to retrieve demographic data for. Possible values include:              &#x60;AgeGroupOfPopulation&#x60;, &#x60;CountryOfBirth&#x60;, &#x60;NatureOfOccupancy&#x60;,              &#x60;Occupation&#x60;, &#x60;GeographicalPopulation&#x60;, &#x60;DwellingStructure&#x60;,              &#x60;EducationAttendance&#x60;, &#x60;HousingLoanRepayment&#x60;, &#x60;MaritalStatus&#x60;,              &#x60;Religion&#x60;, &#x60;TransportToWork&#x60;, &#x60;FamilyComposition&#x60;,              &#x60;HouseholdIncome&#x60;, &#x60;Rent&#x60;, &#x60;LabourForceStatus&#x60; | [optional] 
 **year** | **int?**| Census Year of data to return | [optional] 

### Return type

[**DemographicsV1DemographicsResults**](DemographicsV1DemographicsResults.md)

### Authorization

[apikey](../README.md#apikey), [oauth2](../README.md#oauth2), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Demographics data returned |  -  |
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="demographicsgetbynamedsuburbwithoutpostcode"></a>
# **DemographicsGetByNamedSuburbWithoutPostcode**
> DemographicsV1DemographicsResults DemographicsGetByNamedSuburbWithoutPostcode (string state, string suburb, string postcode, string types = null, int? year = null)

Search for demographics in a given geographic level.

<br>Where available, all available topics and years will be returned if not supplied.  <br>Note that not all suburbs will have data available for all years and topics.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Domain.Api.V2.Api;
using Domain.Api.V2.Client;
using Domain.Api.V2.Model;

namespace Example
{
    public class DemographicsGetByNamedSuburbWithoutPostcodeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://api.domain.com.au";
            // Configure API key authorization: apikey
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DemographicsApi(config);
            var state = NSW;  // string | The Australian state abbreviation
            var suburb = Pyrmont;  // string | Suburb name to retrieve data for
            var postcode = 2009;  // string | Suburb Post Code, optional, but required for suburbs with official post codes.
            var types = Rent,TransportToWork;  // string | Comma separated list of census topics to retrieve demographic data for. Possible values include:              `AgeGroupOfPopulation`, `CountryOfBirth`, `NatureOfOccupancy`,              `Occupation`, `GeographicalPopulation`, `DwellingStructure`,              `EducationAttendance`, `HousingLoanRepayment`, `MaritalStatus`,              `Religion`, `TransportToWork`, `FamilyComposition`,              `HouseholdIncome`, `Rent`, `LabourForceStatus` (optional) 
            var year = 2016;  // int? | Census Year of data to return (optional) 

            try
            {
                // Search for demographics in a given geographic level.
                DemographicsV1DemographicsResults result = apiInstance.DemographicsGetByNamedSuburbWithoutPostcode(state, suburb, postcode, types, year);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DemographicsApi.DemographicsGetByNamedSuburbWithoutPostcode: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **state** | **string**| The Australian state abbreviation | 
 **suburb** | **string**| Suburb name to retrieve data for | 
 **postcode** | **string**| Suburb Post Code, optional, but required for suburbs with official post codes. | 
 **types** | **string**| Comma separated list of census topics to retrieve demographic data for. Possible values include:              &#x60;AgeGroupOfPopulation&#x60;, &#x60;CountryOfBirth&#x60;, &#x60;NatureOfOccupancy&#x60;,              &#x60;Occupation&#x60;, &#x60;GeographicalPopulation&#x60;, &#x60;DwellingStructure&#x60;,              &#x60;EducationAttendance&#x60;, &#x60;HousingLoanRepayment&#x60;, &#x60;MaritalStatus&#x60;,              &#x60;Religion&#x60;, &#x60;TransportToWork&#x60;, &#x60;FamilyComposition&#x60;,              &#x60;HouseholdIncome&#x60;, &#x60;Rent&#x60;, &#x60;LabourForceStatus&#x60; | [optional] 
 **year** | **int?**| Census Year of data to return | [optional] 

### Return type

[**DemographicsV1DemographicsResults**](DemographicsV1DemographicsResults.md)

### Authorization

[apikey](../README.md#apikey), [oauth2](../README.md#oauth2), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Demographics data returned |  -  |
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

