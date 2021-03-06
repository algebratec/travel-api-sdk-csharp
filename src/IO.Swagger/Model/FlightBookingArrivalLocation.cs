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
    /// FlightBookingArrivalLocation
    /// </summary>
    [DataContract]
        public partial class FlightBookingArrivalLocation :  IEquatable<FlightBookingArrivalLocation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FlightBookingArrivalLocation" /> class.
        /// </summary>
        /// <param name="airport">airport.</param>
        /// <param name="cityAndCountry">cityAndCountry.</param>
        public FlightBookingArrivalLocation(string airport = default(string), string cityAndCountry = default(string))
        {
            this.Airport = airport;
            this.CityAndCountry = cityAndCountry;
        }
        
        /// <summary>
        /// Gets or Sets Airport
        /// </summary>
        [DataMember(Name="airport", EmitDefaultValue=false)]
        public string Airport { get; set; }

        /// <summary>
        /// Gets or Sets CityAndCountry
        /// </summary>
        [DataMember(Name="city_and_country", EmitDefaultValue=false)]
        public string CityAndCountry { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FlightBookingArrivalLocation {\n");
            sb.Append("  Airport: ").Append(Airport).Append("\n");
            sb.Append("  CityAndCountry: ").Append(CityAndCountry).Append("\n");
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
            return this.Equals(input as FlightBookingArrivalLocation);
        }

        /// <summary>
        /// Returns true if FlightBookingArrivalLocation instances are equal
        /// </summary>
        /// <param name="input">Instance of FlightBookingArrivalLocation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FlightBookingArrivalLocation input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Airport == input.Airport ||
                    (this.Airport != null &&
                    this.Airport.Equals(input.Airport))
                ) && 
                (
                    this.CityAndCountry == input.CityAndCountry ||
                    (this.CityAndCountry != null &&
                    this.CityAndCountry.Equals(input.CityAndCountry))
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
                if (this.Airport != null)
                    hashCode = hashCode * 59 + this.Airport.GetHashCode();
                if (this.CityAndCountry != null)
                    hashCode = hashCode * 59 + this.CityAndCountry.GetHashCode();
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
