using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Api.ClickUp.Responses.ResponseModel;

namespace Api.ClickUp.Responses
{

    /// <summary>
    /// Response object of the method GetAuthorizedTeams()
    /// </summary>
    [Serializable]
	[DataContract]
	public class ResponseAuthorizedTeams
		: Helpers.IResponse
	{
		/// <summary>
		/// List of Team Model with information of authorized Teams
		/// </summary>
		[JsonProperty("teams")]
		[DataMember(Name = "teams")]
		public List<ResponseModelTeam> Teams { get; set; }
	}
}