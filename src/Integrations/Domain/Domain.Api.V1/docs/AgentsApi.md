# Domain.Api.V1.Api.AgentsApi

All URIs are relative to *http://api.domain.com.au*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AgentsGet**](AgentsApi.md#agentsget) | **GET** /v1/agents/{id} | Retrieves a specific agent details, including contact information.
[**AgentsGetListings**](AgentsApi.md#agentsgetlistings) | **GET** /v1/agents/{id}/listings | Gets listing using the contact id
[**AgentsSearch**](AgentsApi.md#agentssearch) | **GET** /v1/agents/search | Search for agents by name.


<a name="agentsget"></a>
# **AgentsGet**
> DomainAgencyServiceV1ModelAgentDto AgentsGet (int id)

Retrieves a specific agent details, including contact information.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Domain.Api.V1.Api;
using Domain.Api.V1.Client;
using Domain.Api.V1.Model;

namespace Example
{
    public class AgentsGetExample
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

            var apiInstance = new AgentsApi(config);
            var id = 56;  // int | Agent identifier

            try
            {
                // Retrieves a specific agent details, including contact information.
                DomainAgencyServiceV1ModelAgentDto result = apiInstance.AgentsGet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AgentsApi.AgentsGet: " + e.Message );
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
 **id** | **int**| Agent identifier | 

### Return type

[**DomainAgencyServiceV1ModelAgentDto**](DomainAgencyServiceV1ModelAgentDto.md)

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

<a name="agentsgetlistings"></a>
# **AgentsGetListings**
> List&lt;DomainPublicAdapterWebApiModelsV1ListingsListing&gt; AgentsGetListings (int id, DateTime? dateUpdatedSince = null, bool? includedArchivedListings = null, int? pageNumber = null, int? pageSize = null)

Gets listing using the contact id

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Domain.Api.V1.Api;
using Domain.Api.V1.Client;
using Domain.Api.V1.Model;

namespace Example
{
    public class AgentsGetListingsExample
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

            var apiInstance = new AgentsApi(config);
            var id = 56;  // int | Agent identifier
            var dateUpdatedSince = 2013-10-20T19:20:30+01:00;  // DateTime? | Filter to remove listings not updated since before the given date time (optional) 
            var includedArchivedListings = true;  // bool? | Filter to remove listings that have been archived (optional) 
            var pageNumber = 56;  // int? | Page number for paginated results (optional) 
            var pageSize = 56;  // int? | Page size for paginated results (optional) 

            try
            {
                // Gets listing using the contact id
                List<DomainPublicAdapterWebApiModelsV1ListingsListing> result = apiInstance.AgentsGetListings(id, dateUpdatedSince, includedArchivedListings, pageNumber, pageSize);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AgentsApi.AgentsGetListings: " + e.Message );
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
 **id** | **int**| Agent identifier | 
 **dateUpdatedSince** | **DateTime?**| Filter to remove listings not updated since before the given date time | [optional] 
 **includedArchivedListings** | **bool?**| Filter to remove listings that have been archived | [optional] 
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

<a name="agentssearch"></a>
# **AgentsSearch**
> List&lt;DomainAgentSearchV1ModelAutoSuggestAgentResultDto&gt; AgentsSearch (string query, int? pageNumber = null, int? pageSize = null)

Search for agents by name.

The returned Agent ID can be used to get an agent details by ID. See `GET /agents/{id}/`

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Domain.Api.V1.Api;
using Domain.Api.V1.Client;
using Domain.Api.V1.Model;

namespace Example
{
    public class AgentsSearchExample
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

            var apiInstance = new AgentsApi(config);
            var query = query_example;  // string | The name, or portion of name, to search for.
            var pageNumber = 56;  // int? | Page number for paginated results (optional) 
            var pageSize = 56;  // int? | Page size for paginated results (maximum 20) (optional) 

            try
            {
                // Search for agents by name.
                List<DomainAgentSearchV1ModelAutoSuggestAgentResultDto> result = apiInstance.AgentsSearch(query, pageNumber, pageSize);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AgentsApi.AgentsSearch: " + e.Message );
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
 **query** | **string**| The name, or portion of name, to search for. | 
 **pageNumber** | **int?**| Page number for paginated results | [optional] 
 **pageSize** | **int?**| Page size for paginated results (maximum 20) | [optional] 

### Return type

[**List&lt;DomainAgentSearchV1ModelAutoSuggestAgentResultDto&gt;**](DomainAgentSearchV1ModelAutoSuggestAgentResultDto.md)

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

