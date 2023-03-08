﻿using NUnit.Framework;
using Api.ClickUp.Enums;
using Api.ClickUp.Helpers;
using Api.ClickUp.Params;
using Api.ClickUp.Requests;
using Api.ClickUp.Responses;
using Api.ClickUp.Responses.Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

namespace Api.ClickUp.Tests
{

	/// <summary>
	/// Class for tests of object 'Methods' in 'Api.ClickUp'
	/// </summary>
	[TestFixture]
	public class MethodTests
	{
		#region Private Test Variables

		/// <summary>
		/// Access Token of ClickUp, used for test request
		/// </summary>
		private static readonly string _accessToken = "pk_1O9TG5WQIC8E656880JH8KITR28W4V3A";

		/// <summary>
		/// The Team Id used for test request
		/// </summary>
		private static readonly string _teamId = "2180065";

		/// <summary>
		/// The Space Id used for test request
		/// </summary>
		private static readonly string _spaceId = "2271405";

		/// <summary>
		/// The Folder Id used for test request
		/// </summary>
		private static readonly string _folderId = "2697881";

		/// <summary>
		/// The List Id used for test request
		/// </summary>
		private static readonly string _listId = "4230623";

		/// <summary>
		/// The Task Id used for test request
		/// </summary>
		private static readonly string _taskId = "tdnaf";

		#endregion


		#region Tests Sync Methods

		#region User

		/// <summary>
		/// Tests of GetAutorizedUser method
		/// </summary>
		[Test]
		public void ShouldGetAuthorizedUser()
		{
			string methodName = "GetAuthorizedUser";
			ResponseGeneric<ResponseAuthorizedUser, ResponseError> response = null;
			try
			{
				Methods clickUpAPI = new Methods(_accessToken);
				response = clickUpAPI.GetAuthorizedUser();
			}
			catch (Exception ex)
			{
				Assert.Fail($"The Test Method of '{methodName}' generate exception: {ex.Message}");
			}
			if (response != null)
			{
				Assert.That(response.ResponseSuccess != null || response.ResponseError != null, $"The ResponseSuccess and the ResponseError of the GenericResponse of the request through the method '{methodName}' are null!");
				if (response.ResponseError != null)
					Assert.Fail($"The Test Method of '{methodName}' generate an error with status: {response.RequestStatus} and response: {response.ResponseError.Err}");
				else
				{
					Assert.That(response.ResponseSuccess.User != null, $"The Response of the request through the method '{methodName}' did not return a user!");
					Assert.That(response.ResponseSuccess.User.Username == "Open Projects", $"The Response of the request through the method '{methodName}' did not return the 'Open Projects' user!");
				}
			}
			else
			{
				Assert.Fail($"The Response of the request through the method '{methodName}' is null!");
			}
		}
		#endregion

		#region Teams
		/// <summary>
		/// Tests of GetAuthotizedTeams method
		/// </summary>
		[Test]
		public void ShouldGetAuthorizedTeams()
		{
			string methodName = "GetAuthorizedTeams";
			ResponseGeneric<ResponseAuthorizedTeams, ResponseError> response = null;
			try
			{
				Methods clickUpAPI = new Methods(_accessToken);
				response = clickUpAPI.GetAuthorizedTeams();
			}
			catch (Exception ex)
			{
				Assert.Fail($"The Test Method of '{methodName}' generate exception: {ex.Message}");
			}
			if (response != null)
			{
				Assert.That(response.ResponseSuccess != null || response.ResponseError != null, $"The ResponseSuccess and the ResponseError of the GenericResponse of the request through the method '{methodName}' are null!");
				if (response.ResponseError != null)
					Assert.Fail($"The Test Method of '{methodName}' generate an error with status: {response.RequestStatus} and response: {response.ResponseError.Err}");
				else
				{
					Assert.That(response.ResponseSuccess.Teams.Count == 2, $"The Response of the request through the method '{methodName}' did not return two teams!");
					Assert.That(response.ResponseSuccess.Teams.First().Members.Count == 1, $"The Response of the request through the method '{methodName}' did not return the first team with its members!");
					Assert.That(response.ResponseSuccess.Teams.First().Members.Single().User.Username == "Open Projects", $"The Response of the request through the method '{methodName}' did not return the first team with the expected member!");
				}
			}
			else
			{
				Assert.Fail($"The Response of the request through the method '{methodName}' is null!");
			}
		}

		/// <summary>
		/// Tests of GetTeamById method
		/// </summary>
		[Test]
		public void ShouldGetTeamById()
		{
			string methodName = "GetTeamById";
			ResponseGeneric<ResponseTeam, ResponseError> response = null;
			try
			{
				Methods clickUpAPI = new Methods(_accessToken);
				response = clickUpAPI.GetTeamById(new ParamsGetTeamById(_teamId));
			}
			catch (Exception ex)
			{
				Assert.Fail($"The Test Method of '{methodName}' generate exception: {ex.Message}");
			}
			if (response != null)
			{
				Assert.That(response.ResponseSuccess != null || response.ResponseError != null, $"The ResponseSuccess and the ResponseError of the GenericResponse of the request through the method '{methodName}' are null!");
				if (response.ResponseError != null)
					Assert.Fail($"The Test Method of '{methodName}' generate an error with status: {response.RequestStatus} and response: {response.ResponseError.Err}");
				else
				{
					Assert.That(response.ResponseSuccess.Team != null, $"The Response of the request through the method '{methodName}' did not return a team!");
					Assert.That(response.ResponseSuccess.Team.Id == _teamId, $"The Response of the request through the method '{methodName}' did not return the expected team!");
				}
			}
			else
			{
				Assert.Fail($"The Response of the request through the method '{methodName}' is null!");
			}
		}
		#endregion

		#region Spaces
		/// <summary>
		/// Tests of GetTeamSpaces method
		/// </summary>
		[Test]
		public void ShouldGetTeamSpaces()
		{
			string methodName = "GetTeamSpaces";
			ResponseGeneric<ResponseTeamSpaces, ResponseError> response = null;
			try
			{
				Methods clickUpAPI = new Methods(_accessToken);
				response = clickUpAPI.GetTeamSpaces(new ParamsGetTeamSpaces(_teamId));
			}
			catch (Exception ex)
			{
				Assert.Fail($"The Test Method of '{methodName}' generate exception: {ex.Message}"); // Always return false
			}
			if (response != null)
			{
				Assert.That(response.ResponseSuccess != null || response.ResponseError != null, $"The ResponseSuccess and the ResponseError of the GenericResponse of the request through the method '{methodName}' are null!"); // Always return false
				if (response.ResponseError != null)
					Assert.Fail($"The Test Method of '{methodName}' generate an error with status: {response.RequestStatus} and response: {response.ResponseError.Err}");
				else
				{
					Assert.That(response.ResponseSuccess.Spaces.Any(x => x.Id == _spaceId), $"The Response of the request through the method '{methodName}' did not return at least one space with an expected value!");
				}
			}
			else
			{
				Assert.Fail($"The Response of the request through the method '{methodName}' is null!");
			}
		}

