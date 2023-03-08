using Newtonsoft.Json;

namespace Api.ClickUp.Responses.ResponseModel
{
    /// <summary>
    /// Model object of Dependency Warning information response
    /// </summary>
    public class ResponseModelDependencyWarning
        : Helpers.IResponse
    {
        /// <summary>
        /// Check if the Dependecy Warning are enabled
        /// </summary>
        [JsonProperty("enabled")]
        public bool? Enabled { get; set; }
    }
}