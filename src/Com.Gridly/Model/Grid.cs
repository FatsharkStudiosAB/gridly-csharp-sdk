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
    /// Grid
    /// </summary>
    [DataContract]
    public partial class Grid :  IEquatable<Grid>, IValidatableObject
    {
        /// <summary>
        /// Defines RecordIdentifierType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum RecordIdentifierTypeEnum
        {
            /// <summary>
            /// Enum RecordId for value: recordId
            /// </summary>
            [EnumMember(Value = "recordId")]
            RecordId = 1,

            /// <summary>
            /// Enum PathTagRecordId for value: pathTagRecordId
            /// </summary>
            [EnumMember(Value = "pathTagRecordId")]
            PathTagRecordId = 2

        }

        /// <summary>
        /// Gets or Sets RecordIdentifierType
        /// </summary>
        [DataMember(Name="recordIdentifierType", EmitDefaultValue=true)]
        public RecordIdentifierTypeEnum? RecordIdentifierType { get; set; }
        /// <summary>
        /// Defines Status
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum Deleted for value: deleted
            /// </summary>
            [EnumMember(Value = "deleted")]
            Deleted = 1,

            /// <summary>
            /// Enum Active for value: active
            /// </summary>
            [EnumMember(Value = "active")]
            Active = 2,

            /// <summary>
            /// Enum Inactive for value: inactive
            /// </summary>
            [EnumMember(Value = "inactive")]
            Inactive = 3,

            /// <summary>
            /// Enum Restoring for value: restoring
            /// </summary>
            [EnumMember(Value = "restoring")]
            Restoring = 4,

            /// <summary>
            /// Enum BackingUp for value: backingUp
            /// </summary>
            [EnumMember(Value = "backingUp")]
            BackingUp = 5,

            /// <summary>
            /// Enum Uploading for value: uploading
            /// </summary>
            [EnumMember(Value = "uploading")]
            Uploading = 6,

            /// <summary>
            /// Enum Importing for value: importing
            /// </summary>
            [EnumMember(Value = "importing")]
            Importing = 7,

            /// <summary>
            /// Enum Branching for value: branching
            /// </summary>
            [EnumMember(Value = "branching")]
            Branching = 8,

            /// <summary>
            /// Enum Merging for value: merging
            /// </summary>
            [EnumMember(Value = "merging")]
            Merging = 9,

            /// <summary>
            /// Enum Duplicating for value: duplicating
            /// </summary>
            [EnumMember(Value = "duplicating")]
            Duplicating = 10,

            /// <summary>
            /// Enum ClearingRecords for value: clearingRecords
            /// </summary>
            [EnumMember(Value = "clearingRecords")]
            ClearingRecords = 11

        }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=true)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Grid" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="columns">columns.</param>
        /// <param name="defaultAccessViewId">defaultAccessViewId.</param>
        /// <param name="description">description.</param>
        /// <param name="metadata">metadata.</param>
        /// <param name="name">name.</param>
        /// <param name="recordIdentifierType">recordIdentifierType.</param>
        /// <param name="status">status.</param>
        public Grid(string id = default(string), List<ViewColumn> columns = default(List<ViewColumn>), string defaultAccessViewId = default(string), string description = default(string), Dictionary<string, string> metadata = default(Dictionary<string, string>), string name = default(string), RecordIdentifierTypeEnum? recordIdentifierType = default(RecordIdentifierTypeEnum?), StatusEnum? status = default(StatusEnum?))
        {
            this.Id = id;
            this.Columns = columns;
            this.DefaultAccessViewId = defaultAccessViewId;
            this.Description = description;
            this.Metadata = metadata;
            this.Name = name;
            this.RecordIdentifierType = recordIdentifierType;
            this.Status = status;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=true)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Columns
        /// </summary>
        [DataMember(Name="columns", EmitDefaultValue=true)]
        public List<ViewColumn> Columns { get; set; }

        /// <summary>
        /// Gets or Sets DefaultAccessViewId
        /// </summary>
        [DataMember(Name="defaultAccessViewId", EmitDefaultValue=true)]
        public string DefaultAccessViewId { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=true)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Metadata
        /// </summary>
        [DataMember(Name="metadata", EmitDefaultValue=true)]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }



        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Grid {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Columns: ").Append(Columns).Append("\n");
            sb.Append("  DefaultAccessViewId: ").Append(DefaultAccessViewId).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  RecordIdentifierType: ").Append(RecordIdentifierType).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
            return this.Equals(input as Grid);
        }

        /// <summary>
        /// Returns true if Grid instances are equal
        /// </summary>
        /// <param name="input">Instance of Grid to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Grid input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Columns == input.Columns ||
                    this.Columns != null &&
                    input.Columns != null &&
                    this.Columns.SequenceEqual(input.Columns)
                ) && 
                (
                    this.DefaultAccessViewId == input.DefaultAccessViewId ||
                    (this.DefaultAccessViewId != null &&
                    this.DefaultAccessViewId.Equals(input.DefaultAccessViewId))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Metadata == input.Metadata ||
                    this.Metadata != null &&
                    input.Metadata != null &&
                    this.Metadata.SequenceEqual(input.Metadata)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.RecordIdentifierType == input.RecordIdentifierType ||
                    (this.RecordIdentifierType != null &&
                    this.RecordIdentifierType.Equals(input.RecordIdentifierType))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Columns != null)
                    hashCode = hashCode * 59 + this.Columns.GetHashCode();
                if (this.DefaultAccessViewId != null)
                    hashCode = hashCode * 59 + this.DefaultAccessViewId.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Metadata != null)
                    hashCode = hashCode * 59 + this.Metadata.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.RecordIdentifierType != null)
                    hashCode = hashCode * 59 + this.RecordIdentifierType.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
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
