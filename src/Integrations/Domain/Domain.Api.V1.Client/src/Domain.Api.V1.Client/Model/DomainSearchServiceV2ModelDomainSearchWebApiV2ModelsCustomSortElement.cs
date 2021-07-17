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
    /// DomainSearchServiceV2ModelDomainSearchWebApiV2ModelsCustomSortElement
    /// </summary>
    [DataContract(Name = "Domain.SearchService.v2.Model.DomainSearchWebApiV2ModelsCustomSortElement")]
    public partial class DomainSearchServiceV2ModelDomainSearchWebApiV2ModelsCustomSortElement : IEquatable<DomainSearchServiceV2ModelDomainSearchWebApiV2ModelsCustomSortElement>, IValidatableObject
    {
        /// <summary>
        /// Defines Field
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum FieldEnum
        {
            /// <summary>
            /// Enum AdId for value: AdId
            /// </summary>
            [EnumMember(Value = "AdId")]
            AdId = 1,

            /// <summary>
            /// Enum PromoLevelScore for value: PromoLevelScore
            /// </summary>
            [EnumMember(Value = "PromoLevelScore")]
            PromoLevelScore = 2,

            /// <summary>
            /// Enum FreshnessLevel for value: FreshnessLevel
            /// </summary>
            [EnumMember(Value = "FreshnessLevel")]
            FreshnessLevel = 3,

            /// <summary>
            /// Enum ProductBoost for value: ProductBoost
            /// </summary>
            [EnumMember(Value = "ProductBoost")]
            ProductBoost = 4,

            /// <summary>
            /// Enum DateUpdated for value: DateUpdated
            /// </summary>
            [EnumMember(Value = "DateUpdated")]
            DateUpdated = 5,

            /// <summary>
            /// Enum DateListed for value: DateListed
            /// </summary>
            [EnumMember(Value = "DateListed")]
            DateListed = 6,

            /// <summary>
            /// Enum SuburbName for value: SuburbName
            /// </summary>
            [EnumMember(Value = "SuburbName")]
            SuburbName = 7,

            /// <summary>
            /// Enum PriceDisplayOption for value: PriceDisplayOption
            /// </summary>
            [EnumMember(Value = "PriceDisplayOption")]
            PriceDisplayOption = 8,

            /// <summary>
            /// Enum SoldDate for value: SoldDate
            /// </summary>
            [EnumMember(Value = "SoldDate")]
            SoldDate = 9,

            /// <summary>
            /// Enum Price for value: Price
            /// </summary>
            [EnumMember(Value = "Price")]
            Price = 10,

            /// <summary>
            /// Enum EarliestInspectionOpenTime for value: EarliestInspectionOpenTime
            /// </summary>
            [EnumMember(Value = "EarliestInspectionOpenTime")]
            EarliestInspectionOpenTime = 11,

            /// <summary>
            /// Enum EarliestAuctionTime for value: EarliestAuctionTime
            /// </summary>
            [EnumMember(Value = "EarliestAuctionTime")]
            EarliestAuctionTime = 12,

            /// <summary>
            /// Enum DateAvailable for value: DateAvailable
            /// </summary>
            [EnumMember(Value = "DateAvailable")]
            DateAvailable = 13

        }

        /// <summary>
        /// Gets or Sets Field
        /// </summary>
        [DataMember(Name = "field", EmitDefaultValue = false)]
        public FieldEnum? Field { get; set; }
        /// <summary>
        /// Defines Direction
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DirectionEnum
        {
            /// <summary>
            /// Enum Ascending for value: Ascending
            /// </summary>
            [EnumMember(Value = "Ascending")]
            Ascending = 1,

            /// <summary>
            /// Enum Descending for value: Descending
            /// </summary>
            [EnumMember(Value = "Descending")]
            Descending = 2

        }

        /// <summary>
        /// Gets or Sets Direction
        /// </summary>
        [DataMember(Name = "direction", EmitDefaultValue = false)]
        public DirectionEnum? Direction { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DomainSearchServiceV2ModelDomainSearchWebApiV2ModelsCustomSortElement" /> class.
        /// </summary>
        /// <param name="field">field.</param>
        /// <param name="direction">direction.</param>
        public DomainSearchServiceV2ModelDomainSearchWebApiV2ModelsCustomSortElement(FieldEnum? field = default(FieldEnum?), DirectionEnum? direction = default(DirectionEnum?))
        {
            this.Field = field;
            this.Direction = direction;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DomainSearchServiceV2ModelDomainSearchWebApiV2ModelsCustomSortElement {\n");
            sb.Append("  Field: ").Append(Field).Append("\n");
            sb.Append("  Direction: ").Append(Direction).Append("\n");
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
            return this.Equals(input as DomainSearchServiceV2ModelDomainSearchWebApiV2ModelsCustomSortElement);
        }

        /// <summary>
        /// Returns true if DomainSearchServiceV2ModelDomainSearchWebApiV2ModelsCustomSortElement instances are equal
        /// </summary>
        /// <param name="input">Instance of DomainSearchServiceV2ModelDomainSearchWebApiV2ModelsCustomSortElement to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DomainSearchServiceV2ModelDomainSearchWebApiV2ModelsCustomSortElement input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Field == input.Field ||
                    this.Field.Equals(input.Field)
                ) && 
                (
                    this.Direction == input.Direction ||
                    this.Direction.Equals(input.Direction)
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
                hashCode = hashCode * 59 + this.Field.GetHashCode();
                hashCode = hashCode * 59 + this.Direction.GetHashCode();
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