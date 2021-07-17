# Domain.Api.V2.Model.ListingsV2Status
The lifecycle status of a Listing  * `Unknown` - The listing has an unknown status, this can only be the case if data is somehow corrupted. * `Archived` - The listing has been archived and is inactive. * `UnderOffer` - An offer has been made for the listing. The listing is still active. * `Sold` - The listing has been sold.             The listing is inactive but may appear as sold listing on Domain * `Leased` - The listing has been leased. * `NewDevelopment` - The listing is a New Development Listing.             The listing is active. * `RecentlyUpdated` - The listing or project has been updated in past few days.             The listing is active. * `New` - The listing or project has been created in past few days.             The listing is active. * `Live` - The listing or project is currently live and has not been recently created or updated.             This listing is active. * `Pending` - This status is only used by projects.             It indicates that the project is pending to be activated (start date in the future).             This project is inactive. * `DepositTaken` - Deposit Taken. This listing is still active.
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

