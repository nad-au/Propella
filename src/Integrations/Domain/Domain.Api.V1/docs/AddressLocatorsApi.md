# Domain.Api.V1.Api.AddressLocatorsApi

All URIs are relative to *http://api.domain.com.au*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddressLocatorsGet**](AddressLocatorsApi.md#addresslocatorsget) | **GET** /v1/addressLocators | Retrieves matching ids for use in other services.


<a name="addresslocatorsget"></a>
# **AddressLocatorsGet**
> List&lt;DomainAPMServiceV3ModelAPMAPIModelsTokenisedSearchV3AddressDataModel&gt; AddressLocatorsGet (string searchLevel, string unitNumber = null, string streetNumber = null, string streetName = null, string streetType = null, string suburb = null, string state = null, string postcode = null)

Retrieves matching ids for use in other services.

Use this endpoint to retrieve IDs that may be used to query information from other endpoints.    For example use `id` of the `Suburb` level to query [`demographics`](/docs/v1/apis/pkg_properties_locations/references/demographics_get)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Domain.Api.V1.Api;
using Domain.Api.V1.Client;
using Domain.Api.V1.Model;

namespace Example
{
    public class AddressLocatorsGetExample
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

            var apiInstance = new AddressLocatorsApi(config);
            var searchLevel = searchLevel_example;  // string | Requested search level. Valid values are: `Address`, and `Suburb`
            var unitNumber = unitNumber_example;  // string | Unit number (optional) 
            var streetNumber = streetNumber_example;  // string | Street number (optional) 
            var streetName = streetName_example;  // string | Street name (optional) 
            var streetType = streetType_example;  // string | Street type (optional) 
            var suburb = suburb_example;  // string | Suburb (optional) 
            var state = state_example;  // string | State (optional) 
            var postcode = postcode_example;  // string | Postcode (optional) 

            try
            {
                // Retrieves matching ids for use in other services.
                List<DomainAPMServiceV3ModelAPMAPIModelsTokenisedSearchV3AddressDataModel> result = apiInstance.AddressLocatorsGet(searchLevel, unitNumber, streetNumber, streetName, streetType, suburb, state, postcode);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AddressLocatorsApi.AddressLocatorsGet: " + e.Message );
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
 **searchLevel** | **string**| Requested search level. Valid values are: &#x60;Address&#x60;, and &#x60;Suburb&#x60; | 
 **unitNumber** | **string**| Unit number | [optional] 
 **streetNumber** | **string**| Street number | [optional] 
 **streetName** | **string**| Street name | [optional] 
 **streetType** | **string**| Street type | [optional] 
 **suburb** | **string**| Suburb | [optional] 
 **state** | **string**| State | [optional] 
 **postcode** | **string**| Postcode | [optional] 

### Return type

[**List&lt;DomainAPMServiceV3ModelAPMAPIModelsTokenisedSearchV3AddressDataModel&gt;**](DomainAPMServiceV3ModelAPMAPIModelsTokenisedSearchV3AddressDataModel.md)

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

