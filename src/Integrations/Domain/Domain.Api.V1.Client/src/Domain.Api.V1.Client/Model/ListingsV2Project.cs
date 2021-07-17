/*
 * Domain Public API
 *
 * See https://developer.domain.com.au for more information
 *
 * The version of the OpenAPI document: v1
 * Contact: api@domain.com.au
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Domain.Api.V1.Client.Client.OpenAPIDateConverter;

namespace Domain.Api.V1.Client.Model
{
    /// <summary>
    /// A structured representation of a Project
    /// </summary>
    [DataContract(Name = "Listings.V2.Project")]
    public partial class ListingsV2Project : IEquatable<ListingsV2Project>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListingsV2Project" /> class.
        /// </summary>
        /// <param name="projectProfileType">projectProfileType.</param>
        /// <param name="id">Project ID.</param>
        /// <param name="name">Project Name.</param>
        /// <param name="startDate">Start date. DateTime is in AEST (Australian Eastern Standard Time) timezone..</param>
        /// <param name="endDate">End date.DateTime is in AEST (Australian Eastern Standard Time) timezone..</param>
        /// <param name="address">address.</param>
        /// <param name="viewingAddress">viewingAddress.</param>
        /// <param name="propertyTypes">Property types available at the project..</param>
        /// <param name="displayableAddress">displayableAddress.</param>
        /// <param name="enquiryEmailAddress">Enquiry email address.</param>
        /// <param name="advertiserIdentifiers">advertiserIdentifiers.</param>
        /// <param name="providerDetails">providerDetails.</param>
        /// <param name="media">Images and videos.</param>
        /// <param name="projectUrl">Project URL.</param>
        /// <param name="headline">Headline.</param>
        /// <param name="tagline">Tag line.</param>
        /// <param name="displayAsLastUpdated">The &#39;last updated&#39; date to show to customers. DateTime is in AEST (Australian Eastern Standard Time) timezone..</param>
        /// <param name="modifiedBy">Last updated by.</param>
        /// <param name="modifiedDate">Last updated, used for auditing. DateTime is in AEST (Australian Eastern Standard Time) timezone..</param>
        /// <param name="createdBy">Created by.</param>
        /// <param name="createdDate">Created date. DateTime is in AEST (Australian Eastern Standard Time) timezone..</param>
        /// <param name="backgroundColour">Background colour.</param>
        /// <param name="description">Description.</param>
        /// <param name="appointmentRequired">If inspections require an appointment..</param>
        /// <param name="features">Features.</param>
        /// <param name="priceFrom">Price from.</param>
        /// <param name="priceTo">Price to.</param>
        /// <param name="bannerUrl">Banner URL.</param>
        /// <param name="bigBannerUrl">Big banner URL.</param>
        /// <param name="smallBannerUrl">Small banner URL.</param>
        /// <param name="logoUrl">Logo URL.</param>
        /// <param name="pdfs">PDF files, such as brochures etc..</param>
        /// <param name="inspectionDetails">inspectionDetails.</param>
        /// <param name="numberOfFloors">Number of floors.</param>
        /// <param name="numberOfApartments">Number of apartments.</param>
        /// <param name="estimatedCompletionDate">Estimated completion date. DateTime in AEST (Australian Eastern Standard Time) timezone..</param>
        /// <param name="startingPrice">Lowest child listing price.</param>
        /// <param name="childListingIds">Child listing identifiers..</param>
        /// <param name="linkedProjectIds">Linked project identifiers..</param>
        public ListingsV2Project(ListingsV2ProjectProfileType projectProfileType = default(ListingsV2ProjectProfileType), int id = default(int), string name = default(string), DateTime? startDate = default(DateTime?), DateTime? endDate = default(DateTime?), ListingsV2ProjectAddressParts address = default(ListingsV2ProjectAddressParts), ListingsV2ProjectAddressParts viewingAddress = default(ListingsV2ProjectAddressParts), List<ListingsV2PropertyType> propertyTypes = default(List<ListingsV2PropertyType>), ListingsV2ProjectAddressParts displayableAddress = default(ListingsV2ProjectAddressParts), string enquiryEmailAddress = default(string), ListingsV2AdvertiserIdentifiers advertiserIdentifiers = default(ListingsV2AdvertiserIdentifiers), ListingsV2ProviderDetails providerDetails = default(ListingsV2ProviderDetails), List<ListingsV2ProjectMedia> media = default(List<ListingsV2ProjectMedia>), string projectUrl = default(string), string headline = default(string), string tagline = default(string), DateTime displayAsLastUpdated = default(DateTime), string modifiedBy = default(string), DateTime modifiedDate = default(DateTime), string createdBy = default(string), DateTime createdDate = default(DateTime), string backgroundColour = default(string), string description = default(string), bool appointmentRequired = default(bool), List<string> features = default(List<string>), double? priceFrom = default(double?), double? priceTo = default(double?), string bannerUrl = default(string), string bigBannerUrl = default(string), string smallBannerUrl = default(string), string logoUrl = default(string), List<ListingsV2PdfUpload> pdfs = default(List<ListingsV2PdfUpload>), ListingsV2PropertyInspections inspectionDetails = default(ListingsV2PropertyInspections), int? numberOfFloors = default(int?), int? numberOfApartments = default(int?), DateTime? estimatedCompletionDate = default(DateTime?), double? startingPrice = default(double?), List<int> childListingIds = default(List<int>), List<int> linkedProjectIds = default(List<int>))
        {
            this.ProjectProfileType = projectProfileType;
            this.Id = id;
            this.Name = name;
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.Address = address;
            this.ViewingAddress = viewingAddress;
            this.PropertyTypes = propertyTypes;
            this.DisplayableAddress = displayableAddress;
            this.EnquiryEmailAddress = enquiryEmailAddress;
            this.AdvertiserIdentifiers = advertiserIdentifiers;
            this.ProviderDetails = providerDetails;
            this.Media = media;
            this.ProjectUrl = projectUrl;
            this.Headline = headline;
            this.Tagline = tagline;
            this.DisplayAsLastUpdated = displayAsLastUpdated;
            this.ModifiedBy = modifiedBy;
            this.ModifiedDate = modifiedDate;
            this.CreatedBy = createdBy;
            this.CreatedDate = createdDate;
            this.BackgroundColour = backgroundColour;
            this.Description = description;
            this.AppointmentRequired = appointmentRequired;
            this.Features = features;
            this.PriceFrom = priceFrom;
            this.PriceTo = priceTo;
            this.BannerUrl = bannerUrl;
            this.BigBannerUrl = bigBannerUrl;
            this.SmallBannerUrl = smallBannerUrl;
            this.LogoUrl = logoUrl;
            this.Pdfs = pdfs;
            this.InspectionDetails = inspectionDetails;
            this.NumberOfFloors = numberOfFloors;
            this.NumberOfApartments = numberOfApartments;
            this.EstimatedCompletionDate = estimatedCompletionDate;
            this.StartingPrice = startingPrice;
            this.ChildListingIds = childListingIds;
            this.LinkedProjectIds = linkedProjectIds;
        }

        /// <summary>
        /// Gets or Sets ProjectProfileType
        /// </summary>
        [DataMember(Name = "projectProfileType", EmitDefaultValue = false)]
        public ListingsV2ProjectProfileType ProjectProfileType { get; set; }

        /// <summary>
        /// Project ID
        /// </summary>
        /// <value>Project ID</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public int Id { get; set; }

        /// <summary>
        /// Project Name
        /// </summary>
        /// <value>Project Name</value>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Start date. DateTime is in AEST (Australian Eastern Standard Time) timezone.
        /// </summary>
        /// <value>Start date. DateTime is in AEST (Australian Eastern Standard Time) timezone.</value>
        [DataMember(Name = "startDate", EmitDefaultValue = true)]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// End date.DateTime is in AEST (Australian Eastern Standard Time) timezone.
        /// </summary>
        /// <value>End date.DateTime is in AEST (Australian Eastern Standard Time) timezone.</value>
        [DataMember(Name = "endDate", EmitDefaultValue = true)]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        [DataMember(Name = "address", EmitDefaultValue = false)]
        public ListingsV2ProjectAddressParts Address { get; set; }

        /// <summary>
        /// Gets or Sets ViewingAddress
        /// </summary>
        [DataMember(Name = "viewingAddress", EmitDefaultValue = false)]
        public ListingsV2ProjectAddressParts ViewingAddress { get; set; }

        /// <summary>
        /// Property types available at the project.
        /// </summary>
        /// <value>Property types available at the project.</value>
        [DataMember(Name = "propertyTypes", EmitDefaultValue = true)]
        public List<ListingsV2PropertyType> PropertyTypes { get; set; }

        /// <summary>
        /// Gets or Sets DisplayableAddress
        /// </summary>
        [DataMember(Name = "displayableAddress", EmitDefaultValue = false)]
        public ListingsV2ProjectAddressParts DisplayableAddress { get; set; }

        /// <summary>
        /// Enquiry email address
        /// </summary>
        /// <value>Enquiry email address</value>
        [DataMember(Name = "enquiryEmailAddress", EmitDefaultValue = true)]
        public string EnquiryEmailAddress { get; set; }

        /// <summary>
        /// Gets or Sets AdvertiserIdentifiers
        /// </summary>
        [DataMember(Name = "advertiserIdentifiers", EmitDefaultValue = false)]
        public ListingsV2AdvertiserIdentifiers AdvertiserIdentifiers { get; set; }

        /// <summary>
        /// Gets or Sets ProviderDetails
        /// </summary>
        [DataMember(Name = "providerDetails", EmitDefaultValue = false)]
        public ListingsV2ProviderDetails ProviderDetails { get; set; }

        /// <summary>
        /// Images and videos
        /// </summary>
        /// <value>Images and videos</value>
        [DataMember(Name = "media", EmitDefaultValue = true)]
        public List<ListingsV2ProjectMedia> Media { get; set; }

        /// <summary>
        /// Project URL
        /// </summary>
        /// <value>Project URL</value>
        [DataMember(Name = "projectUrl", EmitDefaultValue = true)]
        public string ProjectUrl { get; set; }

        /// <summary>
        /// Headline
        /// </summary>
        /// <value>Headline</value>
        [DataMember(Name = "headline", EmitDefaultValue = true)]
        public string Headline { get; set; }

        /// <summary>
        /// Tag line
        /// </summary>
        /// <value>Tag line</value>
        [DataMember(Name = "tagline", EmitDefaultValue = true)]
        public string Tagline { get; set; }

        /// <summary>
        /// The &#39;last updated&#39; date to show to customers. DateTime is in AEST (Australian Eastern Standard Time) timezone.
        /// </summary>
        /// <value>The &#39;last updated&#39; date to show to customers. DateTime is in AEST (Australian Eastern Standard Time) timezone.</value>
        [DataMember(Name = "displayAsLastUpdated", EmitDefaultValue = false)]
        public DateTime DisplayAsLastUpdated { get; set; }

        /// <summary>
        /// Last updated by
        /// </summary>
        /// <value>Last updated by</value>
        [DataMember(Name = "modifiedBy", EmitDefaultValue = true)]
        public string ModifiedBy { get; set; }

        /// <summary>
        /// Last updated, used for auditing. DateTime is in AEST (Australian Eastern Standard Time) timezone.
        /// </summary>
        /// <value>Last updated, used for auditing. DateTime is in AEST (Australian Eastern Standard Time) timezone.</value>
        [DataMember(Name = "modifiedDate", EmitDefaultValue = false)]
        public DateTime ModifiedDate { get; set; }

        /// <summary>
        /// Created by
        /// </summary>
        /// <value>Created by</value>
        [DataMember(Name = "createdBy", EmitDefaultValue = true)]
        public string CreatedBy { get; set; }

        /// <summary>
        /// Created date. DateTime is in AEST (Australian Eastern Standard Time) timezone.
        /// </summary>
        /// <value>Created date. DateTime is in AEST (Australian Eastern Standard Time) timezone.</value>
        [DataMember(Name = "createdDate", EmitDefaultValue = false)]
        public DateTime CreatedDate { get; set; }

        /// <summary>
        /// Background colour
        /// </summary>
        /// <value>Background colour</value>
        [DataMember(Name = "backgroundColour", EmitDefaultValue = true)]
        public string BackgroundColour { get; set; }

        /// <summary>
        /// Description
        /// </summary>
        /// <value>Description</value>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// If inspections require an appointment.
        /// </summary>
        /// <value>If inspections require an appointment.</value>
        [DataMember(Name = "appointmentRequired", EmitDefaultValue = false)]
        public bool AppointmentRequired { get; set; }

        /// <summary>
        /// Features
        /// </summary>
        /// <value>Features</value>
        [DataMember(Name = "features", EmitDefaultValue = true)]
        public List<string> Features { get; set; }

        /// <summary>
        /// Price from
        /// </summary>
        /// <value>Price from</value>
        [DataMember(Name = "priceFrom", EmitDefaultValue = true)]
        public double? PriceFrom { get; set; }

        /// <summary>
        /// Price to
        /// </summary>
        /// <value>Price to</value>
        [DataMember(Name = "priceTo", EmitDefaultValue = true)]
        public double? PriceTo { get; set; }

        /// <summary>
        /// Banner URL
        /// </summary>
        /// <value>Banner URL</value>
        [DataMember(Name = "bannerUrl", EmitDefaultValue = true)]
        public string BannerUrl { get; set; }

        /// <summary>
        /// Big banner URL
        /// </summary>
        /// <value>Big banner URL</value>
        [DataMember(Name = "bigBannerUrl", EmitDefaultValue = true)]
        public string BigBannerUrl { get; set; }

        /// <summary>
        /// Small banner URL
        /// </summary>
        /// <value>Small banner URL</value>
        [DataMember(Name = "smallBannerUrl", EmitDefaultValue = true)]
        public string SmallBannerUrl { get; set; }

        /// <summary>
        /// Logo URL
        /// </summary>
        /// <value>Logo URL</value>
        [DataMember(Name = "logoUrl", EmitDefaultValue = true)]
        public string LogoUrl { get; set; }

        /// <summary>
        /// PDF files, such as brochures etc.
        /// </summary>
        /// <value>PDF files, such as brochures etc.</value>
        [DataMember(Name = "pdfs", EmitDefaultValue = true)]
        public List<ListingsV2PdfUpload> Pdfs { get; set; }

        /// <summary>
        /// Gets or Sets InspectionDetails
        /// </summary>
        [DataMember(Name = "inspectionDetails", EmitDefaultValue = false)]
        public ListingsV2PropertyInspections InspectionDetails { get; set; }

        /// <summary>
        /// Number of floors
        /// </summary>
        /// <value>Number of floors</value>
        [DataMember(Name = "numberOfFloors", EmitDefaultValue = true)]
        public int? NumberOfFloors { get; set; }

        /// <summary>
        /// Number of apartments
        /// </summary>
        /// <value>Number of apartments</value>
        [DataMember(Name = "numberOfApartments", EmitDefaultValue = true)]
        public int? NumberOfApartments { get; set; }

        /// <summary>
        /// Estimated completion date. DateTime in AEST (Australian Eastern Standard Time) timezone.
        /// </summary>
        /// <value>Estimated completion date. DateTime in AEST (Australian Eastern Standard Time) timezone.</value>
        [DataMember(Name = "estimatedCompletionDate", EmitDefaultValue = true)]
        public DateTime? EstimatedCompletionDate { get; set; }

        /// <summary>
        /// Lowest child listing price
        /// </summary>
        /// <value>Lowest child listing price</value>
        [DataMember(Name = "startingPrice", EmitDefaultValue = true)]
        public double? StartingPrice { get; set; }

        /// <summary>
        /// Child listing identifiers.
        /// </summary>
        /// <value>Child listing identifiers.</value>
        [DataMember(Name = "childListingIds", EmitDefaultValue = true)]
        public List<int> ChildListingIds { get; set; }

        /// <summary>
        /// Linked project identifiers.
        /// </summary>
        /// <value>Linked project identifiers.</value>
        [DataMember(Name = "linkedProjectIds", EmitDefaultValue = true)]
        public List<int> LinkedProjectIds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListingsV2Project {\n");
            sb.Append("  ProjectProfileType: ").Append(ProjectProfileType).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  ViewingAddress: ").Append(ViewingAddress).Append("\n");
            sb.Append("  PropertyTypes: ").Append(PropertyTypes).Append("\n");
            sb.Append("  DisplayableAddress: ").Append(DisplayableAddress).Append("\n");
            sb.Append("  EnquiryEmailAddress: ").Append(EnquiryEmailAddress).Append("\n");
            sb.Append("  AdvertiserIdentifiers: ").Append(AdvertiserIdentifiers).Append("\n");
            sb.Append("  ProviderDetails: ").Append(ProviderDetails).Append("\n");
            sb.Append("  Media: ").Append(Media).Append("\n");
            sb.Append("  ProjectUrl: ").Append(ProjectUrl).Append("\n");
            sb.Append("  Headline: ").Append(Headline).Append("\n");
            sb.Append("  Tagline: ").Append(Tagline).Append("\n");
            sb.Append("  DisplayAsLastUpdated: ").Append(DisplayAsLastUpdated).Append("\n");
            sb.Append("  ModifiedBy: ").Append(ModifiedBy).Append("\n");
            sb.Append("  ModifiedDate: ").Append(ModifiedDate).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  BackgroundColour: ").Append(BackgroundColour).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  AppointmentRequired: ").Append(AppointmentRequired).Append("\n");
            sb.Append("  Features: ").Append(Features).Append("\n");
            sb.Append("  PriceFrom: ").Append(PriceFrom).Append("\n");
            sb.Append("  PriceTo: ").Append(PriceTo).Append("\n");
            sb.Append("  BannerUrl: ").Append(BannerUrl).Append("\n");
            sb.Append("  BigBannerUrl: ").Append(BigBannerUrl).Append("\n");
            sb.Append("  SmallBannerUrl: ").Append(SmallBannerUrl).Append("\n");
            sb.Append("  LogoUrl: ").Append(LogoUrl).Append("\n");
            sb.Append("  Pdfs: ").Append(Pdfs).Append("\n");
            sb.Append("  InspectionDetails: ").Append(InspectionDetails).Append("\n");
            sb.Append("  NumberOfFloors: ").Append(NumberOfFloors).Append("\n");
            sb.Append("  NumberOfApartments: ").Append(NumberOfApartments).Append("\n");
            sb.Append("  EstimatedCompletionDate: ").Append(EstimatedCompletionDate).Append("\n");
            sb.Append("  StartingPrice: ").Append(StartingPrice).Append("\n");
            sb.Append("  ChildListingIds: ").Append(ChildListingIds).Append("\n");
            sb.Append("  LinkedProjectIds: ").Append(LinkedProjectIds).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListingsV2Project);
        }

        /// <summary>
        /// Returns true if ListingsV2Project instances are equal
        /// </summary>
        /// <param name="input">Instance of ListingsV2Project to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ListingsV2Project input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ProjectProfileType == input.ProjectProfileType ||
                    (this.ProjectProfileType != null &&
                    this.ProjectProfileType.Equals(input.ProjectProfileType))
                ) && 
                (
                    this.Id == input.Id ||
                    this.Id.Equals(input.Id)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.StartDate == input.StartDate ||
                    (this.StartDate != null &&
                    this.StartDate.Equals(input.StartDate))
                ) && 
                (
                    this.EndDate == input.EndDate ||
                    (this.EndDate != null &&
                    this.EndDate.Equals(input.EndDate))
                ) && 
                (
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
                ) && 
                (
                    this.ViewingAddress == input.ViewingAddress ||
                    (this.ViewingAddress != null &&
                    this.ViewingAddress.Equals(input.ViewingAddress))
                ) && 
                (
                    this.PropertyTypes == input.PropertyTypes ||
                    this.PropertyTypes != null &&
                    input.PropertyTypes != null &&
                    this.PropertyTypes.SequenceEqual(input.PropertyTypes)
                ) && 
                (
                    this.DisplayableAddress == input.DisplayableAddress ||
                    (this.DisplayableAddress != null &&
                    this.DisplayableAddress.Equals(input.DisplayableAddress))
                ) && 
                (
                    this.EnquiryEmailAddress == input.EnquiryEmailAddress ||
                    (this.EnquiryEmailAddress != null &&
                    this.EnquiryEmailAddress.Equals(input.EnquiryEmailAddress))
                ) && 
                (
                    this.AdvertiserIdentifiers == input.AdvertiserIdentifiers ||
                    (this.AdvertiserIdentifiers != null &&
                    this.AdvertiserIdentifiers.Equals(input.AdvertiserIdentifiers))
                ) && 
                (
                    this.ProviderDetails == input.ProviderDetails ||
                    (this.ProviderDetails != null &&
                    this.ProviderDetails.Equals(input.ProviderDetails))
                ) && 
                (
                    this.Media == input.Media ||
                    this.Media != null &&
                    input.Media != null &&
                    this.Media.SequenceEqual(input.Media)
                ) && 
                (
                    this.ProjectUrl == input.ProjectUrl ||
                    (this.ProjectUrl != null &&
                    this.ProjectUrl.Equals(input.ProjectUrl))
                ) && 
                (
                    this.Headline == input.Headline ||
                    (this.Headline != null &&
                    this.Headline.Equals(input.Headline))
                ) && 
                (
                    this.Tagline == input.Tagline ||
                    (this.Tagline != null &&
                    this.Tagline.Equals(input.Tagline))
                ) && 
                (
                    this.DisplayAsLastUpdated == input.DisplayAsLastUpdated ||
                    (this.DisplayAsLastUpdated != null &&
                    this.DisplayAsLastUpdated.Equals(input.DisplayAsLastUpdated))
                ) && 
                (
                    this.ModifiedBy == input.ModifiedBy ||
                    (this.ModifiedBy != null &&
                    this.ModifiedBy.Equals(input.ModifiedBy))
                ) && 
                (
                    this.ModifiedDate == input.ModifiedDate ||
                    (this.ModifiedDate != null &&
                    this.ModifiedDate.Equals(input.ModifiedDate))
                ) && 
                (
                    this.CreatedBy == input.CreatedBy ||
                    (this.CreatedBy != null &&
                    this.CreatedBy.Equals(input.CreatedBy))
                ) && 
                (
                    this.CreatedDate == input.CreatedDate ||
                    (this.CreatedDate != null &&
                    this.CreatedDate.Equals(input.CreatedDate))
                ) && 
                (
                    this.BackgroundColour == input.BackgroundColour ||
                    (this.BackgroundColour != null &&
                    this.BackgroundColour.Equals(input.BackgroundColour))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.AppointmentRequired == input.AppointmentRequired ||
                    this.AppointmentRequired.Equals(input.AppointmentRequired)
                ) && 
                (
                    this.Features == input.Features ||
                    this.Features != null &&
                    input.Features != null &&
                    this.Features.SequenceEqual(input.Features)
                ) && 
                (
                    this.PriceFrom == input.PriceFrom ||
                    (this.PriceFrom != null &&
                    this.PriceFrom.Equals(input.PriceFrom))
                ) && 
                (
                    this.PriceTo == input.PriceTo ||
                    (this.PriceTo != null &&
                    this.PriceTo.Equals(input.PriceTo))
                ) && 
                (
                    this.BannerUrl == input.BannerUrl ||
                    (this.BannerUrl != null &&
                    this.BannerUrl.Equals(input.BannerUrl))
                ) && 
                (
                    this.BigBannerUrl == input.BigBannerUrl ||
                    (this.BigBannerUrl != null &&
                    this.BigBannerUrl.Equals(input.BigBannerUrl))
                ) && 
                (
                    this.SmallBannerUrl == input.SmallBannerUrl ||
                    (this.SmallBannerUrl != null &&
                    this.SmallBannerUrl.Equals(input.SmallBannerUrl))
                ) && 
                (
                    this.LogoUrl == input.LogoUrl ||
                    (this.LogoUrl != null &&
                    this.LogoUrl.Equals(input.LogoUrl))
                ) && 
                (
                    this.Pdfs == input.Pdfs ||
                    this.Pdfs != null &&
                    input.Pdfs != null &&
                    this.Pdfs.SequenceEqual(input.Pdfs)
                ) && 
                (
                    this.InspectionDetails == input.InspectionDetails ||
                    (this.InspectionDetails != null &&
                    this.InspectionDetails.Equals(input.InspectionDetails))
                ) && 
                (
                    this.NumberOfFloors == input.NumberOfFloors ||
                    (this.NumberOfFloors != null &&
                    this.NumberOfFloors.Equals(input.NumberOfFloors))
                ) && 
                (
                    this.NumberOfApartments == input.NumberOfApartments ||
                    (this.NumberOfApartments != null &&
                    this.NumberOfApartments.Equals(input.NumberOfApartments))
                ) && 
                (
                    this.EstimatedCompletionDate == input.EstimatedCompletionDate ||
                    (this.EstimatedCompletionDate != null &&
                    this.EstimatedCompletionDate.Equals(input.EstimatedCompletionDate))
                ) && 
                (
                    this.StartingPrice == input.StartingPrice ||
                    (this.StartingPrice != null &&
                    this.StartingPrice.Equals(input.StartingPrice))
                ) && 
                (
                    this.ChildListingIds == input.ChildListingIds ||
                    this.ChildListingIds != null &&
                    input.ChildListingIds != null &&
                    this.ChildListingIds.SequenceEqual(input.ChildListingIds)
                ) && 
                (
                    this.LinkedProjectIds == input.LinkedProjectIds ||
                    this.LinkedProjectIds != null &&
                    input.LinkedProjectIds != null &&
                    this.LinkedProjectIds.SequenceEqual(input.LinkedProjectIds)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.ProjectProfileType != null)
                    hashCode = hashCode * 59 + this.ProjectProfileType.GetHashCode();
                hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.StartDate != null)
                    hashCode = hashCode * 59 + this.StartDate.GetHashCode();
                if (this.EndDate != null)
                    hashCode = hashCode * 59 + this.EndDate.GetHashCode();
                if (this.Address != null)
                    hashCode = hashCode * 59 + this.Address.GetHashCode();
                if (this.ViewingAddress != null)
                    hashCode = hashCode * 59 + this.ViewingAddress.GetHashCode();
                if (this.PropertyTypes != null)
                    hashCode = hashCode * 59 + this.PropertyTypes.GetHashCode();
                if (this.DisplayableAddress != null)
                    hashCode = hashCode * 59 + this.DisplayableAddress.GetHashCode();
                if (this.EnquiryEmailAddress != null)
                    hashCode = hashCode * 59 + this.EnquiryEmailAddress.GetHashCode();
                if (this.AdvertiserIdentifiers != null)
                    hashCode = hashCode * 59 + this.AdvertiserIdentifiers.GetHashCode();
                if (this.ProviderDetails != null)
                    hashCode = hashCode * 59 + this.ProviderDetails.GetHashCode();
                if (this.Media != null)
                    hashCode = hashCode * 59 + this.Media.GetHashCode();
                if (this.ProjectUrl != null)
                    hashCode = hashCode * 59 + this.ProjectUrl.GetHashCode();
                if (this.Headline != null)
                    hashCode = hashCode * 59 + this.Headline.GetHashCode();
                if (this.Tagline != null)
                    hashCode = hashCode * 59 + this.Tagline.GetHashCode();
                if (this.DisplayAsLastUpdated != null)
                    hashCode = hashCode * 59 + this.DisplayAsLastUpdated.GetHashCode();
                if (this.ModifiedBy != null)
                    hashCode = hashCode * 59 + this.ModifiedBy.GetHashCode();
                if (this.ModifiedDate != null)
                    hashCode = hashCode * 59 + this.ModifiedDate.GetHashCode();
                if (this.CreatedBy != null)
                    hashCode = hashCode * 59 + this.CreatedBy.GetHashCode();
                if (this.CreatedDate != null)
                    hashCode = hashCode * 59 + this.CreatedDate.GetHashCode();
                if (this.BackgroundColour != null)
                    hashCode = hashCode * 59 + this.BackgroundColour.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                hashCode = hashCode * 59 + this.AppointmentRequired.GetHashCode();
                if (this.Features != null)
                    hashCode = hashCode * 59 + this.Features.GetHashCode();
                if (this.PriceFrom != null)
                    hashCode = hashCode * 59 + this.PriceFrom.GetHashCode();
                if (this.PriceTo != null)
                    hashCode = hashCode * 59 + this.PriceTo.GetHashCode();
                if (this.BannerUrl != null)
                    hashCode = hashCode * 59 + this.BannerUrl.GetHashCode();
                if (this.BigBannerUrl != null)
                    hashCode = hashCode * 59 + this.BigBannerUrl.GetHashCode();
                if (this.SmallBannerUrl != null)
                    hashCode = hashCode * 59 + this.SmallBannerUrl.GetHashCode();
                if (this.LogoUrl != null)
                    hashCode = hashCode * 59 + this.LogoUrl.GetHashCode();
                if (this.Pdfs != null)
                    hashCode = hashCode * 59 + this.Pdfs.GetHashCode();
                if (this.InspectionDetails != null)
                    hashCode = hashCode * 59 + this.InspectionDetails.GetHashCode();
                if (this.NumberOfFloors != null)
                    hashCode = hashCode * 59 + this.NumberOfFloors.GetHashCode();
                if (this.NumberOfApartments != null)
                    hashCode = hashCode * 59 + this.NumberOfApartments.GetHashCode();
                if (this.EstimatedCompletionDate != null)
                    hashCode = hashCode * 59 + this.EstimatedCompletionDate.GetHashCode();
                if (this.StartingPrice != null)
                    hashCode = hashCode * 59 + this.StartingPrice.GetHashCode();
                if (this.ChildListingIds != null)
                    hashCode = hashCode * 59 + this.ChildListingIds.GetHashCode();
                if (this.LinkedProjectIds != null)
                    hashCode = hashCode * 59 + this.LinkedProjectIds.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}