		/// <summary>
		/// Tests of CreateTeamSpace method
		/// </summary>
		[Test]
		public void ShouldCreateTeamSpace()
		{
			string methodName = "CreateTeamSpace";
			string newTeamName = $"Test Space {new Random().Next(0, 999)} created from Tests";
			ResponseGeneric<ResponseModelSpace, ResponseError> response = null;
			try
			{
				Methods clickUpAPI = new Methods(_accessToken);
				response = clickUpAPI.CreateTeamSpace
				(
					new ParamsCreateTeamSpace(_teamId),
					new RequestCreateTeamSpace(newTeamName)
				);
			}
			catch (Exception ex)
			{
				Assert.Fail($"The Test Method of '{methodName}' generate exception: {ex.Message}"); // Always return false
			}
			if (response != null)
			{
				Assert.That(response.ResponseSuccess != null || response.ResponseError != null, $"The ResponseSuccess and the ResponseError of the GenericResponse of the request through the method '{methodName}' are null!"); // Always return false
				if (response.ResponseError != null)
					Assert.Fail($"The Test Method of '{methodName}' generate an error with status: {response.RequestStatus} and response: {response.ResponseError.Err}");
				else
				{
					Assert.That(response.ResponseSuccess.Name == newTeamName, $"The Response of the request through the method '{methodName}' did not return a new space with the same name!");
				}
			}
			else
			{
				Assert.Fail($"The Response of the request through the method '{methodName}' is null!");
			}
		}
		#endregion

		#region Folders
		/// <summary>
		/// Tests of ShouldGetSpaceFolders method
		/// </summary>
		[Test]
		public void ShouldGetSpaceFolders()
		{
			string methodName = "GetSpaceFolders";
			ResponseGeneric<ResponseSpaceFolders, ResponseError> response = null;
			try
			{
				Methods clickUpAPI = new Methods(_accessToken);
				response = clickUpAPI.GetSpaceFolders(new ParamsGetSpaceFolders(_spaceId));
			}
			catch (Exception ex)
			{
				Assert.Fail($"The Test Method of '{methodName}' generate exception: {ex.Message}"); // Always return false
			}
			if (response != null)
			{
				Assert.That(response.ResponseSuccess != null || response.ResponseError != null, $"The ResponseSuccess and the ResponseError of the GenericResponse of the request through the method '{methodName}' are null!"); // Always return false
				if (response.ResponseError != null)
					Assert.Fail($"The Test Method of '{methodName}' generate an error with status: {response.RequestStatus} and response: {response.ResponseError.Err}");
				else
				{
					Assert.That(response.ResponseSuccess.Folders.Count > 1, $"The Response of the request through the method '{methodName}' did not return one space!");
					Assert.That(response.ResponseSuccess.Folders.Any(x => x.Lists.Count > 2), $"The Response of the request through the method '{methodName}' returned a space but without at least two lists!");
				}
			}
			else
			{
				Assert.Fail($"The Response of the request through the method '{methodName}' is null!");
			}
		}

		/// <summary>
		/// Tests of CreateFolder method
		/// </summary>
		[Test]
		public void ShouldCreateFolder()
		{
			string methodName = "CreateFolder";
			string newFolderName = $"Test Folder {new Random().Next(0, 999)} created from Tests";
			ResponseGeneric<ResponseModelFolder, ResponseError> response = null;
			try
			{
				Methods clickUpAPI = new Methods(_accessToken);
				response = clickUpAPI.CreateFolder
				(
					new ParamsCreateFolder(_spaceId),
					new RequestCreateFolder(newFolderName)
				);
			}
			catch (Exception ex)
			{
				Assert.Fail($"The Test Method of '{methodName}' generate exception: {ex.Message}"); // Always return false
			}
			if (response != null)
			{
				Assert.That(response.ResponseSuccess != null || response.ResponseError != null, $"The ResponseSuccess and the ResponseError of the GenericResponse of the request through the method '{methodName}' are null!"); // Always return false
				if (response.ResponseError != null)
					Assert.Fail($"The Test Method of '{methodName}' generate an error with status: {response.RequestStatus} and response: {response.ResponseError.Err}");
				else
				{
					Assert.That(response.ResponseSuccess.Name == newFolderName, $"The Response of the request through the method '{methodName}' did not return a new space with the same name!");
				}
			}
			else
			{
				Assert.Fail($"The Response of the request through the method '{methodName}' is null!");
			}
		}
		#endregion

		#region Lists
		/// <summary>
		/// Tests of GetListById method
		/// </summary>
		[Test]
		public void ShouldGetListById()
		{
			string methodName = "GetListById";
			ResponseGeneric<ResponseModelList, ResponseError> response = null;
			try
			{
				Methods clickUpAPI = new Methods(_accessToken);
				response = clickUpAPI.GetListById(new ParamsGetListById(_listId));
			}
			catch (Exception ex)
			{
				Assert.Fail($"The Test Method of '{methodName}' generate exception: {ex.Message}"); // Always return false
			}
			if (response != null)
			{
				Assert.That(response.ResponseSuccess != null || response.ResponseError != null, $"The ResponseSuccess and the ResponseError of the GenericResponse of the request through the method '{methodName}' are null!"); // Always return false
				if (response.ResponseError != null)
					Assert.Fail($"The Test Method of '{methodName}' generate an error with status: {response.RequestStatus} and response: {response.ResponseError.Err}");
				else
				{
					Assert.That(response.ResponseSuccess.Id == _listId, $"The Response of the request through the method '{methodName}' did not return the expected list!");
				}
			}
			else
			{
				Assert.Fail($"The Response of the request through the method '{methodName}' is null!");
			}
		}

		/// <summary>
		/// Tests of CreateList method
		/// </summary>
		[Test]
		public void ShouldCreateList()
		{
			string methodName = "CreateList";
			string newListName = $"Test List {new Random().Next(0, 999)} created from Tests";
			ResponseGeneric<ResponseModelList, ResponseError> response = null;
			try
			{
				Methods clickUpAPI = new Methods(_accessToken);
				response = clickUpAPI.CreateList
				(
					new ParamsCreateFolderList(_folderId),
					new RequestCreateList(newListName)
				);
			}
			catch (Exception ex)
			{
				Assert.Fail($"The Test Method of '{methodName}' generate exception: {ex.Message}"); // Always return false
			}
			if (response != null)
			{
				Assert.That(response.ResponseSuccess != null || response.ResponseError != null, $"The ResponseSuccess and the ResponseError of the GenericResponse of the request through the method '{methodName}' are null!"); // Always return false
				if (response.ResponseError != null)
					Assert.Fail($"The Test Method of '{methodName}' generate an error with status: {response.RequestStatus} and response: {response.ResponseError.Err}");
				else
				{
					Assert.That(response.ResponseSuccess.Name == newListName, $"The Response of the request through the method '{methodName}' did not return a new list with the same name!");
				}
			}
			else
			{
				Assert.Fail($"The Response of the request through the method '{methodName}' is null!");
			}
		}

