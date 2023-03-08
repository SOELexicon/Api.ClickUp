using Api.ClickUp.Responses.Model;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Api.ClickUp.Responses
{
    /// <summary>
    /// Response object of the method GetWebhooks()
    /// </summary>
    public class ResponseWebhooks
        : Helpers.IResponse
    {
        [JsonProperty("webhooks")]
        public List<ResponseModelWebhook> Webhooks { get; set; }
    }
}