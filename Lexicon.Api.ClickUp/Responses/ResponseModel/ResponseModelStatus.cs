using Newtonsoft.Json;

namespace Api.ClickUp.Responses.ResponseModel
{
    /// <summary>
    /// Model Object of Status information Response
    /// </summary>
    public class ResponseModelStatus
        : Helpers.IResponse
    {
        /// <summary>
        /// Name of the Status
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

<<<<<<< HEAD
        /// <summary>
        /// Type of the Status
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// Order index of the Status (Zero based)
        /// </summary>
        [JsonProperty("orderindex")]
        public int OrderIndex { get; set; }

        /// <summary>
=======
    /// <summary>
    /// Model Object of Status information Response
    /// </summary>
    public class ResponseModelStatus
        : Helpers.IResponse
    {
        /// <summary>
        /// Name of the Status
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// Type of the Status
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// Order index of the Status (Zero based)
        /// </summary>
        [JsonProperty("orderindex")]
        public int OrderIndex { get; set; }

        /// <summary>
>>>>>>> 94034a3c1682cc12065299b6eecdf402258a50d5
        /// Color assign at the Status
        /// </summary>
        [JsonProperty("color")]
        public string Color { get; set; }
    }
}