		/// <summary>
		/// Tests of GetFolderlessLists method
		/// </summary>
		[Test]
		public void ShouldGetFolderlessLists()
		{
			string methodName = "GetFolderlessLists";
			ResponseGeneric<ResponseFolderlessLists, ResponseError> response = null;
			try
			{
				Methods clickUpAPI = new Methods(_accessToken);
				response = clickUpAPI.GetFolderlessLists(new ParamsGetFolderlessLists(_spaceId));
			}
			catch (Exception ex)
			{
				Assert.Fail($"The Test Method of '{methodName}' generate exception: {ex.Message}"); // Always return false
			}
			if (response != null)
			{
				Assert.That(response.ResponseSuccess != null || response.ResponseError != null, $"The ResponseSuccess and the ResponseError of the GenericResponse of the request through the method '{methodName}' are null!"); // Always return false
				if (response.ResponseError != null)
					Assert.Fail($"The Test Method of '{methodName}' generate an error with status: {response.RequestStatus} and response: {response.ResponseError.Err}");
				else
				{
					Assert.That(response.ResponseSuccess.Lists.Any(), $"The Response of the request through the method '{methodName}' did not return any spaces!");
					Assert.That(response.ResponseSuccess.Lists.Any(x => x.Name == "Test Folderless List 212 created from Tests"), $"The Response of the request through the method '{methodName}' returned a list without one with an expected name!");
				}
			}
			else
			{
				Assert.Fail($"The Response of the request through the method '{methodName}' is null!");
			}
		}

		/// <summary>
		/// Tests of CreateFolderlessList method
		/// </summary>
		[Test]
		public void ShouldCreateFolderlessList()
		{
			string methodName = "CreateList";
			string newListName = $"Test Folderless List {new Random().Next(0, 999)} created from Tests";
			ResponseGeneric<ResponseModelList, ResponseError> response = null;
			try
			{
				Methods clickUpAPI = new Methods(_accessToken);
				response = clickUpAPI.CreateFolderlessList
				(
					new ParamsCreateFolderlessList(_spaceId),
					new RequestCreateList(newListName)
				);
			}
			catch (Exception ex)
			{
				Assert.Fail($"The Test Method of '{methodName}' generate exception: {ex.Message}"); // Always return false
			}
			if (response != null)
			{
				Assert.That(response.ResponseSuccess != null || response.ResponseError != null, $"The ResponseSuccess and the ResponseError of the GenericResponse of the request through the method '{methodName}' are null!"); // Always return false
				if (response.ResponseError != null)
					Assert.Fail($"The Test Method of '{methodName}' generate an error with status: {response.RequestStatus} and response: {response.ResponseError.Err}");
				else
				{
					Assert.That(response.ResponseSuccess.Name == newListName, $"The Response of the request through the method '{methodName}' did not return a new list with the same name!");
				}
			}
			else
			{
				Assert.Fail($"The Response of the request through the method '{methodName}' is null!");
			}
		}

		/// <summary>
		/// Tests of EditList method
		/// </summary>
		[Test]
		public void ShouldEditList()
		{
			string methodName = "EditList";
			string newListName = $"Test List {new Random().Next(0, 999)} edited from Tests";
			ResponseGeneric<ResponseModelList, ResponseError> response = null;
			try
			{
				Methods clickUpAPI = new Methods(_accessToken);
				response = clickUpAPI.EditList
				(
					new ParamsEditList(_listId),
					new RequestEditList(newListName)
				);
			}
			catch (Exception ex)
			{
				Assert.Fail($"The Test Method of '{methodName}' generate exception: {ex.Message}"); // Always return false
			}
			if (response != null)
			{
				Assert.That(response.ResponseSuccess != null || response.ResponseError != null, $"The ResponseSuccess and the ResponseError of the GenericResponse of the request through the method '{methodName}' are null!"); // Always return false
				if (response.ResponseError != null)
					Assert.Fail($"The Test Method of '{methodName}' generate an error with status: {response.RequestStatus} and response: {response.ResponseError.Err}");
				else
				{
					Assert.That(response.ResponseSuccess.Name == newListName, $"The Response of the request through the method '{methodName}' did not return an edited list with the same name!");
				}
			}
			else
			{
				Assert.Fail($"The Response of the request through the method '{methodName}' is null!");
			}
		}
		#endregion

		#region Tasks
		/// <summary>
		/// Tests of GetTaskById method
		/// </summary>
		[Test]
		public void ShouldGetTaskById()
		{
			string methodName = "GetTaskById";
			ResponseGeneric<ResponseModelTask, ResponseError> response = null;
			try
			{
				Methods clickUpAPI = new Methods(_accessToken);
				response = clickUpAPI.GetTaskById(new ParamsGetTaskById("te05k"));
			}
			catch (Exception ex)
			{
				Assert.Fail($"The Test Method of '{methodName}' generate exception: {ex.Message}"); // Always return false
			}
			if (response != null)
			{
				Assert.That(response.ResponseSuccess != null || response.ResponseError != null, $"The ResponseSuccess and the ResponseError of the GenericResponse of the request through the method '{methodName}' are null!"); // Always return false
				if (response.ResponseError != null)
					Assert.Fail($"The Test Method of '{methodName}' generate an error with status: {response.RequestStatus} and response: {response.ResponseError.Err}");
				else
				{
					Assert.That(response.ResponseSuccess.Id == "te05k", $"The Response of the request through the method '{methodName}' did not return the expected task by ID!");
					Assert.That(response.ResponseSuccess.Name == "test task", $"The Response of the request through the method '{methodName}' did not return the expected task by name!");
				}
			}
			else
			{
				Assert.Fail($"The Response of the request through the method '{methodName}' is null!");
			}
		}

