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
    public class ResponseTimeTracking
<<<<<<< HEAD
        : Helpers.IResponse
    {
=======
		: Helpers.IResponse
	{
>>>>>>> 94034a3c1682cc12065299b6eecdf402258a50d5
        [JsonProperty("data")]
        public List<ResponseModelTimeTracking> Data { get; set; }
    }
}