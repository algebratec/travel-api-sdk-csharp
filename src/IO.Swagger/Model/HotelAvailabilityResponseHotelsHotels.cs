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
    /// HotelAvailabilityResponseHotelsHotels
    /// </summary>
    [DataContract]
        public partial class HotelAvailabilityResponseHotelsHotels :  IEquatable<HotelAvailabilityResponseHotelsHotels>, IValidatableObject
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
        /// Defines Currency
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum CurrencyEnum
        {
            /// <summary>
            /// Enum DZD for value: DZD
            /// </summary>
            [EnumMember(Value = "DZD")]
            DZD = 1,
            /// <summary>
            /// Enum EUR for value: EUR
            /// </summary>
            [EnumMember(Value = "EUR")]
            EUR = 2,
            /// <summary>
            /// Enum DTN for value: DTN
            /// </summary>
            [EnumMember(Value = "DTN")]
            DTN = 3        }
        /// <summary>
        /// Gets or Sets Currency
        /// </summary>
        [DataMember(Name="currency", EmitDefaultValue=false)]
        public CurrencyEnum? Currency { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="HotelAvailabilityResponseHotelsHotels" /> class.
        /// </summary>
        /// <param name="code">code.</param>
        /// <param name="providerCode">providerCode.</param>
        /// <param name="contractCode">contractCode.</param>
        /// <param name="supplierCode">supplierCode.</param>
        /// <param name="country">country.</param>
        /// <param name="name">name.</param>
        /// <param name="description">description.</param>
        /// <param name="providerName">providerName.</param>
        /// <param name="address">address.</param>
        /// <param name="phone">phone.</param>
        /// <param name="mail">mail.</param>
        /// <param name="fax">fax.</param>
        /// <param name="image">image.</param>
        /// <param name="images">images.</param>
        /// <param name="zoneCode">zoneCode.</param>
        /// <param name="category">category.</param>
        /// <param name="zoneName">zoneName.</param>
        /// <param name="comments">comments.</param>
        /// <param name="latitude">latitude.</param>
        /// <param name="longitude">longitude.</param>
        /// <param name="rooms">rooms.</param>
        /// <param name="accommodations">accommodations.</param>
        /// <param name="themes">themes.</param>
        /// <param name="facilities">facilities.</param>
        /// <param name="prohibitions">prohibitions.</param>
        /// <param name="extras">extras.</param>
        /// <param name="combinations">combinations.</param>
        /// <param name="currency">currency.</param>
        public HotelAvailabilityResponseHotelsHotels(string code = default(string), string providerCode = default(string), string contractCode = default(string), string supplierCode = default(string), string country = default(string), string name = default(string), string description = default(string), string providerName = default(string), string address = default(string), string phone = default(string), string mail = default(string), string fax = default(string), string image = default(string), List<HotelAvailabilityResponseHotelsImages> images = default(List<HotelAvailabilityResponseHotelsImages>), string zoneCode = default(string), CategoryEnum? category = default(CategoryEnum?), string zoneName = default(string), string comments = default(string), string latitude = default(string), string longitude = default(string), List<HotelAvailabilityResponseHotelsRooms> rooms = default(List<HotelAvailabilityResponseHotelsRooms>), List<HotelAvailabilityResponseHotelsAccommodations> accommodations = default(List<HotelAvailabilityResponseHotelsAccommodations>), List<HotelAvailabilityResponseHotelsThemes> themes = default(List<HotelAvailabilityResponseHotelsThemes>), List<HotelAvailabilityResponseHotelsThemes> facilities = default(List<HotelAvailabilityResponseHotelsThemes>), List<HotelAvailabilityResponseHotelsThemes> prohibitions = default(List<HotelAvailabilityResponseHotelsThemes>), List<HotelAvailabilityResponseHotelsExtras> extras = default(List<HotelAvailabilityResponseHotelsExtras>), List<HotelAvailabilityResponseHotelsCombinations> combinations = default(List<HotelAvailabilityResponseHotelsCombinations>), CurrencyEnum? currency = default(CurrencyEnum?))
        {
            this.Code = code;
            this.ProviderCode = providerCode;
            this.ContractCode = contractCode;
            this.SupplierCode = supplierCode;
            this.Country = country;
            this.Name = name;
            this.Description = description;
            this.ProviderName = providerName;
            this.Address = address;
            this.Phone = phone;
            this.Mail = mail;
            this.Fax = fax;
            this.Image = image;
            this.Images = images;
            this.ZoneCode = zoneCode;
            this.Category = category;
            this.ZoneName = zoneName;
            this.Comments = comments;
            this.Latitude = latitude;
            this.Longitude = longitude;
            this.Rooms = rooms;
            this.Accommodations = accommodations;
            this.Themes = themes;
            this.Facilities = facilities;
            this.Prohibitions = prohibitions;
            this.Extras = extras;
            this.Combinations = combinations;
            this.Currency = currency;
        }
        
        /// <summary>
        /// Gets or Sets Code
        /// </summary>
        [DataMember(Name="code", EmitDefaultValue=false)]
        public string Code { get; set; }

        /// <summary>
        /// Gets or Sets ProviderCode
        /// </summary>
        [DataMember(Name="providerCode", EmitDefaultValue=false)]
        public string ProviderCode { get; set; }

        /// <summary>
        /// Gets or Sets ContractCode
        /// </summary>
        [DataMember(Name="contractCode", EmitDefaultValue=false)]
        public string ContractCode { get; set; }

        /// <summary>
        /// Gets or Sets SupplierCode
        /// </summary>
        [DataMember(Name="supplierCode", EmitDefaultValue=false)]
        public string SupplierCode { get; set; }

        /// <summary>
        /// Gets or Sets Country
        /// </summary>
        [DataMember(Name="country", EmitDefaultValue=false)]
        public string Country { get; set; }

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
        /// Gets or Sets Phone
        /// </summary>
        [DataMember(Name="phone", EmitDefaultValue=false)]
        public string Phone { get; set; }

        /// <summary>
        /// Gets or Sets Mail
        /// </summary>
        [DataMember(Name="mail", EmitDefaultValue=false)]
        public string Mail { get; set; }

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
        /// Gets or Sets Images
        /// </summary>
        [DataMember(Name="images", EmitDefaultValue=false)]
        public List<HotelAvailabilityResponseHotelsImages> Images { get; set; }

        /// <summary>
        /// Gets or Sets ZoneCode
        /// </summary>
        [DataMember(Name="zoneCode", EmitDefaultValue=false)]
        public string ZoneCode { get; set; }


        /// <summary>
        /// Gets or Sets ZoneName
        /// </summary>
        [DataMember(Name="zoneName", EmitDefaultValue=false)]
        public string ZoneName { get; set; }

        /// <summary>
        /// Gets or Sets Comments
        /// </summary>
        [DataMember(Name="comments", EmitDefaultValue=false)]
        public string Comments { get; set; }

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
        /// Gets or Sets Rooms
        /// </summary>
        [DataMember(Name="rooms", EmitDefaultValue=false)]
        public List<HotelAvailabilityResponseHotelsRooms> Rooms { get; set; }

        /// <summary>
        /// Gets or Sets Accommodations
        /// </summary>
        [DataMember(Name="accommodations", EmitDefaultValue=false)]
        public List<HotelAvailabilityResponseHotelsAccommodations> Accommodations { get; set; }

        /// <summary>
        /// Gets or Sets Themes
        /// </summary>
        [DataMember(Name="themes", EmitDefaultValue=false)]
        public List<HotelAvailabilityResponseHotelsThemes> Themes { get; set; }

        /// <summary>
        /// Gets or Sets Facilities
        /// </summary>
        [DataMember(Name="facilities", EmitDefaultValue=false)]
        public List<HotelAvailabilityResponseHotelsThemes> Facilities { get; set; }

        /// <summary>
        /// Gets or Sets Prohibitions
        /// </summary>
        [DataMember(Name="prohibitions", EmitDefaultValue=false)]
        public List<HotelAvailabilityResponseHotelsThemes> Prohibitions { get; set; }

        /// <summary>
        /// Gets or Sets Extras
        /// </summary>
        [DataMember(Name="Extras", EmitDefaultValue=false)]
        public List<HotelAvailabilityResponseHotelsExtras> Extras { get; set; }

        /// <summary>
        /// Gets or Sets Combinations
        /// </summary>
        [DataMember(Name="Combinations", EmitDefaultValue=false)]
        public List<HotelAvailabilityResponseHotelsCombinations> Combinations { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HotelAvailabilityResponseHotelsHotels {\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  ProviderCode: ").Append(ProviderCode).Append("\n");
            sb.Append("  ContractCode: ").Append(ContractCode).Append("\n");
            sb.Append("  SupplierCode: ").Append(SupplierCode).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  ProviderName: ").Append(ProviderName).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  Phone: ").Append(Phone).Append("\n");
            sb.Append("  Mail: ").Append(Mail).Append("\n");
            sb.Append("  Fax: ").Append(Fax).Append("\n");
            sb.Append("  Image: ").Append(Image).Append("\n");
            sb.Append("  Images: ").Append(Images).Append("\n");
            sb.Append("  ZoneCode: ").Append(ZoneCode).Append("\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  ZoneName: ").Append(ZoneName).Append("\n");
            sb.Append("  Comments: ").Append(Comments).Append("\n");
            sb.Append("  Latitude: ").Append(Latitude).Append("\n");
            sb.Append("  Longitude: ").Append(Longitude).Append("\n");
            sb.Append("  Rooms: ").Append(Rooms).Append("\n");
            sb.Append("  Accommodations: ").Append(Accommodations).Append("\n");
            sb.Append("  Themes: ").Append(Themes).Append("\n");
            sb.Append("  Facilities: ").Append(Facilities).Append("\n");
            sb.Append("  Prohibitions: ").Append(Prohibitions).Append("\n");
            sb.Append("  Extras: ").Append(Extras).Append("\n");
            sb.Append("  Combinations: ").Append(Combinations).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
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
            return this.Equals(input as HotelAvailabilityResponseHotelsHotels);
        }

        /// <summary>
        /// Returns true if HotelAvailabilityResponseHotelsHotels instances are equal
        /// </summary>
        /// <param name="input">Instance of HotelAvailabilityResponseHotelsHotels to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HotelAvailabilityResponseHotelsHotels input)
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
                    this.ProviderCode == input.ProviderCode ||
                    (this.ProviderCode != null &&
                    this.ProviderCode.Equals(input.ProviderCode))
                ) && 
                (
                    this.ContractCode == input.ContractCode ||
                    (this.ContractCode != null &&
                    this.ContractCode.Equals(input.ContractCode))
                ) && 
                (
                    this.SupplierCode == input.SupplierCode ||
                    (this.SupplierCode != null &&
                    this.SupplierCode.Equals(input.SupplierCode))
                ) && 
                (
                    this.Country == input.Country ||
                    (this.Country != null &&
                    this.Country.Equals(input.Country))
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
                    this.Phone == input.Phone ||
                    (this.Phone != null &&
                    this.Phone.Equals(input.Phone))
                ) && 
                (
                    this.Mail == input.Mail ||
                    (this.Mail != null &&
                    this.Mail.Equals(input.Mail))
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
                    this.Images == input.Images ||
                    this.Images != null &&
                    input.Images != null &&
                    this.Images.SequenceEqual(input.Images)
                ) && 
                (
                    this.ZoneCode == input.ZoneCode ||
                    (this.ZoneCode != null &&
                    this.ZoneCode.Equals(input.ZoneCode))
                ) && 
                (
                    this.Category == input.Category ||
                    (this.Category != null &&
                    this.Category.Equals(input.Category))
                ) && 
                (
                    this.ZoneName == input.ZoneName ||
                    (this.ZoneName != null &&
                    this.ZoneName.Equals(input.ZoneName))
                ) && 
                (
                    this.Comments == input.Comments ||
                    (this.Comments != null &&
                    this.Comments.Equals(input.Comments))
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
                    this.Rooms == input.Rooms ||
                    this.Rooms != null &&
                    input.Rooms != null &&
                    this.Rooms.SequenceEqual(input.Rooms)
                ) && 
                (
                    this.Accommodations == input.Accommodations ||
                    this.Accommodations != null &&
                    input.Accommodations != null &&
                    this.Accommodations.SequenceEqual(input.Accommodations)
                ) && 
                (
                    this.Themes == input.Themes ||
                    this.Themes != null &&
                    input.Themes != null &&
                    this.Themes.SequenceEqual(input.Themes)
                ) && 
                (
                    this.Facilities == input.Facilities ||
                    this.Facilities != null &&
                    input.Facilities != null &&
                    this.Facilities.SequenceEqual(input.Facilities)
                ) && 
                (
                    this.Prohibitions == input.Prohibitions ||
                    this.Prohibitions != null &&
                    input.Prohibitions != null &&
                    this.Prohibitions.SequenceEqual(input.Prohibitions)
                ) && 
                (
                    this.Extras == input.Extras ||
                    this.Extras != null &&
                    input.Extras != null &&
                    this.Extras.SequenceEqual(input.Extras)
                ) && 
                (
                    this.Combinations == input.Combinations ||
                    this.Combinations != null &&
                    input.Combinations != null &&
                    this.Combinations.SequenceEqual(input.Combinations)
                ) && 
                (
                    this.Currency == input.Currency ||
                    (this.Currency != null &&
                    this.Currency.Equals(input.Currency))
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
                if (this.ProviderCode != null)
                    hashCode = hashCode * 59 + this.ProviderCode.GetHashCode();
                if (this.ContractCode != null)
                    hashCode = hashCode * 59 + this.ContractCode.GetHashCode();
                if (this.SupplierCode != null)
                    hashCode = hashCode * 59 + this.SupplierCode.GetHashCode();
                if (this.Country != null)
                    hashCode = hashCode * 59 + this.Country.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.ProviderName != null)
                    hashCode = hashCode * 59 + this.ProviderName.GetHashCode();
                if (this.Address != null)
                    hashCode = hashCode * 59 + this.Address.GetHashCode();
                if (this.Phone != null)
                    hashCode = hashCode * 59 + this.Phone.GetHashCode();
                if (this.Mail != null)
                    hashCode = hashCode * 59 + this.Mail.GetHashCode();
                if (this.Fax != null)
                    hashCode = hashCode * 59 + this.Fax.GetHashCode();
                if (this.Image != null)
                    hashCode = hashCode * 59 + this.Image.GetHashCode();
                if (this.Images != null)
                    hashCode = hashCode * 59 + this.Images.GetHashCode();
                if (this.ZoneCode != null)
                    hashCode = hashCode * 59 + this.ZoneCode.GetHashCode();
                if (this.Category != null)
                    hashCode = hashCode * 59 + this.Category.GetHashCode();
                if (this.ZoneName != null)
                    hashCode = hashCode * 59 + this.ZoneName.GetHashCode();
                if (this.Comments != null)
                    hashCode = hashCode * 59 + this.Comments.GetHashCode();
                if (this.Latitude != null)
                    hashCode = hashCode * 59 + this.Latitude.GetHashCode();
                if (this.Longitude != null)
                    hashCode = hashCode * 59 + this.Longitude.GetHashCode();
                if (this.Rooms != null)
                    hashCode = hashCode * 59 + this.Rooms.GetHashCode();
                if (this.Accommodations != null)
                    hashCode = hashCode * 59 + this.Accommodations.GetHashCode();
                if (this.Themes != null)
                    hashCode = hashCode * 59 + this.Themes.GetHashCode();
                if (this.Facilities != null)
                    hashCode = hashCode * 59 + this.Facilities.GetHashCode();
                if (this.Prohibitions != null)
                    hashCode = hashCode * 59 + this.Prohibitions.GetHashCode();
                if (this.Extras != null)
                    hashCode = hashCode * 59 + this.Extras.GetHashCode();
                if (this.Combinations != null)
                    hashCode = hashCode * 59 + this.Combinations.GetHashCode();
                if (this.Currency != null)
                    hashCode = hashCode * 59 + this.Currency.GetHashCode();
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
