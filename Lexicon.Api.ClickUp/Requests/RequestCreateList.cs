﻿using Newtonsoft.Json;
using System;
using System.Runtime.Serialization;

namespace Api.ClickUp.Requests
{
	/// <summary>
	/// Request object for method CreateList()
	/// </summary>
	[Serializable]
	[DataContract]
	public class RequestCreateList
	{
		#region Attributes

		/// <summary>
		/// Name of the new list
		/// </summary>
		[JsonProperty("name")]
		[DataMember(Name = "name")]
		public string Name { get; set; }

		#endregion


		#region Constructor

		/// <summary>
		/// The constructor of RequestCreateList
		/// </summary>
		/// <param name="name"></param>
		public RequestCreateList(string name)
		{
			Name = name;
		}

		#endregion


		#region Public Methods

		/// <summary>
		/// Validation method of data
		/// </summary>
		public void ValidateData()
		{
			if (string.IsNullOrEmpty(Name))
			{
				throw new ArgumentNullException("Name");
			}
		}

		#endregion
	}
}