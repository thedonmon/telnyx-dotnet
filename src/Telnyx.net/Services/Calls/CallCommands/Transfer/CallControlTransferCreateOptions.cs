﻿namespace Telnyx
{
    using System;
    using Newtonsoft.Json;
    using Telnyx.net.Services.Calls.Models;

    /// <summary>
    /// CallControlTransferCreateOptions
    /// </summary>
    public class CallControlTransferCreateOptions : BaseOptions
    {
        /// <summary>
        /// The DID or SIP URI to dial out to.
        /// </summary>
        [JsonProperty("to")]
        public string To { get; set; }

        /// <summary>
        /// The `from` number to be used as the caller id presented to the destination (`to` number). The number should be in +E164 format. This attribute will default to the `from` number of the original call if omitted.
        /// </summary>
        [JsonProperty("from")]
        public string From { get; set; }

        /// <summary>
        /// The URL of a file to be played back to the callee when the call is answered. The URL can point to either a WAV or MP3 file.
        /// </summary>
        [JsonProperty("audio_url")]
        public string AudioUrl { get; set; }

        /// <summary>
        /// The number of seconds that Telnyx will wait for the call to be answered by the destination to which it is being called. If the timeout is reached before an answer is received, the call will hangup and a `call.hangup` webhook with a `hangup_cause` of `timeout` will be sent. Minimum value is 5 seconds. Maximum value is 120 seconds.
        /// Default: 30
        /// Example: 60
        /// </summary>
        [JsonProperty("timeout_secs")]
        public int TimeoutSecs { get; set; }

        /// <summary>
        /// Sets the maximum duration of a Call Control Leg in seconds. If the time limit is reached, the call will hangup and a `call.hangup` webhook with a `hangup_cause` of `time_limit` will be sent. For example, by setting a time limit of 120 seconds, a Call Leg will be automatically terminated two minutes after being answered. The default time limit is 14400 seconds or 4 hours and this is also the maximum allowed call length.
        /// <value>Default: 14400 Example: 600</value>
        /// </summary>
        [JsonProperty("time_limit_secs")]
        public int TimeLimitSecs { get; set; }

        /// <summary>
        /// Gets or sets a value Enables Answering Machine Detection. When a call is answered, Telnyx runs real-time detection to determine if it was picked up by a human or a machine and sends an `call.machine.detection.ended` webhook with the analysis result. If 'greeting_end' or 'detect_words' is used and a 'machine' is detected, you will receive another 'call.machine.greeting.ended' webhook when the answering machine greeting ends with a beep or silence. If `detect_beep` is used, you will only receive 'call.machine.greeting.ended' if a beep is detected.
        /// </summary>
        [JsonProperty("answering_machine_detection")]
        public string AnsweringMachineDetection { get; set; }

        /// <summary>
        /// Optional config parameter to modify answering_machine_detection performance
        /// </summary>
        [JsonProperty("answering_machine_detection_config")]
        public AnsweringMachineDetectionConfig AnsweringMachineDetConfig { get; set; }

        /// <summary>
        /// Gets or sets use this field to add state to every subsequent webhook. It must be a valid Base-64 encoded string
        /// </summary>
        [JsonProperty("client_state")]
        public string ClientState { get; set; }

        /// <summary>
        /// Gets or sets use this field to avoid duplicate commands. Telnyx will ignore commands with the same "command_id".
        /// </summary>
        /// <value>Example: "891510ac-f3e4-11e8-af5b-de00688a4901"</value>
        [JsonProperty("command_id")]
        public Guid CommandId { get; set; }

        /// <summary>
        /// Use another call's control id for sharing the same call session id
        /// </summary>
        /// <value>Example: "ilditnZK_eVysupV21KzmzN_sM29ygfauQojpm4BgFtfX5hXAcjotg=="</value>
        [JsonProperty("link_to")]
        public string LinkTo { get; set; }

        /// <summary>
        /// SIP Authentication username used for SIP challenges.
        /// </summary>
        [JsonProperty("sip_auth_username")]
        public string SipAuthUsername { get; set; }

        /// <summary>
        /// SIP Authentication password used for SIP challenges.
        /// </summary>
        [JsonProperty("sip_auth_password")]
        public string SipAuthPassword { get; set; }
    }
}