/*
 * Gridly API
 *
 * Gridly API documentation
 *
 * The version of the OpenAPI document: 3.32.2
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
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
using OpenAPIDateConverter = Com.Gridly.Client.OpenAPIDateConverter;

namespace Com.Gridly.Model
{
    /// <summary>
    /// NumberFormat
    /// </summary>
    [DataContract]
    public partial class NumberFormat :  IEquatable<NumberFormat>, IValidatableObject
    {
        /// <summary>
        /// Defines Type
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum DECIMAL for value: DECIMAL
            /// </summary>
            [EnumMember(Value = "DECIMAL")]
            DECIMAL = 1,

            /// <summary>
            /// Enum INTEGER for value: INTEGER
            /// </summary>
            [EnumMember(Value = "INTEGER")]
            INTEGER = 2

        }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=true)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="NumberFormat" /> class.
        /// </summary>
        /// <param name="type">type.</param>
        /// <param name="decimalPlaces">decimalPlaces.</param>
        /// <param name="currencySymbol">currencySymbol.</param>
        /// <param name="use1000Separator">use1000Separator.</param>
        public NumberFormat(TypeEnum? type = default(TypeEnum?), int decimalPlaces = default(int), string currencySymbol = default(string), bool use1000Separator = default(bool))
        {
            this.Type = type;
            this.DecimalPlaces = decimalPlaces;
            this.CurrencySymbol = currencySymbol;
            this.Use1000Separator = use1000Separator;
        }


        /// <summary>
        /// Gets or Sets DecimalPlaces
        /// </summary>
        [DataMember(Name="decimalPlaces", EmitDefaultValue=true)]
        public int DecimalPlaces { get; set; }

        /// <summary>
        /// Gets or Sets CurrencySymbol
        /// </summary>
        [DataMember(Name="currencySymbol", EmitDefaultValue=true)]
        public string CurrencySymbol { get; set; }

        /// <summary>
        /// Gets or Sets Use1000Separator
        /// </summary>
        [DataMember(Name="use1000Separator", EmitDefaultValue=true)]
        public bool Use1000Separator { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NumberFormat {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  DecimalPlaces: ").Append(DecimalPlaces).Append("\n");
            sb.Append("  CurrencySymbol: ").Append(CurrencySymbol).Append("\n");
            sb.Append("  Use1000Separator: ").Append(Use1000Separator).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as NumberFormat);
        }

        /// <summary>
        /// Returns true if NumberFormat instances are equal
        /// </summary>
        /// <param name="input">Instance of NumberFormat to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NumberFormat input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.DecimalPlaces == input.DecimalPlaces ||
                    (this.DecimalPlaces != null &&
                    this.DecimalPlaces.Equals(input.DecimalPlaces))
                ) && 
                (
                    this.CurrencySymbol == input.CurrencySymbol ||
                    (this.CurrencySymbol != null &&
                    this.CurrencySymbol.Equals(input.CurrencySymbol))
                ) && 
                (
                    this.Use1000Separator == input.Use1000Separator ||
                    (this.Use1000Separator != null &&
                    this.Use1000Separator.Equals(input.Use1000Separator))
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
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.DecimalPlaces != null)
                    hashCode = hashCode * 59 + this.DecimalPlaces.GetHashCode();
                if (this.CurrencySymbol != null)
                    hashCode = hashCode * 59 + this.CurrencySymbol.GetHashCode();
                if (this.Use1000Separator != null)
                    hashCode = hashCode * 59 + this.Use1000Separator.GetHashCode();
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
