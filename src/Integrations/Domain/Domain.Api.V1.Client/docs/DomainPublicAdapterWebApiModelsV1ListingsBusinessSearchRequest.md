# Domain.Api.V1.Client.Model.DomainPublicAdapterWebApiModelsV1ListingsBusinessSearchRequest
Represents a CRE Business Search Request
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PageNumber** | **int** |  | [optional] 
**AdvertiserId** | **int** | AdvertiserId e.g. An Agency ID | [optional] 
**PropertyTypes** | **List&lt;string&gt;** | Listing property types | [optional] 
**Keywords** | **List&lt;string&gt;** | Search listings by keyword | [optional] 
**BrandId** | **int** | The franchise brand ID | [optional] 
**FranchiseGroupId** | **int** | The franchise group ID. A franchise group owns multiple franchise brands. | [optional] 
**Locations** | [**List&lt;DomainPublicAdapterWebApiModelsV1ListingsBusinessLocationSearch&gt;**](DomainPublicAdapterWebApiModelsV1ListingsBusinessLocationSearch.md) | Location search criteria | [optional] 
**PageSize** | **int** | Search results page size | [optional] 
**Price** | [**DomainPublicAdapterWebApiModelsV1ListingsBusinessPriceSearch**](DomainPublicAdapterWebApiModelsV1ListingsBusinessPriceSearch.md) |  | [optional] 
**Sort** | **string** | Sorting order | [optional] 
**SearchMode** | **string** | Search mode | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

