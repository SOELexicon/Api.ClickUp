using Newtonsoft.Json;
using System;
using System.Runtime.Serialization;

namespace Api.ClickUp.Params
{
    /// <summary>
    /// The param object of get team space request
    /// </summary>
    public class ParamsGetTeamSpaces
    {
        #region Attributes

        /// <summary>
        /// The Team Id
        /// </summary>
        [JsonProperty("team_id")]
        [DataMember(Name = "team_id")]
        public string TeamId { get; set; }

        #endregion Attributes

        #region Constructor

        /// <summary>
        /// The constructor of ParamsGetTeamSpace
        /// </summary>
        /// <param name="teamId"></param>
        public ParamsGetTeamSpaces(string teamId)
        {
            TeamId = teamId;
        }

        #endregion Constructor

        #region Public Methods

        /// <summary>
        /// Method that validate data insert
        /// </summary>
        public void ValidateData()
        {
            if (string.IsNullOrEmpty(TeamId))
            {
                throw new ArgumentNullException("TeamId");
            }
        }

        #endregion Public Methods
    }
}