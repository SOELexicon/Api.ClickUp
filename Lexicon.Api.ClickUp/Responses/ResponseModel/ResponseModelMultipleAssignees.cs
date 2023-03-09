using Newtonsoft.Json;

namespace Api.ClickUp.Responses.ResponseModel
{
<<<<<<< HEAD
=======

>>>>>>> 94034a3c1682cc12065299b6eecdf402258a50d5
    /// <summary>
    /// Model object of Multiple Assignees information response
    /// </summary>
    public class ResponseModelMultipleAssignees
        : Helpers.IResponse
    {
        /// <summary>
        /// Check if the Multiple Assignees are enabled
        /// </summary>
        [JsonProperty("enabled")]
        public bool? Enabled { get; set; }
    }
}