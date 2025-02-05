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
    /// Cell
    /// </summary>
    [DataContract]
    public partial class Cell :  IEquatable<Cell>, IValidatableObject
    {
        /// <summary>
        /// Defines DependencyStatus
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DependencyStatusEnum
        {
            /// <summary>
            /// Enum UpToDate for value: upToDate
            /// </summary>
            [EnumMember(Value = "upToDate")]
            UpToDate = 1,

            /// <summary>
            /// Enum OutOfDate for value: outOfDate
            /// </summary>
            [EnumMember(Value = "outOfDate")]
            OutOfDate = 2,

            /// <summary>
            /// Enum Unset for value: unset
            /// </summary>
            [EnumMember(Value = "unset")]
            Unset = 3

        }

        /// <summary>
        /// Gets or Sets DependencyStatus
        /// </summary>
        [DataMember(Name="dependencyStatus", EmitDefaultValue=true)]
        public DependencyStatusEnum? DependencyStatus { get; set; }
        /// <summary>
        /// Defines SourceStatus
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SourceStatusEnum
        {
            /// <summary>
            /// Enum Unset for value: unset
            /// </summary>
            [EnumMember(Value = "unset")]
            Unset = 1,

            /// <summary>
            /// Enum DoNotTranslate for value: doNotTranslate
            /// </summary>
            [EnumMember(Value = "doNotTranslate")]
            DoNotTranslate = 2,

            /// <summary>
            /// Enum NotReadyForTranslation for value: notReadyForTranslation
            /// </summary>
            [EnumMember(Value = "notReadyForTranslation")]
            NotReadyForTranslation = 3,

            /// <summary>
            /// Enum ReadyForTranslation for value: readyForTranslation
            /// </summary>
            [EnumMember(Value = "readyForTranslation")]
            ReadyForTranslation = 4,

            /// <summary>
            /// Enum Locked for value: locked
            /// </summary>
            [EnumMember(Value = "locked")]
            Locked = 5

        }

        /// <summary>
        /// Gets or Sets SourceStatus
        /// </summary>
        [DataMember(Name="sourceStatus", EmitDefaultValue=true)]
        public SourceStatusEnum? SourceStatus { get; set; }

        [Obsolete("Use Cell.New(...) instead")]
        /// <summary>
        /// Initializes a new instance of the <see cref="Cell" /> class.
        /// </summary>
        /// <param name="columnId">columnId.</param>
        /// <param name="dependencyStatus">dependencyStatus.</param>
        /// <param name="referencedIds">referencedIds.</param>
        /// <param name="sourceStatus">sourceStatus.</param>
        /// <param name="value">value.</param>
        public Cell(string columnId = default(string), DependencyStatusEnum? dependencyStatus = default(DependencyStatusEnum?), List<string> referencedIds = default(List<string>), SourceStatusEnum? sourceStatus = default(SourceStatusEnum?), Object value = default(Object))
        {
            this.ColumnId = columnId;
            this.DependencyStatus = dependencyStatus;
            this.ReferencedIds = referencedIds;
            this.SourceStatus = sourceStatus;
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Cell" /> class.
        /// </summary>
        /// <param name="columnId">columnId.</param>
        /// <param name="dependencyStatus">dependencyStatus.</param>
        /// <param name="referencedIds">referencedIds.</param>
        /// <param name="value">value.</param>
        /// <param name="sourceStatus">sourceStatus.</param>
        public static Cell New(string columnId = default(string), DependencyStatusEnum? dependencyStatus = default(DependencyStatusEnum?), List<string> referencedIds = default(List<string>), Object value = default(Object), SourceStatusEnum? sourceStatus = default(SourceStatusEnum?))
        {
	        return new Cell(columnId, dependencyStatus, referencedIds, sourceStatus, value);
        }

        /// <summary>
        /// Gets or Sets ColumnId
        /// </summary>
        [DataMember(Name="columnId", EmitDefaultValue=true)]
        public string ColumnId { get; set; }


        /// <summary>
        /// Gets or Sets ReferencedIds
        /// </summary>
        [DataMember(Name="referencedIds", EmitDefaultValue=true)]
        public List<string> ReferencedIds { get; set; }


        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name="value", EmitDefaultValue=true)]
        public Object Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Cell {\n");
            sb.Append("  ColumnId: ").Append(ColumnId).Append("\n");
            sb.Append("  DependencyStatus: ").Append(DependencyStatus).Append("\n");
            sb.Append("  ReferencedIds: ").Append(ReferencedIds).Append("\n");
            sb.Append("  SourceStatus: ").Append(SourceStatus).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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
            return this.Equals(input as Cell);
        }

        /// <summary>
        /// Returns true if Cell instances are equal
        /// </summary>
        /// <param name="input">Instance of Cell to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Cell input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ColumnId == input.ColumnId ||
                    (this.ColumnId != null &&
                    this.ColumnId.Equals(input.ColumnId))
                ) && 
                (
                    this.DependencyStatus == input.DependencyStatus ||
                    (this.DependencyStatus != null &&
                    this.DependencyStatus.Equals(input.DependencyStatus))
                ) && 
                (
                    this.ReferencedIds == input.ReferencedIds ||
                    this.ReferencedIds != null &&
                    input.ReferencedIds != null &&
                    this.ReferencedIds.SequenceEqual(input.ReferencedIds)
                ) && 
                (
                    this.SourceStatus == input.SourceStatus ||
                    (this.SourceStatus != null &&
                    this.SourceStatus.Equals(input.SourceStatus))
                ) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
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
                if (this.ColumnId != null)
                    hashCode = hashCode * 59 + this.ColumnId.GetHashCode();
                if (this.DependencyStatus != null)
                    hashCode = hashCode * 59 + this.DependencyStatus.GetHashCode();
                if (this.ReferencedIds != null)
                    hashCode = hashCode * 59 + this.ReferencedIds.GetHashCode();
                if (this.SourceStatus != null)
                    hashCode = hashCode * 59 + this.SourceStatus.GetHashCode();
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
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
