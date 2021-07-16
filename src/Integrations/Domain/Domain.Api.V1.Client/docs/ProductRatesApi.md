# Domain.Api.V1.Client.Api.ProductRatesApi

All URIs are relative to *http://api.domain.com.au*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ProductsRateForNewListing**](ProductRatesApi.md#productsratefornewlisting) | **POST** /v1/products/ratefornewlisting | Get updated pricing information for a hypothetical listing


<a name="productsratefornewlisting"></a>
# **ProductsRateForNewListing**
> BookingsV2RateForNewListing ProductsRateForNewListing (BookingsV2RateForNewListingRequest bookingsV2RateForNewListingRequest = null)

Get updated pricing information for a hypothetical listing

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Domain.Api.V1.Client.Api;
using Domain.Api.V1.Client.Client;
using Domain.Api.V1.Client.Model;

namespace Example
{
    public class ProductsRateForNewListingExample
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

            var apiInstance = new ProductRatesApi(config);
            var bookingsV2RateForNewListingRequest = new BookingsV2RateForNewListingRequest(); // BookingsV2RateForNewListingRequest |  (optional) 

            try
            {
                // Get updated pricing information for a hypothetical listing
                BookingsV2RateForNewListing result = apiInstance.ProductsRateForNewListing(bookingsV2RateForNewListingRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductRatesApi.ProductsRateForNewListing: " + e.Message );
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
 **bookingsV2RateForNewListingRequest** | [**BookingsV2RateForNewListingRequest**](BookingsV2RateForNewListingRequest.md)|  | [optional] 

### Return type

[**BookingsV2RateForNewListing**](BookingsV2RateForNewListing.md)

### Authorization

[apikey](../README.md#apikey), [oauth2](../README.md#oauth2), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Pricing information for the given listing details |  -  |
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

