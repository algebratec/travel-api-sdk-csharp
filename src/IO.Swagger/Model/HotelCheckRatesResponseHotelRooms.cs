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
    /// HotelCheckRatesResponseHotelRooms
    /// </summary>
    [DataContract]
        public partial class HotelCheckRatesResponseHotelRooms :  IEquatable<HotelCheckRatesResponseHotelRooms>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HotelCheckRatesResponseHotelRooms" /> class.
        /// </summary>
        /// <param name="code">code.</param>
        /// <param name="name">name.</param>
        /// <param name="rates">rates.</param>
        public HotelCheckRatesResponseHotelRooms(string code = default(string), string name = default(string), List<HotelCheckRatesResponseHotelRates> rates = default(List<HotelCheckRatesResponseHotelRates>))
        {
            this.Code = code;
            this.Name = name;
            this.Rates = rates;
        }
        
        /// <summary>
        /// Gets or Sets Code
        /// </summary>
        [DataMember(Name="code", EmitDefaultValue=false)]
        public string Code { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Rates
        /// </summary>
        [DataMember(Name="rates", EmitDefaultValue=false)]
        public List<HotelCheckRatesResponseHotelRates> Rates { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HotelCheckRatesResponseHotelRooms {\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Rates: ").Append(Rates).Append("\n");
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
            return this.Equals(input as HotelCheckRatesResponseHotelRooms);
        }

        /// <summary>
        /// Returns true if HotelCheckRatesResponseHotelRooms instances are equal
        /// </summary>
        /// <param name="input">Instance of HotelCheckRatesResponseHotelRooms to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HotelCheckRatesResponseHotelRooms input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Rates == input.Rates ||
                    this.Rates != null &&
                    input.Rates != null &&
                    this.Rates.SequenceEqual(input.Rates)
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
                if (this.Code != null)
                    hashCode = hashCode * 59 + this.Code.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Rates != null)
                    hashCode = hashCode * 59 + this.Rates.GetHashCode();
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
