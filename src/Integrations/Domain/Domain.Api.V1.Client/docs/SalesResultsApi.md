# Domain.Api.V1.Client.Api.SalesResultsApi

All URIs are relative to *http://api.domain.com.au*

Method | HTTP request | Description
------------- | ------------- | -------------
[**SalesResultsGet**](SalesResultsApi.md#salesresultsget) | **GET** /v1/salesResults/{city} | Retrieves sales results for a given city
[**SalesResultsHead**](SalesResultsApi.md#salesresultshead) | **GET** /v1/salesResults/_head | Retrieves metadata regarding sales result data
[**SalesResultsListings**](SalesResultsApi.md#salesresultslistings) | **GET** /v1/salesResults/{city}/listings | Retrieves listing summaries corresponding to the sales results


<a name="salesresultsget"></a>
# **SalesResultsGet**
> DomainSalesResultsServiceV1ModelDomainSalesResultsModelCityResultsSummary SalesResultsGet (string city)

Retrieves sales results for a given city

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Domain.Api.V1.Client.Api;
using Domain.Api.V1.Client.Client;
using Domain.Api.V1.Client.Model;

namespace Example
{
    public class SalesResultsGetExample
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

            var apiInstance = new SalesResultsApi(config);
            var city = city_example;  // string | City. Supported cities are: `Sydney`, `Melbourne`, `Brisbane`, `Adelaide`, `Canberra`

            try
            {
                // Retrieves sales results for a given city
                DomainSalesResultsServiceV1ModelDomainSalesResultsModelCityResultsSummary result = apiInstance.SalesResultsGet(city);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SalesResultsApi.SalesResultsGet: " + e.Message );
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
 **city** | **string**| City. Supported cities are: &#x60;Sydney&#x60;, &#x60;Melbourne&#x60;, &#x60;Brisbane&#x60;, &#x60;Adelaide&#x60;, &#x60;Canberra&#x60; | 

### Return type

[**DomainSalesResultsServiceV1ModelDomainSalesResultsModelCityResultsSummary**](DomainSalesResultsServiceV1ModelDomainSalesResultsModelCityResultsSummary.md)

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

<a name="salesresultshead"></a>
# **SalesResultsHead**
> DomainSalesResultsServiceV1ModelDomainSalesResultsModelCityResultsDate SalesResultsHead ()

Retrieves metadata regarding sales result data

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Domain.Api.V1.Client.Api;
using Domain.Api.V1.Client.Client;
using Domain.Api.V1.Client.Model;

namespace Example
{
    public class SalesResultsHeadExample
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

            var apiInstance = new SalesResultsApi(config);

            try
            {
                // Retrieves metadata regarding sales result data
                DomainSalesResultsServiceV1ModelDomainSalesResultsModelCityResultsDate result = apiInstance.SalesResultsHead();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SalesResultsApi.SalesResultsHead: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**DomainSalesResultsServiceV1ModelDomainSalesResultsModelCityResultsDate**](DomainSalesResultsServiceV1ModelDomainSalesResultsModelCityResultsDate.md)

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

<a name="salesresultslistings"></a>
# **SalesResultsListings**
> List&lt;DomainPublicAdapterWebApiModelsV1SalesResultsListingSummary&gt; SalesResultsListings (string city)

Retrieves listing summaries corresponding to the sales results

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Domain.Api.V1.Client.Api;
using Domain.Api.V1.Client.Client;
using Domain.Api.V1.Client.Model;

namespace Example
{
    public class SalesResultsListingsExample
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

            var apiInstance = new SalesResultsApi(config);
            var city = city_example;  // string | City. Supported cities are: `Sydney`, `Melbourne`, `Brisbane`, `Adelaide`, `Canberra`

            try
            {
                // Retrieves listing summaries corresponding to the sales results
                List<DomainPublicAdapterWebApiModelsV1SalesResultsListingSummary> result = apiInstance.SalesResultsListings(city);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SalesResultsApi.SalesResultsListings: " + e.Message );
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
 **city** | **string**| City. Supported cities are: &#x60;Sydney&#x60;, &#x60;Melbourne&#x60;, &#x60;Brisbane&#x60;, &#x60;Adelaide&#x60;, &#x60;Canberra&#x60; | 

### Return type

[**List&lt;DomainPublicAdapterWebApiModelsV1SalesResultsListingSummary&gt;**](DomainPublicAdapterWebApiModelsV1SalesResultsListingSummary.md)

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

