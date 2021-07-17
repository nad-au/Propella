# Domain.Api.V1.Model.ListingsV2Project
A structured representation of a Project
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ProjectProfileType** | [**ListingsV2ProjectProfileType**](ListingsV2ProjectProfileType.md) |  | [optional] 
**Id** | **int** | Project ID | [optional] 
**Name** | **string** | Project Name | [optional] 
**StartDate** | **DateTime?** | Start date. DateTime is in AEST (Australian Eastern Standard Time) timezone. | [optional] 
**EndDate** | **DateTime?** | End date.DateTime is in AEST (Australian Eastern Standard Time) timezone. | [optional] 
**Address** | [**ListingsV2ProjectAddressParts**](ListingsV2ProjectAddressParts.md) |  | [optional] 
**ViewingAddress** | [**ListingsV2ProjectAddressParts**](ListingsV2ProjectAddressParts.md) |  | [optional] 
**PropertyTypes** | [**List&lt;ListingsV2PropertyType&gt;**](ListingsV2PropertyType.md) | Property types available at the project. | [optional] 
**DisplayableAddress** | [**ListingsV2ProjectAddressParts**](ListingsV2ProjectAddressParts.md) |  | [optional] 
**EnquiryEmailAddress** | **string** | Enquiry email address | [optional] 
**AdvertiserIdentifiers** | [**ListingsV2AdvertiserIdentifiers**](ListingsV2AdvertiserIdentifiers.md) |  | [optional] 
**ProviderDetails** | [**ListingsV2ProviderDetails**](ListingsV2ProviderDetails.md) |  | [optional] 
**Media** | [**List&lt;ListingsV2ProjectMedia&gt;**](ListingsV2ProjectMedia.md) | Images and videos | [optional] 
**ProjectUrl** | **string** | Project URL | [optional] 
**Headline** | **string** | Headline | [optional] 
**Tagline** | **string** | Tag line | [optional] 
**DisplayAsLastUpdated** | **DateTime** | The &#39;last updated&#39; date to show to customers. DateTime is in AEST (Australian Eastern Standard Time) timezone. | [optional] 
**ModifiedBy** | **string** | Last updated by | [optional] 
**ModifiedDate** | **DateTime** | Last updated, used for auditing. DateTime is in AEST (Australian Eastern Standard Time) timezone. | [optional] 
**CreatedBy** | **string** | Created by | [optional] 
**CreatedDate** | **DateTime** | Created date. DateTime is in AEST (Australian Eastern Standard Time) timezone. | [optional] 
**BackgroundColour** | **string** | Background colour | [optional] 
**Description** | **string** | Description | [optional] 
**AppointmentRequired** | **bool** | If inspections require an appointment. | [optional] 
**Features** | **List&lt;string&gt;** | Features | [optional] 
**PriceFrom** | **double?** | Price from | [optional] 
**PriceTo** | **double?** | Price to | [optional] 
**BannerUrl** | **string** | Banner URL | [optional] 
**BigBannerUrl** | **string** | Big banner URL | [optional] 
**SmallBannerUrl** | **string** | Small banner URL | [optional] 
**LogoUrl** | **string** | Logo URL | [optional] 
**Pdfs** | [**List&lt;ListingsV2PdfUpload&gt;**](ListingsV2PdfUpload.md) | PDF files, such as brochures etc. | [optional] 
**InspectionDetails** | [**ListingsV2PropertyInspections**](ListingsV2PropertyInspections.md) |  | [optional] 
**NumberOfFloors** | **int?** | Number of floors | [optional] 
**NumberOfApartments** | **int?** | Number of apartments | [optional] 
**EstimatedCompletionDate** | **DateTime?** | Estimated completion date. DateTime in AEST (Australian Eastern Standard Time) timezone. | [optional] 
**StartingPrice** | **double?** | Lowest child listing price | [optional] 
**ChildListingIds** | **List&lt;int&gt;** | Child listing identifiers. | [optional] 
**LinkedProjectIds** | **List&lt;int&gt;** | Linked project identifiers. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

