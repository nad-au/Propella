# Domain.Api.V1.Client.Model.DomainPublicAdapterWebApiModelsV1ListingsCommercialSearchRequest
Listing search criteria
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PageNumber** | **int** |  | [optional] 
**AdvertiserId** | **int** | Agency ID | [optional] 
**PageSize** | **int** | Search results page size | [optional] 
**PropertyTypes** | **List&lt;string&gt;** | Listing property types | [optional] 
**Price** | [**DomainPublicAdapterWebApiModelsV1ListingsCommercialPriceSearch**](DomainPublicAdapterWebApiModelsV1ListingsCommercialPriceSearch.md) |  | [optional] 
**Locations** | [**List&lt;DomainPublicAdapterWebApiModelsV1ListingsCommercialLocationSearch&gt;**](DomainPublicAdapterWebApiModelsV1ListingsCommercialLocationSearch.md) | Location search criteria | [optional] 
**Keywords** | **List&lt;string&gt;** | Search listings by keyword | [optional] 
**GeoWindow** | [**DomainPublicAdapterWebApiModelsV1ListingsCommercialGeoWindow**](DomainPublicAdapterWebApiModelsV1ListingsCommercialGeoWindow.md) |  | [optional] 
**LandAreaMin** | **int** | Minimum land area | [optional] 
**LandAreaMax** | **int** | Maximum land area | [optional] 
**BuildingSizeMin** | **int** | Minimum building area | [optional] 
**BuildingSizeMax** | **int** | Maximum building area | [optional] 
**SearchMode** | **string** | Search mode | [optional] 
**Occupancy** | **string** | Occupancy | [optional] 
**Sort** | **string** | Sorting order | [optional] 
**SaleType** | **string** | Sale type | [optional] 
**PropertyTitle** | **string** | Property title | [optional] 
**Parking** | [**DomainPublicAdapterWebApiModelsV1ListingsCommercialParkingSearch**](DomainPublicAdapterWebApiModelsV1ListingsCommercialParkingSearch.md) |  | [optional] 
**ExclusionTypes** | **List&lt;string&gt;** | Exclusion Types | [optional] 
**AnnualReturn** | **int** | Minimum annual return (in percents) | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

