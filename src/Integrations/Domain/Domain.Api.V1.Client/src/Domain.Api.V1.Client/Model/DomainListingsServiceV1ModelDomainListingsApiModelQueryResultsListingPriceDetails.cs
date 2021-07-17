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
    /// DomainListingsServiceV1ModelDomainListingsApiModelQueryResultsListingPriceDetails
    /// </summary>
    [DataContract(Name = "Domain.ListingsService.v1.Model.DomainListingsApiModelQueryResultsListingPriceDetails")]
    public partial class DomainListingsServiceV1ModelDomainListingsApiModelQueryResultsListingPriceDetails : IEquatable<DomainListingsServiceV1ModelDomainListingsApiModelQueryResultsListingPriceDetails>, IValidatableObject
    {
        /// <summary>
        /// Defines HiddenReasons
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum HiddenReasonsEnum
        {
            /// <summary>
            /// Enum ByAgency for value: byAgency
            /// </summary>
            [EnumMember(Value = "byAgency")]
            ByAgency = 1,

            /// <summary>
            /// Enum QLDRestriction for value: qLDRestriction
            /// </summary>
            [EnumMember(Value = "qLDRestriction")]
            QLDRestriction = 2

        }


        /// <summary>
        /// Gets or Sets HiddenReasons
        /// </summary>
        [DataMember(Name = "hiddenReasons", EmitDefaultValue = false)]
        public List<HiddenReasonsEnum> HiddenReasons { get; set; }
        /// <summary>
        /// Defines GstOption
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum GstOptionEnum
        {
            /// <summary>
            /// Enum Na for value: na
            /// </summary>
            [EnumMember(Value = "na")]
            Na = 1,

            /// <summary>
            /// Enum Inc for value: inc
            /// </summary>
            [EnumMember(Value = "inc")]
            Inc = 2,

            /// <summary>
            /// Enum Ex for value: ex
            /// </summary>
            [EnumMember(Value = "ex")]
            Ex = 3

        }

        /// <summary>
        /// Gets or Sets GstOption
        /// </summary>
        [DataMember(Name = "gstOption", EmitDefaultValue = false)]
        public GstOptionEnum? GstOption { get; set; }
        /// <summary>
        /// Defines PriceType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PriceTypeEnum
        {
            /// <summary>
            /// Enum Gross for value: gross
            /// </summary>
            [EnumMember(Value = "gross")]
            Gross = 1,

            /// <summary>
            /// Enum Net for value: net
            /// </summary>
            [EnumMember(Value = "net")]
            Net = 2

        }

        /// <summary>
        /// Gets or Sets PriceType
        /// </summary>
        [DataMember(Name = "priceType", EmitDefaultValue = false)]
        public PriceTypeEnum? PriceType { get; set; }
        /// <summary>
        /// Defines PriceUnit
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PriceUnitEnum
        {
            /// <summary>
            /// Enum TotalAmount for value: totalAmount
            /// </summary>
            [EnumMember(Value = "totalAmount")]
            TotalAmount = 1,

            /// <summary>
            /// Enum PerSqm for value: perSqm
            /// </summary>
            [EnumMember(Value = "perSqm")]
            PerSqm = 2

        }

        /// <summary>
        /// Gets or Sets PriceUnit
        /// </summary>
        [DataMember(Name = "priceUnit", EmitDefaultValue = false)]
        public PriceUnitEnum? PriceUnit { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DomainListingsServiceV1ModelDomainListingsApiModelQueryResultsListingPriceDetails" /> class.
        /// </summary>
        /// <param name="hiddenReasons">hiddenReasons.</param>
        /// <param name="gstOption">gstOption.</param>
        /// <param name="priceType">priceType.</param>
        /// <param name="priceUnit">priceUnit.</param>
        /// <param name="price">price.</param>
        /// <param name="priceFrom">priceFrom.</param>
        /// <param name="priceTo">priceTo.</param>
        /// <param name="pricePrefix">pricePrefix.</param>
        /// <param name="canDisplayPrice">canDisplayPrice.</param>
        /// <param name="displayPrice">displayPrice.</param>
        /// <param name="bond">bond.</param>
        /// <param name="priceReduction">priceReduction.</param>
        public DomainListingsServiceV1ModelDomainListingsApiModelQueryResultsListingPriceDetails(List<HiddenReasonsEnum> hiddenReasons = default(List<HiddenReasonsEnum>), GstOptionEnum? gstOption = default(GstOptionEnum?), PriceTypeEnum? priceType = default(PriceTypeEnum?), PriceUnitEnum? priceUnit = default(PriceUnitEnum?), double price = default(double), int priceFrom = default(int), int priceTo = default(int), string pricePrefix = default(string), bool canDisplayPrice = default(bool), string displayPrice = default(string), double bond = default(double), bool priceReduction = default(bool))
        {
            this.HiddenReasons = hiddenReasons;
            this.GstOption = gstOption;
            this.PriceType = priceType;
            this.PriceUnit = priceUnit;
            this.Price = price;
            this.PriceFrom = priceFrom;
            this.PriceTo = priceTo;
            this.PricePrefix = pricePrefix;
            this.CanDisplayPrice = canDisplayPrice;
            this.DisplayPrice = displayPrice;
            this.Bond = bond;
            this.PriceReduction = priceReduction;
        }

        /// <summary>
        /// Gets or Sets Price
        /// </summary>
        [DataMember(Name = "price", EmitDefaultValue = false)]
        public double Price { get; set; }

        /// <summary>
        /// Gets or Sets PriceFrom
        /// </summary>
        [DataMember(Name = "priceFrom", EmitDefaultValue = false)]
        public int PriceFrom { get; set; }

        /// <summary>
        /// Gets or Sets PriceTo
        /// </summary>
        [DataMember(Name = "priceTo", EmitDefaultValue = false)]
        public int PriceTo { get; set; }

        /// <summary>
        /// Gets or Sets PricePrefix
        /// </summary>
        [DataMember(Name = "pricePrefix", EmitDefaultValue = false)]
        public string PricePrefix { get; set; }

        /// <summary>
        /// Gets or Sets CanDisplayPrice
        /// </summary>
        [DataMember(Name = "canDisplayPrice", EmitDefaultValue = false)]
        public bool CanDisplayPrice { get; set; }

        /// <summary>
        /// Gets or Sets DisplayPrice
        /// </summary>
        [DataMember(Name = "displayPrice", EmitDefaultValue = false)]
        public string DisplayPrice { get; set; }

        /// <summary>
        /// Gets or Sets Bond
        /// </summary>
        [DataMember(Name = "bond", EmitDefaultValue = false)]
        public double Bond { get; set; }

        /// <summary>
        /// Gets or Sets PriceReduction
        /// </summary>
        [DataMember(Name = "priceReduction", EmitDefaultValue = false)]
        public bool PriceReduction { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DomainListingsServiceV1ModelDomainListingsApiModelQueryResultsListingPriceDetails {\n");
            sb.Append("  HiddenReasons: ").Append(HiddenReasons).Append("\n");
            sb.Append("  GstOption: ").Append(GstOption).Append("\n");
            sb.Append("  PriceType: ").Append(PriceType).Append("\n");
            sb.Append("  PriceUnit: ").Append(PriceUnit).Append("\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
            sb.Append("  PriceFrom: ").Append(PriceFrom).Append("\n");
            sb.Append("  PriceTo: ").Append(PriceTo).Append("\n");
            sb.Append("  PricePrefix: ").Append(PricePrefix).Append("\n");
            sb.Append("  CanDisplayPrice: ").Append(CanDisplayPrice).Append("\n");
            sb.Append("  DisplayPrice: ").Append(DisplayPrice).Append("\n");
            sb.Append("  Bond: ").Append(Bond).Append("\n");
            sb.Append("  PriceReduction: ").Append(PriceReduction).Append("\n");
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
            return this.Equals(input as DomainListingsServiceV1ModelDomainListingsApiModelQueryResultsListingPriceDetails);
        }

        /// <summary>
        /// Returns true if DomainListingsServiceV1ModelDomainListingsApiModelQueryResultsListingPriceDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of DomainListingsServiceV1ModelDomainListingsApiModelQueryResultsListingPriceDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DomainListingsServiceV1ModelDomainListingsApiModelQueryResultsListingPriceDetails input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.HiddenReasons == input.HiddenReasons ||
                    this.HiddenReasons.SequenceEqual(input.HiddenReasons)
                ) && 
                (
                    this.GstOption == input.GstOption ||
                    this.GstOption.Equals(input.GstOption)
                ) && 
                (
                    this.PriceType == input.PriceType ||
                    this.PriceType.Equals(input.PriceType)
                ) && 
                (
                    this.PriceUnit == input.PriceUnit ||
                    this.PriceUnit.Equals(input.PriceUnit)
                ) && 
                (
                    this.Price == input.Price ||
                    this.Price.Equals(input.Price)
                ) && 
                (
                    this.PriceFrom == input.PriceFrom ||
                    this.PriceFrom.Equals(input.PriceFrom)
                ) && 
                (
                    this.PriceTo == input.PriceTo ||
                    this.PriceTo.Equals(input.PriceTo)
                ) && 
                (
                    this.PricePrefix == input.PricePrefix ||
                    (this.PricePrefix != null &&
                    this.PricePrefix.Equals(input.PricePrefix))
                ) && 
                (
                    this.CanDisplayPrice == input.CanDisplayPrice ||
                    this.CanDisplayPrice.Equals(input.CanDisplayPrice)
                ) && 
                (
                    this.DisplayPrice == input.DisplayPrice ||
                    (this.DisplayPrice != null &&
                    this.DisplayPrice.Equals(input.DisplayPrice))
                ) && 
                (
                    this.Bond == input.Bond ||
                    this.Bond.Equals(input.Bond)
                ) && 
                (
                    this.PriceReduction == input.PriceReduction ||
                    this.PriceReduction.Equals(input.PriceReduction)
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
                hashCode = hashCode * 59 + this.HiddenReasons.GetHashCode();
                hashCode = hashCode * 59 + this.GstOption.GetHashCode();
                hashCode = hashCode * 59 + this.PriceType.GetHashCode();
                hashCode = hashCode * 59 + this.PriceUnit.GetHashCode();
                hashCode = hashCode * 59 + this.Price.GetHashCode();
                hashCode = hashCode * 59 + this.PriceFrom.GetHashCode();
                hashCode = hashCode * 59 + this.PriceTo.GetHashCode();
                if (this.PricePrefix != null)
                    hashCode = hashCode * 59 + this.PricePrefix.GetHashCode();
                hashCode = hashCode * 59 + this.CanDisplayPrice.GetHashCode();
                if (this.DisplayPrice != null)
                    hashCode = hashCode * 59 + this.DisplayPrice.GetHashCode();
                hashCode = hashCode * 59 + this.Bond.GetHashCode();
                hashCode = hashCode * 59 + this.PriceReduction.GetHashCode();
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