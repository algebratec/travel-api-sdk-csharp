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
    /// FlightAirline
    /// </summary>
    [DataContract]
        public partial class FlightAirline :  IEquatable<FlightAirline>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FlightAirline" /> class.
        /// </summary>
        /// <param name="airline">airline.</param>
        /// <param name="bestPrice">bestPrice.</param>
        /// <param name="callsign">callsign.</param>
        /// <param name="code">code.</param>
        /// <param name="countryOfOrigin">countryOfOrigin.</param>
        /// <param name="iata">iata.</param>
        /// <param name="icao">icao.</param>
        /// <param name="name">name.</param>
        public FlightAirline(string airline = default(string), int? bestPrice = default(int?), string callsign = default(string), string code = default(string), string countryOfOrigin = default(string), string iata = default(string), string icao = default(string), string name = default(string))
        {
            this.Airline = airline;
            this.BestPrice = bestPrice;
            this.Callsign = callsign;
            this.Code = code;
            this.CountryOfOrigin = countryOfOrigin;
            this.Iata = iata;
            this.Icao = icao;
            this.Name = name;
        }
        
        /// <summary>
        /// Gets or Sets Airline
        /// </summary>
        [DataMember(Name="airline", EmitDefaultValue=false)]
        public string Airline { get; set; }

        /// <summary>
        /// Gets or Sets BestPrice
        /// </summary>
        [DataMember(Name="bestPrice", EmitDefaultValue=false)]
        public int? BestPrice { get; set; }

        /// <summary>
        /// Gets or Sets Callsign
        /// </summary>
        [DataMember(Name="callsign", EmitDefaultValue=false)]
        public string Callsign { get; set; }

        /// <summary>
        /// Gets or Sets Code
        /// </summary>
        [DataMember(Name="code", EmitDefaultValue=false)]
        public string Code { get; set; }

        /// <summary>
        /// Gets or Sets CountryOfOrigin
        /// </summary>
        [DataMember(Name="country_of_Origin", EmitDefaultValue=false)]
        public string CountryOfOrigin { get; set; }

        /// <summary>
        /// Gets or Sets Iata
        /// </summary>
        [DataMember(Name="iata", EmitDefaultValue=false)]
        public string Iata { get; set; }

        /// <summary>
        /// Gets or Sets Icao
        /// </summary>
        [DataMember(Name="icao", EmitDefaultValue=false)]
        public string Icao { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FlightAirline {\n");
            sb.Append("  Airline: ").Append(Airline).Append("\n");
            sb.Append("  BestPrice: ").Append(BestPrice).Append("\n");
            sb.Append("  Callsign: ").Append(Callsign).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  CountryOfOrigin: ").Append(CountryOfOrigin).Append("\n");
            sb.Append("  Iata: ").Append(Iata).Append("\n");
            sb.Append("  Icao: ").Append(Icao).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
            return this.Equals(input as FlightAirline);
        }

        /// <summary>
        /// Returns true if FlightAirline instances are equal
        /// </summary>
        /// <param name="input">Instance of FlightAirline to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FlightAirline input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Airline == input.Airline ||
                    (this.Airline != null &&
                    this.Airline.Equals(input.Airline))
                ) && 
                (
                    this.BestPrice == input.BestPrice ||
                    (this.BestPrice != null &&
                    this.BestPrice.Equals(input.BestPrice))
                ) && 
                (
                    this.Callsign == input.Callsign ||
                    (this.Callsign != null &&
                    this.Callsign.Equals(input.Callsign))
                ) && 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) && 
                (
                    this.CountryOfOrigin == input.CountryOfOrigin ||
                    (this.CountryOfOrigin != null &&
                    this.CountryOfOrigin.Equals(input.CountryOfOrigin))
                ) && 
                (
                    this.Iata == input.Iata ||
                    (this.Iata != null &&
                    this.Iata.Equals(input.Iata))
                ) && 
                (
                    this.Icao == input.Icao ||
                    (this.Icao != null &&
                    this.Icao.Equals(input.Icao))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
                if (this.Airline != null)
                    hashCode = hashCode * 59 + this.Airline.GetHashCode();
                if (this.BestPrice != null)
                    hashCode = hashCode * 59 + this.BestPrice.GetHashCode();
                if (this.Callsign != null)
                    hashCode = hashCode * 59 + this.Callsign.GetHashCode();
                if (this.Code != null)
                    hashCode = hashCode * 59 + this.Code.GetHashCode();
                if (this.CountryOfOrigin != null)
                    hashCode = hashCode * 59 + this.CountryOfOrigin.GetHashCode();
                if (this.Iata != null)
                    hashCode = hashCode * 59 + this.Iata.GetHashCode();
                if (this.Icao != null)
                    hashCode = hashCode * 59 + this.Icao.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
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
