# Domain.Api.V2.Client.Model.ListingAdminV2ResidentialOffMarketProperty
Residential off market property
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PropertyType** | **List&lt;string&gt;** | Residential property types&lt;br /&gt;  &#39;Retirement&#39; requires at least one more property type to be specified with it (for example: \&quot;Retirement, ApartmentUnitFlat\&quot;) [&#39;acreageSemiRural&#39;, &#39;apartmentUnitFlat&#39;, &#39;aquaculture&#39;, &#39;blockOfUnits&#39;, &#39;carSpace&#39;, &#39;dairyFarming&#39;, &#39;developmentSite&#39;, &#39;duplex&#39;, &#39;farm&#39;, &#39;fishingForestry&#39;, &#39;newHomeDesigns&#39;, &#39;house&#39;, &#39;newHouseLand&#39;, &#39;irrigationServices&#39;, &#39;newLand&#39;, &#39;livestock&#39;, &#39;newApartments&#39;, &#39;penthouse&#39;, &#39;retirement&#39;, &#39;rural&#39;, &#39;semiDetached&#39;, &#39;specialistFarm&#39;, &#39;studio&#39;, &#39;terrace&#39;, &#39;townhouse&#39;, &#39;vacantLand&#39;, &#39;villa&#39;, &#39;cropping&#39;, &#39;viticulture&#39;, &#39;mixedFarming&#39;, &#39;grazing&#39;, &#39;horticulture&#39;, &#39;equine&#39;, &#39;farmlet&#39;, &#39;orchard&#39;, &#39;ruralLifestyle&#39;]. | 
**BedRooms** | **int** | Number of bedrooms | [optional] 
**BathRooms** | **int** | Number of bathrooms | [optional] 
**ParkingInfo** | [**ListingAdminV2ParkingInfo**](ListingAdminV2ParkingInfo.md) |  | [optional] 
**Images** | [**List&lt;ListingAdminV2PropertyMedia&gt;**](ListingAdminV2PropertyMedia.md) | List of image files, photos or floor plans related to the listing. | [optional] 
**Address** | [**ListingAdminV2Address**](ListingAdminV2Address.md) |  | 
**Area** | [**ListingAdminV2Area**](ListingAdminV2Area.md) |  | [optional] 
**LandArea** | [**ListingAdminV2LandArea**](ListingAdminV2LandArea.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

