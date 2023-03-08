using Newtonsoft.Json;

namespace Api.ClickUp.Responses
{

	/// <summary>
	/// Response object of the Authentication
	/// </summary>
	public class ResponseAccessToken
		: Helpers.IResponse
	{
		/// <summary>
		/// AccessToken Returned
		/// </summary>
		[JsonProperty("access_token")]
		public string AccessToken { get; set; }
	}
}