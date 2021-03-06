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
    /// HotelConfirmationResponseBookingHotel
    /// </summary>
    [DataContract]
        public partial class HotelConfirmationResponseBookingHotel :  IEquatable<HotelConfirmationResponseBookingHotel>, IValidatableObject
    {
        /// <summary>
        /// Defines Category
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum CategoryEnum
        {
            /// <summary>
            /// Enum _1est for value: 1est
            /// </summary>
            [EnumMember(Value = "1est")]
            _1est = 1,
            /// <summary>
            /// Enum _2est for value: 2est
            /// </summary>
            [EnumMember(Value = "2est")]
            _2est = 2,
            /// <summary>
            /// Enum _3set for value: 3set
            /// </summary>
            [EnumMember(Value = "3set")]
            _3set = 3,
            /// <summary>
            /// Enum _4est for value: 4est
            /// </summary>
            [EnumMember(Value = "4est")]
            _4est = 4,
            /// <summary>
            /// Enum _5est for value: 5est
            /// </summary>
            [EnumMember(Value = "5est")]
            _5est = 5        }
        /// <summary>
        /// Gets or Sets Category
        /// </summary>
        [DataMember(Name="category", EmitDefaultValue=false)]
        public CategoryEnum? Category { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="HotelConfirmationResponseBookingHotel" /> class.
        /// </summary>
        /// <param name="code">code.</param>
        /// <param name="name">name.</param>
        /// <param name="description">description.</param>
        /// <param name="providerName">providerName.</param>
        /// <param name="address">address.</param>
        /// <param name="country">country.</param>
        /// <param name="phone">phone.</param>
        /// <param name="email">email.</param>
        /// <param name="fax">fax.</param>
        /// <param name="image">image.</param>
        /// <param name="category">category.</param>
        /// <param name="zoneCode">zoneCode.</param>
        /// <param name="latitude">latitude.</param>
        /// <param name="longitude">longitude.</param>
        /// <param name="zoneName">zoneName.</param>
        /// <param name="totalPrice">totalPrice.</param>
        /// <param name="currency">currency.</param>
        /// <param name="checkIn">checkIn.</param>
        /// <param name="checkOut">checkOut.</param>
        /// <param name="rooms">rooms.</param>
        public HotelConfirmationResponseBookingHotel(string code = default(string), string name = default(string), string description = default(string), string providerName = default(string), string address = default(string), string country = default(string), string phone = default(string), string email = default(string), string fax = default(string), string image = default(string), CategoryEnum? category = default(CategoryEnum?), string zoneCode = default(string), string latitude = default(string), string longitude = default(string), string zoneName = default(string), int? totalPrice = default(int?), string currency = default(string), DateTime? checkIn = default(DateTime?), DateTime? checkOut = default(DateTime?), List<HotelConfirmationResponseBookingHotelRooms> rooms = default(List<HotelConfirmationResponseBookingHotelRooms>))
        {
            this.Code = code;
            this.Name = name;
            this.Description = description;
            this.ProviderName = providerName;
            this.Address = address;
            this.Country = country;
            this.Phone = phone;
            this.Email = email;
            this.Fax = fax;
            this.Image = image;
            this.Category = category;
            this.ZoneCode = zoneCode;
            this.Latitude = latitude;
            this.Longitude = longitude;
            this.ZoneName = zoneName;
            this.TotalPrice = totalPrice;
            this.Currency = currency;
            this.CheckIn = checkIn;
            this.CheckOut = checkOut;
            this.Rooms = rooms;
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
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets ProviderName
        /// </summary>
        [DataMember(Name="providerName", EmitDefaultValue=false)]
        public string ProviderName { get; set; }

        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        [DataMember(Name="address", EmitDefaultValue=false)]
        public string Address { get; set; }

        /// <summary>
        /// Gets or Sets Country
        /// </summary>
        [DataMember(Name="country", EmitDefaultValue=false)]
        public string Country { get; set; }

        /// <summary>
        /// Gets or Sets Phone
        /// </summary>
        [DataMember(Name="phone", EmitDefaultValue=false)]
        public string Phone { get; set; }

        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }

        /// <summary>
        /// Gets or Sets Fax
        /// </summary>
        [DataMember(Name="fax", EmitDefaultValue=false)]
        public string Fax { get; set; }

        /// <summary>
        /// Gets or Sets Image
        /// </summary>
        [DataMember(Name="image", EmitDefaultValue=false)]
        public string Image { get; set; }


        /// <summary>
        /// Gets or Sets ZoneCode
        /// </summary>
        [DataMember(Name="zoneCode", EmitDefaultValue=false)]
        public string ZoneCode { get; set; }

        /// <summary>
        /// Gets or Sets Latitude
        /// </summary>
        [DataMember(Name="latitude", EmitDefaultValue=false)]
        public string Latitude { get; set; }

        /// <summary>
        /// Gets or Sets Longitude
        /// </summary>
        [DataMember(Name="longitude", EmitDefaultValue=false)]
        public string Longitude { get; set; }

        /// <summary>
        /// Gets or Sets ZoneName
        /// </summary>
        [DataMember(Name="zoneName", EmitDefaultValue=false)]
        public string ZoneName { get; set; }

        /// <summary>
        /// Gets or Sets TotalPrice
        /// </summary>
        [DataMember(Name="totalPrice", EmitDefaultValue=false)]
        public int? TotalPrice { get; set; }

        /// <summary>
        /// Gets or Sets Currency
        /// </summary>
        [DataMember(Name="currency", EmitDefaultValue=false)]
        public string Currency { get; set; }

        /// <summary>
        /// Gets or Sets CheckIn
        /// </summary>
        [DataMember(Name="checkIn", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? CheckIn { get; set; }

        /// <summary>
        /// Gets or Sets CheckOut
        /// </summary>
        [DataMember(Name="checkOut", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? CheckOut { get; set; }

        /// <summary>
        /// Gets or Sets Rooms
        /// </summary>
        [DataMember(Name="rooms", EmitDefaultValue=false)]
        public List<HotelConfirmationResponseBookingHotelRooms> Rooms { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HotelConfirmationResponseBookingHotel {\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  ProviderName: ").Append(ProviderName).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  Phone: ").Append(Phone).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Fax: ").Append(Fax).Append("\n");
            sb.Append("  Image: ").Append(Image).Append("\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  ZoneCode: ").Append(ZoneCode).Append("\n");
            sb.Append("  Latitude: ").Append(Latitude).Append("\n");
            sb.Append("  Longitude: ").Append(Longitude).Append("\n");
            sb.Append("  ZoneName: ").Append(ZoneName).Append("\n");
            sb.Append("  TotalPrice: ").Append(TotalPrice).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  CheckIn: ").Append(CheckIn).Append("\n");
            sb.Append("  CheckOut: ").Append(CheckOut).Append("\n");
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
            return this.Equals(input as HotelConfirmationResponseBookingHotel);
        }

        /// <summary>
        /// Returns true if HotelConfirmationResponseBookingHotel instances are equal
        /// </summary>
        /// <param name="input">Instance of HotelConfirmationResponseBookingHotel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HotelConfirmationResponseBookingHotel input)
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
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.ProviderName == input.ProviderName ||
                    (this.ProviderName != null &&
                    this.ProviderName.Equals(input.ProviderName))
                ) && 
                (
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
                ) && 
                (
                    this.Country == input.Country ||
                    (this.Country != null &&
                    this.Country.Equals(input.Country))
                ) && 
                (
                    this.Phone == input.Phone ||
                    (this.Phone != null &&
                    this.Phone.Equals(input.Phone))
                ) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.Fax == input.Fax ||
                    (this.Fax != null &&
                    this.Fax.Equals(input.Fax))
                ) && 
                (
                    this.Image == input.Image ||
                    (this.Image != null &&
                    this.Image.Equals(input.Image))
                ) && 
                (
                    this.Category == input.Category ||
                    (this.Category != null &&
                    this.Category.Equals(input.Category))
                ) && 
                (
                    this.ZoneCode == input.ZoneCode ||
                    (this.ZoneCode != null &&
                    this.ZoneCode.Equals(input.ZoneCode))
                ) && 
                (
                    this.Latitude == input.Latitude ||
                    (this.Latitude != null &&
                    this.Latitude.Equals(input.Latitude))
                ) && 
                (
                    this.Longitude == input.Longitude ||
                    (this.Longitude != null &&
                    this.Longitude.Equals(input.Longitude))
                ) && 
                (
                    this.ZoneName == input.ZoneName ||
                    (this.ZoneName != null &&
                    this.ZoneName.Equals(input.ZoneName))
                ) && 
                (
                    this.TotalPrice == input.TotalPrice ||
                    (this.TotalPrice != null &&
                    this.TotalPrice.Equals(input.TotalPrice))
                ) && 
                (
                    this.Currency == input.Currency ||
                    (this.Currency != null &&
                    this.Currency.Equals(input.Currency))
                ) && 
                (
                    this.CheckIn == input.CheckIn ||
                    (this.CheckIn != null &&
                    this.CheckIn.Equals(input.CheckIn))
                ) && 
                (
                    this.CheckOut == input.CheckOut ||
                    (this.CheckOut != null &&
                    this.CheckOut.Equals(input.CheckOut))
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
                if (this.Code != null)
                    hashCode = hashCode * 59 + this.Code.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.ProviderName != null)
                    hashCode = hashCode * 59 + this.ProviderName.GetHashCode();
                if (this.Address != null)
                    hashCode = hashCode * 59 + this.Address.GetHashCode();
                if (this.Country != null)
                    hashCode = hashCode * 59 + this.Country.GetHashCode();
                if (this.Phone != null)
                    hashCode = hashCode * 59 + this.Phone.GetHashCode();
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.Fax != null)
                    hashCode = hashCode * 59 + this.Fax.GetHashCode();
                if (this.Image != null)
                    hashCode = hashCode * 59 + this.Image.GetHashCode();
                if (this.Category != null)
                    hashCode = hashCode * 59 + this.Category.GetHashCode();
                if (this.ZoneCode != null)
                    hashCode = hashCode * 59 + this.ZoneCode.GetHashCode();
                if (this.Latitude != null)
                    hashCode = hashCode * 59 + this.Latitude.GetHashCode();
                if (this.Longitude != null)
                    hashCode = hashCode * 59 + this.Longitude.GetHashCode();
                if (this.ZoneName != null)
                    hashCode = hashCode * 59 + this.ZoneName.GetHashCode();
                if (this.TotalPrice != null)
                    hashCode = hashCode * 59 + this.TotalPrice.GetHashCode();
                if (this.Currency != null)
                    hashCode = hashCode * 59 + this.Currency.GetHashCode();
                if (this.CheckIn != null)
                    hashCode = hashCode * 59 + this.CheckIn.GetHashCode();
                if (this.CheckOut != null)
                    hashCode = hashCode * 59 + this.CheckOut.GetHashCode();
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
