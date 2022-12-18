﻿//----------------------
// <auto-generated>
//     Generated using the NSwag toolchain v13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0)) (http://NSwag.org)
// </auto-generated>
//----------------------


using StreamChat.Core.InternalDTO.Requests;
using StreamChat.Core.InternalDTO.Events;
using StreamChat.Core.InternalDTO.Models;

namespace StreamChat.Core.InternalDTO.Responses
{
    using System = global::System;

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
    internal partial class CheckPushResponseInternalDTO
    {
        /// <summary>
        /// Object with device errors
        /// </summary>
        [Newtonsoft.Json.JsonProperty("device_errors", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.Dictionary<string, DeviceErrorInfoInternalDTO> DeviceErrors { get; set; }

        /// <summary>
        /// Duration of the request in human-readable format
        /// </summary>
        [Newtonsoft.Json.JsonProperty("duration", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Duration { get; set; }

        /// <summary>
        /// List of general errors
        /// </summary>
        [Newtonsoft.Json.JsonProperty("general_errors", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<string> GeneralErrors { get; set; }

        [Newtonsoft.Json.JsonProperty("rendered_apn_template", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string RenderedApnTemplate { get; set; }

        [Newtonsoft.Json.JsonProperty("rendered_firebase_template", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string RenderedFirebaseTemplate { get; set; }

        [Newtonsoft.Json.JsonProperty("rendered_message", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.Dictionary<string, string> RenderedMessage { get; set; }

        /// <summary>
        /// Don't require existing devices to render templates
        /// </summary>
        [Newtonsoft.Json.JsonProperty("skip_devices", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? SkipDevices { get; set; }

        private System.Collections.Generic.Dictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.Dictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }

    }

}

