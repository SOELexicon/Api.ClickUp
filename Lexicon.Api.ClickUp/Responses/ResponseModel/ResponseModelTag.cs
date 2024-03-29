﻿using Newtonsoft.Json;

namespace Api.ClickUp.Responses.ResponseModel
{
    /// <summary>
    /// Model object of Tag information response
    /// </summary>
    public class ResponseModelTag
        : Helpers.IResponse
    {
        /// <summary>
        /// Name of the Tag
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

<<<<<<< HEAD
        /// <summary>
        /// Foreground color of the Tag
        /// </summary>
        [JsonProperty("tag_fg")]
        public string TagFg { get; set; }

        /// <summary>
        /// Background color of the Tag
        /// </summary>
        [JsonProperty("tag_bg")]
        public string TagBg { get; set; }

        /// <summary>
=======
    /// <summary>
    /// Model object of Tag information response
    /// </summary>
    public class ResponseModelTag
        : Helpers.IResponse
    {
        /// <summary>
        /// Name of the Tag
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Foreground color of the Tag
        /// </summary>
        [JsonProperty("tag_fg")]
        public string TagFg { get; set; }

        /// <summary>
        /// Background color of the Tag
        /// </summary>
        [JsonProperty("tag_bg")]
        public string TagBg { get; set; }

        /// <summary>
>>>>>>> 94034a3c1682cc12065299b6eecdf402258a50d5
        /// Check if the Tag is enabled
        /// </summary>
        [JsonProperty("enabled")]
        public bool? Enabled { get; set; }
    }
}