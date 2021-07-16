# Domain.Api.V1.Client.Api.SuburbPerformanceStatisticsApi

All URIs are relative to *http://api.domain.com.au*

Method | HTTP request | Description
------------- | ------------- | -------------
[**SuburbPerformanceStatisticsGet**](SuburbPerformanceStatisticsApi.md#suburbperformancestatisticsget) | **GET** /v1/suburbPerformanceStatistics | Retrieves suburb performance data


<a name="suburbperformancestatisticsget"></a>
# **SuburbPerformanceStatisticsGet**
> DomainAPMServiceV2ModelAPMAPIModelsSuburbV2SuburbPerformanceModel SuburbPerformanceStatisticsGet (string state, int suburbId, string propertyCategory, int chronologicalSpan, int tPlusFrom, int tPlusTo, string bedrooms = null, string values = null)

Retrieves suburb performance data

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Domain.Api.V1.Client.Api;
using Domain.Api.V1.Client.Client;
using Domain.Api.V1.Client.Model;

namespace Example
{
    public class SuburbPerformanceStatisticsGetExample
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

            var apiInstance = new SuburbPerformanceStatisticsApi(config);
            var state = state_example;  // string | State where the suburb is
            var suburbId = 56;  // int | Suburb Identifier.  Use the `addressLocators` resource to determine the suburbId.
            var propertyCategory = propertyCategory_example;  // string | Property Category. Valid values are: `house`, `unit`, `land`
            var chronologicalSpan = 56;  // int | The size of each chunk of information we want in months. 3, 6, or 12.
            var tPlusFrom = 56;  // int | Countdown number in chronological spans from the current (current chronological span is 1)
            var tPlusTo = 56;  // int | Countdown number in chronological spans from the current (current chronological span is 1, 2 chronological spans ago is 3)
            var bedrooms = bedrooms_example;  // string | Restrict statistics to properties with this number of bedrooms (optional) 
            var values = values_example;  // string | Values to be returned for the series.  If the field is not provided, all available values for the SeriesInfo will be returned. You can specify multiple values using comma separated text.  Valid values are: `MedianSoldPrice`, `AuctionNumberAuctioned`, `AuctionNumberSold`, `AuctionNumberWithdrawn`, `NumberSold`, `LowestSoldPrice`, `HighestSoldPrice`, `5thPercentileSoldPrice`, `25thPercentileSoldPrice`, `75thPercentileSoldPrice`, `95thPercentileSoldPrice`, `DaysOnMarket`, `DiscountPercentage`, `MedianRentListingPrice`, `NumberRentListing`, `HighestRentListingPrice`, `LowestRentListingPrice`, `MedianSaleListingPrice`, `NumberSaleListing`, `HighestSaleListingPrice`, `LowestSaleListingPrice` (optional) 

            try
            {
                // Retrieves suburb performance data
                DomainAPMServiceV2ModelAPMAPIModelsSuburbV2SuburbPerformanceModel result = apiInstance.SuburbPerformanceStatisticsGet(state, suburbId, propertyCategory, chronologicalSpan, tPlusFrom, tPlusTo, bedrooms, values);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SuburbPerformanceStatisticsApi.SuburbPerformanceStatisticsGet: " + e.Message );
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
 **state** | **string**| State where the suburb is | 
 **suburbId** | **int**| Suburb Identifier.  Use the &#x60;addressLocators&#x60; resource to determine the suburbId. | 
 **propertyCategory** | **string**| Property Category. Valid values are: &#x60;house&#x60;, &#x60;unit&#x60;, &#x60;land&#x60; | 
 **chronologicalSpan** | **int**| The size of each chunk of information we want in months. 3, 6, or 12. | 
 **tPlusFrom** | **int**| Countdown number in chronological spans from the current (current chronological span is 1) | 
 **tPlusTo** | **int**| Countdown number in chronological spans from the current (current chronological span is 1, 2 chronological spans ago is 3) | 
 **bedrooms** | **string**| Restrict statistics to properties with this number of bedrooms | [optional] 
 **values** | **string**| Values to be returned for the series.  If the field is not provided, all available values for the SeriesInfo will be returned. You can specify multiple values using comma separated text.  Valid values are: &#x60;MedianSoldPrice&#x60;, &#x60;AuctionNumberAuctioned&#x60;, &#x60;AuctionNumberSold&#x60;, &#x60;AuctionNumberWithdrawn&#x60;, &#x60;NumberSold&#x60;, &#x60;LowestSoldPrice&#x60;, &#x60;HighestSoldPrice&#x60;, &#x60;5thPercentileSoldPrice&#x60;, &#x60;25thPercentileSoldPrice&#x60;, &#x60;75thPercentileSoldPrice&#x60;, &#x60;95thPercentileSoldPrice&#x60;, &#x60;DaysOnMarket&#x60;, &#x60;DiscountPercentage&#x60;, &#x60;MedianRentListingPrice&#x60;, &#x60;NumberRentListing&#x60;, &#x60;HighestRentListingPrice&#x60;, &#x60;LowestRentListingPrice&#x60;, &#x60;MedianSaleListingPrice&#x60;, &#x60;NumberSaleListing&#x60;, &#x60;HighestSaleListingPrice&#x60;, &#x60;LowestSaleListingPrice&#x60; | [optional] 

### Return type

[**DomainAPMServiceV2ModelAPMAPIModelsSuburbV2SuburbPerformanceModel**](DomainAPMServiceV2ModelAPMAPIModelsSuburbV2SuburbPerformanceModel.md)

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

