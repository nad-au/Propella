# Domain.Api.V1.Api.SchoolsApi

All URIs are relative to *http://api.domain.com.au*

Method | HTTP request | Description
------------- | ------------- | -------------
[**SchoolsGet**](SchoolsApi.md#schoolsget) | **GET** /v1/locations/schools/{id} | Retrieves a specific school
[**SchoolsSearch**](SchoolsApi.md#schoolssearch) | **GET** /v1/locations/schools | Searches schools based on specified criteria


<a name="schoolsget"></a>
# **SchoolsGet**
> DomainPublicAdapterWebApiModelsV1LocationsSchoolsSchool SchoolsGet (int id)

Retrieves a specific school

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Domain.Api.V1.Api;
using Domain.Api.V1.Client;
using Domain.Api.V1.Model;

namespace Example
{
    public class SchoolsGetExample
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
            var id = 56;  // int | School identifier

            try
            {
                // Retrieves a specific school
                DomainPublicAdapterWebApiModelsV1LocationsSchoolsSchool result = apiInstance.SchoolsGet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SchoolsApi.SchoolsGet: " + e.Message );
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
 **id** | **int**| School identifier | 

### Return type

[**DomainPublicAdapterWebApiModelsV1LocationsSchoolsSchool**](DomainPublicAdapterWebApiModelsV1LocationsSchoolsSchool.md)

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

<a name="schoolssearch"></a>
# **SchoolsSearch**
> List&lt;DomainPublicAdapterWebApiModelsV1LocationsSchoolsSchool&gt; SchoolsSearch (string coordinate = null)

Searches schools based on specified criteria

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Domain.Api.V1.Api;
using Domain.Api.V1.Client;
using Domain.Api.V1.Model;

namespace Example
{
    public class SchoolsSearchExample
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
            var coordinate = coordinate_example;  // string | Filter schools to include the specified coordinate in their catchment area (lat,long) (optional) 

            try
            {
                // Searches schools based on specified criteria
                List<DomainPublicAdapterWebApiModelsV1LocationsSchoolsSchool> result = apiInstance.SchoolsSearch(coordinate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SchoolsApi.SchoolsSearch: " + e.Message );
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
 **coordinate** | **string**| Filter schools to include the specified coordinate in their catchment area (lat,long) | [optional] 

### Return type

[**List&lt;DomainPublicAdapterWebApiModelsV1LocationsSchoolsSchool&gt;**](DomainPublicAdapterWebApiModelsV1LocationsSchoolsSchool.md)

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

