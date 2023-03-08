using Newtonsoft.Json;
using Api.ClickUp.Responses.Model;

namespace Api.ClickUp.Responses
{

	/// <summary>
	/// Response object of the method CreateWebhook()
	/// </summary>
	public class ResponseWebhook
		: Helpers.IResponse
	{
		[JsonProperty("id")]
		public string Id { get; set; }

		[JsonProperty("webhook")]
		public ResponseModelWebhook Webhook { get; set; }
	}
}