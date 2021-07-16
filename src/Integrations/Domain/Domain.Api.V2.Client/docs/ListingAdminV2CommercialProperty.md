# Domain.Api.V2.Client.Model.ListingAdminV2CommercialProperty
Commercial Property
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PropertyType** | **List&lt;string&gt;** | Commercial property types [&#39;aquaculture&#39;, &#39;dairyFarming&#39;, &#39;developmentLand&#39;, &#39;fishingForestry&#39;, &#39;hotelLeisure&#39;, &#39;industrialWarehouse&#39;, &#39;irrigationServices&#39;, &#39;livestock&#39;, &#39;internationalCommercial&#39;, &#39;medicalConsulting&#39;, &#39;offices&#39;, &#39;parkingCarSpace&#39;, &#39;retail&#39;, &#39;ruralCommercialFarming&#39;, &#39;showroomsBulkyGoods&#39;, &#39;servicedOffices&#39;, &#39;other&#39;, &#39;cropping&#39;, &#39;viticulture&#39;, &#39;mixedFarming&#39;, &#39;grazing&#39;, &#39;horticulture&#39;, &#39;equine&#39;, &#39;farmlet&#39;, &#39;orchard&#39;, &#39;ruralLifestyle&#39;]. | 
**BuildingType** | **string** | Building Type | [optional] 
**Parking** | [**ListingAdminV2Parking**](ListingAdminV2Parking.md) |  | [optional] 
**Pdfs** | [**List&lt;ListingAdminV2PropertyPdf&gt;**](ListingAdminV2PropertyPdf.md) | List of PDF files related to the listing | [optional] 
**IsMarkedForLiveability** | **bool** | Is the property liveability compliant | [optional] 
**PropertyName** | **string** | Name of the property up to 70 characters | [optional] 
**Location** | **string** | Short location information up to 30 character, e.g.: Greenhills Beach | [optional] 
**Images** | [**List&lt;ListingAdminV2PropertyMedia&gt;**](ListingAdminV2PropertyMedia.md) | List of image files, photos or floor plans related to the listing. | [optional] 
**Address** | [**ListingAdminV2Address**](ListingAdminV2Address.md) |  | 
**Area** | [**ListingAdminV2Area**](ListingAdminV2Area.md) |  | [optional] 
**LandArea** | [**ListingAdminV2LandArea**](ListingAdminV2LandArea.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

