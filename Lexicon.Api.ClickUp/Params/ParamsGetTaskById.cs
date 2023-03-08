using Newtonsoft.Json;
using System;
using System.Runtime.Serialization;

namespace Api.ClickUp.Params
{
    /// <summary>
    /// The param object of Get Task By ID request
    /// </summary>
    public class ParamsGetTaskById
    {
        #region Attributes

        /// <summary>
        /// The Team Id
        /// </summary>
        [JsonProperty("task_id")]
        [DataMember(Name = "task_id")]
        public string TaskId { get; set; }

        #endregion Attributes

        #region Constructor

        /// <summary>
        /// The constructor of ParamsGetTasksById
        /// </summary>
        /// <param name="teamId"></param>
        public ParamsGetTaskById(string taskId)
        {
            TaskId = taskId;
        }

        #endregion Constructor

        #region Public Methods

        /// <summary>
        /// Method that validate the data insert
        /// </summary>
        public void ValidateData()
        {
            if (string.IsNullOrEmpty(TaskId))
            {
                throw new ArgumentNullException("TaskId");
            }
        }

        #endregion Public Methods
    }
}