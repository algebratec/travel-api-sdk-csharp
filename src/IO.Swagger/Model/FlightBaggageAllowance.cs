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
    /// FlightBaggageAllowance
    /// </summary>
    [DataContract]
        public partial class FlightBaggageAllowance :  IEquatable<FlightBaggageAllowance>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FlightBaggageAllowance" /> class.
        /// </summary>
        /// <param name="freeAllowance">freeAllowance.</param>
        /// <param name="quantityCode">quantityCode.</param>
        /// <param name="unitQualifier">unitQualifier.</param>
        /// <param name="withBaggage">withBaggage.</param>
        public FlightBaggageAllowance(int? freeAllowance = default(int?), string quantityCode = default(string), string unitQualifier = default(string), bool? withBaggage = default(bool?))
        {
            this.FreeAllowance = freeAllowance;
            this.QuantityCode = quantityCode;
            this.UnitQualifier = unitQualifier;
            this.WithBaggage = withBaggage;
        }
        
        /// <summary>
        /// Gets or Sets FreeAllowance
        /// </summary>
        [DataMember(Name="freeAllowance", EmitDefaultValue=false)]
        public int? FreeAllowance { get; set; }

        /// <summary>
        /// Gets or Sets QuantityCode
        /// </summary>
        [DataMember(Name="quantityCode", EmitDefaultValue=false)]
        public string QuantityCode { get; set; }

        /// <summary>
        /// Gets or Sets UnitQualifier
        /// </summary>
        [DataMember(Name="unitQualifier", EmitDefaultValue=false)]
        public string UnitQualifier { get; set; }

        /// <summary>
        /// Gets or Sets WithBaggage
        /// </summary>
        [DataMember(Name="withBaggage", EmitDefaultValue=false)]
        public bool? WithBaggage { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FlightBaggageAllowance {\n");
            sb.Append("  FreeAllowance: ").Append(FreeAllowance).Append("\n");
            sb.Append("  QuantityCode: ").Append(QuantityCode).Append("\n");
            sb.Append("  UnitQualifier: ").Append(UnitQualifier).Append("\n");
            sb.Append("  WithBaggage: ").Append(WithBaggage).Append("\n");
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
            return this.Equals(input as FlightBaggageAllowance);
        }

        /// <summary>
        /// Returns true if FlightBaggageAllowance instances are equal
        /// </summary>
        /// <param name="input">Instance of FlightBaggageAllowance to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FlightBaggageAllowance input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FreeAllowance == input.FreeAllowance ||
                    (this.FreeAllowance != null &&
                    this.FreeAllowance.Equals(input.FreeAllowance))
                ) && 
                (
                    this.QuantityCode == input.QuantityCode ||
                    (this.QuantityCode != null &&
                    this.QuantityCode.Equals(input.QuantityCode))
                ) && 
                (
                    this.UnitQualifier == input.UnitQualifier ||
                    (this.UnitQualifier != null &&
                    this.UnitQualifier.Equals(input.UnitQualifier))
                ) && 
                (
                    this.WithBaggage == input.WithBaggage ||
                    (this.WithBaggage != null &&
                    this.WithBaggage.Equals(input.WithBaggage))
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
                if (this.FreeAllowance != null)
                    hashCode = hashCode * 59 + this.FreeAllowance.GetHashCode();
                if (this.QuantityCode != null)
                    hashCode = hashCode * 59 + this.QuantityCode.GetHashCode();
                if (this.UnitQualifier != null)
                    hashCode = hashCode * 59 + this.UnitQualifier.GetHashCode();
                if (this.WithBaggage != null)
                    hashCode = hashCode * 59 + this.WithBaggage.GetHashCode();
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