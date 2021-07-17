# Domain.Api.V1.Model.DomainListingAdminServiceV1ModelOffMarketDetails
Shows offmarket info
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ListingAction** | **string** | Sale or Rent. Optional if Domain Ad ID is provided. | [optional] 
**OffMarketAction** | **string** | Off Market Action | [optional] 
**ListingProvider** | **string** | A string identifying the data provider | [optional] 
**DomainAgencyID** | **int** | Domain Agency ID. Optional if Domain Ad ID is provided. | [optional] 
**ProviderAdId** | **string** | External Advertisement ID. Optional if Domain Ad ID is provided. | [optional] 
**ActionDate** | **DateTime** | The date property was sold, leased or withdrawn | [optional] 
**SoldDetails** | [**DomainListingAdminServiceV1ModelSoldDetails**](DomainListingAdminServiceV1ModelSoldDetails.md) |  | [optional] 
**LeasedDetails** | [**DomainListingAdminServiceV1ModelLeasedDetails**](DomainListingAdminServiceV1ModelLeasedDetails.md) |  | [optional] 
**Comment** | **string** | Extra details for off market action | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

