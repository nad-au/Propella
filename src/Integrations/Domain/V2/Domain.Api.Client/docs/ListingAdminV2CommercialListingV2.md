# Domain.Api.Client.Model.ListingAdminV2CommercialListingV2
Commercial Listing V2
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SalePrice** | [**ListingAdminV2CommercialPrice**](ListingAdminV2CommercialPrice.md) |  | [optional] 
**LeasePrice** | [**ListingAdminV2CommercialPrice**](ListingAdminV2CommercialPrice.md) |  | [optional] 
**Lease** | [**ListingAdminV2Lease**](ListingAdminV2Lease.md) |  | [optional] 
**Eoi** | [**ListingAdminV2EOI**](ListingAdminV2EOI.md) |  | [optional] 
**Tenant** | [**ListingAdminV2Tenant**](ListingAdminV2Tenant.md) |  | [optional] 
**Tender** | [**ListingAdminV2Tender**](ListingAdminV2Tender.md) |  | [optional] 
**OccupancyType** | **string** | Occupancy. Can be &#39;Tenanted&#39;, &#39;Vacant&#39; | [optional] 
**AnnualReturn** | **int** | Integer value of percentage return on this property or business. | [optional] 
**UnitsOffered** | **int** | Integer value of units offered for sale or lease | [optional] 
**UnitDetails** | [**List&lt;ListingAdminV2SpecificUnitDetail&gt;**](ListingAdminV2SpecificUnitDetail.md) | Units details | [optional] 
**Nabers** | **double** | The NABERS Rating is the energy efficiency rating that the property has been measured to have.   This rating is measured in increments of .5 and can range from 0 to 6.   The NABERS rating is required for spaces within office buildings of 1000 square metres or more.  For more information on the NABERS rating system please visit http://www.nabers.gov.au | [optional] 
**SaleTerms** | **string** | Information relating to aspects of the sale, such as required deposit, settlement time. Up to 50 characters, optional. Ignored for lease listings | [optional] 
**Auction** | [**ListingAdminV2CommercialAuction**](ListingAdminV2CommercialAuction.md) |  | [optional] 
**PropertyDetails** | [**ListingAdminV2CommercialProperty**](ListingAdminV2CommercialProperty.md) |  | 
**ConjunctionAgents** | [**List&lt;ListingAdminV2AgentContact&gt;**](ListingAdminV2AgentContact.md) | List of conjunction agents | [optional] 
**Highlights** | **List&lt;string&gt;** | Highlight Items | [optional] 
**UnderOfferOrContract** | **bool** | Set for Sale listings only | [optional] 
**DomainAdId** | **int** | Domain Advertisement Id, not applicable for creating new ads.  Mandatory when updating a listing that belongs to an agency that  is in the process of being migrated between listing providers. | [optional] 
**ListingProvider** | **string** | A string identifying the data provider | [optional] 
**DomainAgencyID** | **int** | The Domain Agency Id number | 
**ProviderAdId** | **string** | External Advertisement Id of up to 50 characters will be stored.&lt;br /&gt;  This value is used to identify an Advertisement for updates and should be unique for listing provider.&lt;br /&gt;  This value is case-insensitive (meaning AAAA will update aaaa). | 
**Features** | **string** |  Comma-separated list of features. 1000 characters in length. Select as appropriate or write your own.  INSIDE: Air conditioning, Ensuite, Floorboards, Indoor Spa, Gym, Alarm System, Intercom, Built in wardrobes, Furnished, Internal Laundry, Pets allowed, Cable or Satellite, Gas, Broadband internet access, Bath, Fireplace(s), Separate Dining Room, Heating, Dishwasher, Study.  OUTSIDE: Tennis Court, Secure Parking, Shed, Fully fenced, Balcony / Deck, Garden / Courtyard, Swimming Pool, Outdoor Spa.  LOCATION: Ground floor, Water Views, North Facing, City Views.  ECO FRIENDLY: Double glazed windows, Energy efficient appliances, Water efficient appliances, Wall / ceiling insulation, Rainwater storage tank, Greywater system, Water efficient fixtures, Solar hot water, Solar panels | [optional] 
**Description** | **string** | Description of the property.  6000 characters in length. The following HTML elements are permitted: &amp;lt;br /&amp;gt;, &amp;lt;p&amp;gt;&amp;lt;/p&amp;gt;, &amp;amp;nbsp;. HTML must be well-formed.  Carriage Returns are interpreted as line breaks. Foreign characters must be HTML encoded, e.g., façade for façade | [optional] 
**Summary** | **string** | &#39;Headline&#39; Any HTML stripped out.  If the Summary is less than 80 characters long then the description is concatenated to it and the total trimmed to 250 characters. | [optional] 
**InspectionDetails** | [**ListingAdminV2InspectionDetails**](ListingAdminV2InspectionDetails.md) |  | [optional] 
**Media** | [**List&lt;ListingAdminV2PropertyMedia&gt;**](ListingAdminV2PropertyMedia.md) | Links to VideoURL, virtual tour or weblink. Maximum length of media URLs is 255 characters. | [optional] 
**ListingAction** | **string** | Sale or Rent | 
**ContactPreference** | **string** | Indicates the listing preferred contact method. Default by both phone and email if not provided. | [optional] 
**Contacts** | [**List&lt;ListingAdminV2Contact&gt;**](ListingAdminV2Contact.md) | Minimum required attributes: First name, last name and E-mail.  If the DomainAgentId is provided, contact information will be based on the existing agent found for that id.  Otherwise first name, last name and email will be used to find the matching contact. A new contact will be created if no contact can be found. | [optional] 
**OtherEnquiryEmail** | **string** | Sets an additional Email Address to which enquiries on the Listing will be sent | [optional] 
**ReceiveEmailsToDefaultAddress** | **bool** | Send email enquiries to the default address for this listing type | [optional] 
**IsRural** | **bool** | True if the property is rural | [optional] 
**Supplementary** | [**List&lt;ListingAdminV2ListingSupplementary&gt;**](ListingAdminV2ListingSupplementary.md) | Rural attributes    *Improvements* (optional)    Available &#x60;types&#x60; (fixed list, optional):  * Machinery Shed  * Shearing Shed  * Workshop  * Shearers Quarters  * Silos  * Other Housing  * Managers Accommodation    *Fencing* (optional)    &#x60;description&#x60; (string, optional): free text fencing description, maximum 250 characters.    *Yards* (optional)    Available &#x60;types&#x60; (fixed list, optional):  * Sheep  * Cattle    *Homestead* (optional)    &#x60;description&#x60; (string, optional): description of the homestead and construction, maximum 250 characters.    &#x60;metadata&#x60; (optional)  * &#x60;area&#x60; (decimal, optional): homestead area in square metres.    Available &#x60;types&#x60; (fixed list, optional):  * Office  * Ensuite  * Tennis Court  * Mains Gas  * Floorboards  * Internal Laundry    *Water* (optional)    &#x60;description&#x60; (string, optional): water comments, maximum 250 characters.    Available &#x60;types&#x60; (fixed list, optional):  * Tank  * Well  * Reticulated  * Bores  * Springs  * Creeks  * Dams  * River    *Crops* (optional)    &#x60;description&#x60; (string, optional): description of the crops, maximum 250 characters.    &#x60;metadata&#x60; (optional)  * &#x60;croppedAnnually&#x60; (decimal, optional): average annual area cropped in hectares.  * &#x60;fallowAnnually&#x60; (decimal, optional): average annual fallow area in hectares.  * &#x60;pastures&#x60; (string, optional): description of pastures available, maximum 250 characters.    *Livestock* (optional)    &#x60;description&#x60; (string, optional): additional comments, maximum 250 characters.    &#x60;metadata&#x60; (optional)  * &#x60;capacity&#x60; (decimal, optional): property carrying capacity in DSE (unit of carry capacity).    Available &#x60;types&#x60; (fixed list, optional):  * Sheep  * Pigs  * Cattle  * Poultry  * Horses  * Exotic  * Goats  * Stud    *Inclusions* (optional)    &#x60;description&#x60; (string, optional): description of plant and machinery included in sale, maximum 250 characters.    &#x60;metadata&#x60; (optional)  * &#x60;livestock&#x60; (string, optional): description of livestock included in sale, maximum 250 characters.  * &#x60;crop&#x60; (string, optional): description of crops included in sale, maximum 250 characters.    *Irrigation* (optional)    &#x60;description&#x60; (string, optional): irrigation comments, maximum 250 characters    &#x60;metadata&#x60; (optional)  * &#x60;rainfall&#x60; (decimal, optional): annual rainfall in millimetres. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

