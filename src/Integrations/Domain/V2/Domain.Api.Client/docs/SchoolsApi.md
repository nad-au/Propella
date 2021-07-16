# Domain.Api.Client.Api.SchoolsApi

All URIs are relative to *http://api.domain.com.au*

Method | HTTP request | Description
------------- | ------------- | -------------
[**SchoolsGetById**](SchoolsApi.md#schoolsgetbyid) | **GET** /v2/schools/{id} | Retrieve the details of a school by Id
[**SchoolsSearchByLocation**](SchoolsApi.md#schoolssearchbylocation) | **GET** /v2/schools/{latitude}/{longitude} | Search for a school in a location


<a name="schoolsgetbyid"></a>
# **SchoolsGetById**
> SchoolsV2School SchoolsGetById (int id)

Retrieve the details of a school by Id

Domain School Ids can be obtained from the search by location endpoint.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Domain.Api.Client.Api;
using Domain.Api.Client.Client;
using Domain.Api.Client.Model;

namespace Example
{
    public class SchoolsGetByIdExample
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

            var apiInstance = new SchoolsApi(config);
            var id = 1234;  // int | School id

            try
            {
                // Retrieve the details of a school by Id
                SchoolsV2School result = apiInstance.SchoolsGetById(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SchoolsApi.SchoolsGetById: " + e.Message );
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
 **id** | **int**| School id | 

### Return type

[**SchoolsV2School**](SchoolsV2School.md)

### Authorization

[apikey](../README.md#apikey), [oauth2](../README.md#oauth2), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Schools data returned |  -  |
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="schoolssearchbylocation"></a>
# **SchoolsSearchByLocation**
> List&lt;SchoolsV2SchoolWithDistance&gt; SchoolsSearchByLocation (double latitude, double longitude)

Search for a school in a location

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Domain.Api.Client.Api;
using Domain.Api.Client.Client;
using Domain.Api.Client.Model;

namespace Example
{
    public class SchoolsSearchByLocationExample
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

            var apiInstance = new SchoolsApi(config);
            var latitude = -33.8;  // double | Latitude to search
            var longitude = 150.9;  // double | Longitude to search

            try
            {
                // Search for a school in a location
                List<SchoolsV2SchoolWithDistance> result = apiInstance.SchoolsSearchByLocation(latitude, longitude);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SchoolsApi.SchoolsSearchByLocation: " + e.Message );
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
 **latitude** | **double**| Latitude to search | 
 **longitude** | **double**| Longitude to search | 

### Return type

[**List&lt;SchoolsV2SchoolWithDistance&gt;**](SchoolsV2SchoolWithDistance.md)

### Authorization

[apikey](../README.md#apikey), [oauth2](../README.md#oauth2), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Schools data returned |  -  |
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

