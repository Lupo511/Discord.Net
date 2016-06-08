﻿using Newtonsoft.Json;

namespace Discord.API
{
    public class VoiceState
    {
        [JsonProperty("channel_id")]
        public ulong ChannelId { get; set; }
        [JsonProperty("user_id")]
        public ulong UserId { get; set; }
        [JsonProperty("session_id")]
        public string SessionId { get; set; }
        [JsonProperty("deaf")]
        public bool Deaf { get; set; }
        [JsonProperty("mute")]
        public bool Mute { get; set; }
        [JsonProperty("self_deaf")]
        public bool SelfDeaf { get; set; }
        [JsonProperty("self_mute")]
        public bool SelfMute { get; set; }
        [JsonProperty("suppress")]
        public bool Suppress { get; set; }
    }
}