		/// <summary>
		/// Tests of GetTasks method
		/// </summary>
		[Test]
		public void ShouldGetTasks()
		{
			string methodName = "GetTasks";
			ResponseGeneric<ResponseTasks, ResponseError> response = null;
			try
			{
				Methods clickUpAPI = new Methods(_accessToken);
				response = clickUpAPI.GetTasks
				(
					new ParamsGetTasks(_teamId)
					{
						ListIds = new List<string>()
						{
							_listId
						}
					}
				);
			}
			catch (Exception ex)
			{
				Assert.Fail($"The Test Method of '{methodName}' generate exception: {ex.Message}"); // Always return false
			}
			if (response != null)
			{
				Assert.That(response.ResponseSuccess != null || response.ResponseError != null, $"The ResponseSuccess and the ResponseError of the GenericResponse of the request through the method '{methodName}' are null!"); // Always return false
				if (response.ResponseError != null)
					Assert.Fail($"The Test Method of '{methodName}' generate an error with status: {response.RequestStatus} and response: {response.ResponseError.Err}");
				else
				{
					Assert.That(response.ResponseSuccess.Tasks.Count > 1, $"The Response of the request through the method '{methodName}' did not return at least one task!");
				}
			}
			else
			{
				Assert.Fail($"The Response of the request through the method '{methodName}' is null!");
			}
		}

		/// <summary>
		/// Tests of CreateTaskInList method
		/// </summary>
		[Test]
		public void ShouldCreateTaskInList()
		{
			string methodName = "CreateTaskInList";
			string newTaskName = $"Test Task {new Random().Next(0, 999)} created from Tests";
			ResponseGeneric<ResponseModelTask, ResponseError> response = null;
			try
			{
				Methods clickUpAPI = new Methods(_accessToken);
				response = clickUpAPI.CreateTaskInList
				(
					new ParamsCreateTaskInList(_listId),
					new RequestCreateTaskInList(newTaskName)
					{
						DueDate = new DateTime(2022, 04, 17, 15, 17, 13),
						Priority = TaskPriority.Low
					}
				);
			}
			catch (Exception ex)
			{
				Assert.Fail($"The Test Method of '{methodName}' generate exception: {ex.Message}"); // Always return false
			}
			if (response != null)
			{
				Assert.That(response.ResponseSuccess != null || response.ResponseError != null, $"The ResponseSuccess and the ResponseError of the GenericResponse of the request through the method '{methodName}' are null!"); // Always return false
				if (response.ResponseError != null)
					Assert.Fail($"The Test Method of '{methodName}' generate an error with status: {response.RequestStatus} and response: {response.ResponseError.Err}");
				else
				{
					Assert.That(response.ResponseSuccess.Name == newTaskName, $"The Response of the request through the method '{methodName}' did not return a new task with the same name!");
				}
			}
			else
			{
				Assert.Fail($"The Response of the request through the method '{methodName}' is null!");
			}
		}

		/// <summary>
		/// Tests of EditTask method
		/// </summary>
		[Test]
		public void ShouldEditTask()
		{
			string methodName = "EditTask";
			string newTaskName = $"Test Task {new Random().Next(0, 999)} edited from Tests";
			ResponseGeneric<ResponseModelTask, ResponseError> response = null;
			try
			{
				Methods clickUpAPI = new Methods(_accessToken);
				response = clickUpAPI.EditTask
				(
					new ParamsEditTask(_taskId),
					new RequestEditTask(newTaskName)
				);
			}
			catch (Exception ex)
			{
				Assert.Fail($"The Test Method of '{methodName}' generate exception: {ex.Message}"); // Always return false
			}
			if (response != null)
			{
				Assert.That(response.ResponseSuccess != null || response.ResponseError != null, $"The ResponseSuccess and the ResponseError of the GenericResponse of the request through the method '{methodName}' are null!"); // Always return false
				if (response.ResponseError != null)
					Assert.Fail($"The Test Method of '{methodName}' generate an error with status: {response.RequestStatus} and response: {response.ResponseError.Err}");
				else
				{
					Assert.That(response.ResponseSuccess.Name == newTaskName, $"The Response of the request through the method '{methodName}' did not return an edited list with the same name!");
				}
			}
			else
			{
				Assert.Fail($"The Response of the request through the method '{methodName}' is null!");
			}
		}
		#endregion

		#region Webhooks
		/// <summary>
		/// Tests of GetTeamWebhooks method
		/// </summary>
		[Test]
		public void ShouldGetTeamWebhooks()
		{
			string methodName = "GetTeamWebhooks";
			ResponseGeneric<ResponseWebhooks, ResponseError> response = null;
			try
			{
				Methods clickUpAPI = new Methods(_accessToken);
				response = clickUpAPI.GetTeamWebhooks(new ParamsGetTeamWebhooks(_teamId));
			}
			catch (Exception ex)
			{
				Assert.Fail($"The Test Method of '{methodName}' generate exception: {ex.Message}"); // Always return false
			}
			if (response != null)
			{
				Assert.That(response.ResponseSuccess != null || response.ResponseError != null, $"The ResponseSuccess and the ResponseError of the GenericResponse of the request through the method '{methodName}' are null!"); // Always return false
				if (response.ResponseError != null)
					Assert.Fail($"The Test Method of '{methodName}' generate an error with status: {response.RequestStatus} and response: {response.ResponseError.Err}");
				else
				{
					Assert.That(response.ResponseSuccess.Webhooks.Any(x => x.Endpoint.StartsWith("https://localhost:")), $"The Response of the request through the method '{methodName}' did not return one space!");
				}
			}
			else
			{
				Assert.Fail($"The Response of the request through the method '{methodName}' is null!");
			}
		}

		/// <summary>
		/// Tests of CreateTeamWebhook method
		/// </summary>
		[Test]
		public void ShouldCreateTeamWebhook()
		{
			string methodName = "CreateTeamWebhook";
			string endpoint = $"https://localhost:{new Random().Next(100, 9999)}";
			ResponseGeneric<ResponseWebhook, ResponseError> response = null;
			try
			{
				Methods clickUpAPI = new Methods(_accessToken);
				response = clickUpAPI.CreateTeamWebhook
				(
					new ParamsCreateTeamWebhook(_teamId),
					new RequestCreateTeamWebhook(endpoint)
				);
			}
			catch (Exception ex)
			{
				Assert.Fail($"The Test Method of '{methodName}' generate exception: {ex.Message}"); // Always return false
			}
			if (response != null)
			{
				Assert.That(response.ResponseSuccess != null || response.ResponseError != null, $"The ResponseSuccess and the ResponseError of the GenericResponse of the request through the method '{methodName}' are null!"); // Always return false
				if (response.ResponseError != null)
					Assert.Fail($"The Test Method of '{methodName}' generate an error with status: {response.RequestStatus} and response: {response.ResponseError.Err}");
				else
				{
					Assert.That(response.ResponseSuccess.Webhook.Endpoint == endpoint, $"The Response of the request through the method '{methodName}' did not return a new webhook with the same name!");
				}
			}
			else
			{
				Assert.Fail($"The Response of the request through the method '{methodName}' is null!");
			}
		}
		#endregion

		#endregion


		#region Test Async Methods

		#region User

