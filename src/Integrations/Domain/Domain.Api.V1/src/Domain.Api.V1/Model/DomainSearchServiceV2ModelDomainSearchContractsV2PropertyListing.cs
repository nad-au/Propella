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
using OpenAPIDateConverter = Domain.Api.V1.Client.OpenAPIDateConverter;

namespace Domain.Api.V1.Model
{
    /// <summary>
    /// DomainSearchServiceV2ModelDomainSearchContractsV2PropertyListing
    /// </summary>
    [DataContract(Name = "Domain.SearchService.v2.Model.DomainSearchContractsV2PropertyListing")]
    public partial class DomainSearchServiceV2ModelDomainSearchContractsV2PropertyListing : IEquatable<DomainSearchServiceV2ModelDomainSearchContractsV2PropertyListing>, IValidatableObject
    {
        /// <summary>
        /// Defines PromoLevel
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PromoLevelEnum
        {
            /// <summary>
            /// Enum Standard for value: Standard
            /// </summary>
            [EnumMember(Value = "Standard")]
            Standard = 1,

            /// <summary>
            /// Enum StandardPP for value: StandardPP
            /// </summary>
            [EnumMember(Value = "StandardPP")]
            StandardPP = 2,

            /// <summary>
            /// Enum Elite for value: Elite
            /// </summary>
            [EnumMember(Value = "Elite")]
            Elite = 3,

            /// <summary>
            /// Enum ElitePP for value: ElitePP
            /// </summary>
            [EnumMember(Value = "ElitePP")]
            ElitePP = 4,

            /// <summary>
            /// Enum PremiumPlus for value: PremiumPlus
            /// </summary>
            [EnumMember(Value = "PremiumPlus")]
            PremiumPlus = 5

        }

        /// <summary>
        /// Gets or Sets PromoLevel
        /// </summary>
        [DataMember(Name = "promoLevel", EmitDefaultValue = false)]
        public PromoLevelEnum? PromoLevel { get; set; }
        /// <summary>
        /// Defines ListingType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ListingTypeEnum
        {
            /// <summary>
            /// Enum Sale for value: Sale
            /// </summary>
            [EnumMember(Value = "Sale")]
            Sale = 1,

            /// <summary>
            /// Enum Rent for value: Rent
            /// </summary>
            [EnumMember(Value = "Rent")]
            Rent = 2,

            /// <summary>
            /// Enum Share for value: Share
            /// </summary>
            [EnumMember(Value = "Share")]
            Share = 3,

            /// <summary>
            /// Enum Sold for value: Sold
            /// </summary>
            [EnumMember(Value = "Sold")]
            Sold = 4,

            /// <summary>
            /// Enum NewHomes for value: NewHomes
            /// </summary>
            [EnumMember(Value = "NewHomes")]
            NewHomes = 5

        }

