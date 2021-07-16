# Domain.Api.V1.Client.Model.BookingsV2RateForNewListingRequest
Provide a summary of the intended listing for which to calculate a rate.
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AgencyId** | **int** | Id of the agency for whom rates are to be calculated. | 
**AgentFirstName** | **string** | The first name of the primary agent associated with the listing. | 
**AgentLastName** | **string** | The last name of the primary agent associated with the listing | 
**AgentEmail** | **string** | The email of the primary agent associated with the listing. | 
**Suburb** | **string** | Suburb for which rates are to be calculated. | 
**Postcode** | **string** | Postcode for which rates are to be calculated. | 
**State** | **string** | State for which rates are to be calculated | 
**PropertyType** | [**ListingsV1PropertyType**](ListingsV1PropertyType.md) |  | 
**IsNewDevelopment** | **bool** | Whether to return the normal or new development rates | 
**ListingType** | [**ListingsV1Objective**](ListingsV1Objective.md) |  | 
**Price** | **double** | The value of the listing | 
**Channel** | [**ListingsV1Channel**](ListingsV1Channel.md) |  | 
**BookingStartDate** | **DateTime?** | Date at which the booking will start. Defaults to today. Allows for returning future contracts/price changes. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

