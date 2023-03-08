﻿using Api.ClickUp.Responses.ResponseModel;
using Newtonsoft.Json;

namespace Api.ClickUp.Responses
{
    /// <summary>
    /// Response object of the method GetAuthorizedUser()
    /// </summary>
    public class ResponseAuthorizedUser
        : Helpers.IResponse
    {
        /// <summary>
        /// User Model Object with information of authorized User
        /// </summary>
        [JsonProperty("user")]
        public ResponseModelUser User { get; set; }
    }
}