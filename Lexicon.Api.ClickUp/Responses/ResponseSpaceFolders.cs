using Api.ClickUp.Responses.ResponseModel;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Api.ClickUp.Responses
{
    /// <summary>
    /// Response object of the method GetSpaceFolders()
    /// </summary>
    public class ResponseSpaceFolders
        : Helpers.IResponse
    {
        /// <summary>
        /// List of Folder Model with information of the Space
        /// </summary>
        [JsonProperty("folders")]
        public List<ResponseModelFolder> Folders { get; set; }
    }
}