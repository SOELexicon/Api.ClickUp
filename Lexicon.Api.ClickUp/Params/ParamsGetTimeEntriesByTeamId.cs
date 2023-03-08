using Api.ClickUp.Enums;
using Api.ClickUp.Helpers;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Api.ClickUp.Params
{

	/// <summary>
	/// The param object of Get Time Entries by Team ID request
	/// </summary>
	public class ParamsGetTimeEntriesByTeamId
	{
		#region Attributes

		/// <summary>
		/// Unix time in milliseconds
		/// </summary>
		[JsonProperty("start_date")]
        [JsonConverter(typeof(JsonConverterDateTimeMilliseconds))]
        [DataMember(Name = "start_date")]
		public DateTime? StartDate { get; set; }

		/// <summary>
		/// Unix time in milliseconds
		/// </summary>
		[JsonProperty("end_date")]
        [JsonConverter(typeof(JsonConverterDateTimeMilliseconds))]
        [DataMember(Name = "end_date")]
		public DateTime? EndDate { get; set; }

		/// <summary>
		/// Filter by user_id.
		/// Only Workspace Owners/Admins have access to do this.
		/// </summary>
		[JsonProperty("assignee")]
		[DataMember(Name = "assignee")]
		public long? Assignee { get; set; }

		/// <summary>
		/// Include task tags in the response for time entries associated with tasks.
		/// </summary>
		[JsonProperty("include_task_tags")]
		[DataMember(Name = "include_task_tags")]
		public bool? IncludeTaskTags { get; set; }

		/// <summary>
		/// Include the names of the List, Folder, and Space along with the list_id,folder_id, and space_id.
		/// </summary>
		[JsonProperty("include_location_names")]
		[DataMember(Name = "include_location_names")]
		public bool? IncludeLocationNames { get; set; }

		/// <summary>
		/// Only include time entries associated with tasks in a specific Space.
		/// </summary>
		[JsonProperty("space_id")]
		[DataMember(Name = "space_id")]
		public long? SpaceId { get; set; }

		/// <summary>
		/// Only include time entries associated with tasks in a specific Folder.
		/// </summary>
		[JsonProperty("folder_id")]
		[DataMember(Name = "folder_id")]
		public long? FolderId { get; set; }

		/// <summary>
		/// Only include time entries associated with tasks in a specific List.
		/// </summary>
		[JsonProperty("list_id")]
		[DataMember(Name = "list_id")]
		public long? ListId { get; set; }

		/// <summary>
		/// Only include time entries associated with a specific task.
		/// </summary>
		[JsonProperty("task_id")]
		[DataMember(Name = "task_id")]
		public long? TaskId { get; set; }

		/// <summary>
		/// If you want to reference a task by it's custom task id, this value must be true.
		/// </summary>
		[JsonProperty("custom_task_ids")]
		[DataMember(Name = "custom_task_ids")]
		public bool? CustomTaskIds { get; set; }

		/// <summary>
		/// Only used when the custom_task_ids parameter is set to true.
		/// </summary>
		[JsonProperty("team_id")]
		[DataMember(Name = "team_id")]
		public string TeamId { get; set; }

		#endregion


		#region Constructor

		/// <summary>
		/// The constructor of ParamsGetTasks
		/// </summary>
		/// <param name="teamId"></param>
		public ParamsGetTimeEntriesByTeamId(string teamId)
		{
			TeamId = teamId;
		}

		#endregion


		#region Public Methods

		/// <summary>
		/// Method that validate the data insert
		/// </summary>
		public void ValidateData()
		{
			if (string.IsNullOrEmpty(TeamId))
			{
				throw new ArgumentNullException("TeamId");
			}
		}

		#endregion

	}
}