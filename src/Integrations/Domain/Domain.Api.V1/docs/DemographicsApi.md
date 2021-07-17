# Domain.Api.V1.Api.DemographicsApi

All URIs are relative to *http://api.domain.com.au*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DemographicsGet**](DemographicsApi.md#demographicsget) | **GET** /v1/demographics | Retrieves demographic information


<a name="demographicsget"></a>
# **DemographicsGet**
> DomainDemographicsServiceV1ModelDemographicsResultsModel DemographicsGet (string level, int id, string types = null, string year = null)

Retrieves demographic information

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Domain.Api.V1.Api;
using Domain.Api.V1.Client;
using Domain.Api.V1.Model;

namespace Example
{
    public class DemographicsGetExample
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
            var level = level_example;  // string | Geographic level.  Valid values are: `Postcode`, `Suburb`
            var id = 56;  // int | Location identifier. If the geographic level is Suburb this is a Suburb ID value, if the geographic level is postcode this is a Postcode ID value.  See the `/addressLocators` endpoint.
            var types = types_example;  // string | Comma separated list of demographic data requested. If not provided, all data will be returned. Valid values are: `AgeGroupOfPopulation`, `CountryOfBirth`, `NatureOfOccupancy`, `GeographicalPopulation`, `DwellingStructure`, `HousingLoanRepayment`, `MaritalStatus`, `Religion`, `Occupation`, `EducationAttendance`, `TransportToWork` (optional) 
            var year = year_example;  // string | Year of the source data.  Valid values are: `2011`, `2016` (optional) 

            try
            {
                // Retrieves demographic information
                DomainDemographicsServiceV1ModelDemographicsResultsModel result = apiInstance.DemographicsGet(level, id, types, year);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DemographicsApi.DemographicsGet: " + e.Message );
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
 **level** | **string**| Geographic level.  Valid values are: &#x60;Postcode&#x60;, &#x60;Suburb&#x60; | 
 **id** | **int**| Location identifier. If the geographic level is Suburb this is a Suburb ID value, if the geographic level is postcode this is a Postcode ID value.  See the &#x60;/addressLocators&#x60; endpoint. | 
 **types** | **string**| Comma separated list of demographic data requested. If not provided, all data will be returned. Valid values are: &#x60;AgeGroupOfPopulation&#x60;, &#x60;CountryOfBirth&#x60;, &#x60;NatureOfOccupancy&#x60;, &#x60;GeographicalPopulation&#x60;, &#x60;DwellingStructure&#x60;, &#x60;HousingLoanRepayment&#x60;, &#x60;MaritalStatus&#x60;, &#x60;Religion&#x60;, &#x60;Occupation&#x60;, &#x60;EducationAttendance&#x60;, &#x60;TransportToWork&#x60; | [optional] 
 **year** | **string**| Year of the source data.  Valid values are: &#x60;2011&#x60;, &#x60;2016&#x60; | [optional] 

### Return type

[**DomainDemographicsServiceV1ModelDemographicsResultsModel**](DomainDemographicsServiceV1ModelDemographicsResultsModel.md)

### Authorization

[apikey](../README.md#apikey), [oauth2](../README.md#oauth2), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, text/html, application/xml, text/xml

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

