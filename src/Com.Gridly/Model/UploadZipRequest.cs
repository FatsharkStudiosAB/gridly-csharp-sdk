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
    /// UploadZipRequest
    /// </summary>
    [DataContract]
    public partial class UploadZipRequest :  IEquatable<UploadZipRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UploadZipRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UploadZipRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UploadZipRequest" /> class.
        /// </summary>
        /// <param name="columnId">columnId (required).</param>
        /// <param name="fileMappings">fileMappings (required).</param>
        /// <param name="file">file (required).</param>
        public UploadZipRequest(string columnId = default(string), string fileMappings = default(string), System.IO.Stream file = default(System.IO.Stream))
        {
            // to ensure "columnId" is required (not null)
            if (columnId == null)
            {
                throw new InvalidDataException("columnId is a required property for UploadZipRequest and cannot be null");
            }
            else
            {
                this.ColumnId = columnId;
            }

            // to ensure "fileMappings" is required (not null)
            if (fileMappings == null)
            {
                throw new InvalidDataException("fileMappings is a required property for UploadZipRequest and cannot be null");
            }
            else
            {
                this.FileMappings = fileMappings;
            }

            // to ensure "file" is required (not null)
            if (file == null)
            {
                throw new InvalidDataException("file is a required property for UploadZipRequest and cannot be null");
            }
            else
            {
                this.File = file;
            }

        }

        /// <summary>
        /// Gets or Sets ColumnId
        /// </summary>
        [DataMember(Name="columnId", EmitDefaultValue=true)]
        public string ColumnId { get; set; }

        /// <summary>
        /// Gets or Sets FileMappings
        /// </summary>
        [DataMember(Name="fileMappings", EmitDefaultValue=true)]
        public string FileMappings { get; set; }

        /// <summary>
        /// Gets or Sets File
        /// </summary>
        [DataMember(Name="file", EmitDefaultValue=true)]
        public System.IO.Stream File { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UploadZipRequest {\n");
            sb.Append("  ColumnId: ").Append(ColumnId).Append("\n");
            sb.Append("  FileMappings: ").Append(FileMappings).Append("\n");
            sb.Append("  File: ").Append(File).Append("\n");
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
            return this.Equals(input as UploadZipRequest);
        }

        /// <summary>
        /// Returns true if UploadZipRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of UploadZipRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UploadZipRequest input)
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
                    this.FileMappings == input.FileMappings ||
                    (this.FileMappings != null &&
                    this.FileMappings.Equals(input.FileMappings))
                ) && 
                (
                    this.File == input.File ||
                    (this.File != null &&
                    this.File.Equals(input.File))
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
                if (this.FileMappings != null)
                    hashCode = hashCode * 59 + this.FileMappings.GetHashCode();
                if (this.File != null)
                    hashCode = hashCode * 59 + this.File.GetHashCode();
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
