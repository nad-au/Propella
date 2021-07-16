# Domain.Api.V1.Client.Api.PropertiesApi

All URIs are relative to *http://api.domain.com.au*

Method | HTTP request | Description
------------- | ------------- | -------------
[**PropertiesGet**](PropertiesApi.md#propertiesget) | **GET** /v1/properties/{id} | Retrieves a specific property.
[**PropertiesGetPriceEstimate**](PropertiesApi.md#propertiesgetpriceestimate) | **GET** /v1/properties/{id}/priceEstimate | Retrieves the current price estimate for the given property.
[**PropertiesSuggest**](PropertiesApi.md#propertiessuggest) | **GET** /v1/properties/_suggest | Search for suggested addressed for the given terms


<a name="propertiesget"></a>
# **PropertiesGet**
> DomainPublicAdapterWebApiModelsV1PropertiesProperty PropertiesGet (string id)

Retrieves a specific property.

Applicable [policies](/docs/latest/support/policies) apply here include APM attribution and appropriate state government attribution.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Domain.Api.V1.Client.Api;
using Domain.Api.V1.Client.Client;
using Domain.Api.V1.Client.Model;

namespace Example
{
    public class PropertiesGetExample
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

            var apiInstance = new PropertiesApi(config);
            var id = id_example;  // string | Property identifier.  Use the `_suggest` resource to determine the propertyId.

            try
            {
                // Retrieves a specific property.
                DomainPublicAdapterWebApiModelsV1PropertiesProperty result = apiInstance.PropertiesGet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PropertiesApi.PropertiesGet: " + e.Message );
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
 **id** | **string**| Property identifier.  Use the &#x60;_suggest&#x60; resource to determine the propertyId. | 

### Return type

[**DomainPublicAdapterWebApiModelsV1PropertiesProperty**](DomainPublicAdapterWebApiModelsV1PropertiesProperty.md)

### Authorization

[apikey](../README.md#apikey), [oauth2](../README.md#oauth2), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, text/html

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="propertiesgetpriceestimate"></a>
# **PropertiesGetPriceEstimate**
> DomainPublicAdapterWebApiModelsV1PropertiesPriceEstimate PropertiesGetPriceEstimate (string id)

Retrieves the current price estimate for the given property.

The price estimate data is refreshed monthly, typically towards the end of each month.    The price estimate provides a guide of the approximate market value for a property.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Domain.Api.V1.Client.Api;
using Domain.Api.V1.Client.Client;
using Domain.Api.V1.Client.Model;

namespace Example
{
    public class PropertiesGetPriceEstimateExample
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

            var apiInstance = new PropertiesApi(config);
            var id = id_example;  // string | Property identifier.  Use the `_suggest` resource to determine the propertyId.

            try
            {
                // Retrieves the current price estimate for the given property.
                DomainPublicAdapterWebApiModelsV1PropertiesPriceEstimate result = apiInstance.PropertiesGetPriceEstimate(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PropertiesApi.PropertiesGetPriceEstimate: " + e.Message );
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
 **id** | **string**| Property identifier.  Use the &#x60;_suggest&#x60; resource to determine the propertyId. | 

### Return type

[**DomainPublicAdapterWebApiModelsV1PropertiesPriceEstimate**](DomainPublicAdapterWebApiModelsV1PropertiesPriceEstimate.md)

### Authorization

[apikey](../README.md#apikey), [oauth2](../README.md#oauth2), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, text/html

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="propertiessuggest"></a>
# **PropertiesSuggest**
> List&lt;LocationTypeaheadV1PropertySuggestion&gt; PropertiesSuggest (string terms = null, int? pageSize = null, LocationTypeaheadV1PropertySuggestionChannel? channel = null)

Search for suggested addressed for the given terms

Applicable [policies](/docs/latest/support/policies) apply here include APM attribution.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Domain.Api.V1.Client.Api;
using Domain.Api.V1.Client.Client;
using Domain.Api.V1.Client.Model;

namespace Example
{
    public class PropertiesSuggestExample
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

            var apiInstance = new PropertiesApi(config);
            var terms = 1 Smith Street, Smithfield, NSW;  // string | The address to search (optional) 
            var pageSize = 56;  // int? | Number of suggestions (maximum 20) (optional)  (default to 20)
            var channel = ;  // LocationTypeaheadV1PropertySuggestionChannel? | Restrict the suggestions to this type of property: `All` (default), `Residential`, `Commercial` (optional) 

            try
            {
                // Search for suggested addressed for the given terms
                List<LocationTypeaheadV1PropertySuggestion> result = apiInstance.PropertiesSuggest(terms, pageSize, channel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PropertiesApi.PropertiesSuggest: " + e.Message );
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
 **terms** | **string**| The address to search | [optional] 
 **pageSize** | **int?**| Number of suggestions (maximum 20) | [optional] [default to 20]
 **channel** | **LocationTypeaheadV1PropertySuggestionChannel?**| Restrict the suggestions to this type of property: &#x60;All&#x60; (default), &#x60;Residential&#x60;, &#x60;Commercial&#x60; | [optional] 

### Return type

[**List&lt;LocationTypeaheadV1PropertySuggestion&gt;**](LocationTypeaheadV1PropertySuggestion.md)

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

