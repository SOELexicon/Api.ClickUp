﻿using Newtonsoft.Json;

namespace Api.ClickUp.Responses.ResponseModel
{
<<<<<<< HEAD
=======

>>>>>>> 94034a3c1682cc12065299b6eecdf402258a50d5
    /// <summary>
    /// Model object of Custom Field information response
    /// </summary>
    public class ResponseModelCustomFields
        : Helpers.IResponse
    {
        /// <summary>
        /// Check if the Custom Fields are enabled
        /// </summary>
        [JsonProperty("enabled")]
        public bool? Enabled { get; set; }
    }
}