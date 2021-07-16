# Domain.Api.V1.Client.Api.StatisticsApi

All URIs are relative to *http://api.domain.com.au*

Method | HTTP request | Description
------------- | ------------- | -------------
[**StatisticsPost**](StatisticsApi.md#statisticspost) | **POST** /v1/statistics/{event} | Record a statistic event along with its associated metadata (if applicable)


<a name="statisticspost"></a>
# **StatisticsPost**
> void StatisticsPost (string _event, Object body)

Record a statistic event along with its associated metadata (if applicable)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Domain.Api.V1.Client.Api;
using Domain.Api.V1.Client.Client;
using Domain.Api.V1.Client.Model;

namespace Example
{
    public class StatisticsPostExample
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

            var apiInstance = new StatisticsApi(config);
            var _event = _event_example;  // string | The event type
            var body = ;  // Object | A JSON object dictionary of the metadata associated with the event.

            try
            {
                // Record a statistic event along with its associated metadata (if applicable)
                apiInstance.StatisticsPost(_event, body);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StatisticsApi.StatisticsPost: " + e.Message );
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
 **_event** | **string**| The event type | 
 **body** | **Object**| A JSON object dictionary of the metadata associated with the event. | 

### Return type

void (empty response body)

### Authorization

[apikey](../README.md#apikey), [oauth2](../README.md#oauth2), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, text/html, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, text/html, application/xml, text/xml

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **202** | The statistic event has been queued for reporting. |  -  |
| **400** | There was a validation error with the supplied data. Check the error message for details |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

