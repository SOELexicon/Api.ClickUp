using Newtonsoft.Json;
using System.Collections.Generic;

namespace Api.ClickUp.Responses.ResponseModel
{
    /// <summary>
    /// Model object of List information response
    /// </summary>
    public class ResponseModelList
        : Helpers.IResponse
    {
        /// <summary>
        /// Id of the List
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

<<<<<<< HEAD
        /// <summary>
        /// Name of the List
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }

        [JsonProperty("folder")]
        public ResponseModelFolder Folder { get; set; }

        [JsonProperty("space")]
        public ResponseModelSpace Space { get; set; }

=======
    /// <summary>
    /// Model object of List information response
    /// </summary>
    public class ResponseModelList
        : Helpers.IResponse
    {

        /// <summary>
        /// Id of the List
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// Name of the List
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }

        [JsonProperty("folder")]
        public ResponseModelFolder Folder { get; set; }

        [JsonProperty("space")]
        public ResponseModelSpace Space { get; set; }

>>>>>>> 94034a3c1682cc12065299b6eecdf402258a50d5
        /// <summary>
        /// List of Status Model that contains the information of Statuses (Only if Override Statuses is true)
        /// </summary>
        [JsonProperty("statuses")]
        public List<ResponseModelStatus> Statuses { get; set; }
    }
}