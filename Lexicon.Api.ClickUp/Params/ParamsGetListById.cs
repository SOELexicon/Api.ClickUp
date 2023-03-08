using Newtonsoft.Json;
using System;
using System.Runtime.Serialization;

namespace Api.ClickUp.Params
{
    /// <summary>
    /// The param object of Get list by id request
    /// </summary>
    public class ParamsGetListById
    {
        #region Attributes

        /// <summary>
        /// The Space Id
        /// </summary>
        [JsonProperty("list_id")]
        [DataMember(Name = "list_id")]
        public string ListId { get; set; }

        #endregion Attributes

        #region Constructor

        /// <summary>
        /// The constructor of ParamsGetListById
        /// </summary>
        /// <param name="listId"></param>
        public ParamsGetListById(string listId)
        {
            ListId = listId;
        }

        #endregion Constructor

        #region Public Methods

        /// <summary>
        /// Method that validate the data insert
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