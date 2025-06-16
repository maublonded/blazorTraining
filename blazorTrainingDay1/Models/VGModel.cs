using System.ComponentModel.DataAnnotations;

namespace blazorTrainingDay1.Models
{
	public class VGModel
	{
		[Required(ErrorMessage = "The videogame must have a name")]
		public string VGName { get; set; }
		[Required(ErrorMessage = "The videogame must have a category")]
		public string VGCategory { get; set; }
		[Required, Range(1950, 2100, ErrorMessage = "Enter a valid year (1950-2100)")]
		public int VGYear { get; set; }
		public float VGRating { get; set; }
	}
}
