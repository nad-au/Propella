# Domain.Api.V2.Model.ListingsV2AuctionDetails
The detail's of the auction in case of a listing for sale being auctioned or sold by auction
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AuctionSchedule** | [**ListingsV2AuctionSchedule**](ListingsV2AuctionSchedule.md) |  | [optional] 
**AuctionedPrice** | **int?** | The auctioned price entered by the Advertiser.   This price will only be visible if allowed by the Advertiser  and the listing as been auctioned | [optional] 
**AuctionedDate** | **DateTime?** | The listing&#39;s last auctioned date and time specified by the Advertiser.  This will only be visible if the listing has been auctioned.  DateTime is in AEST (Australian Eastern Standard Time) timezone. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

