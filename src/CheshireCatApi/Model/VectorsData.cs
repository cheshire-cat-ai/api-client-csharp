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
    /// VectorsData
    /// </summary>
    [DataContract(Name = "VectorsData")]
    public partial class VectorsData : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VectorsData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected VectorsData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="VectorsData" /> class.
        /// </summary>
        /// <param name="embedder">embedder (required).</param>
        /// <param name="collections">collections (required).</param>
        public VectorsData(string embedder = default(string), Dictionary<string, List<CollectionData>> collections = default(Dictionary<string, List<CollectionData>>))
        {
            // to ensure "embedder" is required (not null)
            if (embedder == null)
            {
                throw new ArgumentNullException("embedder is a required property for VectorsData and cannot be null");
            }
            this.Embedder = embedder;
            // to ensure "collections" is required (not null)
            if (collections == null)
            {
                throw new ArgumentNullException("collections is a required property for VectorsData and cannot be null");
            }
            this.Collections = collections;
        }

        /// <summary>
        /// Gets or Sets Embedder
        /// </summary>
        [DataMember(Name = "embedder", IsRequired = true, EmitDefaultValue = true)]
        public string Embedder { get; set; }

        /// <summary>
        /// Gets or Sets Collections
        /// </summary>
        [DataMember(Name = "collections", IsRequired = true, EmitDefaultValue = true)]
        public Dictionary<string, List<CollectionData>> Collections { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class VectorsData {\n");
            sb.Append("  Embedder: ").Append(Embedder).Append("\n");
            sb.Append("  Collections: ").Append(Collections).Append("\n");
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
