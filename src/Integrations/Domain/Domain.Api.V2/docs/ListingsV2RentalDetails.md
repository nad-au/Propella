# Domain.Api.V2.Model.ListingsV2RentalDetails
The rental detail's of the listing in case of it being for rent or leased
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RentalMethod** | [**ListingsV2RentalMethod**](ListingsV2RentalMethod.md) |  | [optional] 
**Source** | [**ListingsV2PublishSource**](ListingsV2PublishSource.md) |  | [optional] 
**LeasedDate** | **DateTime?** | The Date the listing was leased. DateTime is in AEST (Australian Eastern Standard Time) timezone. | [optional] 
**LeasedPrice** | **int?** | The last leased price entered by the Advertiser   This price will only be visible if allowed by the Advertiser  and the listing as been leased | [optional] 
**CanDisplayPrice** | **bool** | Indicates whether this instance can display price | [optional] 
**LeasedMonths** | **int?** | The number of months the property was last leased for  This will only be visible if the property has been leased | [optional] 
**TermOfLeaseFrom** | **int?** | Lease term range from | [optional] 
**TermOfLeaseTo** | **int?** | Lease term range to | [optional] 
**LeaseOutgoings** | **int?** | Outgoing cost of current lease | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