		/// <summary>
		/// Tests of GetAutorizedUserAsync method
		/// </summary>
		[Test]
		public void ShouldGetAuthorizedUserAsync()
		{
			string methodName = "GetAuthorizedUserAsync";
			ResponseGeneric<ResponseAuthorizedUser, ResponseError> response = null;
			try
			{
				Methods clickUpAPI = new Methods(_accessToken);
				Task.Run(async () => {
					response = await clickUpAPI.GetAuthorizedUserAsync();
				})
				.Wait();
			}
			catch (Exception ex)
			{
				Assert.Fail($"The Test Method of '{methodName}' generate exception: {ex.Message}");
			}
			if (response != null)
			{
				Assert.That(response.ResponseSuccess != null || response.ResponseError != null, $"The ResponseSuccess and the ResponseError of the GenericResponse of the request through the method '{methodName}' are null!");
				if (response.ResponseError != null)
					Assert.Fail($"The Test Method of '{methodName}' generate an error with status: {response.RequestStatus} and response: {response.ResponseError.Err}");
				else
				{
					Assert.That(response.ResponseSuccess.User != null, $"The Response of the request through the method '{methodName}' did not return a user!");
					Assert.That(response.ResponseSuccess.User.Username == "Open Projects", $"The Response of the request through the method '{methodName}' did not return the 'Open Projects' user!");
				}
			}
			else
			{
				Assert.Fail($"The Response of the request through the method '{methodName}' is null!");
			}
		}
		#endregion

		#region Teams
		/// <summary>
		/// Tests of GetAuthotizedTeamsAsync method
		/// </summary>
		[Test]
		public void ShouldGetAuthorizedTeamsAsync()
		{
			string methodName = "GetAuthorizedTeamsAsync";
			ResponseGeneric<ResponseAuthorizedTeams, ResponseError> response = null;
			try
			{
				Methods clickUpAPI = new Methods(_accessToken);
				Task.Run(async () => {
					response = await clickUpAPI.GetAuthorizedTeamsAsync();
				})
				.Wait();
			}
			catch (Exception ex)
			{
				Assert.Fail($"The Test Method of '{methodName}' generate exception: {ex.Message}");
			}
			if (response != null)
			{
				Assert.That(response.ResponseSuccess != null || response.ResponseError != null, $"The ResponseSuccess and the ResponseError of the GenericResponse of the request through the method '{methodName}' are null!");
				if (response.ResponseError != null)
					Assert.Fail($"The Test Method of '{methodName}' generate an error with status: {response.RequestStatus} and response: {response.ResponseError.Err}");
				else
				{
					Assert.That(response.ResponseSuccess.Teams.Count == 2, $"The Response of the request through the method '{methodName}' did not return two teams!");
					Assert.That(response.ResponseSuccess.Teams.First().Members.Count == 1, $"The Response of the request through the method '{methodName}' did not return the first team with its members!");
					Assert.That(response.ResponseSuccess.Teams.First().Members.Single().User.Username == "Open Projects", $"The Response of the request through the method '{methodName}' did not return the first team with the expected member!");
				}
			}
			else
			{
				Assert.Fail($"The Response of the request through the method '{methodName}' is null!");
			}
		}

		/// <summary>
		/// Tests of GetTeamByIdAsync method
		/// </summary>
		[Test]
		public void ShouldGetTeamByIdAsync()
		{
			string methodName = "GetTeamByIdAsync";
			ResponseGeneric<ResponseTeam, ResponseError> response = null;
			try
			{
				Methods clickUpAPI = new Methods(_accessToken);
				Task.Run(async () => {
					response = await clickUpAPI.GetTeamByIdAsync(new ParamsGetTeamById(_teamId));
				})
				.Wait();
			}
			catch (Exception ex)
			{
				Assert.Fail($"The Test Method of '{methodName}' generate exception: {ex.Message}");
			}
			if (response != null)
			{
				Assert.That(response.ResponseSuccess != null || response.ResponseError != null, $"The ResponseSuccess and the ResponseError of the GenericResponse of the request through the method '{methodName}' are null!");
				if (response.ResponseError != null)
					Assert.Fail($"The Test Method of '{methodName}' generate an error with status: {response.RequestStatus} and response: {response.ResponseError.Err}");
				else
				{
					Assert.That(response.ResponseSuccess.Team != null, $"The Response of the request through the method '{methodName}' did not return a team!");
					Assert.That(response.ResponseSuccess.Team.Id == _teamId, $"The Response of the request through the method '{methodName}' did not return the expected team!");
				}
			}
			else
			{
				Assert.Fail($"The Response of the request through the method '{methodName}' is null!");
			}
		}
		#endregion

		#region Spaces
		/// <summary>
		/// Tests of GetTeamSpacesAsync method
		/// </summary>
		[Test]
		public void ShouldGetTeamSpacesAsync()
		{
			string methodName = "GetTeamSpacesAsync";
			ResponseGeneric<ResponseTeamSpaces, ResponseError> response = null;
			try
			{
				Methods clickUpAPI = new Methods(_accessToken);
				Task.Run(async () => {
					response = await clickUpAPI.GetTeamSpacesAsync(new ParamsGetTeamSpaces(_teamId));
				})
				.Wait();
			}
			catch (Exception ex)
			{
				Assert.Fail($"The Test Method of '{methodName}' generate exception: {ex.Message}"); // Always return false
			}
			if (response != null)
			{
				Assert.That(response.ResponseSuccess != null || response.ResponseError != null, $"The ResponseSuccess and the ResponseError of the GenericResponse of the request through the method '{methodName}' are null!"); // Always return false
				if (response.ResponseError != null)
					Assert.Fail($"The Test Method of '{methodName}' generate an error with status: {response.RequestStatus} and response: {response.ResponseError.Err}");
				else
				{
					Assert.That(response.ResponseSuccess.Spaces.Any(x => x.Id == _spaceId), $"The Response of the request through the method '{methodName}' did not return at least one space with an expected value!");
				}
			}
			else
			{
				Assert.Fail($"The Response of the request through the method '{methodName}' is null!");
			}
		}

		/// <summary>
		/// Tests of CreateTeamSpaceAsync method
		/// </summary>
		[Test]
		public void ShouldCreateTeamSpaceAsync()
		{
			string methodName = "CreateTeamSpaceAsync";
			string newTeamName = $"Test Space {new Random().Next(0, 999)} created from Tests";
			ResponseGeneric<ResponseModelSpace, ResponseError> response = null;
			try
			{
				Methods clickUpAPI = new Methods(_accessToken);
				Task.Run(async () => {
					response = await clickUpAPI.CreateTeamSpaceAsync
					(
						new ParamsCreateTeamSpace(_teamId),
						new RequestCreateTeamSpace(newTeamName)
					);
				})
				.Wait();
			}
			catch (Exception ex)
			{
				Assert.Fail($"The Test Method of '{methodName}' generate exception: {ex.Message}"); // Always return false
			}
			if (response != null)
			{
				Assert.That(response.ResponseSuccess != null || response.ResponseError != null, $"The ResponseSuccess and the ResponseError of the GenericResponse of the request through the method '{methodName}' are null!"); // Always return false
				if (response.ResponseError != null)
					Assert.Fail($"The Test Method of '{methodName}' generate an error with status: {response.RequestStatus} and response: {response.ResponseError.Err}");
				else
				{
					Assert.That(response.ResponseSuccess.Name == newTeamName, $"The Response of the request through the method '{methodName}' did not return a new space with the same name!");
				}
			}
			else
			{
				Assert.Fail($"The Response of the request through the method '{methodName}' is null!");
			}
		}
		#endregion