        /// <summary>
        /// Gets or Sets ListingType
        /// </summary>
        [DataMember(Name = "listingType", EmitDefaultValue = false)]
        public ListingTypeEnum? ListingType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DomainSearchServiceV2ModelDomainSearchContractsV2PropertyListing" /> class.
        /// </summary>
        /// <param name="promoLevel">promoLevel.</param>
        /// <param name="listingType">listingType.</param>
        /// <param name="id">id.</param>
        /// <param name="projectId">projectId.</param>
        /// <param name="advertiser">advertiser.</param>
        /// <param name="priceDetails">priceDetails.</param>
        /// <param name="media">media.</param>
        /// <param name="propertyDetails">propertyDetails.</param>
        /// <param name="headline">headline.</param>
        /// <param name="summaryDescription">summaryDescription.</param>
        /// <param name="hasFloorplan">hasFloorplan.</param>
        /// <param name="hasVideo">hasVideo.</param>
        /// <param name="labels">labels.</param>
        /// <param name="auctionSchedule">auctionSchedule.</param>
        /// <param name="dateAvailable">dateAvailable.</param>
        /// <param name="dateListed">dateListed.</param>
        /// <param name="inspectionSchedule">inspectionSchedule.</param>
        /// <param name="soldData">soldData.</param>
        /// <param name="listingSlug">listingSlug.</param>
        public DomainSearchServiceV2ModelDomainSearchContractsV2PropertyListing(PromoLevelEnum? promoLevel = default(PromoLevelEnum?), ListingTypeEnum? listingType = default(ListingTypeEnum?), int id = default(int), int projectId = default(int), DomainSearchServiceV2ModelDomainSearchContractsV2Advertiser advertiser = default(DomainSearchServiceV2ModelDomainSearchContractsV2Advertiser), DomainSearchServiceV2ModelDomainSearchContractsV2PriceDetails priceDetails = default(DomainSearchServiceV2ModelDomainSearchContractsV2PriceDetails), List<DomainSearchServiceV2ModelDomainSearchContractsV2Media> media = default(List<DomainSearchServiceV2ModelDomainSearchContractsV2Media>), DomainSearchServiceV2ModelDomainSearchContractsV2PropertyDetails propertyDetails = default(DomainSearchServiceV2ModelDomainSearchContractsV2PropertyDetails), string headline = default(string), string summaryDescription = default(string), bool hasFloorplan = default(bool), bool hasVideo = default(bool), List<string> labels = default(List<string>), DomainSearchServiceV2ModelDomainSearchContractsV2AuctionSchedule auctionSchedule = default(DomainSearchServiceV2ModelDomainSearchContractsV2AuctionSchedule), DateTime dateAvailable = default(DateTime), DateTime dateListed = default(DateTime), DomainSearchServiceV2ModelDomainSearchContractsV2InspectionSchedule inspectionSchedule = default(DomainSearchServiceV2ModelDomainSearchContractsV2InspectionSchedule), DomainSearchServiceV2ModelDomainSearchContractsV2SoldData soldData = default(DomainSearchServiceV2ModelDomainSearchContractsV2SoldData), string listingSlug = default(string))
        {
            this.PromoLevel = promoLevel;
            this.ListingType = listingType;
            this.Id = id;
            this.ProjectId = projectId;
            this.Advertiser = advertiser;
            this.PriceDetails = priceDetails;
            this.Media = media;
            this.PropertyDetails = propertyDetails;
            this.Headline = headline;
            this.SummaryDescription = summaryDescription;
            this.HasFloorplan = hasFloorplan;
            this.HasVideo = hasVideo;
            this.Labels = labels;
            this.AuctionSchedule = auctionSchedule;
            this.DateAvailable = dateAvailable;
            this.DateListed = dateListed;
            this.InspectionSchedule = inspectionSchedule;
            this.SoldData = soldData;
            this.ListingSlug = listingSlug;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public int Id { get; set; }

        /// <summary>
        /// Gets or Sets ProjectId
        /// </summary>
        [DataMember(Name = "projectId", EmitDefaultValue = false)]
        public int ProjectId { get; set; }

        /// <summary>
        /// Gets or Sets Advertiser
        /// </summary>
        [DataMember(Name = "advertiser", EmitDefaultValue = false)]
        public DomainSearchServiceV2ModelDomainSearchContractsV2Advertiser Advertiser { get; set; }

        /// <summary>
        /// Gets or Sets PriceDetails
        /// </summary>
        [DataMember(Name = "priceDetails", EmitDefaultValue = false)]
        public DomainSearchServiceV2ModelDomainSearchContractsV2PriceDetails PriceDetails { get; set; }

        /// <summary>
        /// Gets or Sets Media
        /// </summary>
        [DataMember(Name = "media", EmitDefaultValue = false)]
        public List<DomainSearchServiceV2ModelDomainSearchContractsV2Media> Media { get; set; }

        /// <summary>
        /// Gets or Sets PropertyDetails
        /// </summary>
        [DataMember(Name = "propertyDetails", EmitDefaultValue = false)]
        public DomainSearchServiceV2ModelDomainSearchContractsV2PropertyDetails PropertyDetails { get; set; }

        /// <summary>
        /// Gets or Sets Headline
        /// </summary>
        [DataMember(Name = "headline", EmitDefaultValue = false)]
        public string Headline { get; set; }

        /// <summary>
        /// Gets or Sets SummaryDescription
        /// </summary>
        [DataMember(Name = "summaryDescription", EmitDefaultValue = false)]
        public string SummaryDescription { get; set; }

        /// <summary>
        /// Gets or Sets HasFloorplan
        /// </summary>
        [DataMember(Name = "hasFloorplan", EmitDefaultValue = false)]
        public bool HasFloorplan { get; set; }

        /// <summary>
        /// Gets or Sets HasVideo
        /// </summary>
        [DataMember(Name = "hasVideo", EmitDefaultValue = false)]
        public bool HasVideo { get; set; }

        /// <summary>
        /// Gets or Sets Labels
        /// </summary>
        [DataMember(Name = "labels", EmitDefaultValue = false)]
        public List<string> Labels { get; set; }

        /// <summary>
        /// Gets or Sets AuctionSchedule
        /// </summary>
        [DataMember(Name = "auctionSchedule", EmitDefaultValue = false)]
        public DomainSearchServiceV2ModelDomainSearchContractsV2AuctionSchedule AuctionSchedule { get; set; }

        /// <summary>
        /// Gets or Sets DateAvailable
        /// </summary>
        [DataMember(Name = "dateAvailable", EmitDefaultValue = false)]
        public DateTime DateAvailable { get; set; }

        /// <summary>
        /// Gets or Sets DateListed
        /// </summary>
        [DataMember(Name = "dateListed", EmitDefaultValue = false)]
        public DateTime DateListed { get; set; }

        /// <summary>
        /// Gets or Sets InspectionSchedule
        /// </summary>
        [DataMember(Name = "inspectionSchedule", EmitDefaultValue = false)]
        public DomainSearchServiceV2ModelDomainSearchContractsV2InspectionSchedule InspectionSchedule { get; set; }

        /// <summary>
        /// Gets or Sets SoldData
        /// </summary>
        [DataMember(Name = "soldData", EmitDefaultValue = false)]
        public DomainSearchServiceV2ModelDomainSearchContractsV2SoldData SoldData { get; set; }

        /// <summary>
        /// Gets or Sets ListingSlug
        /// </summary>
        [DataMember(Name = "listingSlug", EmitDefaultValue = false)]
        public string ListingSlug { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DomainSearchServiceV2ModelDomainSearchContractsV2PropertyListing {\n");
            sb.Append("  PromoLevel: ").Append(PromoLevel).Append("\n");
            sb.Append("  ListingType: ").Append(ListingType).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ProjectId: ").Append(ProjectId).Append("\n");
            sb.Append("  Advertiser: ").Append(Advertiser).Append("\n");
            sb.Append("  PriceDetails: ").Append(PriceDetails).Append("\n");
            sb.Append("  Media: ").Append(Media).Append("\n");
            sb.Append("  PropertyDetails: ").Append(PropertyDetails).Append("\n");
            sb.Append("  Headline: ").Append(Headline).Append("\n");
            sb.Append("  SummaryDescription: ").Append(SummaryDescription).Append("\n");
            sb.Append("  HasFloorplan: ").Append(HasFloorplan).Append("\n");
            sb.Append("  HasVideo: ").Append(HasVideo).Append("\n");
            sb.Append("  Labels: ").Append(Labels).Append("\n");
            sb.Append("  AuctionSchedule: ").Append(AuctionSchedule).Append("\n");
            sb.Append("  DateAvailable: ").Append(DateAvailable).Append("\n");
            sb.Append("  DateListed: ").Append(DateListed).Append("\n");
            sb.Append("  InspectionSchedule: ").Append(InspectionSchedule).Append("\n");
            sb.Append("  SoldData: ").Append(SoldData).Append("\n");
            sb.Append("  ListingSlug: ").Append(ListingSlug).Append("\n");
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
            return this.Equals(input as DomainSearchServiceV2ModelDomainSearchContractsV2PropertyListing);
        }

        /// <summary>
        /// Returns true if DomainSearchServiceV2ModelDomainSearchContractsV2PropertyListing instances are equal
        /// </summary>
        /// <param name="input">Instance of DomainSearchServiceV2ModelDomainSearchContractsV2PropertyListing to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DomainSearchServiceV2ModelDomainSearchContractsV2PropertyListing input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PromoLevel == input.PromoLevel ||
                    this.PromoLevel.Equals(input.PromoLevel)
                ) && 
                (
                    this.ListingType == input.ListingType ||
                    this.ListingType.Equals(input.ListingType)
                ) && 
                (
                    this.Id == input.Id ||
                    this.Id.Equals(input.Id)
                ) && 
                (
                    this.ProjectId == input.ProjectId ||
                    this.ProjectId.Equals(input.ProjectId)
                ) && 
                (
                    this.Advertiser == input.Advertiser ||
                    (this.Advertiser != null &&
                    this.Advertiser.Equals(input.Advertiser))
                ) && 
                (
                    this.PriceDetails == input.PriceDetails ||
                    (this.PriceDetails != null &&
                    this.PriceDetails.Equals(input.PriceDetails))
                ) && 
                (
                    this.Media == input.Media ||
                    this.Media != null &&
                    input.Media != null &&
                    this.Media.SequenceEqual(input.Media)
                ) && 
                (
                    this.PropertyDetails == input.PropertyDetails ||
                    (this.PropertyDetails != null &&
                    this.PropertyDetails.Equals(input.PropertyDetails))
                ) && 
                (
                    this.Headline == input.Headline ||
                    (this.Headline != null &&
                    this.Headline.Equals(input.Headline))
                ) && 
                (
                    this.SummaryDescription == input.SummaryDescription ||
                    (this.SummaryDescription != null &&
                    this.SummaryDescription.Equals(input.SummaryDescription))
                ) && 
                (
                    this.HasFloorplan == input.HasFloorplan ||
                    this.HasFloorplan.Equals(input.HasFloorplan)
                ) && 
                (
                    this.HasVideo == input.HasVideo ||
                    this.HasVideo.Equals(input.HasVideo)
                ) && 
                (
                    this.Labels == input.Labels ||
                    this.Labels != null &&
                    input.Labels != null &&
                    this.Labels.SequenceEqual(input.Labels)
                ) && 
                (
                    this.AuctionSchedule == input.AuctionSchedule ||
                    (this.AuctionSchedule != null &&
                    this.AuctionSchedule.Equals(input.AuctionSchedule))
                ) && 
                (
                    this.DateAvailable == input.DateAvailable ||
                    (this.DateAvailable != null &&
                    this.DateAvailable.Equals(input.DateAvailable))
                ) && 
                (
                    this.DateListed == input.DateListed ||
                    (this.DateListed != null &&
                    this.DateListed.Equals(input.DateListed))
                ) && 
                (
                    this.InspectionSchedule == input.InspectionSchedule ||
                    (this.InspectionSchedule != null &&
                    this.InspectionSchedule.Equals(input.InspectionSchedule))
                ) && 
                (
                    this.SoldData == input.SoldData ||
                    (this.SoldData != null &&
                    this.SoldData.Equals(input.SoldData))
                ) && 
                (
                    this.ListingSlug == input.ListingSlug ||
                    (this.ListingSlug != null &&
                    this.ListingSlug.Equals(input.ListingSlug))
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
                hashCode = hashCode * 59 + this.PromoLevel.GetHashCode();
                hashCode = hashCode * 59 + this.ListingType.GetHashCode();
                hashCode = hashCode * 59 + this.Id.GetHashCode();
                hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.Advertiser != null)
                    hashCode = hashCode * 59 + this.Advertiser.GetHashCode();
                if (this.PriceDetails != null)
                    hashCode = hashCode * 59 + this.PriceDetails.GetHashCode();
                if (this.Media != null)
                    hashCode = hashCode * 59 + this.Media.GetHashCode();
                if (this.PropertyDetails != null)
                    hashCode = hashCode * 59 + this.PropertyDetails.GetHashCode();
                if (this.Headline != null)
                    hashCode = hashCode * 59 + this.Headline.GetHashCode();
                if (this.SummaryDescription != null)
                    hashCode = hashCode * 59 + this.SummaryDescription.GetHashCode();
                hashCode = hashCode * 59 + this.HasFloorplan.GetHashCode();
                hashCode = hashCode * 59 + this.HasVideo.GetHashCode();
                if (this.Labels != null)
                    hashCode = hashCode * 59 + this.Labels.GetHashCode();
                if (this.AuctionSchedule != null)
                    hashCode = hashCode * 59 + this.AuctionSchedule.GetHashCode();
                if (this.DateAvailable != null)
                    hashCode = hashCode * 59 + this.DateAvailable.GetHashCode();
                if (this.DateListed != null)
                    hashCode = hashCode * 59 + this.DateListed.GetHashCode();
                if (this.InspectionSchedule != null)
                    hashCode = hashCode * 59 + this.InspectionSchedule.GetHashCode();
                if (this.SoldData != null)
                    hashCode = hashCode * 59 + this.SoldData.GetHashCode();
                if (this.ListingSlug != null)
                    hashCode = hashCode * 59 + this.ListingSlug.GetHashCode();
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