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
    /// FlightAvailabilityResponse
    /// </summary>
    [DataContract]
        public partial class FlightAvailabilityResponse : AlgebratecResponse,  IEquatable<FlightAvailabilityResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FlightAvailabilityResponse" /> class.
        /// </summary>
        /// <param name="availability">availability.</param>
        public FlightAvailabilityResponse(FlightAvailability availability = default(FlightAvailability), List<Error> errors = default(List<Error>), string provider = default(string), bool? success = default(bool?)) : base(errors, provider, success)
        {
            this.Availability = availability;
        }
        
        /// <summary>
        /// Gets or Sets Availability
        /// </summary>
        [DataMember(Name="availability", EmitDefaultValue=false)]
        public FlightAvailability Availability { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FlightAvailabilityResponse {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Availability: ").Append(Availability).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
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
            return this.Equals(input as FlightAvailabilityResponse);
        }

        /// <summary>
        /// Returns true if FlightAvailabilityResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of FlightAvailabilityResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FlightAvailabilityResponse input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.Availability == input.Availability ||
                    (this.Availability != null &&
                    this.Availability.Equals(input.Availability))
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
                int hashCode = base.GetHashCode();
                if (this.Availability != null)
                    hashCode = hashCode * 59 + this.Availability.GetHashCode();
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
            foreach(var x in BaseValidate(validationContext)) yield return x;
            yield break;
        }
    }
}