		#region Folders
		/// <summary>
		/// Tests of CreateFolder method
		/// </summary>
		[Test]
		public void ShouldCreateFolderAsync()
		{
			string methodName = "CreateFolderAsync";
			string newFolderName = $"Test Folder {new Random().Next(0, 999)} created from Tests";
			ResponseGeneric<ResponseModelFolder, ResponseError> response = null;
			try
			{
				Methods clickUpAPI = new Methods(_accessToken);
				Task.Run(async () => {
					response = await clickUpAPI.CreateFolderAsync
					(
						new ParamsCreateFolder(_spaceId),
						new RequestCreateFolder(newFolderName)
					);
				})
				.Wait();
			}
			catch (Exception ex)
			{
				Assert.Fail($"The Test Method of '{methodName}' generate exception: {ex.Message}"); // Always return false
			}
			if (response != null)
			{
				Assert.That(response.ResponseSuccess != null || response.ResponseError != null, $"The ResponseSuccess and the ResponseError of the GenericResponse of the request through the method '{methodName}' are null!"); // Always return false
				if (response.ResponseError != null)
					Assert.Fail($"The Test Method of '{methodName}' generate an error with status: {response.RequestStatus} and response: {response.ResponseError.Err}");
				else
				{
					Assert.That(response.ResponseSuccess.Name == newFolderName, $"The Response of the request through the method '{methodName}' did not return a new space with the same name!");
				}
			}
			else
			{
				Assert.Fail($"The Response of the request through the method '{methodName}' is null!");
			}
		}

		/// <summary>
		/// Tests of GetSpaceFoldersAsync method
		/// </summary>
		[Test]
		public void ShouldGetSpaceFoldersAsync()
		{
			string methodName = "GetSpaceFoldersAsync";
			ResponseGeneric<ResponseSpaceFolders, ResponseError> response = null;
			try
			{
				Methods clickUpAPI = new Methods(_accessToken);
				Task.Run(async () => {
					response = await clickUpAPI.GetSpaceFoldersAsync(new ParamsGetSpaceFolders(_spaceId));
				})
				.Wait();
			}
			catch (Exception ex)
			{
				Assert.Fail($"The Test Method of '{methodName}' generate exception: {ex.Message}"); // Always return false
			}
			if (response != null)
			{
				Assert.That(response.ResponseSuccess != null || response.ResponseError != null, $"The ResponseSuccess and the ResponseError of the GenericResponse of the request through the method '{methodName}' are null!"); // Always return false
				if (response.ResponseError != null)
					Assert.Fail($"The Test Method of '{methodName}' generate an error with status: {response.RequestStatus} and response: {response.ResponseError.Err}");
				else
				{
					Assert.That(response.ResponseSuccess.Folders.Count > 1, $"The Response of the request through the method '{methodName}' did not return one space!");
					Assert.That(response.ResponseSuccess.Folders.Any(x => x.Lists.Count > 2), $"The Response of the request through the method '{methodName}' returned a space but without at least two lists!");
				}
			}
			else
			{
				Assert.Fail($"The Response of the request through the method '{methodName}' is null!");
			}
		}
		#endregion

		#region Lists
		/// <summary>
		/// Tests of GetListByIdAsync method
		/// </summary>
		[Test]
		public void ShouldGetListByIdAsync()
		{
			string methodName = "GetListByIdAsync";
			ResponseGeneric<ResponseModelList, ResponseError> response = null;
			try
			{
				Methods clickUpAPI = new Methods(_accessToken);
				Task.Run(async () => {
					response = await clickUpAPI.GetListByIdAsync(new ParamsGetListById(_listId));
				})
				.Wait();
			}
			catch (Exception ex)
			{
				Assert.Fail($"The Test Method of '{methodName}' generate exception: {ex.Message}"); // Always return false
			}
			if (response != null)
			{
				Assert.That(response.ResponseSuccess != null || response.ResponseError != null, $"The ResponseSuccess and the ResponseError of the GenericResponse of the request through the method '{methodName}' are null!"); // Always return false
				if (response.ResponseError != null)
					Assert.Fail($"The Test Method of '{methodName}' generate an error with status: {response.RequestStatus} and response: {response.ResponseError.Err}");
				else
				{
					Assert.That(response.ResponseSuccess.Id == _listId, $"The Response of the request through the method '{methodName}' did not return the expected list!");
				}
			}
			else
			{
				Assert.Fail($"The Response of the request through the method '{methodName}' is null!");
			}
		}

		/// <summary>
		/// Tests of CreateListAsync method
		/// </summary>
		[Test]
		public void ShouldCreateListAsync()
		{
			string methodName = "CreateListAsync";
			string newListName = $"Test List {new Random().Next(0, 999)} created from Tests";
			ResponseGeneric<ResponseModelList, ResponseError> response = null;
			try
			{
				Methods clickUpAPI = new Methods(_accessToken);
				Task.Run(async () => {
					response = await clickUpAPI.CreateListAsync
					(
						new ParamsCreateFolderList(_folderId),
						new RequestCreateList(newListName)
					);
				})
				.Wait();
			}
			catch (Exception ex)
			{
				Assert.Fail($"The Test Method of '{methodName}' generate exception: {ex.Message}"); // Always return false
			}
			if (response != null)
			{
				Assert.That(response.ResponseSuccess != null || response.ResponseError != null, $"The ResponseSuccess and the ResponseError of the GenericResponse of the request through the method '{methodName}' are null!"); // Always return false
				if (response.ResponseError != null)
					Assert.Fail($"The Test Method of '{methodName}' generate an error with status: {response.RequestStatus} and response: {response.ResponseError.Err}");
				else
				{
					Assert.That(response.ResponseSuccess.Name == newListName, $"The Response of the request through the method '{methodName}' did not return a new list with the same name!");
				}
			}
			else
			{
				Assert.Fail($"The Response of the request through the method '{methodName}' is null!");
			}
		}

