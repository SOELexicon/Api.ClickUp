<<<<<<< HEAD
﻿using Api.ClickUp.Responses.ResponseModel;
using Newtonsoft.Json;
=======
﻿using Newtonsoft.Json;
>>>>>>> 94034a3c1682cc12065299b6eecdf402258a50d5
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Api.ClickUp.Responses.ResponseModel;

namespace Api.ClickUp.Responses
{
<<<<<<< HEAD
=======

>>>>>>> 94034a3c1682cc12065299b6eecdf402258a50d5
    /// <summary>
    /// Response object of the method GetAuthorizedTeams()
    /// </summary>
    [Serializable]
<<<<<<< HEAD
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
=======
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
>>>>>>> 94034a3c1682cc12065299b6eecdf402258a50d5
}