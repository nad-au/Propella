# Domain.Api.V1.Api.AgenciesApi

All URIs are relative to *http://api.domain.com.au*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AgenciesCreateTestAgency**](AgenciesApi.md#agenciescreatetestagency) | **POST** /v1/agencies/_testAgency | Creates a test agency
[**AgenciesGet**](AgenciesApi.md#agenciesget) | **GET** /v1/agencies/{id} | Retrieves a specific agency details.
[**AgenciesGetBundleContracts**](AgenciesApi.md#agenciesgetbundlecontracts) | **GET** /v1/agencies/{id}/bundlecontracts | Retrieves the product bundle contracts applicable to the specific agency.
[**AgenciesGetListings**](AgenciesApi.md#agenciesgetlistings) | **GET** /v1/agencies/{id}/listings | Retrieves listings across all channels for a specific agency matching specified criteria.
[**AgenciesGetStatistics**](AgenciesApi.md#agenciesgetstatistics) | **GET** /v1/agencies/{id}/statistics | Retrieves statistics across all channels for a specific agency.
[**AgenciesGetSubscriptions**](AgenciesApi.md#agenciesgetsubscriptions) | **GET** /v1/agencies/{id}/subscriptions | Retrieves the active subscriptions for the specific agency
[**AgenciesHead**](AgenciesApi.md#agencieshead) | **HEAD** /v1/agencies | Retrieves summary of agency search
[**AgenciesSearch**](AgenciesApi.md#agenciessearch) | **GET** /v1/agencies | Retrieves summary of agencies matching the specified criteria.


<a name="agenciescreatetestagency"></a>
# **AgenciesCreateTestAgency**
> DomainAgencyServiceV2ModelAgency AgenciesCreateTestAgency ()

Creates a test agency

Enables automatic creation of a test agency in our sandbox environment.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Domain.Api.V1.Api;
using Domain.Api.V1.Client;
using Domain.Api.V1.Model;

namespace Example
{
    public class AgenciesCreateTestAgencyExample
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

            var apiInstance = new AgenciesApi(config);

            try
            {
                // Creates a test agency
                DomainAgencyServiceV2ModelAgency result = apiInstance.AgenciesCreateTestAgency();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AgenciesApi.AgenciesCreateTestAgency: " + e.Message );
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

[**DomainAgencyServiceV2ModelAgency**](DomainAgencyServiceV2ModelAgency.md)

### Authorization

[apikey](../README.md#apikey), [oauth2](../README.md#oauth2), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, text/html, application/xml, text/xml

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | When a request is made on a non sandbox environment |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="agenciesget"></a>
# **AgenciesGet**
> DomainAgencyServiceV2ModelAgency AgenciesGet (int id)

Retrieves a specific agency details.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Domain.Api.V1.Api;
using Domain.Api.V1.Client;
using Domain.Api.V1.Model;

namespace Example
{
    public class AgenciesGetExample
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

            var apiInstance = new AgenciesApi(config);
            var id = 56;  // int | Agency identifier

            try
            {
                // Retrieves a specific agency details.
                DomainAgencyServiceV2ModelAgency result = apiInstance.AgenciesGet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AgenciesApi.AgenciesGet: " + e.Message );
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
 **id** | **int**| Agency identifier | 

### Return type

[**DomainAgencyServiceV2ModelAgency**](DomainAgencyServiceV2ModelAgency.md)

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

<a name="agenciesgetbundlecontracts"></a>
# **AgenciesGetBundleContracts**
> List&lt;DomainBookingServiceV1ModelProductBundleContractDetailsResponse&gt; AgenciesGetBundleContracts (int id)

Retrieves the product bundle contracts applicable to the specific agency.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Domain.Api.V1.Api;
using Domain.Api.V1.Client;
using Domain.Api.V1.Model;

namespace Example
{
    public class AgenciesGetBundleContractsExample
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

            var apiInstance = new AgenciesApi(config);
            var id = 56;  // int | Agency identifier

            try
            {
                // Retrieves the product bundle contracts applicable to the specific agency.
                List<DomainBookingServiceV1ModelProductBundleContractDetailsResponse> result = apiInstance.AgenciesGetBundleContracts(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AgenciesApi.AgenciesGetBundleContracts: " + e.Message );
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
 **id** | **int**| Agency identifier | 

### Return type

[**List&lt;DomainBookingServiceV1ModelProductBundleContractDetailsResponse&gt;**](DomainBookingServiceV1ModelProductBundleContractDetailsResponse.md)

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

<a name="agenciesgetlistings"></a>
# **AgenciesGetListings**
> List&lt;DomainPublicAdapterWebApiModelsV1ListingsListing&gt; AgenciesGetListings (int id, string listingStatusFilter = null, DateTime? dateUpdatedSince = null, int? pageNumber = null, int? pageSize = null)

Retrieves listings across all channels for a specific agency matching specified criteria.

Note that the result page size is clamped at 200.  Requesting a page size greater than this will be treated as if only a page size of 200 were requested.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Domain.Api.V1.Api;
using Domain.Api.V1.Client;
using Domain.Api.V1.Model;

namespace Example
{
    public class AgenciesGetListingsExample
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

            var apiInstance = new AgenciesApi(config);
            var id = 56;  // int | Agency identifier
            var listingStatusFilter = listingStatusFilter_example;  // string | Filter for listing status (optional) 
            var dateUpdatedSince = 2013-10-20T19:20:30+01:00;  // DateTime? | Filter to remove listings not updated since before the given date time (optional) 
            var pageNumber = 56;  // int? | Page number for paginated results (optional) 
            var pageSize = 56;  // int? | Page size for paginated results (optional) 

            try
            {
                // Retrieves listings across all channels for a specific agency matching specified criteria.
                List<DomainPublicAdapterWebApiModelsV1ListingsListing> result = apiInstance.AgenciesGetListings(id, listingStatusFilter, dateUpdatedSince, pageNumber, pageSize);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AgenciesApi.AgenciesGetListings: " + e.Message );
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
 **id** | **int**| Agency identifier | 
 **listingStatusFilter** | **string**| Filter for listing status | [optional] 
 **dateUpdatedSince** | **DateTime?**| Filter to remove listings not updated since before the given date time | [optional] 
 **pageNumber** | **int?**| Page number for paginated results | [optional] 
 **pageSize** | **int?**| Page size for paginated results | [optional] 

### Return type

[**List&lt;DomainPublicAdapterWebApiModelsV1ListingsListing&gt;**](DomainPublicAdapterWebApiModelsV1ListingsListing.md)

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

<a name="agenciesgetstatistics"></a>
# **AgenciesGetStatistics**
> List&lt;DomainPublicAdapterWebApiModelsV1ListingsStatistics&gt; AgenciesGetStatistics (int id, string timePeriod = null, string statusFilter = null, int? pageNumber = null, int? pageSize = null)

Retrieves statistics across all channels for a specific agency.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Domain.Api.V1.Api;
using Domain.Api.V1.Client;
using Domain.Api.V1.Model;

namespace Example
{
    public class AgenciesGetStatisticsExample
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

            var apiInstance = new AgenciesApi(config);
            var id = 56;  // int | Agency identifier
            var timePeriod = timePeriod_example;  // string | Period to report on, Valid values are: `last7Days`, `last90Days`, `wholeCampaign`. Default is `last7Days`. (optional) 
            var statusFilter = statusFilter_example;  // string | Status to filter, Valid values are: `Live`, `LiveAndArchived`. Default is `LiveAndArchived` (optional) 
            var pageNumber = 56;  // int? | Page number (optional) 
            var pageSize = 56;  // int? | Page size (optional) 

            try
            {
                // Retrieves statistics across all channels for a specific agency.
                List<DomainPublicAdapterWebApiModelsV1ListingsStatistics> result = apiInstance.AgenciesGetStatistics(id, timePeriod, statusFilter, pageNumber, pageSize);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AgenciesApi.AgenciesGetStatistics: " + e.Message );
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
 **id** | **int**| Agency identifier | 
 **timePeriod** | **string**| Period to report on, Valid values are: &#x60;last7Days&#x60;, &#x60;last90Days&#x60;, &#x60;wholeCampaign&#x60;. Default is &#x60;last7Days&#x60;. | [optional] 
 **statusFilter** | **string**| Status to filter, Valid values are: &#x60;Live&#x60;, &#x60;LiveAndArchived&#x60;. Default is &#x60;LiveAndArchived&#x60; | [optional] 
 **pageNumber** | **int?**| Page number | [optional] 
 **pageSize** | **int?**| Page size | [optional] 

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

<a name="agenciesgetsubscriptions"></a>
# **AgenciesGetSubscriptions**
> List&lt;DomainAgencyServiceV1ModelAgencySubscriptionDto&gt; AgenciesGetSubscriptions (int id, string channel = null)

Retrieves the active subscriptions for the specific agency

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Domain.Api.V1.Api;
using Domain.Api.V1.Client;
using Domain.Api.V1.Model;

namespace Example
{
    public class AgenciesGetSubscriptionsExample
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

            var apiInstance = new AgenciesApi(config);
            var id = 56;  // int | Agency identifier
            var channel = channel_example;  // string | Channel. Either `residential` or `commercial` (case insensitive). Defaults to `residential` if not provided (optional) 

            try
            {
                // Retrieves the active subscriptions for the specific agency
                List<DomainAgencyServiceV1ModelAgencySubscriptionDto> result = apiInstance.AgenciesGetSubscriptions(id, channel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AgenciesApi.AgenciesGetSubscriptions: " + e.Message );
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
 **id** | **int**| Agency identifier | 
 **channel** | **string**| Channel. Either &#x60;residential&#x60; or &#x60;commercial&#x60; (case insensitive). Defaults to &#x60;residential&#x60; if not provided | [optional] 

### Return type

[**List&lt;DomainAgencyServiceV1ModelAgencySubscriptionDto&gt;**](DomainAgencyServiceV1ModelAgencySubscriptionDto.md)

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

<a name="agencieshead"></a>
# **AgenciesHead**
> void AgenciesHead (string q, int? pageNumber = null, int? pageSize = null)

Retrieves summary of agency search

Given a specified agency search criteria, this endpoint can be used to ascertain the result count that can be expected.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Domain.Api.V1.Api;
using Domain.Api.V1.Client;
using Domain.Api.V1.Model;

namespace Example
{
    public class AgenciesHeadExample
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

            var apiInstance = new AgenciesApi(config);
            var q = q_example;  // string | Search phrase.  e.g. name:\"Agency XYZ\"
            var pageNumber = 56;  // int? | Page number for paginated results (optional) 
            var pageSize = 56;  // int? | Page size for paginated results (optional) 

            try
            {
                // Retrieves summary of agency search
                apiInstance.AgenciesHead(q, pageNumber, pageSize);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AgenciesApi.AgenciesHead: " + e.Message );
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
 **q** | **string**| Search phrase.  e.g. name:\&quot;Agency XYZ\&quot; | 
 **pageNumber** | **int?**| Page number for paginated results | [optional] 
 **pageSize** | **int?**| Page size for paginated results | [optional] 

### Return type

void (empty response body)

### Authorization

[apikey](../README.md#apikey), [oauth2](../README.md#oauth2), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, text/html, application/xml, text/xml

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Result count returned, see X-Total-Count header |  -  |
| **404** | No results |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="agenciessearch"></a>
# **AgenciesSearch**
> List&lt;DomainAgencyServiceV2ModelAgencySummary&gt; AgenciesSearch (string q, int? pageNumber = null, int? pageSize = null)

Retrieves summary of agencies matching the specified criteria.

<para>The <code>q</code> parameter supports:</para>  <ul>    <li>name: search by name eg. <code>name:\"Agency XYZ\"</code></li>    <li>providerId: search by providerId. eg. <code>providerId:\"ABC Software\"</code></li>    <li>domainUrl: search by domainUrl. eg. <code>domainUrl:\"agency-xyz\"</code></li>    <li>dateUpdated: search by dateUpdated. eg. <code>dateUpdated:\"2016-12-25\"</code></li>    <li>suburbId: search by suburbId. Lists supported.  eg. <code>suburbId:1</code> eg. <code>suburbId:(1 OR 2 OR 3)</code>.  Can include related suburbs by adding <code>in:related</code></li>    <li>accountType: search by account type. Lists supported.  eg. <code>accountType:residential</code> eg. <code>accountType:(residential OR commercial)</code> Valid values are: none, residential, commerciallight, commercialfull, developer, holiday, business</li>    <li>      <code>in:all</code> includes archived agencies (archived agencies excluded by default)</li>    <li>      <code>-is:selfservice</code> excludes selfservice</li>  </ul>

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Domain.Api.V1.Api;
using Domain.Api.V1.Client;
using Domain.Api.V1.Model;

namespace Example
{
    public class AgenciesSearchExample
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

            var apiInstance = new AgenciesApi(config);
            var q = q_example;  // string | Search phrase.  e.g. name:\"Agency XYZ\"
            var pageNumber = 56;  // int? | Page number for paginated results (optional) 
            var pageSize = 56;  // int? | Page size for paginated results (optional) 

            try
            {
                // Retrieves summary of agencies matching the specified criteria.
                List<DomainAgencyServiceV2ModelAgencySummary> result = apiInstance.AgenciesSearch(q, pageNumber, pageSize);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AgenciesApi.AgenciesSearch: " + e.Message );
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
 **q** | **string**| Search phrase.  e.g. name:\&quot;Agency XYZ\&quot; | 
 **pageNumber** | **int?**| Page number for paginated results | [optional] 
 **pageSize** | **int?**| Page size for paginated results | [optional] 

### Return type

[**List&lt;DomainAgencyServiceV2ModelAgencySummary&gt;**](DomainAgencyServiceV2ModelAgencySummary.md)

### Authorization

[apikey](../README.md#apikey), [oauth2](../README.md#oauth2), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, text/html, application/xml, text/xml

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Search results found |  -  |
| **404** | No results |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

