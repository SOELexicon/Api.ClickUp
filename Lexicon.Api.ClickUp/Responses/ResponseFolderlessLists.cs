using Newtonsoft.Json;
using System.Collections.Generic;
using Api.ClickUp.Responses.ResponseModel;

namespace Api.ClickUp.Responses
{

    /// <summary>
    /// Response object of the method GetFolderlessLists()
    /// </summary>
    public class ResponseFolderlessLists
		: Helpers.IResponse
	{
		/// <summary>
		/// List of List Model with information of the Space
		/// </summary>
		[JsonProperty("lists")]
		public List<ResponseModelList> Lists { get; set; }
	}
}