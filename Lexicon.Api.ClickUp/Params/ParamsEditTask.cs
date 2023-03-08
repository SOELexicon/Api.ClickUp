using Newtonsoft.Json;
using System;
using System.Runtime.Serialization;

namespace Api.ClickUp.Params
{
    /// <summary>
    /// The param object of Edit Task Request
    /// </summary>
    public class ParamsEditTask
    {
        #region Attributes

        /// <summary>
        /// The Task Id
        /// </summary>
        [JsonProperty("task_id")]
        [DataMember(Name = "task_id")]
        public string TaskId { get; set; }

        #endregion Attributes

        #region Constructor

        /// <summary>
        /// Constructor of ParamsEditTask
        /// </summary>
        /// <param name="taskId"></param>
        public ParamsEditTask(string taskId)
        {
            TaskId = taskId;
        }

        #endregion Constructor

        #region Public Methods

        /// <summary>
        /// Method that validate data insert
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