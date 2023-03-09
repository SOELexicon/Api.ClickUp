using Newtonsoft.Json;
using System.Collections.Generic;

namespace Api.ClickUp.Responses.ResponseModel
{
    /// <summary>
    /// Model object of Priorities information response
    /// </summary>
    public class ResponseModelPriorities
        : Helpers.IResponse
    {
        /// <summary>
        /// Check if enabled Priorities
        /// </summary>
        [JsonProperty("enabled")]
        public bool? Enabled { get; set; }

<<<<<<< HEAD
=======
    /// <summary>
    /// Model object of Priorities information response
    /// </summary>
    public class ResponseModelPriorities
        : Helpers.IResponse
    {
        /// <summary>
        /// Check if enabled Priorities
        /// </summary>
        [JsonProperty("enabled")]
        public bool? Enabled { get; set; }

>>>>>>> 94034a3c1682cc12065299b6eecdf402258a50d5
        /// <summary>
        /// List of Model Priority with priorities information
        /// </summary>
        [JsonProperty("priorities")]
        public List<ResponseModelPriority> Priorities { get; set; }
    }
}