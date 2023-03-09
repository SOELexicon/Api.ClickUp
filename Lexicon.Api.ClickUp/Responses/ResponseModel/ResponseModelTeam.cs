﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Api.ClickUp.Responses.ResponseModel
{
    /// <summary>
    /// Model Object of Team information response
    /// </summary>
    [Serializable]
    [DataContract]
    public class ResponseModelTeam
        : Helpers.IResponse
    {
        /// <summary>
        /// Id of the team
        /// </summary>
        [JsonProperty("id")]
        [DataMember(Name = "id")]
        public string Id { get; set; }

<<<<<<< HEAD
        /// <summary>
        /// Name of the Team
        /// </summary>
        [JsonProperty("name")]
        [DataMember(Name = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Theme Color of the Team
        /// </summary>
        [JsonProperty("color")]
        [DataMember(Name = "color")]
        public string Color { get; set; }

        /// <summary>
        /// The Url of the Avatar of the Team
        /// </summary>
        [JsonProperty("avatar")]
        [DataMember(Name = "avatar")]
        public string Avatar { get; set; }

        /// <summary>
        /// List of User Model object with the members of the Team
        /// </summary>
        [JsonProperty("members")]
        [DataMember(Name = "members")]
        public List<MembersContainer> Members { get; set; }

=======
    /// <summary>
    /// Model Object of Team information response
    /// </summary>
    [Serializable]
    [DataContract]
    public class ResponseModelTeam
        : Helpers.IResponse
    {
        /// <summary>
        /// Id of the team
        /// </summary>
        [JsonProperty("id")]
        [DataMember(Name = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Name of the Team
        /// </summary>
        [JsonProperty("name")]
        [DataMember(Name = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Theme Color of the Team
        /// </summary>
        [JsonProperty("color")]
        [DataMember(Name = "color")]
        public string Color { get; set; }

        /// <summary>
        /// The Url of the Avatar of the Team
        /// </summary>
        [JsonProperty("avatar")]
        [DataMember(Name = "avatar")]
        public string Avatar { get; set; }

        /// <summary>
        /// List of User Model object with the members of the Team
        /// </summary>
        [JsonProperty("members")]
        [DataMember(Name = "members")]
        public List<MembersContainer> Members { get; set; }

>>>>>>> 94034a3c1682cc12065299b6eecdf402258a50d5
        [Serializable]
        [DataContract]
        public class MembersContainer
        {
            [JsonProperty("user")]
            [DataMember(Name = "user")]
            public ResponseModelUser User { get; set; }
        }
    }
}