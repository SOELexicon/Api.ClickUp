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
    /// Response object of the method GetAuthorizedUser()
    /// </summary>
    public class ResponseAuthorizedUser
<<<<<<< HEAD
        : Helpers.IResponse
    {
        /// <summary>
        /// User Model Object with information of authorized User
        /// </summary>
        [JsonProperty("user")]
        public ResponseModelUser User { get; set; }
    }
=======
		: Helpers.IResponse
	{
		/// <summary>
		/// User Model Object with information of authorized User
		/// </summary>
		[JsonProperty("user")]
		public ResponseModelUser User { get; set; }
	}
>>>>>>> 94034a3c1682cc12065299b6eecdf402258a50d5
}