using Group7Final.Models;
namespace Group7Final.Data
{
	public interface IVidGameService
	{
		List<Vidgame> GetAllGames();
		
		Vidgame GetGameById(int Id);
		int? AddGame(Vidgame v);
		int? UpdateGame(Vidgame v);
		int? RemoveGameById(int id);
	}
}
