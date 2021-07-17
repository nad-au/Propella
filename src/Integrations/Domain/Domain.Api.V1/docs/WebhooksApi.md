# Domain.Api.V1.Api.WebhooksApi

All URIs are relative to *http://api.domain.com.au*

Method | HTTP request | Description
------------- | ------------- | -------------
[**WebhooksCreateSubscription**](WebhooksApi.md#webhookscreatesubscription) | **PUT** /v1/webhooks/{id}/subscriptions | Creates a subscription
[**WebhooksDeleteSubscription**](WebhooksApi.md#webhooksdeletesubscription) | **DELETE** /v1/subscriptions/{id} | Deletes a webhook subscription
[**WebhooksGetSubscription**](WebhooksApi.md#webhooksgetsubscription) | **GET** /v1/subscriptions/{id} | Retrieves a webhook subscription
[**WebhooksListSubscriptions**](WebhooksApi.md#webhookslistsubscriptions) | **GET** /v1/webhooks/{id}/subscriptions | Retreives all webhook subscriptions


<a name="webhookscreatesubscription"></a>
# **WebhooksCreateSubscription**
> DomainPublicAdapterWebApiModelsV1SubscriptionsSubscription WebhooksCreateSubscription (string id, DomainNotificationPortalV1ModelAddSubscriptionRequest domainNotificationPortalV1ModelAddSubscriptionRequest)

Creates a subscription

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Domain.Api.V1.Api;
using Domain.Api.V1.Client;
using Domain.Api.V1.Model;

namespace Example
{
    public class WebhooksCreateSubscriptionExample
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

            var apiInstance = new WebhooksApi(config);
            var id = id_example;  // string | Webhook identifier
            var domainNotificationPortalV1ModelAddSubscriptionRequest = new DomainNotificationPortalV1ModelAddSubscriptionRequest(); // DomainNotificationPortalV1ModelAddSubscriptionRequest | Subscription data

            try
            {
                // Creates a subscription
                DomainPublicAdapterWebApiModelsV1SubscriptionsSubscription result = apiInstance.WebhooksCreateSubscription(id, domainNotificationPortalV1ModelAddSubscriptionRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WebhooksApi.WebhooksCreateSubscription: " + e.Message );
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
 **id** | **string**| Webhook identifier | 
 **domainNotificationPortalV1ModelAddSubscriptionRequest** | [**DomainNotificationPortalV1ModelAddSubscriptionRequest**](DomainNotificationPortalV1ModelAddSubscriptionRequest.md)| Subscription data | 

### Return type

[**DomainPublicAdapterWebApiModelsV1SubscriptionsSubscription**](DomainPublicAdapterWebApiModelsV1SubscriptionsSubscription.md)

### Authorization

[apikey](../README.md#apikey), [oauth2](../README.md#oauth2), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, text/html, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, text/html

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | BadRequest |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="webhooksdeletesubscription"></a>
# **WebhooksDeleteSubscription**
> void WebhooksDeleteSubscription (string id)

Deletes a webhook subscription

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Domain.Api.V1.Api;
using Domain.Api.V1.Client;
using Domain.Api.V1.Model;

namespace Example
{
    public class WebhooksDeleteSubscriptionExample
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

            var apiInstance = new WebhooksApi(config);
            var id = id_example;  // string | Subscription identifier

            try
            {
                // Deletes a webhook subscription
                apiInstance.WebhooksDeleteSubscription(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WebhooksApi.WebhooksDeleteSubscription: " + e.Message );
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
 **id** | **string**| Subscription identifier | 

### Return type

void (empty response body)

### Authorization

[apikey](../README.md#apikey), [oauth2](../README.md#oauth2), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="webhooksgetsubscription"></a>
# **WebhooksGetSubscription**
> DomainPublicAdapterWebApiModelsV1SubscriptionsSubscription WebhooksGetSubscription (string id)

Retrieves a webhook subscription

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Domain.Api.V1.Api;
using Domain.Api.V1.Client;
using Domain.Api.V1.Model;

namespace Example
{
    public class WebhooksGetSubscriptionExample
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

            var apiInstance = new WebhooksApi(config);
            var id = id_example;  // string | Subscription identifier

            try
            {
                // Retrieves a webhook subscription
                DomainPublicAdapterWebApiModelsV1SubscriptionsSubscription result = apiInstance.WebhooksGetSubscription(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WebhooksApi.WebhooksGetSubscription: " + e.Message );
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
 **id** | **string**| Subscription identifier | 

### Return type

[**DomainPublicAdapterWebApiModelsV1SubscriptionsSubscription**](DomainPublicAdapterWebApiModelsV1SubscriptionsSubscription.md)

### Authorization

[apikey](../README.md#apikey), [oauth2](../README.md#oauth2), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, text/html

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="webhookslistsubscriptions"></a>
# **WebhooksListSubscriptions**
> List&lt;DomainPublicAdapterWebApiModelsV1SubscriptionsSubscription&gt; WebhooksListSubscriptions (string id, int? pageNumber = null, int? pageSize = null)

Retreives all webhook subscriptions

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Domain.Api.V1.Api;
using Domain.Api.V1.Client;
using Domain.Api.V1.Model;

namespace Example
{
    public class WebhooksListSubscriptionsExample
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

            var apiInstance = new WebhooksApi(config);
            var id = id_example;  // string | Subscriber (Webhook) ID
            var pageNumber = 56;  // int? |  (optional) 
            var pageSize = 56;  // int? |  (optional) 

            try
            {
                // Retreives all webhook subscriptions
                List<DomainPublicAdapterWebApiModelsV1SubscriptionsSubscription> result = apiInstance.WebhooksListSubscriptions(id, pageNumber, pageSize);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WebhooksApi.WebhooksListSubscriptions: " + e.Message );
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
 **id** | **string**| Subscriber (Webhook) ID | 
 **pageNumber** | **int?**|  | [optional] 
 **pageSize** | **int?**|  | [optional] 

### Return type

[**List&lt;DomainPublicAdapterWebApiModelsV1SubscriptionsSubscription&gt;**](DomainPublicAdapterWebApiModelsV1SubscriptionsSubscription.md)

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

