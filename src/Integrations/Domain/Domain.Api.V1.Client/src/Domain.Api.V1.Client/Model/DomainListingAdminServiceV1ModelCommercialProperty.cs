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
    /// Commercial Property
    /// </summary>
    [DataContract(Name = "Domain.ListingAdminService.v1.Model.CommercialProperty")]
    public partial class DomainListingAdminServiceV1ModelCommercialProperty : IEquatable<DomainListingAdminServiceV1ModelCommercialProperty>, IValidatableObject
    {
        /// <summary>
        /// Defines PropertyType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PropertyTypeEnum
        {
            /// <summary>
            /// Enum Aquaculture for value: aquaculture
            /// </summary>
            [EnumMember(Value = "aquaculture")]
            Aquaculture = 1,

            /// <summary>
            /// Enum DairyFarming for value: dairyFarming
            /// </summary>
            [EnumMember(Value = "dairyFarming")]
            DairyFarming = 2,

            /// <summary>
            /// Enum DevelopmentLand for value: developmentLand
            /// </summary>
            [EnumMember(Value = "developmentLand")]
            DevelopmentLand = 3,

            /// <summary>
            /// Enum FishingForestry for value: fishingForestry
            /// </summary>
            [EnumMember(Value = "fishingForestry")]
            FishingForestry = 4,

            /// <summary>
            /// Enum HotelLeisure for value: hotelLeisure
            /// </summary>
            [EnumMember(Value = "hotelLeisure")]
            HotelLeisure = 5,

            /// <summary>
            /// Enum IndustrialWarehouse for value: industrialWarehouse
            /// </summary>
            [EnumMember(Value = "industrialWarehouse")]
            IndustrialWarehouse = 6,

            /// <summary>
            /// Enum IrrigationServices for value: irrigationServices
            /// </summary>
            [EnumMember(Value = "irrigationServices")]
            IrrigationServices = 7,

            /// <summary>
            /// Enum Livestock for value: livestock
            /// </summary>
            [EnumMember(Value = "livestock")]
            Livestock = 8,

            /// <summary>
            /// Enum InternationalCommercial for value: internationalCommercial
            /// </summary>
            [EnumMember(Value = "internationalCommercial")]
            InternationalCommercial = 9,

            /// <summary>
            /// Enum MedicalConsulting for value: medicalConsulting
            /// </summary>
            [EnumMember(Value = "medicalConsulting")]
            MedicalConsulting = 10,

            /// <summary>
            /// Enum Offices for value: offices
            /// </summary>
            [EnumMember(Value = "offices")]
            Offices = 11,

            /// <summary>
            /// Enum ParkingCarSpace for value: parkingCarSpace
            /// </summary>
            [EnumMember(Value = "parkingCarSpace")]
            ParkingCarSpace = 12,

            /// <summary>
            /// Enum Retail for value: retail
            /// </summary>
            [EnumMember(Value = "retail")]
            Retail = 13,

            /// <summary>
            /// Enum RuralCommercialFarming for value: ruralCommercialFarming
            /// </summary>
            [EnumMember(Value = "ruralCommercialFarming")]
            RuralCommercialFarming = 14,

            /// <summary>
            /// Enum ShowroomsBulkyGoods for value: showroomsBulkyGoods
            /// </summary>
            [EnumMember(Value = "showroomsBulkyGoods")]
            ShowroomsBulkyGoods = 15,

            /// <summary>
            /// Enum ServicedOffices for value: servicedOffices
            /// </summary>
            [EnumMember(Value = "servicedOffices")]
            ServicedOffices = 16,

            /// <summary>
            /// Enum Other for value: other
            /// </summary>
            [EnumMember(Value = "other")]
            Other = 17,

            /// <summary>
            /// Enum Cropping for value: cropping
            /// </summary>
            [EnumMember(Value = "cropping")]
            Cropping = 18,

            /// <summary>
            /// Enum Viticulture for value: viticulture
            /// </summary>
            [EnumMember(Value = "viticulture")]
            Viticulture = 19,

            /// <summary>
            /// Enum MixedFarming for value: mixedFarming
            /// </summary>
            [EnumMember(Value = "mixedFarming")]
            MixedFarming = 20,

            /// <summary>
            /// Enum Grazing for value: grazing
            /// </summary>
            [EnumMember(Value = "grazing")]
            Grazing = 21,

            /// <summary>
            /// Enum Horticulture for value: horticulture
            /// </summary>
            [EnumMember(Value = "horticulture")]
            Horticulture = 22,

            /// <summary>
            /// Enum Equine for value: equine
            /// </summary>
            [EnumMember(Value = "equine")]
            Equine = 23,

            /// <summary>
            /// Enum Farmlet for value: farmlet
            /// </summary>
            [EnumMember(Value = "farmlet")]
            Farmlet = 24,

            /// <summary>
            /// Enum Orchard for value: orchard
            /// </summary>
            [EnumMember(Value = "orchard")]
            Orchard = 25,

            /// <summary>
            /// Enum RuralLifestyle for value: ruralLifestyle
            /// </summary>
            [EnumMember(Value = "ruralLifestyle")]
            RuralLifestyle = 26

        }


        /// <summary>
        /// Commercial property types [&#39;aquaculture&#39;, &#39;dairyFarming&#39;, &#39;developmentLand&#39;, &#39;fishingForestry&#39;, &#39;hotelLeisure&#39;, &#39;industrialWarehouse&#39;, &#39;irrigationServices&#39;, &#39;livestock&#39;, &#39;internationalCommercial&#39;, &#39;medicalConsulting&#39;, &#39;offices&#39;, &#39;parkingCarSpace&#39;, &#39;retail&#39;, &#39;ruralCommercialFarming&#39;, &#39;showroomsBulkyGoods&#39;, &#39;servicedOffices&#39;, &#39;other&#39;, &#39;cropping&#39;, &#39;viticulture&#39;, &#39;mixedFarming&#39;, &#39;grazing&#39;, &#39;horticulture&#39;, &#39;equine&#39;, &#39;farmlet&#39;, &#39;orchard&#39;, &#39;ruralLifestyle&#39;].
        /// </summary>
        /// <value>Commercial property types [&#39;aquaculture&#39;, &#39;dairyFarming&#39;, &#39;developmentLand&#39;, &#39;fishingForestry&#39;, &#39;hotelLeisure&#39;, &#39;industrialWarehouse&#39;, &#39;irrigationServices&#39;, &#39;livestock&#39;, &#39;internationalCommercial&#39;, &#39;medicalConsulting&#39;, &#39;offices&#39;, &#39;parkingCarSpace&#39;, &#39;retail&#39;, &#39;ruralCommercialFarming&#39;, &#39;showroomsBulkyGoods&#39;, &#39;servicedOffices&#39;, &#39;other&#39;, &#39;cropping&#39;, &#39;viticulture&#39;, &#39;mixedFarming&#39;, &#39;grazing&#39;, &#39;horticulture&#39;, &#39;equine&#39;, &#39;farmlet&#39;, &#39;orchard&#39;, &#39;ruralLifestyle&#39;].</value>
        [DataMember(Name = "propertyType", EmitDefaultValue = false)]
        public List<PropertyTypeEnum> PropertyType { get; set; }
        /// <summary>
        /// Building Type
        /// </summary>
        /// <value>Building Type</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum BuildingTypeEnum
        {
            /// <summary>
            /// Enum Whole for value: whole
            /// </summary>
            [EnumMember(Value = "whole")]
            Whole = 1,

            /// <summary>
            /// Enum Part for value: part
            /// </summary>
            [EnumMember(Value = "part")]
            Part = 2,

            /// <summary>
            /// Enum Na for value: na
            /// </summary>
            [EnumMember(Value = "na")]
            Na = 3

        }

        /// <summary>
        /// Building Type
        /// </summary>
        /// <value>Building Type</value>
        [DataMember(Name = "buildingType", EmitDefaultValue = false)]
        public BuildingTypeEnum? BuildingType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DomainListingAdminServiceV1ModelCommercialProperty" /> class.
        /// </summary>
        /// <param name="propertyType">Commercial property types [&#39;aquaculture&#39;, &#39;dairyFarming&#39;, &#39;developmentLand&#39;, &#39;fishingForestry&#39;, &#39;hotelLeisure&#39;, &#39;industrialWarehouse&#39;, &#39;irrigationServices&#39;, &#39;livestock&#39;, &#39;internationalCommercial&#39;, &#39;medicalConsulting&#39;, &#39;offices&#39;, &#39;parkingCarSpace&#39;, &#39;retail&#39;, &#39;ruralCommercialFarming&#39;, &#39;showroomsBulkyGoods&#39;, &#39;servicedOffices&#39;, &#39;other&#39;, &#39;cropping&#39;, &#39;viticulture&#39;, &#39;mixedFarming&#39;, &#39;grazing&#39;, &#39;horticulture&#39;, &#39;equine&#39;, &#39;farmlet&#39;, &#39;orchard&#39;, &#39;ruralLifestyle&#39;]..</param>
        /// <param name="buildingType">Building Type.</param>
        /// <param name="parking">parking.</param>
        /// <param name="pdfs">List of PDF files related to the listing.</param>
        /// <param name="isMarkedForLiveability">Is the property liveability compliant.</param>
        /// <param name="propertyName">Name of the property up to 70 characters.</param>
        /// <param name="location">Short location information up to 30 character, e.g.: Greenhills Beach.</param>
        /// <param name="images">List of image files, photos or floor plans related to the listing..</param>
        /// <param name="address">address.</param>
        /// <param name="area">area.</param>
        /// <param name="landArea">landArea.</param>
        public DomainListingAdminServiceV1ModelCommercialProperty(List<PropertyTypeEnum> propertyType = default(List<PropertyTypeEnum>), BuildingTypeEnum? buildingType = default(BuildingTypeEnum?), DomainListingAdminServiceV1ModelParking parking = default(DomainListingAdminServiceV1ModelParking), List<DomainListingAdminServiceV1ModelPropertyPdf> pdfs = default(List<DomainListingAdminServiceV1ModelPropertyPdf>), bool isMarkedForLiveability = default(bool), string propertyName = default(string), string location = default(string), List<DomainListingAdminServiceV1ModelPropertyMedia> images = default(List<DomainListingAdminServiceV1ModelPropertyMedia>), DomainListingAdminServiceV1ModelAddress address = default(DomainListingAdminServiceV1ModelAddress), DomainListingAdminServiceV1ModelArea area = default(DomainListingAdminServiceV1ModelArea), DomainListingAdminServiceV1ModelLandArea landArea = default(DomainListingAdminServiceV1ModelLandArea))
        {
            this.PropertyType = propertyType;
            this.BuildingType = buildingType;
            this.Parking = parking;
            this.Pdfs = pdfs;
            this.IsMarkedForLiveability = isMarkedForLiveability;
            this.PropertyName = propertyName;
            this.Location = location;
            this.Images = images;
            this.Address = address;
            this.Area = area;
            this.LandArea = landArea;
        }

        /// <summary>
        /// Gets or Sets Parking
        /// </summary>
        [DataMember(Name = "parking", EmitDefaultValue = false)]
        public DomainListingAdminServiceV1ModelParking Parking { get; set; }

        /// <summary>
        /// List of PDF files related to the listing
        /// </summary>
        /// <value>List of PDF files related to the listing</value>
        [DataMember(Name = "pdfs", EmitDefaultValue = false)]
        public List<DomainListingAdminServiceV1ModelPropertyPdf> Pdfs { get; set; }

        /// <summary>
        /// Is the property liveability compliant
        /// </summary>
        /// <value>Is the property liveability compliant</value>
        [DataMember(Name = "isMarkedForLiveability", EmitDefaultValue = false)]
        public bool IsMarkedForLiveability { get; set; }

        /// <summary>
        /// Name of the property up to 70 characters
        /// </summary>
        /// <value>Name of the property up to 70 characters</value>
        [DataMember(Name = "propertyName", EmitDefaultValue = false)]
        public string PropertyName { get; set; }

        /// <summary>
        /// Short location information up to 30 character, e.g.: Greenhills Beach
        /// </summary>
        /// <value>Short location information up to 30 character, e.g.: Greenhills Beach</value>
        [DataMember(Name = "location", EmitDefaultValue = false)]
        public string Location { get; set; }

        /// <summary>
        /// List of image files, photos or floor plans related to the listing.
        /// </summary>
        /// <value>List of image files, photos or floor plans related to the listing.</value>
        [DataMember(Name = "images", EmitDefaultValue = false)]
        public List<DomainListingAdminServiceV1ModelPropertyMedia> Images { get; set; }

        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        [DataMember(Name = "address", EmitDefaultValue = false)]
        public DomainListingAdminServiceV1ModelAddress Address { get; set; }

        /// <summary>
        /// Gets or Sets Area
        /// </summary>
        [DataMember(Name = "area", EmitDefaultValue = false)]
        public DomainListingAdminServiceV1ModelArea Area { get; set; }

        /// <summary>
        /// Gets or Sets LandArea
        /// </summary>
        [DataMember(Name = "landArea", EmitDefaultValue = false)]
        public DomainListingAdminServiceV1ModelLandArea LandArea { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DomainListingAdminServiceV1ModelCommercialProperty {\n");
            sb.Append("  PropertyType: ").Append(PropertyType).Append("\n");
            sb.Append("  BuildingType: ").Append(BuildingType).Append("\n");
            sb.Append("  Parking: ").Append(Parking).Append("\n");
            sb.Append("  Pdfs: ").Append(Pdfs).Append("\n");
            sb.Append("  IsMarkedForLiveability: ").Append(IsMarkedForLiveability).Append("\n");
            sb.Append("  PropertyName: ").Append(PropertyName).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("  Images: ").Append(Images).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  Area: ").Append(Area).Append("\n");
            sb.Append("  LandArea: ").Append(LandArea).Append("\n");
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
            return this.Equals(input as DomainListingAdminServiceV1ModelCommercialProperty);
        }

        /// <summary>
        /// Returns true if DomainListingAdminServiceV1ModelCommercialProperty instances are equal
        /// </summary>
        /// <param name="input">Instance of DomainListingAdminServiceV1ModelCommercialProperty to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DomainListingAdminServiceV1ModelCommercialProperty input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PropertyType == input.PropertyType ||
                    this.PropertyType.SequenceEqual(input.PropertyType)
                ) && 
                (
                    this.BuildingType == input.BuildingType ||
                    this.BuildingType.Equals(input.BuildingType)
                ) && 
                (
                    this.Parking == input.Parking ||
                    (this.Parking != null &&
                    this.Parking.Equals(input.Parking))
                ) && 
                (
                    this.Pdfs == input.Pdfs ||
                    this.Pdfs != null &&
                    input.Pdfs != null &&
                    this.Pdfs.SequenceEqual(input.Pdfs)
                ) && 
                (
                    this.IsMarkedForLiveability == input.IsMarkedForLiveability ||
                    this.IsMarkedForLiveability.Equals(input.IsMarkedForLiveability)
                ) && 
                (
                    this.PropertyName == input.PropertyName ||
                    (this.PropertyName != null &&
                    this.PropertyName.Equals(input.PropertyName))
                ) && 
                (
                    this.Location == input.Location ||
                    (this.Location != null &&
                    this.Location.Equals(input.Location))
                ) && 
                (
                    this.Images == input.Images ||
                    this.Images != null &&
                    input.Images != null &&
                    this.Images.SequenceEqual(input.Images)
                ) && 
                (
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
                ) && 
                (
                    this.Area == input.Area ||
                    (this.Area != null &&
                    this.Area.Equals(input.Area))
                ) && 
                (
                    this.LandArea == input.LandArea ||
                    (this.LandArea != null &&
                    this.LandArea.Equals(input.LandArea))
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
                hashCode = hashCode * 59 + this.PropertyType.GetHashCode();
                hashCode = hashCode * 59 + this.BuildingType.GetHashCode();
                if (this.Parking != null)
                    hashCode = hashCode * 59 + this.Parking.GetHashCode();
                if (this.Pdfs != null)
                    hashCode = hashCode * 59 + this.Pdfs.GetHashCode();
                hashCode = hashCode * 59 + this.IsMarkedForLiveability.GetHashCode();
                if (this.PropertyName != null)
                    hashCode = hashCode * 59 + this.PropertyName.GetHashCode();
                if (this.Location != null)
                    hashCode = hashCode * 59 + this.Location.GetHashCode();
                if (this.Images != null)
                    hashCode = hashCode * 59 + this.Images.GetHashCode();
                if (this.Address != null)
                    hashCode = hashCode * 59 + this.Address.GetHashCode();
                if (this.Area != null)
                    hashCode = hashCode * 59 + this.Area.GetHashCode();
                if (this.LandArea != null)
                    hashCode = hashCode * 59 + this.LandArea.GetHashCode();
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