using Newtonsoft.Json;
using System.Collections.Generic;

namespace Api.ClickUp.Responses.ResponseModel
{
    /// <summary>
    /// Model object of Folder information response
    /// </summary>
    public class ResponseModelFolder
        : Helpers.IResponse
    {
        /// <summary>
        /// Id of the Project
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

<<<<<<< HEAD
        /// <summary>
        /// Name of the Project
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Check if override statuses of the space for this project
        /// </summary>
        [JsonProperty("override_statuses")]
        public bool? OverrideStatuses { get; set; }

        /// <summary>
        /// List of List Model that contains the information of the lists in this project
        /// </summary>
        [JsonProperty("lists")]
        public List<ResponseModelList> Lists { get; set; }

        /// <summary>
=======
    /// <summary>
    /// Model object of Folder information response
    /// </summary>
    public class ResponseModelFolder
        : Helpers.IResponse
    {
        /// <summary>
        /// Id of the Project
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// Name of the Project
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Check if override statuses of the space for this project
        /// </summary>
        [JsonProperty("override_statuses")]
        public bool? OverrideStatuses { get; set; }

        /// <summary>
        /// List of List Model that contains the information of the lists in this project
        /// </summary>
        [JsonProperty("lists")]
        public List<ResponseModelList> Lists { get; set; }

        /// <summary>
>>>>>>> 94034a3c1682cc12065299b6eecdf402258a50d5
        /// List of Status Model that contains the information of Statuses (Only if Override Statuses is true)
        /// </summary>
        [JsonProperty("statuses")]
        public List<ResponseModelStatus> Statuses { get; set; }
    }
}