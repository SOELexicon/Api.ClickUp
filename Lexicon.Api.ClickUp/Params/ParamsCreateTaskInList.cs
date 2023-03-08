using Newtonsoft.Json;
using System;
using System.Runtime.Serialization;

namespace Api.ClickUp.Params
{
    /// <summary>
    /// The param object of CReate Task in List Request
    /// </summary>
    public class ParamsCreateTaskInList
    {
        #region Attributes

        /// <summary>
        /// The List Id
        /// </summary>
        [JsonProperty("list_id")]
        [DataMember(Name = "list_id")]
        public string ListId { get; set; }

        #endregion Attributes

        #region Constructor

        /// <summary>
        /// The Constructor of 'ParamsCreateTaskInList'
        /// </summary>
        /// <param name="listId"></param>
        public ParamsCreateTaskInList(string listId)
        {
            ListId = listId;
        }

        #endregion Constructor

        #region Public Methods

        /// <summary>
        /// Method that validate data insert
        /// </summary>
        public void ValidateData()
        {
            if (string.IsNullOrEmpty(ListId))
            {
                throw new ArgumentNullException("ListId");
            }
        }

        #endregion Public Methods
    }
}