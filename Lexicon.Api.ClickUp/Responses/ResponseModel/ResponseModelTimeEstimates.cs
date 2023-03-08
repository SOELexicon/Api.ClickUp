using Newtonsoft.Json;

namespace Api.ClickUp.Responses.Model
{

	/// <summary>
	/// Model object of Time Estimates information response
	/// </summary>
	public class ResponseModelTimeEstimates
		: Helpers.IResponse
	{
		/// <summary>
		/// Check if Time Estimates is enabled
		/// </summary>
		[JsonProperty("enabled")]
		public bool? Enabled { get; set; }
	}
}