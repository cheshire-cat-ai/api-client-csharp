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
    /// Plugin
    /// </summary>
    [DataContract(Name = "Plugin")]
    public partial class Plugin : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Plugin" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Plugin() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Plugin" /> class.
        /// </summary>
        /// <param name="id">id (required).</param>
        /// <param name="name">name (required).</param>
        /// <param name="description">description (required).</param>
        /// <param name="authorName">authorName (required).</param>
        /// <param name="authorUrl">authorUrl (required).</param>
        /// <param name="pluginUrl">pluginUrl (required).</param>
        /// <param name="tags">tags (required).</param>
        /// <param name="thumb">thumb (required).</param>
        /// <param name="varVersion">varVersion (required).</param>
        /// <param name="active">active.</param>
        /// <param name="url">url.</param>
        /// <param name="upgrade">upgrade.</param>
        /// <param name="hooks">hooks.</param>
        /// <param name="tools">tools.</param>
        public Plugin(string id = default(string), string name = default(string), string description = default(string), string authorName = default(string), string authorUrl = default(string), string pluginUrl = default(string), string tags = default(string), string thumb = default(string), string varVersion = default(string), bool active = default(bool), string url = default(string), string upgrade = default(string), List<HooksInner> hooks = default(List<HooksInner>), List<ToolsInner> tools = default(List<ToolsInner>))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for Plugin and cannot be null");
            }
            this.Id = id;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for Plugin and cannot be null");
            }
            this.Name = name;
            // to ensure "description" is required (not null)
            if (description == null)
            {
                throw new ArgumentNullException("description is a required property for Plugin and cannot be null");
            }
            this.Description = description;
            // to ensure "authorName" is required (not null)
            if (authorName == null)
            {
                throw new ArgumentNullException("authorName is a required property for Plugin and cannot be null");
            }
            this.AuthorName = authorName;
            // to ensure "authorUrl" is required (not null)
            if (authorUrl == null)
            {
                throw new ArgumentNullException("authorUrl is a required property for Plugin and cannot be null");
            }
            this.AuthorUrl = authorUrl;
            // to ensure "pluginUrl" is required (not null)
            if (pluginUrl == null)
            {
                throw new ArgumentNullException("pluginUrl is a required property for Plugin and cannot be null");
            }
            this.PluginUrl = pluginUrl;
            // to ensure "tags" is required (not null)
            if (tags == null)
            {
                throw new ArgumentNullException("tags is a required property for Plugin and cannot be null");
            }
            this.Tags = tags;
            // to ensure "thumb" is required (not null)
            if (thumb == null)
            {
                throw new ArgumentNullException("thumb is a required property for Plugin and cannot be null");
            }
            this.Thumb = thumb;
            // to ensure "varVersion" is required (not null)
            if (varVersion == null)
            {
                throw new ArgumentNullException("varVersion is a required property for Plugin and cannot be null");
            }
            this.VarVersion = varVersion;
            this.Active = active;
            this.Url = url;
            this.Upgrade = upgrade;
            this.Hooks = hooks;
            this.Tools = tools;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", IsRequired = true, EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets AuthorName
        /// </summary>
        [DataMember(Name = "author_name", IsRequired = true, EmitDefaultValue = true)]
        public string AuthorName { get; set; }

        /// <summary>
        /// Gets or Sets AuthorUrl
        /// </summary>
        [DataMember(Name = "author_url", IsRequired = true, EmitDefaultValue = true)]
        public string AuthorUrl { get; set; }

        /// <summary>
        /// Gets or Sets PluginUrl
        /// </summary>
        [DataMember(Name = "plugin_url", IsRequired = true, EmitDefaultValue = true)]
        public string PluginUrl { get; set; }

        /// <summary>
        /// Gets or Sets Tags
        /// </summary>
        [DataMember(Name = "tags", IsRequired = true, EmitDefaultValue = true)]
        public string Tags { get; set; }

        /// <summary>
        /// Gets or Sets Thumb
        /// </summary>
        [DataMember(Name = "thumb", IsRequired = true, EmitDefaultValue = true)]
        public string Thumb { get; set; }

        /// <summary>
        /// Gets or Sets VarVersion
        /// </summary>
        [DataMember(Name = "version", IsRequired = true, EmitDefaultValue = true)]
        public string VarVersion { get; set; }

        /// <summary>
        /// Gets or Sets Active
        /// </summary>
        [DataMember(Name = "active", EmitDefaultValue = true)]
        public bool Active { get; set; }

        /// <summary>
        /// Gets or Sets Url
        /// </summary>
        [DataMember(Name = "url", EmitDefaultValue = false)]
        public string Url { get; set; }

        /// <summary>
        /// Gets or Sets Upgrade
        /// </summary>
        [DataMember(Name = "upgrade", EmitDefaultValue = false)]
        public string Upgrade { get; set; }

        /// <summary>
        /// Gets or Sets Hooks
        /// </summary>
        [DataMember(Name = "hooks", EmitDefaultValue = false)]
        public List<HooksInner> Hooks { get; set; }

        /// <summary>
        /// Gets or Sets Tools
        /// </summary>
        [DataMember(Name = "tools", EmitDefaultValue = false)]
        public List<ToolsInner> Tools { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Plugin {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  AuthorName: ").Append(AuthorName).Append("\n");
            sb.Append("  AuthorUrl: ").Append(AuthorUrl).Append("\n");
            sb.Append("  PluginUrl: ").Append(PluginUrl).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  Thumb: ").Append(Thumb).Append("\n");
            sb.Append("  VarVersion: ").Append(VarVersion).Append("\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  Upgrade: ").Append(Upgrade).Append("\n");
            sb.Append("  Hooks: ").Append(Hooks).Append("\n");
            sb.Append("  Tools: ").Append(Tools).Append("\n");
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
