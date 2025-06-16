using blazorTrainingDay1.Models;

namespace blazorTrainingDay1.Services
{
	public class VGService
	{
		private readonly List<VGModel> _games = new();

		public void AddGame(VGModel game)
		{
			_games.Add(game);
		}

		public List<VGModel > GetGames()
		{
			return _games;
		}
	}
}
