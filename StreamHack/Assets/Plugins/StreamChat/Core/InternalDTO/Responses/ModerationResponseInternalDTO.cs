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
    internal partial class ModerationResponseInternalDTO
    {
        [Newtonsoft.Json.JsonProperty("action", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Action { get; set; }

        [Newtonsoft.Json.JsonProperty("explicit", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public float? Explicit { get; set; }

        [Newtonsoft.Json.JsonProperty("spam", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public float? Spam { get; set; }

        [Newtonsoft.Json.JsonProperty("toxic", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public float? Toxic { get; set; }

        private System.Collections.Generic.Dictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.Dictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }

    }

}

