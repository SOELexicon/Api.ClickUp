using Newtonsoft.Json;
using System.Collections.Generic;

namespace Api.ClickUp.Responses.ResponseModel
{
    /// <summary>
    /// Model object of List information response
    /// </summary>
    public class ResponseModelItem
        : Helpers.IResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("orderindex")]
        public int OrderIndex { get; set; }
<<<<<<< HEAD

=======
>>>>>>> 94034a3c1682cc12065299b6eecdf402258a50d5
        [JsonProperty("assignee")]
        public ResponseModelUser Assignee { get; set; }

        [JsonProperty("group_assignee")]
        public ResponseModelMultipleAssignees GroupAssignee { get; set; }

        [JsonProperty("resolved")]
        public bool Resolved { get; set; }

        [JsonProperty("parent")]
        public string Parent { get; set; }

        [JsonProperty("date_created")]
        public string DateCreated { get; set; }

        [JsonProperty("children")]
        public List<string> Children { get; set; }
<<<<<<< HEAD
=======

>>>>>>> 94034a3c1682cc12065299b6eecdf402258a50d5
    }
}