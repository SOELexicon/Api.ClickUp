﻿using Newtonsoft.Json;
using Api.ClickUp.Responses.Model;
using System.Collections.Generic;

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