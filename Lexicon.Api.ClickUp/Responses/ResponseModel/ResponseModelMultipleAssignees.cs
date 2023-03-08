using Newtonsoft.Json;

namespace Api.ClickUp.Responses.ResponseModel
{
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