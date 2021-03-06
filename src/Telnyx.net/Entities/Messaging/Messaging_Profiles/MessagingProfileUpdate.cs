namespace Telnyx
{
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// Messaging Profile Update
    /// </summary>
    public class MessagingProfileUpdate : BaseOptions
    {
        /// <summary>
        /// Determines which webhook format will be used, API V1 or API V2.
        /// </summary>
        /// <value>Webhook format: API V1 or API V2.</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum WebhookApiVersionEnum
        {
            /// <summary>
            /// Enum ApiV1 for 1
            /// </summary>
            [EnumMember(Value = "1")]
            ApiV1 = 0,

            /// <summary>
            /// Enum ApiV2 for 2
            /// </summary>
            [EnumMember(Value = "2")]
            ApiV2 = 1
        }

        /// <summary>
        /// Gets or sets a user friendly name for the messaging profile
        /// </summary>
        /// <value>A user friendly name for the messaging profile</value>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the URL where webhooks related to this messaging profile will be sent.
        /// </summary>
        /// <value>The URL where webhooks related to this messaging profile will be sent.</value>
        [JsonProperty("webhook_url")]
        public string WebhookUrl { get; set; }

        /// <summary>
        /// Gets or sets the failover URL where webhooks related to this messaging profile will be sent if sending to the primary URL fails.
        /// </summary>
        /// <value>The failover URL where webhooks related to this messaging profile will be sent if sending to the primary URL fails.</value>
        [JsonProperty("webhook_failover_url")]
        public string WebhookFailoverUrl { get; set; }

        /// <summary>
        /// Gets or sets specifies whether the messaging profile is enabled or not.
        /// </summary>
        /// <value>Specifies whether the messaging profile is enabled or not.</value>
        [JsonProperty("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Gets or sets specifies whether to apply character simplification to text.
        /// </summary>
        /// <value>Specifies whether to apply character simplification to text.</value>
        [JsonProperty("simplify_characters")]
        public bool? SimplifyCharacters { get; set; }

        /// <summary>
        /// Gets or sets destinations to which the messaging profile is allowed to send.
        /// </summary>
        /// <value>Destinations to which the messaging profile is allowed to send.</value>
        [JsonProperty("whitelisted_destinations")]
        public List<string> WhitelistedDestinations { get; set; }

        /// <summary>
        /// Gets or sets determines which webhook format will be used, API V1 or API V2.
        /// </summary>
        /// <value>Determines which webhook format will be used, API V1 or API V2.</value>
        [JsonProperty("webhook_api_version")]
        public WebhookApiVersionEnum? WebhookApiVersion { get; set; }

        /// <summary>
        /// Gets or sets NumberPoolSettings
        /// </summary>
        [JsonProperty("number_pool_settings")]
        public NumberPoolSettings NumberPoolSettings { get; set; }
    }
}
