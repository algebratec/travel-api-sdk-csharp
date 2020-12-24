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
    /// FlightAvailabilityFareDetailsFares
    /// </summary>
    [DataContract]
        public partial class FlightAvailabilityFareDetailsFares :  IEquatable<FlightAvailabilityFareDetailsFares>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FlightAvailabilityFareDetailsFares" /> class.
        /// </summary>
        /// <param name="fareAdvise">fareAdvise.</param>
        /// <param name="fareBasis">fareBasis.</param>
        public FlightAvailabilityFareDetailsFares(List<string> fareAdvise = default(List<string>), string fareBasis = default(string))
        {
            this.FareAdvise = fareAdvise;
            this.FareBasis = fareBasis;
        }
        
        /// <summary>
        /// Gets or Sets FareAdvise
        /// </summary>
        [DataMember(Name="fareAdvise", EmitDefaultValue=false)]
        public List<string> FareAdvise { get; set; }

        /// <summary>
        /// Gets or Sets FareBasis
        /// </summary>
        [DataMember(Name="fareBasis", EmitDefaultValue=false)]
        public string FareBasis { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FlightAvailabilityFareDetailsFares {\n");
            sb.Append("  FareAdvise: ").Append(FareAdvise).Append("\n");
            sb.Append("  FareBasis: ").Append(FareBasis).Append("\n");
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
            return this.Equals(input as FlightAvailabilityFareDetailsFares);
        }

        /// <summary>
        /// Returns true if FlightAvailabilityFareDetailsFares instances are equal
        /// </summary>
        /// <param name="input">Instance of FlightAvailabilityFareDetailsFares to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FlightAvailabilityFareDetailsFares input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FareAdvise == input.FareAdvise ||
                    this.FareAdvise != null &&
                    input.FareAdvise != null &&
                    this.FareAdvise.SequenceEqual(input.FareAdvise)
                ) && 
                (
                    this.FareBasis == input.FareBasis ||
                    (this.FareBasis != null &&
                    this.FareBasis.Equals(input.FareBasis))
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
                if (this.FareAdvise != null)
                    hashCode = hashCode * 59 + this.FareAdvise.GetHashCode();
                if (this.FareBasis != null)
                    hashCode = hashCode * 59 + this.FareBasis.GetHashCode();
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