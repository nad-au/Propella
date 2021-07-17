# Domain.Api.V2.Model.ListingsV2Inspection
Encapsulates the details of a Listing's Inspection
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Recurrence** | [**ListingsV2InspectionRecurrence**](ListingsV2InspectionRecurrence.md) |  | [optional] 
**OpeningDateTime** | **DateTime?** | Opening date and time of the inspection. e.g. 2015-01-01T12:00:00.  Not provided by bulk uploaded listings, in these cases refer to the  inspection description field. DateTime is in AEST (Australian Eastern Standard Time) timezone. | [optional] 
**ClosingDateTime** | **DateTime?** | Closing date and time of the inspection. e.g. 2015-01-01T12:00:00  Not provided by bulk uploaded listings, in these cases refer to the  inspection description field. DateTime is in AEST (Australian Eastern Standard Time) timezone. | [optional] 
**Description** | **string** | Description of the inspection provided by the Advertiser.  When listings are bulk uploaded, inspection times are provided as a string.  Other inspection details will not be provided | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

