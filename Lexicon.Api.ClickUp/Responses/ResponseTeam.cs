<<<<<<< HEAD
﻿using Api.ClickUp.Responses.ResponseModel;
using Newtonsoft.Json;

namespace Api.ClickUp.Responses
{
=======
﻿using Newtonsoft.Json;
using Api.ClickUp.Responses.ResponseModel;

namespace Api.ClickUp.Responses
{

>>>>>>> 94034a3c1682cc12065299b6eecdf402258a50d5
    /// <summary>
    /// Response object of the method GetTeamByID()
    /// </summary>
    public class ResponseTeam
<<<<<<< HEAD
        : Helpers.IResponse
    {
        /// <summary>
        /// Team Model object with the information of the team
        /// </summary>
        [JsonProperty("team")]
        public ResponseModelTeam Team { get; set; }
    }
=======
		: Helpers.IResponse
	{
		/// <summary>
		/// Team Model object with the information of the team
		/// </summary>
		[JsonProperty("team")]
		public ResponseModelTeam Team { get; set; }
	}
>>>>>>> 94034a3c1682cc12065299b6eecdf402258a50d5
}