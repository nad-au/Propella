# Domain.Api.V1.Client.Api.ProjectsApi

All URIs are relative to *http://api.domain.com.au*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ProjectsGetChildListings**](ProjectsApi.md#projectsgetchildlistings) | **GET** /v1/projects/{id}/listings | Retrieves listings of a project


<a name="projectsgetchildlistings"></a>
# **ProjectsGetChildListings**
> List&lt;DomainPublicAdapterWebApiModelsV1ListingsListing&gt; ProjectsGetChildListings (int id)

Retrieves listings of a project

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Domain.Api.V1.Client.Api;
using Domain.Api.V1.Client.Client;
using Domain.Api.V1.Client.Model;

namespace Example
{
    public class ProjectsGetChildListingsExample
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

            var apiInstance = new ProjectsApi(config);
            var id = 56;  // int | 

            try
            {
                // Retrieves listings of a project
                List<DomainPublicAdapterWebApiModelsV1ListingsListing> result = apiInstance.ProjectsGetChildListings(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProjectsApi.ProjectsGetChildListings: " + e.Message );
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
 **id** | **int**|  | 

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

