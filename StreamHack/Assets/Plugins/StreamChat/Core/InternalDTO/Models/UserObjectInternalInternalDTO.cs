﻿//----------------------
// <auto-generated>
//     Generated using the NSwag toolchain v13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0)) (http://NSwag.org)
// </auto-generated>
//----------------------


using StreamChat.Core.InternalDTO.Responses;
using StreamChat.Core.InternalDTO.Requests;
using StreamChat.Core.InternalDTO.Events;

namespace StreamChat.Core.InternalDTO.Models
{
    using System = global::System;

    /// <summary>
    /// Represents chat user
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
    internal partial class UserObjectInternalInternalDTO
    {
        /// <summary>
        /// Expiration date of the ban
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ban_expires", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? BanExpires { get; set; }

        /// <summary>
        /// Whether a user is banned or not
        /// </summary>
        [Newtonsoft.Json.JsonProperty("banned", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Banned { get; set; }

        /// <summary>
        /// Date/time of creation
        /// </summary>
        [Newtonsoft.Json.JsonProperty("created_at", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? CreatedAt { get; set; }

        /// <summary>
        /// Date of deactivation
        /// </summary>
        [Newtonsoft.Json.JsonProperty("deactivated_at", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? DeactivatedAt { get; set; }

        /// <summary>
        /// Date/time of deletion
        /// </summary>
        [Newtonsoft.Json.JsonProperty("deleted_at", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? DeletedAt { get; set; }

        /// <summary>
        /// Unique user identifier
        /// </summary>
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Id { get; set; }

        [Newtonsoft.Json.JsonProperty("invisible", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Invisible { get; set; }

        /// <summary>
        /// Preferred language of a user
        /// </summary>
        [Newtonsoft.Json.JsonProperty("language", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Language { get; set; }

        /// <summary>
        /// Date of last activity
        /// </summary>
        [Newtonsoft.Json.JsonProperty("last_active", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? LastActive { get; set; }

        /// <summary>
        /// Whether a user online or not
        /// </summary>
        [Newtonsoft.Json.JsonProperty("online", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Online { get; set; }

        [Newtonsoft.Json.JsonProperty("push_notifications", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public PushNotificationSettingsInternalDTO PushNotifications { get; set; }

        /// <summary>
        /// Revocation date for tokens
        /// </summary>
        [Newtonsoft.Json.JsonProperty("revoke_tokens_issued_before", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? RevokeTokensIssuedBefore { get; set; }

        /// <summary>
        /// Determines the set of user permissions
        /// </summary>
        [Newtonsoft.Json.JsonProperty("role", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Role { get; set; }

        /// <summary>
        /// List of teams user is a part of
        /// </summary>
        [Newtonsoft.Json.JsonProperty("teams", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<string> Teams { get; set; }

        /// <summary>
        /// Date/time of the last update
        /// </summary>
        [Newtonsoft.Json.JsonProperty("updated_at", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? UpdatedAt { get; set; }

        private System.Collections.Generic.Dictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.Dictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }

    }

}