		/// <summary>
		/// Tests of ShouldGetFolderlessListsAsync method
		/// </summary>
		[Test]
		public void ShouldGetFolderlessListsAsync()
		{
			string methodName = "GetFolderlessListsAsync";
			ResponseGeneric<ResponseFolderlessLists, ResponseError> response = null;
			try
			{
				Methods clickUpAPI = new Methods(_accessToken);
				Task.Run(async () => {
					response = await clickUpAPI.GetFolderlessListsAsync(new ParamsGetFolderlessLists(_spaceId));
				})
				.Wait();
			}
			catch (Exception ex)
			{
				Assert.Fail($"The Test Method of '{methodName}' generate exception: {ex.Message}"); // Always return false
			}
			if (response != null)
			{
				Assert.That(response.ResponseSuccess != null || response.ResponseError != null, $"The ResponseSuccess and the ResponseError of the GenericResponse of the request through the method '{methodName}' are null!"); // Always return false
				if (response.ResponseError != null)
					Assert.Fail($"The Test Method of '{methodName}' generate an error with status: {response.RequestStatus} and response: {response.ResponseError.Err}");
				else
				{
					Assert.That(response.ResponseSuccess.Lists.Any(), $"The Response of the request through the method '{methodName}' did not return any spaces!");
					Assert.That(response.ResponseSuccess.Lists.Any(x => x.Name == "Test Folderless List 212 created from Tests"), $"The Response of the request through the method '{methodName}' returned a list without one with an expected name!");
				}
			}
			else
			{
				Assert.Fail($"The Response of the request through the method '{methodName}' is null!");
			}
		}

		/// <summary>
		/// Tests of CreateFolderlessListAsync method
		/// </summary>
		[Test]
		public void ShouldCreateFolderlessListAsync()
		{
			string methodName = "CreateListAsync";
			string newListName = $"Test Folderless List {new Random().Next(0, 999)} created from Tests";
			ResponseGeneric<ResponseModelList, ResponseError> response = null;
			try
			{
				Methods clickUpAPI = new Methods(_accessToken);
				Task.Run(async () => {
					response = await clickUpAPI.CreateFolderlessListAsync
					(
						new ParamsCreateFolderlessList(_spaceId),
						new RequestCreateList(newListName)
					);
				})
				.Wait();
			}
			catch (Exception ex)
			{
				Assert.Fail($"The Test Method of '{methodName}' generate exception: {ex.Message}"); // Always return false
			}
			if (response != null)
			{
				Assert.That(response.ResponseSuccess != null || response.ResponseError != null, $"The ResponseSuccess and the ResponseError of the GenericResponse of the request through the method '{methodName}' are null!"); // Always return false
				if (response.ResponseError != null)
					Assert.Fail($"The Test Method of '{methodName}' generate an error with status: {response.RequestStatus} and response: {response.ResponseError.Err}");
				else
				{
					Assert.That(response.ResponseSuccess.Name == newListName, $"The Response of the request through the method '{methodName}' did not return a new list with the same name!");
				}
			}
			else
			{
				Assert.Fail($"The Response of the request through the method '{methodName}' is null!");
			}
		}

		/// <summary>
		/// Tests of EditListAsync method
		/// </summary>
		[Test]
		public void ShouldEditListAsync()
		{
			string methodName = "EditListAsync";
			string newListName = $"Test List {new Random().Next(0, 999)} edited from Tests";
			ResponseGeneric<ResponseModelList, ResponseError> response = null;
			try
			{
				Methods clickUpAPI = new Methods(_accessToken);
				Task.Run(async () => {
					response = await clickUpAPI.EditListAsync
					(
						new ParamsEditList(_listId),
						new RequestEditList(newListName)
					);
				})
				.Wait();
			}
			catch (Exception ex)
			{
				Assert.Fail($"The Test Method of '{methodName}' generate exception: {ex.Message}"); // Always return false
			}
			if (response != null)
			{
				Assert.That(response.ResponseSuccess != null || response.ResponseError != null, $"The ResponseSuccess and the ResponseError of the GenericResponse of the request through the method '{methodName}' are null!"); // Always return false
				if (response.ResponseError != null)
					Assert.Fail($"The Test Method of '{methodName}' generate an error with status: {response.RequestStatus} and response: {response.ResponseError.Err}");
				else
				{
					Assert.That(response.ResponseSuccess.Name == newListName, $"The Response of the request through the method '{methodName}' did not return an edited list with the same name!");
				}
			}
			else
			{
				Assert.Fail($"The Response of the request through the method '{methodName}' is null!");
			}
		}
		#endregion

		#region Tasks
		/// <summary>
		/// Tests of GetTaskByIdAsync method
		/// </summary>
		[Test]
		public void ShouldGetTaskByIdAsync()
		{
			string methodName = "GetTaskByIdAsync";
			ResponseGeneric<ResponseModelTask, ResponseError> response = null;
			try
			{
				Methods clickUpAPI = new Methods(_accessToken);
				Task.Run(async () => {
					response = await clickUpAPI.GetTaskByIdAsync(new ParamsGetTaskById("te05k"));
				})
				.Wait();
			}
			catch (Exception ex)
			{
				Assert.Fail($"The Test Method of '{methodName}' generate exception: {ex.Message}"); // Always return false
			}
			if (response != null)
			{
				Assert.That(response.ResponseSuccess != null || response.ResponseError != null, $"The ResponseSuccess and the ResponseError of the GenericResponse of the request through the method '{methodName}' are null!"); // Always return false
				if (response.ResponseError != null)
					Assert.Fail($"The Test Method of '{methodName}' generate an error with status: {response.RequestStatus} and response: {response.ResponseError.Err}");
				else
				{
					Assert.That(response.ResponseSuccess.Id == "te05k", $"The Response of the request through the method '{methodName}' did not return the expected task by ID!");
					Assert.That(response.ResponseSuccess.Name == "test task", $"The Response of the request through the method '{methodName}' did not return the expected task by name!");
				}
			}
			else
			{
				Assert.Fail($"The Response of the request through the method '{methodName}' is null!");
			}
		}

		/// <summary>
		/// Tests of GetTasksAsync method
		/// </summary>
		[Test]
		public void ShouldGetTasksAsync()
		{
			string methodName = "GetTasksAsync";
			ResponseGeneric<ResponseTasks, ResponseError> response = null;
			try
			{
				Methods clickUpAPI = new Methods(_accessToken);
				Task.Run(async () => {
					response = await clickUpAPI.GetTasksAsync
					(
						new ParamsGetTasks(_teamId)
						{
							ListIds = new List<string>()
							{
								_listId
							}
						}
					);
				})
				.Wait();
			}
			catch (Exception ex)
			{
				Assert.Fail($"The Test Method of '{methodName}' generate exception: {ex.Message}"); // Always return false
			}
			if (response != null)
			{
				Assert.That(response.ResponseSuccess != null || response.ResponseError != null, $"The ResponseSuccess and the ResponseError of the GenericResponse of the request through the method '{methodName}' are null!"); // Always return false
				if (response.ResponseError != null)
					Assert.Fail($"The Test Method of '{methodName}' generate an error with status: {response.RequestStatus} and response: {response.ResponseError.Err}");
				else
				{
					Assert.That(response.ResponseSuccess.Tasks.Count > 1, $"The Response of the request through the method '{methodName}' did not return at least one task!");
				}
			}
			else
			{
				Assert.Fail($"The Response of the request through the method '{methodName}' is null!");
			}
		}

