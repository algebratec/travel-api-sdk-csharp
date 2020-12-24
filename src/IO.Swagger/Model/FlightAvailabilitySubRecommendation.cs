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
    /// FlightAvailabilitySubRecommendation
    /// </summary>
    [DataContract]
        public partial class FlightAvailabilitySubRecommendation :  IEquatable<FlightAvailabilitySubRecommendation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FlightAvailabilitySubRecommendation" /> class.
        /// </summary>
        /// <param name="baggage">baggage.</param>
        /// <param name="bounds">bounds.</param>
        /// <param name="fareRules">fareRules.</param>
        public FlightAvailabilitySubRecommendation(FlightBaggageAllowance baggage = default(FlightBaggageAllowance), List<FlightAvailabilitySubRecommendationBounds> bounds = default(List<FlightAvailabilitySubRecommendationBounds>), List<string> fareRules = default(List<string>))
        {
            this.Baggage = baggage;
            this.Bounds = bounds;
            this.FareRules = fareRules;
        }
        
        /// <summary>
        /// Gets or Sets Baggage
        /// </summary>
        [DataMember(Name="baggage", EmitDefaultValue=false)]
        public FlightBaggageAllowance Baggage { get; set; }

        /// <summary>
        /// Gets or Sets Bounds
        /// </summary>
        [DataMember(Name="bounds", EmitDefaultValue=false)]
        public List<FlightAvailabilitySubRecommendationBounds> Bounds { get; set; }

        /// <summary>
        /// Gets or Sets FareRules
        /// </summary>
        [DataMember(Name="fareRules", EmitDefaultValue=false)]
        public List<string> FareRules { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FlightAvailabilitySubRecommendation {\n");
            sb.Append("  Baggage: ").Append(Baggage).Append("\n");
            sb.Append("  Bounds: ").Append(Bounds).Append("\n");
            sb.Append("  FareRules: ").Append(FareRules).Append("\n");
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
            return this.Equals(input as FlightAvailabilitySubRecommendation);
        }

        /// <summary>
        /// Returns true if FlightAvailabilitySubRecommendation instances are equal
        /// </summary>
        /// <param name="input">Instance of FlightAvailabilitySubRecommendation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FlightAvailabilitySubRecommendation input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Baggage == input.Baggage ||
                    (this.Baggage != null &&
                    this.Baggage.Equals(input.Baggage))
                ) && 
                (
                    this.Bounds == input.Bounds ||
                    this.Bounds != null &&
                    input.Bounds != null &&
                    this.Bounds.SequenceEqual(input.Bounds)
                ) && 
                (
                    this.FareRules == input.FareRules ||
                    this.FareRules != null &&
                    input.FareRules != null &&
                    this.FareRules.SequenceEqual(input.FareRules)
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
                if (this.Baggage != null)
                    hashCode = hashCode * 59 + this.Baggage.GetHashCode();
                if (this.Bounds != null)
                    hashCode = hashCode * 59 + this.Bounds.GetHashCode();
                if (this.FareRules != null)
                    hashCode = hashCode * 59 + this.FareRules.GetHashCode();
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
