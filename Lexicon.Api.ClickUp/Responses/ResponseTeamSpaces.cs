using Api.ClickUp.Responses.ResponseModel;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Api.ClickUp.Responses
{
    /// <summary>
    /// Response object of the method GetTeamSpaces()
    /// </summary>
    public class ResponseTeamSpaces
        : Helpers.IResponse
    {
        /// <summary>
        /// List of Space Model with information of authorized Team
        /// </summary>
        [JsonProperty("spaces")]
        public List<ResponseModelSpace> Spaces { get; set; }
    }
}