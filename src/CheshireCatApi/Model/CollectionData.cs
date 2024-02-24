/*
 * 😸 Cheshire-Cat API
 *
 * Customizable AI architecture
 *
 * The version of the OpenAPI document: 0.0.5
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = CheshireCatApi.Client.OpenAPIDateConverter;

namespace CheshireCatApi.Model
{
    /// <summary>
    /// CollectionData
    /// </summary>
    [DataContract(Name = "CollectionData")]
    public partial class CollectionData : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CollectionData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CollectionData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CollectionData" /> class.
        /// </summary>
        /// <param name="pageContent">pageContent (required).</param>
        /// <param name="metadata">metadata (required).</param>
        /// <param name="id">id (required).</param>
        /// <param name="score">score (required).</param>
        /// <param name="vector">vector (required).</param>
        public CollectionData(string pageContent = default(string), MetaData metadata = default(MetaData), string id = default(string), int score = default(int), List<int> vector = default(List<int>))
        {
            // to ensure "pageContent" is required (not null)
            if (pageContent == null)
            {
                throw new ArgumentNullException("pageContent is a required property for CollectionData and cannot be null");
            }
            this.PageContent = pageContent;
            // to ensure "metadata" is required (not null)
            if (metadata == null)
            {
                throw new ArgumentNullException("metadata is a required property for CollectionData and cannot be null");
            }
            this.Metadata = metadata;
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for CollectionData and cannot be null");
            }
            this.Id = id;
            this.Score = score;
            // to ensure "vector" is required (not null)
            if (vector == null)
            {
                throw new ArgumentNullException("vector is a required property for CollectionData and cannot be null");
            }
            this.Vector = vector;
        }

        /// <summary>
        /// Gets or Sets PageContent
        /// </summary>
        [DataMember(Name = "page_content", IsRequired = true, EmitDefaultValue = true)]
        public string PageContent { get; set; }

        /// <summary>
        /// Gets or Sets Metadata
        /// </summary>
        [DataMember(Name = "metadata", IsRequired = true, EmitDefaultValue = true)]
        public MetaData Metadata { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Score
        /// </summary>
        [DataMember(Name = "score", IsRequired = true, EmitDefaultValue = true)]
        public int Score { get; set; }

        /// <summary>
        /// Gets or Sets Vector
        /// </summary>
        [DataMember(Name = "vector", IsRequired = true, EmitDefaultValue = true)]
        public List<int> Vector { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CollectionData {\n");
            sb.Append("  PageContent: ").Append(PageContent).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Score: ").Append(Score).Append("\n");
            sb.Append("  Vector: ").Append(Vector).Append("\n");
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