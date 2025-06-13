using System.ComponentModel.DataAnnotations;

namespace blazorTrainingDay1.Models
{
	public class UsersModel
	{
		[Required(ErrorMessage = "User name is required")]
		public string Name { get; set; }
		[Range(18, 110, ErrorMessage = "Age must be between 18 and 110")]
		public int Age { get; set; }
		[Required(ErrorMessage = "Email is required")]
		[EmailAddress(ErrorMessage = "E-Mail adress not valid")]
		public string Email { get; set; }
		[Required, MinLength(6, ErrorMessage = "6 Characters minimum")]
		public string Password { get; set; }
	}
}
