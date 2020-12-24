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
    /// HotelConfirmationRequest
    /// </summary>
    [DataContract]
        public partial class HotelConfirmationRequest :  IEquatable<HotelConfirmationRequest>, IValidatableObject
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
        /// Initializes a new instance of the <see cref="HotelConfirmationRequest" /> class.
        /// </summary>
        /// <param name="language">language.</param>
        /// <param name="arrivalTime">arrivalTime.</param>
        /// <param name="comment">comment.</param>
        /// <param name="holder">holder.</param>
        /// <param name="payment">payment.</param>
        /// <param name="rooms">rooms.</param>
        /// <param name="extras">extras.</param>
        public HotelConfirmationRequest(LanguageEnum? language = default(LanguageEnum?), string arrivalTime = default(string), string comment = default(string), HotelConfirmationRequestHolder holder = default(HotelConfirmationRequestHolder), HotelConfirmationRequestPayment payment = default(HotelConfirmationRequestPayment), List<HotelConfirmationRequestRooms> rooms = default(List<HotelConfirmationRequestRooms>), List<int?> extras = default(List<int?>))
        {
            this.Language = language;
            this.ArrivalTime = arrivalTime;
            this.Comment = comment;
            this.Holder = holder;
            this.Payment = payment;
            this.Rooms = rooms;
            this.Extras = extras;
        }
        

        /// <summary>
        /// Gets or Sets ArrivalTime
        /// </summary>
        [DataMember(Name="arrivalTime", EmitDefaultValue=false)]
        public string ArrivalTime { get; set; }

        /// <summary>
        /// Gets or Sets Comment
        /// </summary>
        [DataMember(Name="comment", EmitDefaultValue=false)]
        public string Comment { get; set; }

        /// <summary>
        /// Gets or Sets Holder
        /// </summary>
        [DataMember(Name="holder", EmitDefaultValue=false)]
        public HotelConfirmationRequestHolder Holder { get; set; }

        /// <summary>
        /// Gets or Sets Payment
        /// </summary>
        [DataMember(Name="payment", EmitDefaultValue=false)]
        public HotelConfirmationRequestPayment Payment { get; set; }

        /// <summary>
        /// Gets or Sets Rooms
        /// </summary>
        [DataMember(Name="rooms", EmitDefaultValue=false)]
        public List<HotelConfirmationRequestRooms> Rooms { get; set; }

        /// <summary>
        /// Gets or Sets Extras
        /// </summary>
        [DataMember(Name="extras", EmitDefaultValue=false)]
        public List<int?> Extras { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HotelConfirmationRequest {\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  ArrivalTime: ").Append(ArrivalTime).Append("\n");
            sb.Append("  Comment: ").Append(Comment).Append("\n");
            sb.Append("  Holder: ").Append(Holder).Append("\n");
            sb.Append("  Payment: ").Append(Payment).Append("\n");
            sb.Append("  Rooms: ").Append(Rooms).Append("\n");
            sb.Append("  Extras: ").Append(Extras).Append("\n");
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
            return this.Equals(input as HotelConfirmationRequest);
        }

        /// <summary>
        /// Returns true if HotelConfirmationRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of HotelConfirmationRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HotelConfirmationRequest input)
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
                    this.ArrivalTime == input.ArrivalTime ||
                    (this.ArrivalTime != null &&
                    this.ArrivalTime.Equals(input.ArrivalTime))
                ) && 
                (
                    this.Comment == input.Comment ||
                    (this.Comment != null &&
                    this.Comment.Equals(input.Comment))
                ) && 
                (
                    this.Holder == input.Holder ||
                    (this.Holder != null &&
                    this.Holder.Equals(input.Holder))
                ) && 
                (
                    this.Payment == input.Payment ||
                    (this.Payment != null &&
                    this.Payment.Equals(input.Payment))
                ) && 
                (
                    this.Rooms == input.Rooms ||
                    this.Rooms != null &&
                    input.Rooms != null &&
                    this.Rooms.SequenceEqual(input.Rooms)
                ) && 
                (
                    this.Extras == input.Extras ||
                    this.Extras != null &&
                    input.Extras != null &&
                    this.Extras.SequenceEqual(input.Extras)
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
                if (this.ArrivalTime != null)
                    hashCode = hashCode * 59 + this.ArrivalTime.GetHashCode();
                if (this.Comment != null)
                    hashCode = hashCode * 59 + this.Comment.GetHashCode();
                if (this.Holder != null)
                    hashCode = hashCode * 59 + this.Holder.GetHashCode();
                if (this.Payment != null)
                    hashCode = hashCode * 59 + this.Payment.GetHashCode();
                if (this.Rooms != null)
                    hashCode = hashCode * 59 + this.Rooms.GetHashCode();
                if (this.Extras != null)
                    hashCode = hashCode * 59 + this.Extras.GetHashCode();
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