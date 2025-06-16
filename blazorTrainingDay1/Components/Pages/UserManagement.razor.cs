using blazorTrainingDay1.Models;
using Microsoft.AspNetCore.Components;

namespace blazorTrainingDay1.Components.Pages
{
	public partial class UserManagement
	{
		[SupplyParameterFromForm]
		private UsersModel user { get; set; } = new UsersModel();
		private List<UsersModel> registeredUsers = new();
		public string successMessage;

		public void registerUser()
		{
			registeredUsers.Add(user);
			successMessage = $"User {user.Name} was registered successfully";
			user = new();
		}

		public void deleteUser(UsersModel userToDelete)
		{
			registeredUsers.Remove(userToDelete);
		}
	}
}