using Newtonsoft.Json;
using System.Collections.Generic;

namespace Api.ClickUp.Requests.RequestModel
{
    /// <summary>
    /// Support Models for assigness user at the task
    /// </summary>
    public class RequestModelSupportAssignees
    {
        #region Attributes

<<<<<<< HEAD
        /// <summary>
        /// List of integer id of the user added to the task
        /// </summary>
        [JsonProperty("add")]
        public List<long> Add { get; set; }

        /// <summary>
        /// List of integer id of the user removed to the task
        /// </summary>
        [JsonProperty("rem")]
        public List<long> Rem { get; set; }

        #endregion Attributes
=======
    /// <summary>
    /// Support Models for assigness user at the task
    /// </summary>
    public class RequestModelSupportAssignees
    {

        #region Attributes

        /// <summary>
        /// List of integer id of the user added to the task
        /// </summary>
        [JsonProperty("add")]
        public List<long> Add { get; set; }
>>>>>>> 94034a3c1682cc12065299b6eecdf402258a50d5

        #region Public Methods

        /// <summary>
<<<<<<< HEAD
        /// Validation method of data
        /// </summary>
        public void ValidateData()
        { }

        #endregion Public Methods
=======
        /// List of integer id of the user removed to the task
        /// </summary>
        [JsonProperty("rem")]
        public List<long> Rem { get; set; }

        #endregion


        #region Public Methods

        /// <summary>
        /// Validation method of data
        /// </summary>
        public void ValidateData() { }

        #endregion
>>>>>>> 94034a3c1682cc12065299b6eecdf402258a50d5
    }
}