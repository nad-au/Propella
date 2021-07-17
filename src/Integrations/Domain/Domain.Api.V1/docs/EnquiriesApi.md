# Domain.Api.V1.Api.EnquiriesApi

All URIs are relative to *http://api.domain.com.au*

Method | HTTP request | Description
------------- | ------------- | -------------
[**EnquiriesGet**](EnquiriesApi.md#enquiriesget) | **GET** /v1/enquiries/{id} | Retrieves a specific enquiry.
[**EnquiriesPost**](EnquiriesApi.md#enquiriespost) | **POST** /v1/enquiries | Sends an enquiry for listing, agency, etc... (based on the enquiry type and referenceid).  Recipients and template will be automatically selected.
[**EnquiriesSearch**](EnquiriesApi.md#enquiriessearch) | **GET** /v1/enquiries | Searches enquiries based on agents or agencies.


<a name="enquiriesget"></a>
# **EnquiriesGet**
> DomainPublicAdapterWebApiModelsV1EnquiriesEnquiryReport EnquiriesGet (string id)

Retrieves a specific enquiry.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Domain.Api.V1.Api;
using Domain.Api.V1.Client;
using Domain.Api.V1.Model;

namespace Example
{
    public class EnquiriesGetExample
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

            var apiInstance = new EnquiriesApi(config);
            var id = id_example;  // string | Enquiry identifier

            try
            {
                // Retrieves a specific enquiry.
                DomainPublicAdapterWebApiModelsV1EnquiriesEnquiryReport result = apiInstance.EnquiriesGet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EnquiriesApi.EnquiriesGet: " + e.Message );
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
 **id** | **string**| Enquiry identifier | 

### Return type

[**DomainPublicAdapterWebApiModelsV1EnquiriesEnquiryReport**](DomainPublicAdapterWebApiModelsV1EnquiriesEnquiryReport.md)

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

<a name="enquiriespost"></a>
# **EnquiriesPost**
> DomainEnquiryServiceV1ModelGroupEnquiryServiceModelsEnquiryResponse EnquiriesPost (DomainPublicAdapterWebApiModelsV1EnquiriesEnquiry domainPublicAdapterWebApiModelsV1EnquiriesEnquiry)

Sends an enquiry for listing, agency, etc... (based on the enquiry type and referenceid).  Recipients and template will be automatically selected.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Domain.Api.V1.Api;
using Domain.Api.V1.Client;
using Domain.Api.V1.Model;

namespace Example
{
    public class EnquiriesPostExample
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

            var apiInstance = new EnquiriesApi(config);
            var domainPublicAdapterWebApiModelsV1EnquiriesEnquiry = new DomainPublicAdapterWebApiModelsV1EnquiriesEnquiry(); // DomainPublicAdapterWebApiModelsV1EnquiriesEnquiry | The enquiry object

            try
            {
                // Sends an enquiry for listing, agency, etc... (based on the enquiry type and referenceid).  Recipients and template will be automatically selected.
                DomainEnquiryServiceV1ModelGroupEnquiryServiceModelsEnquiryResponse result = apiInstance.EnquiriesPost(domainPublicAdapterWebApiModelsV1EnquiriesEnquiry);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EnquiriesApi.EnquiriesPost: " + e.Message );
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
 **domainPublicAdapterWebApiModelsV1EnquiriesEnquiry** | [**DomainPublicAdapterWebApiModelsV1EnquiriesEnquiry**](DomainPublicAdapterWebApiModelsV1EnquiriesEnquiry.md)| The enquiry object | 

### Return type

[**DomainEnquiryServiceV1ModelGroupEnquiryServiceModelsEnquiryResponse**](DomainEnquiryServiceV1ModelGroupEnquiryServiceModelsEnquiryResponse.md)

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

<a name="enquiriessearch"></a>
# **EnquiriesSearch**
> List&lt;DomainPublicAdapterWebApiModelsV1EnquiriesEnquiryReport&gt; EnquiriesSearch (int? agencyId = null, int? agentId = null, DateTime? from = null, DateTime? to = null, int? pageNumber = null)

Searches enquiries based on agents or agencies.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Domain.Api.V1.Api;
using Domain.Api.V1.Client;
using Domain.Api.V1.Model;

namespace Example
{
    public class EnquiriesSearchExample
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

            var apiInstance = new EnquiriesApi(config);
            var agencyId = 56;  // int? | Agency identifier (optional) 
            var agentId = 56;  // int? | Agent identifier (optional) 
            var from = 2013-10-20T19:20:30+01:00;  // DateTime? | Enquiries received from (optional) 
            var to = 2013-10-20T19:20:30+01:00;  // DateTime? | Enquiries received up to (optional) 
            var pageNumber = 56;  // int? | Page number for paginated results (25 per page) (optional) 

            try
            {
                // Searches enquiries based on agents or agencies.
                List<DomainPublicAdapterWebApiModelsV1EnquiriesEnquiryReport> result = apiInstance.EnquiriesSearch(agencyId, agentId, from, to, pageNumber);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EnquiriesApi.EnquiriesSearch: " + e.Message );
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
 **agencyId** | **int?**| Agency identifier | [optional] 
 **agentId** | **int?**| Agent identifier | [optional] 
 **from** | **DateTime?**| Enquiries received from | [optional] 
 **to** | **DateTime?**| Enquiries received up to | [optional] 
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

