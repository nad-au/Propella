# Domain.Api.V1.Api.DisclaimersApi

All URIs are relative to *http://api.domain.com.au*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DisclaimersGet**](DisclaimersApi.md#disclaimersget) | **GET** /v1/disclaimers | Retrieves disclaimers for given ids
[**DisclaimersGetByProduct**](DisclaimersApi.md#disclaimersgetbyproduct) | **GET** /v1/disclaimers/product/{product} | Retrieves disclaimers for given product


<a name="disclaimersget"></a>
# **DisclaimersGet**
> List&lt;DomainAPMServiceV2ModelAPMAPIModelsDisclaimerV2DisclaimerModel&gt; DisclaimersGet (string ids = null)

Retrieves disclaimers for given ids

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Domain.Api.V1.Api;
using Domain.Api.V1.Client;
using Domain.Api.V1.Model;

namespace Example
{
    public class DisclaimersGetExample
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

            var apiInstance = new DisclaimersApi(config);
            var ids = ids_example;  // string | Comma separated list of ids. Eg. \"1,2,3\" (optional) 

            try
            {
                // Retrieves disclaimers for given ids
                List<DomainAPMServiceV2ModelAPMAPIModelsDisclaimerV2DisclaimerModel> result = apiInstance.DisclaimersGet(ids);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DisclaimersApi.DisclaimersGet: " + e.Message );
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
 **ids** | **string**| Comma separated list of ids. Eg. \&quot;1,2,3\&quot; | [optional] 

### Return type

[**List&lt;DomainAPMServiceV2ModelAPMAPIModelsDisclaimerV2DisclaimerModel&gt;**](DomainAPMServiceV2ModelAPMAPIModelsDisclaimerV2DisclaimerModel.md)

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

<a name="disclaimersgetbyproduct"></a>
# **DisclaimersGetByProduct**
> List&lt;DomainAPMServiceV2ModelAPMAPIModelsDisclaimerV2DisclaimerModel&gt; DisclaimersGetByProduct (string product)

Retrieves disclaimers for given product

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Domain.Api.V1.Api;
using Domain.Api.V1.Client;
using Domain.Api.V1.Model;

namespace Example
{
    public class DisclaimersGetByProductExample
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

            var apiInstance = new DisclaimersApi(config);
            var product = product_example;  // string | Possible product values: `PropertyData`, `AURIN`, `HomePriceGuide`

            try
            {
                // Retrieves disclaimers for given product
                List<DomainAPMServiceV2ModelAPMAPIModelsDisclaimerV2DisclaimerModel> result = apiInstance.DisclaimersGetByProduct(product);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DisclaimersApi.DisclaimersGetByProduct: " + e.Message );
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
 **product** | **string**| Possible product values: &#x60;PropertyData&#x60;, &#x60;AURIN&#x60;, &#x60;HomePriceGuide&#x60; | 

### Return type

[**List&lt;DomainAPMServiceV2ModelAPMAPIModelsDisclaimerV2DisclaimerModel&gt;**](DomainAPMServiceV2ModelAPMAPIModelsDisclaimerV2DisclaimerModel.md)

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

