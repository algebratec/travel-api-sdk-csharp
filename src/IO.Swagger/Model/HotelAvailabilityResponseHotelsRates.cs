/* 
 * Algebratec API
 *
 * Learn and test our api with ease
 *
 * OpenAPI spec version: 1.0.0
 * Contact: support@algebratec.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// HotelAvailabilityResponseHotelsRates
    /// </summary>
    [DataContract]
        public partial class HotelAvailabilityResponseHotelsRates :  IEquatable<HotelAvailabilityResponseHotelsRates>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HotelAvailabilityResponseHotelsRates" /> class.
        /// </summary>
        /// <param name="boardName">boardName.</param>
        /// <param name="boardCode">boardCode.</param>
        /// <param name="price">price.</param>
        /// <param name="rateKey">rateKey.</param>
        /// <param name="rateComment">rateComment.</param>
        /// <param name="taxes">taxes.</param>
        /// <param name="cancellationPolicies">cancellationPolicies.</param>
        public HotelAvailabilityResponseHotelsRates(string boardName = default(string), string boardCode = default(string), int? price = default(int?), string rateKey = default(string), string rateComment = default(string), List<HotelAvailabilityResponseHotelsTaxes> taxes = default(List<HotelAvailabilityResponseHotelsTaxes>), List<HotelAvailabilityResponseHotelsCancellationPolicies> cancellationPolicies = default(List<HotelAvailabilityResponseHotelsCancellationPolicies>))
        {
            this.BoardName = boardName;
            this.BoardCode = boardCode;
            this.Price = price;
            this.RateKey = rateKey;
            this.RateComment = rateComment;
            this.Taxes = taxes;
            this.CancellationPolicies = cancellationPolicies;
        }
        
        /// <summary>
        /// Gets or Sets BoardName
        /// </summary>
        [DataMember(Name="boardName", EmitDefaultValue=false)]
        public string BoardName { get; set; }

        /// <summary>
        /// Gets or Sets BoardCode
        /// </summary>
        [DataMember(Name="boardCode", EmitDefaultValue=false)]
        public string BoardCode { get; set; }

        /// <summary>
        /// Gets or Sets Price
        /// </summary>
        [DataMember(Name="price", EmitDefaultValue=false)]
        public int? Price { get; set; }

        /// <summary>
        /// Gets or Sets RateKey
        /// </summary>
        [DataMember(Name="rateKey", EmitDefaultValue=false)]
        public string RateKey { get; set; }

        /// <summary>
        /// Gets or Sets RateComment
        /// </summary>
        [DataMember(Name="rateComment", EmitDefaultValue=false)]
        public string RateComment { get; set; }

        /// <summary>
        /// Gets or Sets Taxes
        /// </summary>
        [DataMember(Name="taxes", EmitDefaultValue=false)]
        public List<HotelAvailabilityResponseHotelsTaxes> Taxes { get; set; }

        /// <summary>
        /// Gets or Sets CancellationPolicies
        /// </summary>
        [DataMember(Name="cancellationPolicies", EmitDefaultValue=false)]
        public List<HotelAvailabilityResponseHotelsCancellationPolicies> CancellationPolicies { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HotelAvailabilityResponseHotelsRates {\n");
            sb.Append("  BoardName: ").Append(BoardName).Append("\n");
            sb.Append("  BoardCode: ").Append(BoardCode).Append("\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
            sb.Append("  RateKey: ").Append(RateKey).Append("\n");
            sb.Append("  RateComment: ").Append(RateComment).Append("\n");
            sb.Append("  Taxes: ").Append(Taxes).Append("\n");
            sb.Append("  CancellationPolicies: ").Append(CancellationPolicies).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as HotelAvailabilityResponseHotelsRates);
        }

        /// <summary>
        /// Returns true if HotelAvailabilityResponseHotelsRates instances are equal
        /// </summary>
        /// <param name="input">Instance of HotelAvailabilityResponseHotelsRates to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HotelAvailabilityResponseHotelsRates input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BoardName == input.BoardName ||
                    (this.BoardName != null &&
                    this.BoardName.Equals(input.BoardName))
                ) && 
                (
                    this.BoardCode == input.BoardCode ||
                    (this.BoardCode != null &&
                    this.BoardCode.Equals(input.BoardCode))
                ) && 
                (
                    this.Price == input.Price ||
                    (this.Price != null &&
                    this.Price.Equals(input.Price))
                ) && 
                (
                    this.RateKey == input.RateKey ||
                    (this.RateKey != null &&
                    this.RateKey.Equals(input.RateKey))
                ) && 
                (
                    this.RateComment == input.RateComment ||
                    (this.RateComment != null &&
                    this.RateComment.Equals(input.RateComment))
                ) && 
                (
                    this.Taxes == input.Taxes ||
                    this.Taxes != null &&
                    input.Taxes != null &&
                    this.Taxes.SequenceEqual(input.Taxes)
                ) && 
                (
                    this.CancellationPolicies == input.CancellationPolicies ||
                    this.CancellationPolicies != null &&
                    input.CancellationPolicies != null &&
                    this.CancellationPolicies.SequenceEqual(input.CancellationPolicies)
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
                if (this.BoardName != null)
                    hashCode = hashCode * 59 + this.BoardName.GetHashCode();
                if (this.BoardCode != null)
                    hashCode = hashCode * 59 + this.BoardCode.GetHashCode();
                if (this.Price != null)
                    hashCode = hashCode * 59 + this.Price.GetHashCode();
                if (this.RateKey != null)
                    hashCode = hashCode * 59 + this.RateKey.GetHashCode();
                if (this.RateComment != null)
                    hashCode = hashCode * 59 + this.RateComment.GetHashCode();
                if (this.Taxes != null)
                    hashCode = hashCode * 59 + this.Taxes.GetHashCode();
                if (this.CancellationPolicies != null)
                    hashCode = hashCode * 59 + this.CancellationPolicies.GetHashCode();
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