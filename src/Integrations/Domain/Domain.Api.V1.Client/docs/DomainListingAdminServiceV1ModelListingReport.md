# Domain.Api.V1.Client.Model.DomainListingAdminServiceV1ModelListingReport
Represent current listing status and aggregation of status messages
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ProcessStatus** | **string** | Status of listing been processed  * Queued - We received request  * Processing - Request been processed  * Processed - Successful processed request  * Failed - Processing failed  * Error - Individual errors encountered | [optional] 
**AgencyId** | **long** | AgencyId from Domain | [optional] 
**ProviderId** | **string** | ProviderId for the agency | [optional] 
**ProviderAdId** | **string** | Listing identifier provided by CRM | [optional] 
**AdId** | **List&lt;long&gt;** | Advertisement Id from domain | [optional] 
**QualityScore** | **int** | Quality score of the listing, based on data completeness | [optional] 
**Events** | [**List&lt;DomainListingAdminServiceV1ModelModelEvent&gt;**](DomainListingAdminServiceV1ModelModelEvent.md) | All Events associated with this processing request | [optional] 
**Versions** | [**List&lt;DomainListingAdminServiceV1ModelReportVersion&gt;**](DomainListingAdminServiceV1ModelReportVersion.md) | version list | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

