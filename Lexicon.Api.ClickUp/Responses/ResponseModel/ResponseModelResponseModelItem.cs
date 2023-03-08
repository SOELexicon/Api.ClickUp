using System.Collections.Generic;
using Newtonsoft.Json;

namespace Api.ClickUp.Responses.Model
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
     
	}
}