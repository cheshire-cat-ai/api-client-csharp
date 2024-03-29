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
    /// ConversationHistory
    /// </summary>
    [DataContract(Name = "ConversationHistory")]
    public partial class ConversationHistory : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationHistory" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ConversationHistory() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationHistory" /> class.
        /// </summary>
        /// <param name="history">history (required).</param>
        public ConversationHistory(List<ConversationMessage> history = default(List<ConversationMessage>))
        {
            // to ensure "history" is required (not null)
            if (history == null)
            {
                throw new ArgumentNullException("history is a required property for ConversationHistory and cannot be null");
            }
            this.History = history;
        }

        /// <summary>
        /// Gets or Sets History
        /// </summary>
        [DataMember(Name = "history", IsRequired = true, EmitDefaultValue = true)]
        public List<ConversationMessage> History { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ConversationHistory {\n");
            sb.Append("  History: ").Append(History).Append("\n");
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
