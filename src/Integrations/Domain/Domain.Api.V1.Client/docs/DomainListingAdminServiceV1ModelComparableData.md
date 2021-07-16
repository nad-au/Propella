# Domain.Api.V1.Client.Model.DomainListingAdminServiceV1ModelComparableData
Information regarding past comparable   property sales that influenced the setting of teh estimationPrice
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ComparableProperty** | [**List&lt;DomainListingAdminServiceV1ModelPastSaleData&gt;**](DomainListingAdminServiceV1ModelPastSaleData.md) | To be comparable, property must be Of a similar standard or condition to the property for sale  And Sold in the last six months and be within two kilometres of the property for sale (if the property for sale is in the Melbourne metropolitan area)  Or Sold in the last 18 months and be within five kilometres of the property for sale (if the property for sale is outside the Melbourne metropolitan area). | [optional] 
**DeclarationText** | **string** | Text description should be provided   If you reasonably believe that there are less than three comparable sales within the prescribed period outlined above  for ComparableProperty {Domain.Listing.Admin.Model.Entities.ComparableData.ComparableProperty}  Required when no past sale property data   was provided | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

