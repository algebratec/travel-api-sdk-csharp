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
    /// FlightFareResponse
    /// </summary>
    [DataContract]
        public partial class FlightFareResponse : AlgebratecResponse,  IEquatable<FlightFareResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FlightFareResponse" /> class.
        /// </summary>
        /// <param name="fare">fare.</param>
        public FlightFareResponse(FlightFare fare = default(FlightFare), List<Error> errors = default(List<Error>), List<Provider> providers = default(List<Provider>), List<Supplier> suppliers = default(List<Supplier>), bool? success = default(bool?)) : base(errors, providers, suppliers, success)
        {
            this.Fare = fare;
        }
        
        /// <summary>
        /// Gets or Sets Fare
        /// </summary>
        [DataMember(Name="fare", EmitDefaultValue=false)]
        public FlightFare Fare { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FlightFareResponse {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Fare: ").Append(Fare).Append("\n");
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
            return this.Equals(input as FlightFareResponse);
        }

        /// <summary>
        /// Returns true if FlightFareResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of FlightFareResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FlightFareResponse input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.Fare == input.Fare ||
                    (this.Fare != null &&
                    this.Fare.Equals(input.Fare))
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
                if (this.Fare != null)
                    hashCode = hashCode * 59 + this.Fare.GetHashCode();
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
