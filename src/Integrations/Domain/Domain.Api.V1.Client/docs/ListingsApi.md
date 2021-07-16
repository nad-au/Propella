# Domain.Api.V1.Client.Api.ListingsApi

All URIs are relative to *http://api.domain.com.au*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ListingLocationsSearch**](ListingsApi.md#listinglocationssearch) | **GET** /v1/listings/locations | Suggests listing locations
[**ListingsDetailedBusinessSearch**](ListingsApi.md#listingsdetailedbusinesssearch) | **POST** /v1/listings/business/_search | Retrieves business listings matching the specified criteria.
[**ListingsDetailedCommercialSearch**](ListingsApi.md#listingsdetailedcommercialsearch) | **POST** /v1/listings/commercial/_search | Retrieves commercial listings matching the specified criteria.
[**ListingsDetailedResidentialSearch**](ListingsApi.md#listingsdetailedresidentialsearch) | **POST** /v1/listings/residential/_search | Retrieves residential listings matching the specified criteria.
[**ListingsGet**](ListingsApi.md#listingsget) | **GET** /v1/listings/{id} | Retrieves a specific listing.
[**ListingsGetEnquiries**](ListingsApi.md#listingsgetenquiries) | **GET** /v1/listings/{id}/enquiries | Returns enquiries for a given listing
[**ListingsGetListingReport**](ListingsApi.md#listingsgetlistingreport) | **GET** /v1/listings/processingReports/{id} | Gets the processing report
[**ListingsGetListingReportByReference**](ListingsApi.md#listingsgetlistingreportbyreference) | **GET** /v1/listings/processingReports | Searches processing reports
[**ListingsGetListingStatistics**](ListingsApi.md#listingsgetlistingstatistics) | **GET** /v1/listings/{id}/statistics | Retrieves listings stats for the specified listing
[**ListingsGetListingStatisticsByAgentId**](ListingsApi.md#listingsgetlistingstatisticsbyagentid) | **GET** /v1/listings/statistics | Retrieves stats for the listings of a given agent
[**ListingsUpdateOffmarketDetails**](ListingsApi.md#listingsupdateoffmarketdetails) | **POST** /v1/listings/{id}/offmarket | Takes a listing offmarket
[**ListingsUpsertBusinessListing**](ListingsApi.md#listingsupsertbusinesslisting) | **PUT** /v1/listings/business | Creates or updates a business listing
[**ListingsUpsertCommercialListing**](ListingsApi.md#listingsupsertcommerciallisting) | **PUT** /v1/listings/commercial | Creates or updates a commercial listing
[**ListingsUpsertResidentialListing**](ListingsApi.md#listingsupsertresidentiallisting) | **PUT** /v1/listings/residential | Creates or updates a residential listing
[**ProjectsGet**](ListingsApi.md#projectsget) | **GET** /v1/projects/{id} | Details of project
[**ProjectsSearch**](ListingsApi.md#projectssearch) | **GET** /v1/projects | Searches projects


<a name="listinglocationssearch"></a>
# **ListingLocationsSearch**
> List&lt;DomainPublicAdapterWebApiModelsV1ListingsListingLocation&gt; ListingLocationsSearch (string terms = null)

Suggests listing locations

The resulting suggested location can be of type \"suburb\" / \"area\" / \"region\".    The `name` property corresponds to the type of location returned.    The area name / region name can be fed into the corresponding fields search fields.  See [`v1/listings/residential/_search`](/docs/v1/apis/pkg_agents_listings/references/listings_detailedresidentialsearch)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Domain.Api.V1.Client.Api;
using Domain.Api.V1.Client.Client;
using Domain.Api.V1.Client.Model;

namespace Example
{
    public class ListingLocationsSearchExample
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
            var terms = terms_example;  // string | Suburb / area / region prefix, or postcode (optional) 

            try
            {
                // Suggests listing locations
                List<DomainPublicAdapterWebApiModelsV1ListingsListingLocation> result = apiInstance.ListingLocationsSearch(terms);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ListingsApi.ListingLocationsSearch: " + e.Message );
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
 **terms** | **string**| Suburb / area / region prefix, or postcode | [optional] 

### Return type

[**List&lt;DomainPublicAdapterWebApiModelsV1ListingsListingLocation&gt;**](DomainPublicAdapterWebApiModelsV1ListingsListingLocation.md)

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

<a name="listingsdetailedbusinesssearch"></a>
# **ListingsDetailedBusinessSearch**
> List&lt;DomainPublicAdapterWebApiModelsV1ListingsBusinessListing&gt; ListingsDetailedBusinessSearch (DomainPublicAdapterWebApiModelsV1ListingsBusinessSearchRequest domainPublicAdapterWebApiModelsV1ListingsBusinessSearchRequest)

Retrieves business listings matching the specified criteria.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Domain.Api.V1.Client.Api;
using Domain.Api.V1.Client.Client;
using Domain.Api.V1.Client.Model;

namespace Example
{
    public class ListingsDetailedBusinessSearchExample
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
            var domainPublicAdapterWebApiModelsV1ListingsBusinessSearchRequest = new DomainPublicAdapterWebApiModelsV1ListingsBusinessSearchRequest(); // DomainPublicAdapterWebApiModelsV1ListingsBusinessSearchRequest | Search parameters

            try
            {
                // Retrieves business listings matching the specified criteria.
                List<DomainPublicAdapterWebApiModelsV1ListingsBusinessListing> result = apiInstance.ListingsDetailedBusinessSearch(domainPublicAdapterWebApiModelsV1ListingsBusinessSearchRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ListingsApi.ListingsDetailedBusinessSearch: " + e.Message );
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
 **domainPublicAdapterWebApiModelsV1ListingsBusinessSearchRequest** | [**DomainPublicAdapterWebApiModelsV1ListingsBusinessSearchRequest**](DomainPublicAdapterWebApiModelsV1ListingsBusinessSearchRequest.md)| Search parameters | 

### Return type

[**List&lt;DomainPublicAdapterWebApiModelsV1ListingsBusinessListing&gt;**](DomainPublicAdapterWebApiModelsV1ListingsBusinessListing.md)

### Authorization

[apikey](../README.md#apikey), [oauth2](../README.md#oauth2), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, text/html, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, text/html, application/xml, text/xml

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listingsdetailedcommercialsearch"></a>
# **ListingsDetailedCommercialSearch**
> List&lt;DomainPublicAdapterWebApiModelsV1ListingsCommercialListing&gt; ListingsDetailedCommercialSearch (DomainPublicAdapterWebApiModelsV1ListingsCommercialSearchRequest domainPublicAdapterWebApiModelsV1ListingsCommercialSearchRequest)

Retrieves commercial listings matching the specified criteria.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Domain.Api.V1.Client.Api;
using Domain.Api.V1.Client.Client;
using Domain.Api.V1.Client.Model;

namespace Example
{
    public class ListingsDetailedCommercialSearchExample
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
            var domainPublicAdapterWebApiModelsV1ListingsCommercialSearchRequest = new DomainPublicAdapterWebApiModelsV1ListingsCommercialSearchRequest(); // DomainPublicAdapterWebApiModelsV1ListingsCommercialSearchRequest | Search parameters

            try
            {
                // Retrieves commercial listings matching the specified criteria.
                List<DomainPublicAdapterWebApiModelsV1ListingsCommercialListing> result = apiInstance.ListingsDetailedCommercialSearch(domainPublicAdapterWebApiModelsV1ListingsCommercialSearchRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ListingsApi.ListingsDetailedCommercialSearch: " + e.Message );
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
 **domainPublicAdapterWebApiModelsV1ListingsCommercialSearchRequest** | [**DomainPublicAdapterWebApiModelsV1ListingsCommercialSearchRequest**](DomainPublicAdapterWebApiModelsV1ListingsCommercialSearchRequest.md)| Search parameters | 

### Return type

[**List&lt;DomainPublicAdapterWebApiModelsV1ListingsCommercialListing&gt;**](DomainPublicAdapterWebApiModelsV1ListingsCommercialListing.md)

### Authorization

[apikey](../README.md#apikey), [oauth2](../README.md#oauth2), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, text/html, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, text/html, application/xml, text/xml

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listingsdetailedresidentialsearch"></a>
# **ListingsDetailedResidentialSearch**
> List&lt;DomainSearchServiceV2ModelDomainSearchContractsV2SearchResult&gt; ListingsDetailedResidentialSearch (DomainSearchServiceV2ModelDomainSearchWebApiV2ModelsSearchParameters domainSearchServiceV2ModelDomainSearchWebApiV2ModelsSearchParameters)

Retrieves residential listings matching the specified criteria.

Search results are limited to the first 1000 results.    If the number of results is greater, the intention is to refine the search by adding more restrictive parameters, to find a relevant set of results.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Domain.Api.V1.Client.Api;
using Domain.Api.V1.Client.Client;
using Domain.Api.V1.Client.Model;

namespace Example
{
    public class ListingsDetailedResidentialSearchExample
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
            var domainSearchServiceV2ModelDomainSearchWebApiV2ModelsSearchParameters = new DomainSearchServiceV2ModelDomainSearchWebApiV2ModelsSearchParameters(); // DomainSearchServiceV2ModelDomainSearchWebApiV2ModelsSearchParameters | Search parameters

            try
            {
                // Retrieves residential listings matching the specified criteria.
                List<DomainSearchServiceV2ModelDomainSearchContractsV2SearchResult> result = apiInstance.ListingsDetailedResidentialSearch(domainSearchServiceV2ModelDomainSearchWebApiV2ModelsSearchParameters);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ListingsApi.ListingsDetailedResidentialSearch: " + e.Message );
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
 **domainSearchServiceV2ModelDomainSearchWebApiV2ModelsSearchParameters** | [**DomainSearchServiceV2ModelDomainSearchWebApiV2ModelsSearchParameters**](DomainSearchServiceV2ModelDomainSearchWebApiV2ModelsSearchParameters.md)| Search parameters | 

### Return type

[**List&lt;DomainSearchServiceV2ModelDomainSearchContractsV2SearchResult&gt;**](DomainSearchServiceV2ModelDomainSearchContractsV2SearchResult.md)

### Authorization

[apikey](../README.md#apikey), [oauth2](../README.md#oauth2), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, text/html, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, text/html, application/xml, text/xml

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listingsget"></a>
# **ListingsGet**
> DomainPublicAdapterWebApiModelsV1ListingsListing ListingsGet (int id)

Retrieves a specific listing.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Domain.Api.V1.Client.Api;
using Domain.Api.V1.Client.Client;
using Domain.Api.V1.Client.Model;

namespace Example
{
    public class ListingsGetExample
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
            var id = 56;  // int | Listing identifier

            try
            {
                // Retrieves a specific listing.
                DomainPublicAdapterWebApiModelsV1ListingsListing result = apiInstance.ListingsGet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ListingsApi.ListingsGet: " + e.Message );
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
 **id** | **int**| Listing identifier | 

### Return type

[**DomainPublicAdapterWebApiModelsV1ListingsListing**](DomainPublicAdapterWebApiModelsV1ListingsListing.md)

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

<a name="listingsgetenquiries"></a>
# **ListingsGetEnquiries**
> List&lt;DomainPublicAdapterWebApiModelsV1EnquiriesEnquiryReport&gt; ListingsGetEnquiries (int id, int? pageNumber = null)

Returns enquiries for a given listing

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Domain.Api.V1.Client.Api;
using Domain.Api.V1.Client.Client;
using Domain.Api.V1.Client.Model;

namespace Example
{
    public class ListingsGetEnquiriesExample
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
            var id = 56;  // int | Listing identifier
            var pageNumber = 56;  // int? | Page number for paginated results (25 per page) (optional) 

            try
            {
                // Returns enquiries for a given listing
                List<DomainPublicAdapterWebApiModelsV1EnquiriesEnquiryReport> result = apiInstance.ListingsGetEnquiries(id, pageNumber);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ListingsApi.ListingsGetEnquiries: " + e.Message );
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
 **id** | **int**| Listing identifier | 
 **pageNumber** | **int?**| Page number for paginated results (25 per page) | [optional] 

### Return type

[**List&lt;DomainPublicAdapterWebApiModelsV1EnquiriesEnquiryReport&gt;**](DomainPublicAdapterWebApiModelsV1EnquiriesEnquiryReport.md)

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

<a name="listingsgetlistingreport"></a>
# **ListingsGetListingReport**
> DomainListingAdminServiceV1ModelListingReport ListingsGetListingReport (string id)

Gets the processing report

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Domain.Api.V1.Client.Api;
using Domain.Api.V1.Client.Client;
using Domain.Api.V1.Client.Model;

namespace Example
{
    public class ListingsGetListingReportExample
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
            var id = id_example;  // string | Report id

            try
            {
                // Gets the processing report
                DomainListingAdminServiceV1ModelListingReport result = apiInstance.ListingsGetListingReport(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ListingsApi.ListingsGetListingReport: " + e.Message );
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
 **id** | **string**| Report id | 

### Return type

[**DomainListingAdminServiceV1ModelListingReport**](DomainListingAdminServiceV1ModelListingReport.md)

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

<a name="listingsgetlistingreportbyreference"></a>
# **ListingsGetListingReportByReference**
> List&lt;DomainListingAdminServiceV1ModelListingReport&gt; ListingsGetListingReportByReference (int agencyId, string providerAdId)

Searches processing reports

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Domain.Api.V1.Client.Api;
using Domain.Api.V1.Client.Client;
using Domain.Api.V1.Client.Model;

namespace Example
{
    public class ListingsGetListingReportByReferenceExample
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
            var agencyId = 56;  // int | Domain agency Id
            var providerAdId = providerAdId_example;  // string | External provider advertisement identifier

            try
            {
                // Searches processing reports
                List<DomainListingAdminServiceV1ModelListingReport> result = apiInstance.ListingsGetListingReportByReference(agencyId, providerAdId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ListingsApi.ListingsGetListingReportByReference: " + e.Message );
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
 **agencyId** | **int**| Domain agency Id | 
 **providerAdId** | **string**| External provider advertisement identifier | 

### Return type

[**List&lt;DomainListingAdminServiceV1ModelListingReport&gt;**](DomainListingAdminServiceV1ModelListingReport.md)

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

<a name="listingsgetlistingstatistics"></a>
# **ListingsGetListingStatistics**
> DomainPublicAdapterWebApiModelsV1ListingsStatisticsReport ListingsGetListingStatistics (int id, string timePeriod = null)

Retrieves listings stats for the specified listing

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Domain.Api.V1.Client.Api;
using Domain.Api.V1.Client.Client;
using Domain.Api.V1.Client.Model;

namespace Example
{
    public class ListingsGetListingStatisticsExample
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
            var id = 56;  // int | Listing identifier
            var timePeriod = timePeriod_example;  // string | The time period to show statistics for. Valid values are: `last7Days`, `last90Days`, `wholeCampaign` (optional) 

            try
            {
                // Retrieves listings stats for the specified listing
                DomainPublicAdapterWebApiModelsV1ListingsStatisticsReport result = apiInstance.ListingsGetListingStatistics(id, timePeriod);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ListingsApi.ListingsGetListingStatistics: " + e.Message );
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
 **id** | **int**| Listing identifier | 
 **timePeriod** | **string**| The time period to show statistics for. Valid values are: &#x60;last7Days&#x60;, &#x60;last90Days&#x60;, &#x60;wholeCampaign&#x60; | [optional] 

### Return type

[**DomainPublicAdapterWebApiModelsV1ListingsStatisticsReport**](DomainPublicAdapterWebApiModelsV1ListingsStatisticsReport.md)

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

<a name="listingsgetlistingstatisticsbyagentid"></a>
# **ListingsGetListingStatisticsByAgentId**
> List&lt;DomainPublicAdapterWebApiModelsV1ListingsStatistics&gt; ListingsGetListingStatisticsByAgentId (int agentId, string timePeriod, string statusFilter, int? pageNumber = null, int? pageSize = null)

Retrieves stats for the listings of a given agent

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Domain.Api.V1.Client.Api;
using Domain.Api.V1.Client.Client;
using Domain.Api.V1.Client.Model;

namespace Example
{
    public class ListingsGetListingStatisticsByAgentIdExample
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
            var agentId = 56;  // int | Agent identifier
            var timePeriod = timePeriod_example;  // string | The time period to show statistics for. Valid values are: `last7Days`, `last90Days`, `wholeCampaign`
            var statusFilter = statusFilter_example;  // string | Listing filter
            var pageNumber = 56;  // int? | Page number for paginated results (optional) 
            var pageSize = 56;  // int? | Page size for paginated results (optional) 

            try
            {
                // Retrieves stats for the listings of a given agent
                List<DomainPublicAdapterWebApiModelsV1ListingsStatistics> result = apiInstance.ListingsGetListingStatisticsByAgentId(agentId, timePeriod, statusFilter, pageNumber, pageSize);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ListingsApi.ListingsGetListingStatisticsByAgentId: " + e.Message );
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
 **agentId** | **int**| Agent identifier | 
 **timePeriod** | **string**| The time period to show statistics for. Valid values are: &#x60;last7Days&#x60;, &#x60;last90Days&#x60;, &#x60;wholeCampaign&#x60; | 
 **statusFilter** | **string**| Listing filter | 
 **pageNumber** | **int?**| Page number for paginated results | [optional] 
 **pageSize** | **int?**| Page size for paginated results | [optional] 

### Return type

[**List&lt;DomainPublicAdapterWebApiModelsV1ListingsStatistics&gt;**](DomainPublicAdapterWebApiModelsV1ListingsStatistics.md)

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

<a name="listingsupdateoffmarketdetails"></a>
# **ListingsUpdateOffmarketDetails**
> DomainListingAdminServiceV1ModelListingResponse ListingsUpdateOffmarketDetails (int id, DomainListingAdminServiceV1ModelOffMarketDetails domainListingAdminServiceV1ModelOffMarketDetails)

Takes a listing offmarket

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Domain.Api.V1.Client.Api;
using Domain.Api.V1.Client.Client;
using Domain.Api.V1.Client.Model;

namespace Example
{
    public class ListingsUpdateOffmarketDetailsExample
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
            var id = 56;  // int | Listing identifier
            var domainListingAdminServiceV1ModelOffMarketDetails = new DomainListingAdminServiceV1ModelOffMarketDetails(); // DomainListingAdminServiceV1ModelOffMarketDetails | 

            try
            {
                // Takes a listing offmarket
                DomainListingAdminServiceV1ModelListingResponse result = apiInstance.ListingsUpdateOffmarketDetails(id, domainListingAdminServiceV1ModelOffMarketDetails);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ListingsApi.ListingsUpdateOffmarketDetails: " + e.Message );
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
 **id** | **int**| Listing identifier | 
 **domainListingAdminServiceV1ModelOffMarketDetails** | [**DomainListingAdminServiceV1ModelOffMarketDetails**](DomainListingAdminServiceV1ModelOffMarketDetails.md)|  | 

### Return type

[**DomainListingAdminServiceV1ModelListingResponse**](DomainListingAdminServiceV1ModelListingResponse.md)

### Authorization

[apikey](../README.md#apikey), [oauth2](../README.md#oauth2), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, text/html, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, text/html, application/xml, text/xml

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Ok |  -  |
| **202** | Accepted |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listingsupsertbusinesslisting"></a>
# **ListingsUpsertBusinessListing**
> DomainListingAdminServiceV1ModelListingResponse ListingsUpsertBusinessListing (DomainListingAdminServiceV1ModelBusinessListing domainListingAdminServiceV1ModelBusinessListing)

Creates or updates a business listing

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Domain.Api.V1.Client.Api;
using Domain.Api.V1.Client.Client;
using Domain.Api.V1.Client.Model;

namespace Example
{
    public class ListingsUpsertBusinessListingExample
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
            var domainListingAdminServiceV1ModelBusinessListing = new DomainListingAdminServiceV1ModelBusinessListing(); // DomainListingAdminServiceV1ModelBusinessListing | The business listing

            try
            {
                // Creates or updates a business listing
                DomainListingAdminServiceV1ModelListingResponse result = apiInstance.ListingsUpsertBusinessListing(domainListingAdminServiceV1ModelBusinessListing);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ListingsApi.ListingsUpsertBusinessListing: " + e.Message );
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
 **domainListingAdminServiceV1ModelBusinessListing** | [**DomainListingAdminServiceV1ModelBusinessListing**](DomainListingAdminServiceV1ModelBusinessListing.md)| The business listing | 

### Return type

[**DomainListingAdminServiceV1ModelListingResponse**](DomainListingAdminServiceV1ModelListingResponse.md)

### Authorization

[apikey](../README.md#apikey), [oauth2](../README.md#oauth2), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, text/html, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, text/html, application/xml, text/xml

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Ok |  -  |
| **202** | Accepted |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listingsupsertcommerciallisting"></a>
# **ListingsUpsertCommercialListing**
> DomainListingAdminServiceV1ModelListingResponse ListingsUpsertCommercialListing (DomainListingAdminServiceV1ModelCommercialListing domainListingAdminServiceV1ModelCommercialListing)

Creates or updates a commercial listing

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Domain.Api.V1.Client.Api;
using Domain.Api.V1.Client.Client;
using Domain.Api.V1.Client.Model;

namespace Example
{
    public class ListingsUpsertCommercialListingExample
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
            var domainListingAdminServiceV1ModelCommercialListing = new DomainListingAdminServiceV1ModelCommercialListing(); // DomainListingAdminServiceV1ModelCommercialListing | The commercial listing

            try
            {
                // Creates or updates a commercial listing
                DomainListingAdminServiceV1ModelListingResponse result = apiInstance.ListingsUpsertCommercialListing(domainListingAdminServiceV1ModelCommercialListing);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ListingsApi.ListingsUpsertCommercialListing: " + e.Message );
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
 **domainListingAdminServiceV1ModelCommercialListing** | [**DomainListingAdminServiceV1ModelCommercialListing**](DomainListingAdminServiceV1ModelCommercialListing.md)| The commercial listing | 

### Return type

[**DomainListingAdminServiceV1ModelListingResponse**](DomainListingAdminServiceV1ModelListingResponse.md)

### Authorization

[apikey](../README.md#apikey), [oauth2](../README.md#oauth2), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, text/html, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, text/html, application/xml, text/xml

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Ok |  -  |
| **202** | Accepted |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listingsupsertresidentiallisting"></a>
# **ListingsUpsertResidentialListing**
> DomainListingAdminServiceV1ModelListingResponse ListingsUpsertResidentialListing (DomainListingAdminServiceV1ModelResidentialListing domainListingAdminServiceV1ModelResidentialListing)

Creates or updates a residential listing

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Domain.Api.V1.Client.Api;
using Domain.Api.V1.Client.Client;
using Domain.Api.V1.Client.Model;

namespace Example
{
    public class ListingsUpsertResidentialListingExample
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
            var domainListingAdminServiceV1ModelResidentialListing = new DomainListingAdminServiceV1ModelResidentialListing(); // DomainListingAdminServiceV1ModelResidentialListing | The residential listing

            try
            {
                // Creates or updates a residential listing
                DomainListingAdminServiceV1ModelListingResponse result = apiInstance.ListingsUpsertResidentialListing(domainListingAdminServiceV1ModelResidentialListing);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ListingsApi.ListingsUpsertResidentialListing: " + e.Message );
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
 **domainListingAdminServiceV1ModelResidentialListing** | [**DomainListingAdminServiceV1ModelResidentialListing**](DomainListingAdminServiceV1ModelResidentialListing.md)| The residential listing | 

### Return type

[**DomainListingAdminServiceV1ModelListingResponse**](DomainListingAdminServiceV1ModelListingResponse.md)

### Authorization

[apikey](../README.md#apikey), [oauth2](../README.md#oauth2), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, text/html, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, text/html, application/xml, text/xml

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Ok |  -  |
| **202** | Accepted |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="projectsget"></a>
# **ProjectsGet**
> ListingsV2Project ProjectsGet (int id)

Details of project

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Domain.Api.V1.Client.Api;
using Domain.Api.V1.Client.Client;
using Domain.Api.V1.Client.Model;

namespace Example
{
    public class ProjectsGetExample
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
            var id = 56;  // int | Id of the project

            try
            {
                // Details of project
                ListingsV2Project result = apiInstance.ProjectsGet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ListingsApi.ProjectsGet: " + e.Message );
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
 **id** | **int**| Id of the project | 

### Return type

[**ListingsV2Project**](ListingsV2Project.md)

### Authorization

[apikey](../README.md#apikey), [oauth2](../README.md#oauth2), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="projectssearch"></a>
# **ProjectsSearch**
> List&lt;ListingsV2Project&gt; ProjectsSearch (int? agencyId = null, int? pageNumber = null, int? pageSize = null)

Searches projects

Note that the result page size is clamped at 100.  Requesting a page size greater than this will be treated as if only a page size of 100 were requested.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Domain.Api.V1.Client.Api;
using Domain.Api.V1.Client.Client;
using Domain.Api.V1.Client.Model;

namespace Example
{
    public class ProjectsSearchExample
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
            var agencyId = 56;  // int? | Restricts to the provided agency (optional) 
            var pageNumber = 56;  // int? | Page number for paginated results (optional)  (default to 1)
            var pageSize = 56;  // int? | Page size for paginated results (optional)  (default to 20)

            try
            {
                // Searches projects
                List<ListingsV2Project> result = apiInstance.ProjectsSearch(agencyId, pageNumber, pageSize);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ListingsApi.ProjectsSearch: " + e.Message );
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
 **agencyId** | **int?**| Restricts to the provided agency | [optional] 
 **pageNumber** | **int?**| Page number for paginated results | [optional] [default to 1]
 **pageSize** | **int?**| Page size for paginated results | [optional] [default to 20]

### Return type

[**List&lt;ListingsV2Project&gt;**](ListingsV2Project.md)

### Authorization

[apikey](../README.md#apikey), [oauth2](../README.md#oauth2), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

