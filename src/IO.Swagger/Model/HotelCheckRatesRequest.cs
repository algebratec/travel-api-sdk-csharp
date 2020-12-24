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
    /// HotelCheckRatesRequest
    /// </summary>
    [DataContract]
        public partial class HotelCheckRatesRequest :  IEquatable<HotelCheckRatesRequest>, IValidatableObject
    {
        /// <summary>
        /// Defines Language
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum LanguageEnum
        {
            /// <summary>
            /// Enum EN for value: EN
            /// </summary>
            [EnumMember(Value = "EN")]
            EN = 1,
            /// <summary>
            /// Enum FR for value: FR
            /// </summary>
            [EnumMember(Value = "FR")]
            FR = 2,
            /// <summary>
            /// Enum AR for value: AR
            /// </summary>
            [EnumMember(Value = "AR")]
            AR = 3        }
        /// <summary>
        /// Gets or Sets Language
        /// </summary>
        [DataMember(Name="language", EmitDefaultValue=false)]
        public LanguageEnum? Language { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="HotelCheckRatesRequest" /> class.
        /// </summary>
        /// <param name="language">language.</param>
        /// <param name="rooms">rooms.</param>
        public HotelCheckRatesRequest(LanguageEnum? language = default(LanguageEnum?), List<HotelCheckRatesRequestRooms> rooms = default(List<HotelCheckRatesRequestRooms>))
        {
            this.Language = language;
            this.Rooms = rooms;
        }
        

        /// <summary>
        /// Gets or Sets Rooms
        /// </summary>
        [DataMember(Name="rooms", EmitDefaultValue=false)]
        public List<HotelCheckRatesRequestRooms> Rooms { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HotelCheckRatesRequest {\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  Rooms: ").Append(Rooms).Append("\n");
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
            return this.Equals(input as HotelCheckRatesRequest);
        }

        /// <summary>
        /// Returns true if HotelCheckRatesRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of HotelCheckRatesRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HotelCheckRatesRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Language == input.Language ||
                    (this.Language != null &&
                    this.Language.Equals(input.Language))
                ) && 
                (
                    this.Rooms == input.Rooms ||
                    this.Rooms != null &&
                    input.Rooms != null &&
                    this.Rooms.SequenceEqual(input.Rooms)
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
                if (this.Language != null)
                    hashCode = hashCode * 59 + this.Language.GetHashCode();
                if (this.Rooms != null)
                    hashCode = hashCode * 59 + this.Rooms.GetHashCode();
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