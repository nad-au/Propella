# Domain.Api.V2.Client.Api.ListingsApi

All URIs are relative to *http://api.domain.com.au*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ListingsBypropertyid**](ListingsApi.md#listingsbypropertyid) | **GET** /v2/properties/{propertyId}/listings | Retrieve list of listings for the given property id
[**ListingsUpsertbusinessoffmarket**](ListingsApi.md#listingsupsertbusinessoffmarket) | **POST** /v2/listings/business/offmarket | Creates an externally sold business listing; or takes an existing business listing off the market.
[**ListingsUpsertcommerciallisting**](ListingsApi.md#listingsupsertcommerciallisting) | **PUT** /v2/listings/commercial | Creates a commercial listing.
[**ListingsUpsertcommercialoffmarket**](ListingsApi.md#listingsupsertcommercialoffmarket) | **POST** /v2/listings/commercial/offmarket | Creates an externally sold or leased commercial listing; or takes an existing commercial listing off the market.
[**ListingsUpsertresidentialoffmarket**](ListingsApi.md#listingsupsertresidentialoffmarket) | **POST** /v2/listings/residential/offmarket | Creates an externally sold or leased residential listing; or takes an existing residential listing off the market.
[**PreMarketGet**](ListingsApi.md#premarketget) | **GET** /v2/premarket/listings/{id} | Retrieves a pre-portal listing.
[**PreMarketPatch**](ListingsApi.md#premarketpatch) | **PATCH** /v2/premarket/listings/{id} | Patch document based on the listing Id
[**PreMarketPost**](ListingsApi.md#premarketpost) | **POST** /v2/premarket/listings | Creates or updates a pre-portal listing.


<a name="listingsbypropertyid"></a>
# **ListingsBypropertyid**
> List&lt;ListingsV2Listing&gt; ListingsBypropertyid (string propertyId, DateTime? updatedSince = null, DateTime? listedSince = null, ListingsV2SaleMode? saleMode = null)

Retrieve list of listings for the given property id

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Domain.Api.V2.Client.Api;
using Domain.Api.V2.Client.Client;
using Domain.Api.V2.Client.Model;

namespace Example
{
    public class ListingsBypropertyidExample
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

            var apiInstance = new ListingsApi(config);
            var propertyId = propertyId_example;  // string | 
            var updatedSince = 2013-10-20T19:20:30+01:00;  // DateTime? |  (optional) 
            var listedSince = 2013-10-20T19:20:30+01:00;  // DateTime? |  (optional) 
            var saleMode = ;  // ListingsV2SaleMode? |  (optional) 

            try
            {
                // Retrieve list of listings for the given property id
                List<ListingsV2Listing> result = apiInstance.ListingsBypropertyid(propertyId, updatedSince, listedSince, saleMode);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ListingsApi.ListingsBypropertyid: " + e.Message );
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
 **propertyId** | **string**|  | 
 **updatedSince** | **DateTime?**|  | [optional] 
 **listedSince** | **DateTime?**|  | [optional] 
 **saleMode** | **ListingsV2SaleMode?**|  | [optional] 

### Return type

[**List&lt;ListingsV2Listing&gt;**](ListingsV2Listing.md)

### Authorization

[apikey](../README.md#apikey), [oauth2](../README.md#oauth2), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Listings for the property id |  -  |
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listingsupsertbusinessoffmarket"></a>
# **ListingsUpsertbusinessoffmarket**
> ListingAdminV2ListingResponse ListingsUpsertbusinessoffmarket (ListingAdminV2BusinessOffMarketListing listingAdminV2BusinessOffMarketListing)

Creates an externally sold business listing; or takes an existing business listing off the market.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Domain.Api.V2.Client.Api;
using Domain.Api.V2.Client.Client;
using Domain.Api.V2.Client.Model;

namespace Example
{
    public class ListingsUpsertbusinessoffmarketExample
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

            var apiInstance = new ListingsApi(config);
            var listingAdminV2BusinessOffMarketListing = new ListingAdminV2BusinessOffMarketListing(); // ListingAdminV2BusinessOffMarketListing | Listing data

            try
            {
                // Creates an externally sold business listing; or takes an existing business listing off the market.
                ListingAdminV2ListingResponse result = apiInstance.ListingsUpsertbusinessoffmarket(listingAdminV2BusinessOffMarketListing);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ListingsApi.ListingsUpsertbusinessoffmarket: " + e.Message );
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
 **listingAdminV2BusinessOffMarketListing** | [**ListingAdminV2BusinessOffMarketListing**](ListingAdminV2BusinessOffMarketListing.md)| Listing data | 

### Return type

[**ListingAdminV2ListingResponse**](ListingAdminV2ListingResponse.md)

### Authorization

[apikey](../README.md#apikey), [oauth2](../README.md#oauth2), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Listing data hasn&#39;t been changed |  -  |
| **202** | Listing data has been accepted |  -  |
| **400** | Listing data is not valid |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listingsupsertcommerciallisting"></a>
# **ListingsUpsertcommerciallisting**
> ListingAdminV2ListingResponse ListingsUpsertcommerciallisting (ListingAdminV2CommercialListingV2 listingAdminV2CommercialListingV2)

Creates a commercial listing.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Domain.Api.V2.Client.Api;
using Domain.Api.V2.Client.Client;
using Domain.Api.V2.Client.Model;

namespace Example
{
    public class ListingsUpsertcommerciallistingExample
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

            var apiInstance = new ListingsApi(config);
            var listingAdminV2CommercialListingV2 = new ListingAdminV2CommercialListingV2(); // ListingAdminV2CommercialListingV2 | Listing data

            try
            {
                // Creates a commercial listing.
                ListingAdminV2ListingResponse result = apiInstance.ListingsUpsertcommerciallisting(listingAdminV2CommercialListingV2);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ListingsApi.ListingsUpsertcommerciallisting: " + e.Message );
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
 **listingAdminV2CommercialListingV2** | [**ListingAdminV2CommercialListingV2**](ListingAdminV2CommercialListingV2.md)| Listing data | 

### Return type

[**ListingAdminV2ListingResponse**](ListingAdminV2ListingResponse.md)

### Authorization

[apikey](../README.md#apikey), [oauth2](../README.md#oauth2), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Listing data hasn&#39;t been changed |  -  |
| **202** | Listing data has been accepted |  -  |
| **400** | Listing data is not valid |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listingsupsertcommercialoffmarket"></a>
# **ListingsUpsertcommercialoffmarket**
> ListingAdminV2ListingResponse ListingsUpsertcommercialoffmarket (ListingAdminV2CommercialOffMarketListing listingAdminV2CommercialOffMarketListing)

Creates an externally sold or leased commercial listing; or takes an existing commercial listing off the market.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Domain.Api.V2.Client.Api;
using Domain.Api.V2.Client.Client;
using Domain.Api.V2.Client.Model;

namespace Example
{
    public class ListingsUpsertcommercialoffmarketExample
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

            var apiInstance = new ListingsApi(config);
            var listingAdminV2CommercialOffMarketListing = new ListingAdminV2CommercialOffMarketListing(); // ListingAdminV2CommercialOffMarketListing | Listing data

            try
            {
                // Creates an externally sold or leased commercial listing; or takes an existing commercial listing off the market.
                ListingAdminV2ListingResponse result = apiInstance.ListingsUpsertcommercialoffmarket(listingAdminV2CommercialOffMarketListing);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ListingsApi.ListingsUpsertcommercialoffmarket: " + e.Message );
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
 **listingAdminV2CommercialOffMarketListing** | [**ListingAdminV2CommercialOffMarketListing**](ListingAdminV2CommercialOffMarketListing.md)| Listing data | 

### Return type

[**ListingAdminV2ListingResponse**](ListingAdminV2ListingResponse.md)

### Authorization

[apikey](../README.md#apikey), [oauth2](../README.md#oauth2), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Listing data hasn&#39;t been changed |  -  |
| **202** | Listing data has been accepted |  -  |
| **400** | Listing data is not valid |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listingsupsertresidentialoffmarket"></a>
# **ListingsUpsertresidentialoffmarket**
> ListingAdminV2ListingResponse ListingsUpsertresidentialoffmarket (ListingAdminV2ResidentialOffMarketListing listingAdminV2ResidentialOffMarketListing)

Creates an externally sold or leased residential listing; or takes an existing residential listing off the market.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Domain.Api.V2.Client.Api;
using Domain.Api.V2.Client.Client;
using Domain.Api.V2.Client.Model;

namespace Example
{
    public class ListingsUpsertresidentialoffmarketExample
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

            var apiInstance = new ListingsApi(config);
            var listingAdminV2ResidentialOffMarketListing = new ListingAdminV2ResidentialOffMarketListing(); // ListingAdminV2ResidentialOffMarketListing | Listing data

            try
            {
                // Creates an externally sold or leased residential listing; or takes an existing residential listing off the market.
                ListingAdminV2ListingResponse result = apiInstance.ListingsUpsertresidentialoffmarket(listingAdminV2ResidentialOffMarketListing);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ListingsApi.ListingsUpsertresidentialoffmarket: " + e.Message );
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
 **listingAdminV2ResidentialOffMarketListing** | [**ListingAdminV2ResidentialOffMarketListing**](ListingAdminV2ResidentialOffMarketListing.md)| Listing data | 

### Return type

[**ListingAdminV2ListingResponse**](ListingAdminV2ListingResponse.md)

### Authorization

[apikey](../README.md#apikey), [oauth2](../README.md#oauth2), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Listing data hasn&#39;t been changed |  -  |
| **202** | Listing data has been accepted |  -  |
| **400** | Listing data is not valid |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="premarketget"></a>
# **PreMarketGet**
> PreMarketV1ListingResponse PreMarketGet (string id)

Retrieves a pre-portal listing.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Domain.Api.V2.Client.Api;
using Domain.Api.V2.Client.Client;
using Domain.Api.V2.Client.Model;

namespace Example
{
    public class PreMarketGetExample
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

            var apiInstance = new ListingsApi(config);
            var id = id_example;  // string | Pre-portal listing ID.

            try
            {
                // Retrieves a pre-portal listing.
                PreMarketV1ListingResponse result = apiInstance.PreMarketGet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ListingsApi.PreMarketGet: " + e.Message );
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
 **id** | **string**| Pre-portal listing ID. | 

### Return type

[**PreMarketV1ListingResponse**](PreMarketV1ListingResponse.md)

### Authorization

[apikey](../README.md#apikey), [oauth2](../README.md#oauth2), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **409** | Conflict |  -  |
| **500** | Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="premarketpatch"></a>
# **PreMarketPatch**
> PreMarketV1ListingRequest PreMarketPatch (string id, PreMarketV1ListingRequestJsonPatchDocument preMarketV1ListingRequestJsonPatchDocument = null)

Patch document based on the listing Id

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Domain.Api.V2.Client.Api;
using Domain.Api.V2.Client.Client;
using Domain.Api.V2.Client.Model;

namespace Example
{
    public class PreMarketPatchExample
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

            var apiInstance = new ListingsApi(config);
            var id = id_example;  // string | 
            var preMarketV1ListingRequestJsonPatchDocument = new PreMarketV1ListingRequestJsonPatchDocument(); // PreMarketV1ListingRequestJsonPatchDocument | ```  Examples:  [  {   \"op\": \"replace\",   \"path\": \"/bedrooms\",   \"value\": 3     },  {   \"op\": \"replace\",   \"path\": \"/listingStatus\",   \"value\": \"sold\"  },  {   \"op\": \"remove\",   \"path\": \"/StatementOfInformation\"  },  {   \"op\": \"add\",   \"path\": \"/contacts/-\",   \"value\": {    \"firstName\": \"lily\",    \"lastName\": \"li\",    \"email\": \"lily.li@domain.com.au\",    \"phone\": \"0411111111\",    \"mobile\": null,    \"fax\": null   }  }  ]  ``` (optional) 

            try
            {
                // Patch document based on the listing Id
                PreMarketV1ListingRequest result = apiInstance.PreMarketPatch(id, preMarketV1ListingRequestJsonPatchDocument);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ListingsApi.PreMarketPatch: " + e.Message );
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
 **id** | **string**|  | 
 **preMarketV1ListingRequestJsonPatchDocument** | [**PreMarketV1ListingRequestJsonPatchDocument**](PreMarketV1ListingRequestJsonPatchDocument.md)| &#x60;&#x60;&#x60;  Examples:  [  {   \&quot;op\&quot;: \&quot;replace\&quot;,   \&quot;path\&quot;: \&quot;/bedrooms\&quot;,   \&quot;value\&quot;: 3     },  {   \&quot;op\&quot;: \&quot;replace\&quot;,   \&quot;path\&quot;: \&quot;/listingStatus\&quot;,   \&quot;value\&quot;: \&quot;sold\&quot;  },  {   \&quot;op\&quot;: \&quot;remove\&quot;,   \&quot;path\&quot;: \&quot;/StatementOfInformation\&quot;  },  {   \&quot;op\&quot;: \&quot;add\&quot;,   \&quot;path\&quot;: \&quot;/contacts/-\&quot;,   \&quot;value\&quot;: {    \&quot;firstName\&quot;: \&quot;lily\&quot;,    \&quot;lastName\&quot;: \&quot;li\&quot;,    \&quot;email\&quot;: \&quot;lily.li@domain.com.au\&quot;,    \&quot;phone\&quot;: \&quot;0411111111\&quot;,    \&quot;mobile\&quot;: null,    \&quot;fax\&quot;: null   }  }  ]  &#x60;&#x60;&#x60; | [optional] 

### Return type

[**PreMarketV1ListingRequest**](PreMarketV1ListingRequest.md)

### Authorization

[apikey](../README.md#apikey), [oauth2](../README.md#oauth2), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **202** | Success |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **500** | Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="premarketpost"></a>
# **PreMarketPost**
> PreMarketV1CreateOrUpdateListingResponse PreMarketPost (PreMarketV1ListingRequest preMarketV1ListingRequest = null)

Creates or updates a pre-portal listing.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Domain.Api.V2.Client.Api;
using Domain.Api.V2.Client.Client;
using Domain.Api.V2.Client.Model;

namespace Example
{
    public class PreMarketPostExample
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

            var apiInstance = new ListingsApi(config);
            var preMarketV1ListingRequest = new PreMarketV1ListingRequest(); // PreMarketV1ListingRequest | Pre-portal listing request. (optional) 

            try
            {
                // Creates or updates a pre-portal listing.
                PreMarketV1CreateOrUpdateListingResponse result = apiInstance.PreMarketPost(preMarketV1ListingRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ListingsApi.PreMarketPost: " + e.Message );
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
 **preMarketV1ListingRequest** | [**PreMarketV1ListingRequest**](PreMarketV1ListingRequest.md)| Pre-portal listing request. | [optional] 

### Return type

[**PreMarketV1CreateOrUpdateListingResponse**](PreMarketV1CreateOrUpdateListingResponse.md)

### Authorization

[apikey](../README.md#apikey), [oauth2](../README.md#oauth2), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **202** | Success |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **500** | Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

