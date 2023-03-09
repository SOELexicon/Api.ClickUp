using Newtonsoft.Json;

namespace Api.ClickUp.Responses.ResponseModel
{
<<<<<<< HEAD
=======

>>>>>>> 94034a3c1682cc12065299b6eecdf402258a50d5
    /// <summary>
    /// Model object of Time Estimates information response
    /// </summary>
    public class ResponseModelTimeEstimates
        : Helpers.IResponse
    {
        /// <summary>
        /// Check if Time Estimates is enabled
        /// </summary>
        [JsonProperty("enabled")]
        public bool? Enabled { get; set; }
    }
}