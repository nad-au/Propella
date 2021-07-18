/*
 * Domain Public API
 *
 * See https://developer.domain.com.au for more information
 *
 * The version of the OpenAPI document: v2
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
using OpenAPIDateConverter = Domain.Api.V2.Client.OpenAPIDateConverter;

namespace Domain.Api.V2.Model
{
    /// <summary>
    /// The lifecycle status of a Listing  * &#x60;Unknown&#x60; - The listing has an unknown status, this can only be the case if data is somehow corrupted. * &#x60;Archived&#x60; - The listing has been archived and is inactive. * &#x60;UnderOffer&#x60; - An offer has been made for the listing. The listing is still active. * &#x60;Sold&#x60; - The listing has been sold.             The listing is inactive but may appear as sold listing on Domain * &#x60;Leased&#x60; - The listing has been leased. * &#x60;NewDevelopment&#x60; - The listing is a New Development Listing.             The listing is active. * &#x60;RecentlyUpdated&#x60; - The listing or project has been updated in past few days.             The listing is active. * &#x60;New&#x60; - The listing or project has been created in past few days.             The listing is active. * &#x60;Live&#x60; - The listing or project is currently live and has not been recently created or updated.             This listing is active. * &#x60;Pending&#x60; - This status is only used by projects.             It indicates that the project is pending to be activated (start date in the future).             This project is inactive. * &#x60;DepositTaken&#x60; - Deposit Taken. This listing is still active.
    /// </summary>
    /// <value>The lifecycle status of a Listing  * &#x60;Unknown&#x60; - The listing has an unknown status, this can only be the case if data is somehow corrupted. * &#x60;Archived&#x60; - The listing has been archived and is inactive. * &#x60;UnderOffer&#x60; - An offer has been made for the listing. The listing is still active. * &#x60;Sold&#x60; - The listing has been sold.             The listing is inactive but may appear as sold listing on Domain * &#x60;Leased&#x60; - The listing has been leased. * &#x60;NewDevelopment&#x60; - The listing is a New Development Listing.             The listing is active. * &#x60;RecentlyUpdated&#x60; - The listing or project has been updated in past few days.             The listing is active. * &#x60;New&#x60; - The listing or project has been created in past few days.             The listing is active. * &#x60;Live&#x60; - The listing or project is currently live and has not been recently created or updated.             This listing is active. * &#x60;Pending&#x60; - This status is only used by projects.             It indicates that the project is pending to be activated (start date in the future).             This project is inactive. * &#x60;DepositTaken&#x60; - Deposit Taken. This listing is still active.</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum ListingsV2Status
    {
        /// <summary>
        /// Enum Unknown for value: unknown
        /// </summary>
        [EnumMember(Value = "unknown")]
        Unknown = 1,

        /// <summary>
        /// Enum Archived for value: archived
        /// </summary>
        [EnumMember(Value = "archived")]
        Archived = 2,

        /// <summary>
        /// Enum UnderOffer for value: underOffer
        /// </summary>
        [EnumMember(Value = "underOffer")]
        UnderOffer = 3,

        /// <summary>
        /// Enum Sold for value: sold
        /// </summary>
        [EnumMember(Value = "sold")]
        Sold = 4,

        /// <summary>
        /// Enum Leased for value: leased
        /// </summary>
        [EnumMember(Value = "leased")]
        Leased = 5,

        /// <summary>
        /// Enum NewDevelopment for value: newDevelopment
        /// </summary>
        [EnumMember(Value = "newDevelopment")]
        NewDevelopment = 6,

        /// <summary>
        /// Enum RecentlyUpdated for value: recentlyUpdated
        /// </summary>
        [EnumMember(Value = "recentlyUpdated")]
        RecentlyUpdated = 7,

        /// <summary>
        /// Enum New for value: new
        /// </summary>
        [EnumMember(Value = "new")]
        New = 8,

        /// <summary>
        /// Enum Live for value: live
        /// </summary>
        [EnumMember(Value = "live")]
        Live = 9,

        /// <summary>
        /// Enum Pending for value: pending
        /// </summary>
        [EnumMember(Value = "pending")]
        Pending = 10,

        /// <summary>
        /// Enum DepositTaken for value: depositTaken
        /// </summary>
        [EnumMember(Value = "depositTaken")]
        DepositTaken = 11

    }

}