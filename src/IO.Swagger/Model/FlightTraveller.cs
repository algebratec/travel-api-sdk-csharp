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
    /// FlightTraveller
    /// </summary>
    [DataContract]
        public partial class FlightTraveller : FlightBaseTraveller,  IEquatable<FlightTraveller>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FlightTraveller" /> class.
        /// </summary>
        /// <param name="specialService">specialService.</param>
        /// <param name="infant">infant.</param>
        public FlightTraveller(string specialService = default(string), FlightBaseTraveller infant = default(FlightBaseTraveller), string birthDate = default(string), string firstname = default(string), string lastname = default(string), string nationality = default(string), DateTime? passportExpirationDate = default(DateTime?), string passportNumber = default(string), string sex = default(string)) : base(birthDate, firstname, lastname, nationality, passportExpirationDate, passportNumber, sex)
        {
            this.SpecialService = specialService;
            this.Infant = infant;
        }
        
        /// <summary>
        /// Gets or Sets SpecialService
        /// </summary>
        [DataMember(Name="specialService", EmitDefaultValue=false)]
        public string SpecialService { get; set; }

        /// <summary>
        /// Gets or Sets Infant
        /// </summary>
        [DataMember(Name="infant", EmitDefaultValue=false)]
        public FlightBaseTraveller Infant { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FlightTraveller {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  SpecialService: ").Append(SpecialService).Append("\n");
            sb.Append("  Infant: ").Append(Infant).Append("\n");
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
            return this.Equals(input as FlightTraveller);
        }

        /// <summary>
        /// Returns true if FlightTraveller instances are equal
        /// </summary>
        /// <param name="input">Instance of FlightTraveller to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FlightTraveller input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.SpecialService == input.SpecialService ||
                    (this.SpecialService != null &&
                    this.SpecialService.Equals(input.SpecialService))
                ) && base.Equals(input) && 
                (
                    this.Infant == input.Infant ||
                    (this.Infant != null &&
                    this.Infant.Equals(input.Infant))
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
                if (this.SpecialService != null)
                    hashCode = hashCode * 59 + this.SpecialService.GetHashCode();
                if (this.Infant != null)
                    hashCode = hashCode * 59 + this.Infant.GetHashCode();
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