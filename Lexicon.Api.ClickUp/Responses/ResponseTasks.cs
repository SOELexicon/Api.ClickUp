using Newtonsoft.Json;
using System.Collections.Generic;
using Api.ClickUp.Responses.ResponseModel;

namespace Api.ClickUp.Responses
{

    /// <summary>
    /// Response object of the method GetTasks()
    /// </summary>
    public class ResponseTasks
		: Helpers.IResponse
	{
		/// <summary>
		/// List of Model Task with information of Tasks received
		/// </summary>
		[JsonProperty("tasks")]
		public List<ResponseModelTask> Tasks { get; set; }
	}
}