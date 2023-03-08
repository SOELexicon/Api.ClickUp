using Api.ClickUp.Helpers;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Api.ClickUp.Responses.Model
{
    /// <summary>
    /// Model object of Time Tracking information response
    /// </summary>
    [Serializable]
    [DataContract]
    public class ResponseModelTimeTracking : IResponse
    {
        [JsonProperty("id")]
        [DataMember(Name = "id")]
        public string Id { get; set; }

        [JsonProperty("task")]
        [DataMember(Name = "task")]
        public ResponseModelTask Task { get; set; }

        [JsonProperty("wid")]
        [DataMember(Name = "wid")]
        public string WorkspaceId { get; set; }

        [JsonProperty("user")]
        [DataMember(Name = "user")]
        public ResponseModelUser User { get; set; }

        [JsonProperty("billable")]
        [DataMember(Name = "billable")]
        public bool? Billable { get; set; }

        [JsonProperty("start")]
        [DataMember(Name = "start")]
        [JsonConverter(typeof(JsonConverterDateTimeMilliseconds))]
        public DateTime Start { get; set; }

        [JsonProperty("end")]
        [DataMember(Name = "end")]
        [JsonConverter(typeof(JsonConverterDateTimeMilliseconds))]
        public DateTime End { get; set; }

        [JsonProperty("duration")]
        [DataMember(Name = "duration")]
        public string Duration { get; set; }

        [JsonProperty("description")]
        [DataMember(Name = "description")]
        public string Description { get; set; }

        [JsonProperty("tags")]
        [DataMember(Name = "tags")]
        public List<ResponseModelTag> Tags { get; set; }

        [JsonProperty("source")]
        [DataMember(Name = "source")]
        public string Source { get; set; }

        [JsonProperty("at")]
        [DataMember(Name = "at")]
        [JsonConverter(typeof(JsonConverterDateTimeMilliseconds))]
        public DateTime? At { get; set; }

        [JsonProperty("task_location")]
        [DataMember(Name = "task_location")]
        public ResponseModelTaskLocation TaskLocation { get; set; }

        [JsonProperty("task_tags")]
        [DataMember(Name = "task_tags")]
        public List<ResponseModelTag> TaskTags { get; set; }

        [JsonProperty("task_url")]
        [DataMember(Name = "task_url")]
        public string TaskUrl { get; set; }
    }

    public class ResponseModelTaskLocation
    {
        [JsonProperty("list_id")]
        [DataMember(Name = "list_id")]
        public long? ListId { get; set; }

        [JsonProperty("folder_id")]
        [DataMember(Name = "folder_id")]
        public long? FolderId { get; set; }

        [JsonProperty("space_id")]
        [DataMember(Name = "space_id")]
        public long? SpaceId { get; set; }

        [JsonProperty("list_name")]
        [DataMember(Name = "list_name")]
        public string ListName { get; set; }

        [JsonProperty("folder_name")]
        [DataMember(Name = "folder_name")]
        public string FolderName { get; set; }

        [JsonProperty("space_name")]
        [DataMember(Name = "space_name")]
        public string SpaceName { get; set; }
    }
}
