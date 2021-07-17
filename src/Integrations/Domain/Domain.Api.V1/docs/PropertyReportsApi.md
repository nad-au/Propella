# Domain.Api.V1.Api.PropertyReportsApi

All URIs are relative to *http://api.domain.com.au*

Method | HTTP request | Description
------------- | ------------- | -------------
[**PropertyReportsGet**](PropertyReportsApi.md#propertyreportsget) | **GET** /v1/propertyReports | Retrieves a property report based on query parameters


<a name="propertyreportsget"></a>
# **PropertyReportsGet**
> DomainPropertyReportServiceV1ModelPropertyReportGenerationResult PropertyReportsGet (string propertyType, string streetNumber, string streetName, string suburb, string state, string unitNumber = null, string streetType = null, string postcode = null, int? areaSize = null, int? bedrooms = null, int? bathrooms = null, int? parking = null, string preparedFor = null, string productCode = null)

Retrieves a property report based on query parameters

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Domain.Api.V1.Api;
using Domain.Api.V1.Client;
using Domain.Api.V1.Model;

namespace Example
{
    public class PropertyReportsGetExample
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

            var apiInstance = new PropertyReportsApi(config);
            var propertyType = propertyType_example;  // string | Type of property `House`, `Unit`
            var streetNumber = streetNumber_example;  // string | Street number
            var streetName = streetName_example;  // string | Street name
            var suburb = suburb_example;  // string | Suburb e.g. `Pyrmont`
            var state = state_example;  // string | State e.g. `NSW`
            var unitNumber = unitNumber_example;  // string | Unit number (optional) 
            var streetType = streetType_example;  // string | Street type e.g. `Pl` (optional) 
            var postcode = postcode_example;  // string | Postcode e.g. `2009` (optional) 
            var areaSize = 56;  // int? | Area size (optional) 
            var bedrooms = 56;  // int? | Number of bedrooms (optional) 
            var bathrooms = 56;  // int? | Number of bathrooms (optional) 
            var parking = 56;  // int? | Number of parking spots (optional) 
            var preparedFor = preparedFor_example;  // string | \"Prepared for\" information (optional) 
            var productCode = productCode_example;  // string | Report product code (optional) 

            try
            {
                // Retrieves a property report based on query parameters
                DomainPropertyReportServiceV1ModelPropertyReportGenerationResult result = apiInstance.PropertyReportsGet(propertyType, streetNumber, streetName, suburb, state, unitNumber, streetType, postcode, areaSize, bedrooms, bathrooms, parking, preparedFor, productCode);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PropertyReportsApi.PropertyReportsGet: " + e.Message );
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
 **propertyType** | **string**| Type of property &#x60;House&#x60;, &#x60;Unit&#x60; | 
 **streetNumber** | **string**| Street number | 
 **streetName** | **string**| Street name | 
 **suburb** | **string**| Suburb e.g. &#x60;Pyrmont&#x60; | 
 **state** | **string**| State e.g. &#x60;NSW&#x60; | 
 **unitNumber** | **string**| Unit number | [optional] 
 **streetType** | **string**| Street type e.g. &#x60;Pl&#x60; | [optional] 
 **postcode** | **string**| Postcode e.g. &#x60;2009&#x60; | [optional] 
 **areaSize** | **int?**| Area size | [optional] 
 **bedrooms** | **int?**| Number of bedrooms | [optional] 
 **bathrooms** | **int?**| Number of bathrooms | [optional] 
 **parking** | **int?**| Number of parking spots | [optional] 
 **preparedFor** | **string**| \&quot;Prepared for\&quot; information | [optional] 
 **productCode** | **string**| Report product code | [optional] 

### Return type

[**DomainPropertyReportServiceV1ModelPropertyReportGenerationResult**](DomainPropertyReportServiceV1ModelPropertyReportGenerationResult.md)

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

