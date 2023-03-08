using Api.ClickUp.Responses.ResponseModel;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Api.ClickUp.Responses
{
    /// <summary>
    /// Response object of the method GetTasks()
    /// </summary>
    public class ResponseTimeTracking
        : Helpers.IResponse
    {
        [JsonProperty("data")]
        public List<ResponseModelTimeTracking> Data { get; set; }
    }
}