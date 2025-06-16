using blazorTrainingDay1.Models;
using Microsoft.AspNetCore.Components;

namespace blazorTrainingDay1.Components.Pages
{
	public partial class VGAdd
	{
		[SupplyParameterFromForm]
		private VGModel vg { get; set; } = new VGModel();
		private List<VGModel> registeredVG = new();
		public string successMessage;

		public void registerVideogame()
		{
			VGService.AddGame(vg);
			successMessage = $"Videogame {vg.VGName} has registered successfully";
			vg = new();
		}
	}
}