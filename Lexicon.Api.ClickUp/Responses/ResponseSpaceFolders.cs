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
    /// Response object of the method GetSpaceFolders()
    /// </summary>
    public class ResponseSpaceFolders
<<<<<<< HEAD
        : Helpers.IResponse
    {
        /// <summary>
        /// List of Folder Model with information of the Space
        /// </summary>
        [JsonProperty("folders")]
        public List<ResponseModelFolder> Folders { get; set; }
    }
=======
		: Helpers.IResponse
	{
		/// <summary>
		/// List of Folder Model with information of the Space
		/// </summary>
		[JsonProperty("folders")]
		public List<ResponseModelFolder> Folders { get; set; }
	}
>>>>>>> 94034a3c1682cc12065299b6eecdf402258a50d5
}