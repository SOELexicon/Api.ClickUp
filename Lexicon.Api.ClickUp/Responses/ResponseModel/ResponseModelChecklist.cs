﻿using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Api.ClickUp.Responses.Model
{

    /// <summary>
    /// Model object of List information response
    /// </summary>
    /// 
    /// 
    public class ResponseModeChecklist : Helpers.IResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("task_id")]
        public string TaskId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; set; }

        [JsonProperty("orderindex")]
        public int OrderIndex { get; set; }

        [JsonProperty("creator")]
        public ResponseModelUser Creator { get; set; }

        [JsonProperty("resolved")]
        public int Resolved { get; set; }

        [JsonProperty("unresolved")]
        public int Unresolved { get; set; }

        [JsonProperty("items")]
        public List<ResponseModelItem> Items { get; set; }
    }

}