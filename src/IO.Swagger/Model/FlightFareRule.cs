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
    /// FlightFareRule
    /// </summary>
    [DataContract]
        public partial class FlightFareRule :  IEquatable<FlightFareRule>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FlightFareRule" /> class.
        /// </summary>
        /// <param name="flightConditions">flightConditions.</param>
        public FlightFareRule(List<string> flightConditions = default(List<string>))
        {
            this.FlightConditions = flightConditions;
        }
        
        /// <summary>
        /// Gets or Sets FlightConditions
        /// </summary>
        [DataMember(Name="Flight_Conditions", EmitDefaultValue=false)]
        public List<string> FlightConditions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FlightFareRule {\n");
            sb.Append("  FlightConditions: ").Append(FlightConditions).Append("\n");
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
            return this.Equals(input as FlightFareRule);
        }

        /// <summary>
        /// Returns true if FlightFareRule instances are equal
        /// </summary>
        /// <param name="input">Instance of FlightFareRule to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FlightFareRule input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FlightConditions == input.FlightConditions ||
                    this.FlightConditions != null &&
                    input.FlightConditions != null &&
                    this.FlightConditions.SequenceEqual(input.FlightConditions)
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
                if (this.FlightConditions != null)
                    hashCode = hashCode * 59 + this.FlightConditions.GetHashCode();
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
