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
    /// HotelAvailabilityRequestGeolocation
    /// </summary>
    [DataContract]
        public partial class HotelAvailabilityRequestGeolocation :  IEquatable<HotelAvailabilityRequestGeolocation>, IValidatableObject
    {
        /// <summary>
        /// Kilometer or mile
        /// </summary>
        /// <value>Kilometer or mile</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum UnitEnum
        {
            /// <summary>
            /// Enum Km for value: km
            /// </summary>
            [EnumMember(Value = "km")]
            Km = 1,
            /// <summary>
            /// Enum Mi for value: mi
            /// </summary>
            [EnumMember(Value = "mi")]
            Mi = 2        }
        /// <summary>
        /// Kilometer or mile
        /// </summary>
        /// <value>Kilometer or mile</value>
        [DataMember(Name="unit", EmitDefaultValue=false)]
        public UnitEnum? Unit { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="HotelAvailabilityRequestGeolocation" /> class.
        /// </summary>
        /// <param name="longitude">longitude.</param>
        /// <param name="latitude">latitude.</param>
        /// <param name="radius">radius.</param>
        /// <param name="unit">Kilometer or mile.</param>
        public HotelAvailabilityRequestGeolocation(int? longitude = default(int?), int? latitude = default(int?), int? radius = default(int?), UnitEnum? unit = default(UnitEnum?))
        {
            this.Longitude = longitude;
            this.Latitude = latitude;
            this.Radius = radius;
            this.Unit = unit;
        }
        
        /// <summary>
        /// Gets or Sets Longitude
        /// </summary>
        [DataMember(Name="longitude", EmitDefaultValue=false)]
        public int? Longitude { get; set; }

        /// <summary>
        /// Gets or Sets Latitude
        /// </summary>
        [DataMember(Name="latitude", EmitDefaultValue=false)]
        public int? Latitude { get; set; }

        /// <summary>
        /// Gets or Sets Radius
        /// </summary>
        [DataMember(Name="radius", EmitDefaultValue=false)]
        public int? Radius { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HotelAvailabilityRequestGeolocation {\n");
            sb.Append("  Longitude: ").Append(Longitude).Append("\n");
            sb.Append("  Latitude: ").Append(Latitude).Append("\n");
            sb.Append("  Radius: ").Append(Radius).Append("\n");
            sb.Append("  Unit: ").Append(Unit).Append("\n");
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
            return this.Equals(input as HotelAvailabilityRequestGeolocation);
        }

        /// <summary>
        /// Returns true if HotelAvailabilityRequestGeolocation instances are equal
        /// </summary>
        /// <param name="input">Instance of HotelAvailabilityRequestGeolocation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HotelAvailabilityRequestGeolocation input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Longitude == input.Longitude ||
                    (this.Longitude != null &&
                    this.Longitude.Equals(input.Longitude))
                ) && 
                (
                    this.Latitude == input.Latitude ||
                    (this.Latitude != null &&
                    this.Latitude.Equals(input.Latitude))
                ) && 
                (
                    this.Radius == input.Radius ||
                    (this.Radius != null &&
                    this.Radius.Equals(input.Radius))
                ) && 
                (
                    this.Unit == input.Unit ||
                    (this.Unit != null &&
                    this.Unit.Equals(input.Unit))
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
                if (this.Longitude != null)
                    hashCode = hashCode * 59 + this.Longitude.GetHashCode();
                if (this.Latitude != null)
                    hashCode = hashCode * 59 + this.Latitude.GetHashCode();
                if (this.Radius != null)
                    hashCode = hashCode * 59 + this.Radius.GetHashCode();
                if (this.Unit != null)
                    hashCode = hashCode * 59 + this.Unit.GetHashCode();
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