		/// <summary>
		/// Tests of CreateTaskInListAsync method
		/// </summary>
		[Test]
		public void ShouldCreateTaskInListAsync()
		{
			string methodName = "CreateTaskInListAsync";
			string newTaskName = $"Test Task {new Random().Next(0, 999)} created from Tests";
			ResponseGeneric<ResponseModelTask, ResponseError> response = null;
			try
			{
				Methods clickUpAPI = new Methods(_accessToken);
				Task.Run(async () => {
					response = await clickUpAPI.CreateTaskInListAsync
					(
						new ParamsCreateTaskInList(_listId),
						new RequestCreateTaskInList(newTaskName)
						{
							DueDate = new DateTime(2022, 04, 17, 15, 17, 13),
							Priority = TaskPriority.Low
						}
					);
				})
				.Wait();
			}
			catch (Exception ex)
			{
				Assert.Fail($"The Test Method of '{methodName}' generate exception: {ex.Message}"); // Always return false
			}
			if (response != null)
			{
				Assert.That(response.ResponseSuccess != null || response.ResponseError != null, $"The ResponseSuccess and the ResponseError of the GenericResponse of the request through the method '{methodName}' are null!"); // Always return false
				if (response.ResponseError != null)
					Assert.Fail($"The Test Method of '{methodName}' generate an error with status: {response.RequestStatus} and response: {response.ResponseError.Err}");
				else
				{
					Assert.That(response.ResponseSuccess.Name == newTaskName, $"The Response of the request through the method '{methodName}' did not return a new task with the same name!");
				}
			}
			else
			{
				Assert.Fail($"The Response of the request through the method '{methodName}' is null!");
			}
		}

		/// <summary>
		/// Tests of EditTaskAsync method
		/// </summary>
		[Test]
		public void ShouldEditTaskAsync()
		{
			string methodName = "EditTaskAsync";
			string newTaskName = $"Test Task {new Random().Next(0, 999)} edited from Tests";
			ResponseGeneric<ResponseModelTask, ResponseError> response = null;
			try
			{
				Methods clickUpAPI = new Methods(_accessToken);
				Task.Run(async () => {
					response = await clickUpAPI.EditTaskAsync
					(
						new ParamsEditTask(_taskId),
						new RequestEditTask(newTaskName)
					);
				})
				.Wait();
			}
			catch (Exception ex)
			{
				Assert.Fail($"The Test Method of '{methodName}' generate exception: {ex.Message}"); // Always return false
			}
			if (response != null)
			{
				Assert.That(response.ResponseSuccess != null || response.ResponseError != null, $"The ResponseSuccess and the ResponseError of the GenericResponse of the request through the method '{methodName}' are null!"); // Always return false
				if (response.ResponseError != null)
					Assert.Fail($"The Test Method of '{methodName}' generate an error with status: {response.RequestStatus} and response: {response.ResponseError.Err}");
				else
				{
					Assert.That(response.ResponseSuccess.Name == newTaskName, $"The Response of the request through the method '{methodName}' did not return an edited list with the same name!");
				}
			}
			else
			{
				Assert.Fail($"The Response of the request through the method '{methodName}' is null!");
			}
		}
		#endregion

		#region Webhooks
		/// <summary>
		/// Tests of GetTeamWebhooksAsync method
		/// </summary>
		[Test]
		public void ShouldGetTeamWebhooksAsync()
		{
			string methodName = "GetTeamWebhooksAsync";
			ResponseGeneric<ResponseWebhooks, ResponseError> response = null;
			try
			{
				Methods clickUpAPI = new Methods(_accessToken);
				Task.Run(async () => {
					response = await clickUpAPI.GetTeamWebhooksAsync(new ParamsGetTeamWebhooks(_teamId));
				})
				.Wait();
			}
			catch (Exception ex)
			{
				Assert.Fail($"The Test Method of '{methodName}' generate exception: {ex.Message}"); // Always return false
			}
			if (response != null)
			{
				Assert.That(response.ResponseSuccess != null || response.ResponseError != null, $"The ResponseSuccess and the ResponseError of the GenericResponse of the request through the method '{methodName}' are null!"); // Always return false
				if (response.ResponseError != null)
					Assert.Fail($"The Test Method of '{methodName}' generate an error with status: {response.RequestStatus} and response: {response.ResponseError.Err}");
				else
				{
					Assert.That(response.ResponseSuccess.Webhooks.Any(x => x.Endpoint.StartsWith("https://localhost:")), $"The Response of the request through the method '{methodName}' did not return one space!");
				}
			}
			else
			{
				Assert.Fail($"The Response of the request through the method '{methodName}' is null!");
			}
		}

		/// <summary>
		/// Tests of CreateTeamWebhookAsync method
		/// </summary>
		[Test]
		public void ShouldCreateTeamWebhookAsync()
		{
			string methodName = "CreateTeamWebhookAsync";
			string endpoint = $"https://localhost:{new Random().Next(100, 9999)}";
			ResponseGeneric<ResponseWebhook, ResponseError> response = null;
			try
			{
				Methods clickUpAPI = new Methods(_accessToken);
				Task.Run(async () => {
					response = await clickUpAPI.CreateTeamWebhookAsync
					(
						new ParamsCreateTeamWebhook(_teamId),
						new RequestCreateTeamWebhook(endpoint)
					);
				})
				.Wait();
			}
			catch (Exception ex)
			{
				Assert.Fail($"The Test Method of '{methodName}' generate exception: {ex.Message}"); // Always return false
			}
			if (response != null)
			{
				Assert.That(response.ResponseSuccess != null || response.ResponseError != null, $"The ResponseSuccess and the ResponseError of the GenericResponse of the request through the method '{methodName}' are null!"); // Always return false
				if (response.ResponseError != null)
					Assert.Fail($"The Test Method of '{methodName}' generate an error with status: {response.RequestStatus} and response: {response.ResponseError.Err}");
				else
				{
					Assert.That(response.ResponseSuccess.Webhook.Endpoint == endpoint, $"The Response of the request through the method '{methodName}' did not return a new webhook with the same name!");
				}
			}
			else
			{
				Assert.Fail($"The Response of the request through the method '{methodName}' is null!");
			}
		}
		#endregion

		#endregion
	}
}