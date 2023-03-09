<<<<<<< HEAD
﻿using Api.ClickUp.Responses.ResponseModel;
using Newtonsoft.Json;
=======
﻿using Newtonsoft.Json;
>>>>>>> 94034a3c1682cc12065299b6eecdf402258a50d5
using System.Collections.Generic;
using Api.ClickUp.Responses.ResponseModel;

namespace Api.ClickUp.Responses
{
<<<<<<< HEAD
=======

>>>>>>> 94034a3c1682cc12065299b6eecdf402258a50d5
    /// <summary>
    /// Response object of the method GetTasks()
    /// </summary>
    public class ResponseTasks
<<<<<<< HEAD
        : Helpers.IResponse
    {
        /// <summary>
        /// List of Model Task with information of Tasks received
        /// </summary>
        [JsonProperty("tasks")]
        public List<ResponseModelTask> Tasks { get; set; }
    }
=======
		: Helpers.IResponse
	{
		/// <summary>
		/// List of Model Task with information of Tasks received
		/// </summary>
		[JsonProperty("tasks")]
		public List<ResponseModelTask> Tasks { get; set; }
	}
>>>>>>> 94034a3c1682cc12065299b6eecdf402258a50d5
}